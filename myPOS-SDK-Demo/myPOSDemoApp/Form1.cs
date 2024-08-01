using myPOS;
using System;
using System.Globalization;
using System.IO.Ports;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace myPOSDemoApp
{
    public partial class Form1 : Form
    {
        double Amount;
        Currencies cur;
        String PAN = "";
        String ExpiryDate = "";
        String strPreauthCode = "";
        Version version = Assembly.GetEntryAssembly().GetName().Version;


        private bool bVendingAutoCycleIsRunning = false;
        private bool bVendingAutoCycleStopRequested = false;
        private Thread thVendingAutoCycleThread;
        private Semaphore semVendingAutoCycleWaitResult;


        myPOSTerminal t = new myPOSTerminal();
        public Form1()
        {
            InitializeComponent();

            t.ProcessingFinished += ProcessResult;
            t.Log += AddDebugLog;
            t.onPresentCard += _PresentCard;
            t.onCardDetected += _CardDetected;
            t.onPresentPin += _PresentPin;
            t.onPinEntered += _PinEntered;
            t.onPresentDCC += _PresentDCC;
            t.onDCCSelected += _DCCSelected;
            t.onApprovalGetReceiptData += _ReceiptReceiver;
            t.SetLanguage(Language.English);
            t.SetCOMTimeout(3000);
            t.isFixedPinpad = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshComPorts();
            cmbCurrency.DataSource = Enum.GetValues(typeof(Currencies));
            cmbCurrency.SelectedItem = Currencies.EUR;
            cmbReceiptMode.DataSource = Enum.GetValues(typeof(ReceiptMode));
            cmbReceiptMode.SelectedItem = ReceiptMode.NotConfugred;
            cmbReferenceType.DataSource = Enum.GetValues(typeof(ReferenceNumberType));
            cmbReferenceType.SelectedItem = ReferenceNumberType.None;

            cmbLanguage.DataSource = Enum.GetValues(typeof(Language));
            cmbLanguage.SelectedItem = Language.English;

            cmbBeepTone.DataSource = Enum.GetValues(typeof(BeepTone));

            cmbDispalyTextRow1Align.DataSource = Enum.GetValues(typeof(DispalyTextRowAlign));
            cmbDispalyTextRow1Align.SelectedItem = DispalyTextRowAlign.Center;
            cmbDispalyTextRow2Align.DataSource = Enum.GetValues(typeof(DispalyTextRowAlign));
            cmbDispalyTextRow2Align.SelectedItem = DispalyTextRowAlign.Center;
            cmbDispalyTextRow3Align.DataSource = Enum.GetValues(typeof(DispalyTextRowAlign));
            cmbDispalyTextRow3Align.SelectedItem = DispalyTextRowAlign.Center;
            cmbDispalyTextRow4Align.DataSource = Enum.GetValues(typeof(DispalyTextRowAlign));
            cmbDispalyTextRow4Align.SelectedItem = DispalyTextRowAlign.Center;
            cmbDispalyTextRow5Align.DataSource = Enum.GetValues(typeof(DispalyTextRowAlign));
            cmbDispalyTextRow5Align.SelectedItem = DispalyTextRowAlign.Center;

            this.Text = "myPOSDemoApp Version " + version.ToString();
            AddLog("myPOSDemoApp Version: " + version.ToString());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshComPorts();
        }

        void RefreshComPorts()
        {
            cmbComPorts.Items.Clear();
            cmbComPorts.Items.AddRange(SerialPort.GetPortNames());
            cmbComPorts.SelectedIndex = -1;
            cmbComPorts.ResetText();
        }

        protected void ProcessResult(ProcessingResult r)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Processing \"{0}\" finished\r\n", r.Method.ToString());
            sb.AppendFormat("Status: \"{0}\"\r\n", r.Status.ToString());

            if (r.TranData != null)
            {
                sb.AppendFormat("\r\nTransaction data:\r\n");
                sb.AppendFormat("Type: {0}\r\n", r.TranData.Type);
                sb.AppendFormat("Amount: {0}\r\n", r.TranData.Amount);
                sb.AppendFormat("Tip Amount: {0}\r\n", r.TranData.TipAmount);
                sb.AppendFormat("Currency: {0}\r\n", r.TranData.Currency.ToString());
                sb.AppendFormat("Approval: {0}\r\n", r.TranData.Approval);
                sb.AppendFormat("Auth code: {0}\r\n", r.TranData.AuthCode);
                sb.AppendFormat("Preauth Code: {0}\r\n", r.TranData.PreauthCode);
                sb.AppendFormat("RRN: {0}\r\n", r.TranData.RRN);
                sb.AppendFormat("Date: {0}\r\n", r.TranData.TransactionDate.ToString("dd.MM.yyyy"));
                sb.AppendFormat("Time: {0}\r\n", r.TranData.TransactionDate.ToString("HH:mm:ss"));
                sb.AppendFormat("Terminal ID: {0}\r\n", r.TranData.TerminalID);
                sb.AppendFormat("Merchant ID: {0}\r\n", r.TranData.MerchantID);
                sb.AppendFormat("Merchant Name: {0}\r\n", r.TranData.MerchantName);
                sb.AppendFormat("Merchant Address Line 1: {0}\r\n", r.TranData.MerchantAddressLine1);
                sb.AppendFormat("Merchant Address Line 2: {0}\r\n", r.TranData.MerchantAddressLine2);
                sb.AppendFormat("PAN Masked: {0}\r\n", r.TranData.PANMasked);
                sb.AppendFormat("Emboss Name: {0}\r\n", r.TranData.EmbossName);
                sb.AppendFormat("AID: {0}\r\n", r.TranData.AID);
                sb.AppendFormat("AID Name: {0}\r\n", r.TranData.AIDName);
                sb.AppendFormat("AID Preferred Name: {0}\r\n", r.TranData.ApplicationPreferredName);
                sb.AppendFormat("STAN: {0}\r\n", r.TranData.Stan);
                sb.AppendFormat("Signature Required: {0}\r\n", r.TranData.SignatureRequired ? "Yes" : "No");
				sb.AppendFormat("Software Version: {0}\r\n", r.TranData.SoftwareVersion);
			}

            AddLog(sb.ToString());

            if (bVendingAutoCycleIsRunning)
            {
                semVendingAutoCycleWaitResult.Release(1);
                return;
            }

            MessageBox.Show(sb.ToString());
        }

        delegate void AddLogDelegate(string msg);
        protected void AddLog(string msg)
        {
            if (txtLog.InvokeRequired)
            {
                object[] p = new object[1];
                p[0] = msg;
                txtLog.Invoke(new AddLogDelegate(AddLog), p);
                return;
            }

            try
            {
                txtLog.AppendText(msg + "\r\n");

                var indexOfCurrency = msg.IndexOf("CURRENCY_NAME=");

                if (indexOfCurrency != -1)
                {
                    var indexOfComboBoxCurrency = cmbCurrency.Items.IndexOf(Enum.Parse(typeof(Currencies), msg.Substring(indexOfCurrency + "CURRENCY_NAME=".Length, 3)));

                    if (indexOfComboBoxCurrency != -1)
                    {
                        cmbCurrency.SelectedIndex = indexOfComboBoxCurrency;
                    }
                }
            }
            catch { }
        }

        void AddDebugLog(string msg)
        {
            if (!chkWriteLog.Checked) return;
            AddLog(msg);
        }

        void _PresentCard()
        {
            AddLog("Present card");
        }

        void _CardDetected(bool is_wrong_card)
        {
            if (!is_wrong_card)
            {
                AddLog("Card detected");
            }
            else
            {
                AddLog("Bad card detected");
            }
        }

        void _PresentPin(int pin_tries_left)
        {
            if (pin_tries_left == 0)
            {
                AddLog("Present online pin");
            }
            else
            {
                AddLog(String.Format("Present offline pin. Tries left: {0}", pin_tries_left));
            }
        }

        void _PinEntered(bool is_wrong_pin, int pin_tries_left)
        {
            if (is_wrong_pin == false)
            {
                AddLog("PIN entered");
            }
            else
            {
                AddLog(String.Format("Wrong PIN entered. Tries left: {0}", pin_tries_left));
            }
        }

        void _PresentDCC(DCCRequest dcc_req)
        {
            AddLog("Present DCC");
            AddLog(String.Format("{0} {1}", dcc_req.OriginalAmount, dcc_req.OriginalCurrencyName));
            AddLog(String.Format("{0} {1}", dcc_req.DCCAmount, dcc_req.DCCCurrencyName));
            AddLog(String.Format("1 {0} = {1} {2}", dcc_req.OriginalCurrencyName, dcc_req.DCCExchangeRate, dcc_req.DCCCurrencyName));
        }

        void _DCCSelected(bool is_dcc_used)
        {
            if (is_dcc_used)
            {
                AddLog("DCC used");
            }
            else
            {
                AddLog("No DCC used");
            }
        }

        string _ReceiptReceiver()
        {
            string result = "";
            if (bVendingAutoCycleIsRunning)
            {
                return result;
            }

            ReceiptReceiverForm formEntry = new ReceiptReceiverForm();
            if (formEntry.ShowDialog() == DialogResult.OK)
            {
                result = formEntry.txtResult.Text;
            }
            return result;
        }

        private bool ParseAmount()
        {
            string amt = txtAmount.Text;
            amt = amt.Replace(",", ".");
            return Double.TryParse(amt, NumberStyles.Number, CultureInfo.InvariantCulture, out Amount);
        }

        private bool ParseCurrency()
        {
            cur = (Currencies)cmbCurrency.SelectedItem;
            return true;
        }

        private bool ParseMoTo()
        {
            PAN = txtPan.Text;
            ExpiryDate = txtExpiryDate.Text;
            return PAN.Length > 0;
        }

        private bool ParsePreauthCode()
        {
            strPreauthCode = txtPreauthCode.Text;
            Match match = Regex.Match(strPreauthCode, @"[0-9]{6}");
            return match.Success;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbComPorts.Text == String.Empty) return;

            t.Initialize(cmbComPorts.Text);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            t.Disconnect();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            t.AbortOperation();
        }

        private void btnGetStatus_Click(object sender, EventArgs e)
        {
            RequestResult r = t.GetStatus();
            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            double Tip = 0;
            Double.TryParse(txtTipAmount.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out Tip);

            if (!ParseAmount() || !ParseCurrency())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                RequestResult r = t.Purchase(Amount, Tip, cur, (ReferenceNumberType)cmbReferenceType.SelectedItem, txtReferenceNumber.Text, txtOperatorCode.Text);
                switch (r)
                {
                    case RequestResult.Busy:
                    case RequestResult.InvalidParams:
                    case RequestResult.NotInitialized:
                        MessageBox.Show("RequestResult: " + r.ToString());
                        break;
                    default: break;
                }
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (!ParseAmount() || !ParseCurrency())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                t.SetPassword(txtPassword.Text);
                RequestResult r = t.Refund(Amount, cur, String.Empty);
                switch (r)
                {
                    case RequestResult.Busy:
                    case RequestResult.InvalidParams:
                    case RequestResult.NotInitialized:
                        MessageBox.Show("RequestResult: " + r.ToString());
                        break;
                    default: break;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RequestResult r = t.Update();
            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void btnReversal_Click(object sender, EventArgs e)
        {
            t.SetPassword(txtPassword.Text);
            RequestResult r = t.Reversal(String.Empty);
            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            RequestResult r = t.Activate();
            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            RequestResult r = t.Deactivate();
            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void btnReprint_Click(object sender, EventArgs e)
        {
            RequestResult r = t.ReprintReceipt();
            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            t.SetReceiptMode((ReceiptMode)cmbReceiptMode.SelectedItem);
        }

        private void btnPrintExternal_Click(object sender, EventArgs e)
        {
            t.PrintExternal(txtPrintData.Text);
        }

        private void btnPreauth_Click(object sender, EventArgs e)
        {
            double Tip = 0;
            Double.TryParse(txtTipAmount.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out Tip);

            if (!ParseAmount() || !ParseCurrency())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                RequestResult r = t.Preauthorization(Amount, Tip, cur, (ReferenceNumberType)cmbReferenceType.SelectedItem, txtReferenceNumber.Text);
                switch (r)
                {
                    case RequestResult.Busy:
                    case RequestResult.InvalidParams:
                    case RequestResult.NotInitialized:
                        MessageBox.Show("RequestResult: " + r.ToString());
                        break;
                    default: break;
                }
            }
        }

        private void btnPreauthComplete_Click(object sender, EventArgs e)
        {
            if (!ParseAmount() || !ParsePreauthCode())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                RequestResult r = t.CompletePreauth(strPreauthCode, Amount);
                switch (r)
                {
                    case RequestResult.Busy:
                    case RequestResult.InvalidParams:
                    case RequestResult.NotInitialized:
                        MessageBox.Show("RequestResult: " + r.ToString());
                        break;
                    default: break;
                }
            }
        }

        private void btnPreauthCancel_Click(object sender, EventArgs e)
        {
            if (!ParsePreauthCode())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                RequestResult r = t.CancelPreauth(strPreauthCode);
                switch (r)
                {
                    case RequestResult.Busy:
                    case RequestResult.InvalidParams:
                    case RequestResult.NotInitialized:
                        MessageBox.Show("RequestResult: " + r.ToString());
                        break;
                    default: break;
                }
            }
        }

        private void btnMotoPurchase_Click(object sender, EventArgs e)
        {
            double Tip = 0;
            Double.TryParse(txtTipAmount.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out Tip);

            if (!ParseAmount() || !ParseCurrency())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                RequestResult r = t.MoToPurchase(Amount, Tip, cur, PAN, ExpiryDate, (ReferenceNumberType)cmbReferenceType.SelectedItem, txtReferenceNumber.Text, txtOperatorCode.Text);
                switch (r)
                {
                    case RequestResult.Busy:
                    case RequestResult.InvalidParams:
                    case RequestResult.NotInitialized:
                        MessageBox.Show("RequestResult: " + r.ToString());
                        break;
                    default: break;
                }
            }
        }

        private void btnMotoRefund_Click(object sender, EventArgs e)
        {
            if (!ParseAmount() || !ParseCurrency() || !ParseMoTo())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                t.SetPassword(txtPassword.Text);
                RequestResult r = t.MoToRefund(Amount, cur, PAN, ExpiryDate, String.Empty);
                switch (r)
                {
                    case RequestResult.Busy:
                    case RequestResult.InvalidParams:
                    case RequestResult.NotInitialized:
                        MessageBox.Show("RequestResult: " + r.ToString());
                        break;
                    default: break;
                }
            }
        }

        private void btnMotoPreauth_Click(object sender, EventArgs e)
        {
            double Tip = 0;
            Double.TryParse(txtTipAmount.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out Tip);

            if (!ParseAmount() || !ParseCurrency())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                RequestResult r = t.MoToPreauthorization(Amount, Tip, cur, PAN, ExpiryDate, (ReferenceNumberType)cmbReferenceType.SelectedItem, txtReferenceNumber.Text);
                switch (r)
                {
                    case RequestResult.Busy:
                    case RequestResult.InvalidParams:
                    case RequestResult.NotInitialized:
                        MessageBox.Show("RequestResult: " + r.ToString());
                        break;
                    default: break;
                }
            }
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            RequestResult r = t.Ping();
            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            RequestResult r = t.Reboot();
            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void btnGiftActivation_Click(object sender, EventArgs e)
        {
            if (!ParseAmount() || !ParseCurrency())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                RequestResult r = t.GiftcardActivation(Amount, cur);
                switch (r)
                {
                    case RequestResult.Busy:
                    case RequestResult.InvalidParams:
                    case RequestResult.NotInitialized:
                        MessageBox.Show("RequestResult: " + r.ToString());
                        break;
                    default: break;
                }
            }
        }

        private void btnGiftDeactivation_Click(object sender, EventArgs e)
        {
            RequestResult r = t.GiftcardDeactivation();
            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            RequestResult r = t.GiftcardCheckBalance();
            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void btnPaymentRequest_Click(object sender, EventArgs e)
        {
            int days = 0;
            Int32.TryParse(txtDays.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out days);

            if (!ParseAmount() || !ParseCurrency())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                RequestResult r = t.SendPaymentRequest(Amount, cur, txtGSM.Text, txtEMail.Text, txtRecipient.Text, txtReason.Text, days);
                switch (r)
                {
                    case RequestResult.Busy:
                    case RequestResult.InvalidParams:
                    case RequestResult.NotInitialized:
                        MessageBox.Show("RequestResult: " + r.ToString());
                        break;
                    default: break;
                }
            }
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            t.SetLanguage((Language)cmbLanguage.SelectedItem);
        }

        private void btnCheckCard_Click(object sender, EventArgs e)
        {
            RequestResult r = t.CheckCard();
            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void btnOriginalCredit_Click(object sender, EventArgs e)
        {
            if (!ParseAmount() || !ParseCurrency())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                RequestResult r = t.OriginalCredit(Amount, cur);
                switch (r)
                {
                    case RequestResult.Busy:
                    case RequestResult.InvalidParams:
                    case RequestResult.NotInitialized:
                        MessageBox.Show("RequestResult: " + r.ToString());
                        break;
                    default: break;
                }
            }
        }

        private void btnSendLog_Click(object sender, EventArgs e)
        {
            RequestResult r = t.SendLog();
            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void btnVendingPurchase_Click(object sender, EventArgs e)
        {
            if (!ParseAmount() || !ParseCurrency())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                RequestResult r = t.VendingPurchase(Amount, cur, chkVendingShowAmount.Checked);
                switch (r)
                {
                    case RequestResult.Busy:
                    case RequestResult.InvalidParams:
                    case RequestResult.NotInitialized:
                        MessageBox.Show("RequestResult: " + r.ToString());
                        break;
                    default: break;
                }
            }
        }

        private void btnVendingStop_Click(object sender, EventArgs e)
        {
            RequestResult r = t.VendingStop();
            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void btnVendingComplete_Click(object sender, EventArgs e)
        {

            if (!ParseAmount() || !ParseCurrency())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                RequestResult r = t.VendingComplete(Amount, cur);
                switch (r)
                {
                    case RequestResult.Busy:
                    case RequestResult.InvalidParams:
                    case RequestResult.NotInitialized:
                        MessageBox.Show("RequestResult: " + r.ToString());
                        break;
                    default: break;
                }
            }
        }

        private void btnVendingCancel_Click(object sender, EventArgs e)
        {
            RequestResult r = t.VendingCancel();
            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            BeepTone tone = BeepTone.Tone_1680_Hz;
            int duration = 0;
            if (!(cmbBeepTone.SelectedItem is null))
            {
                tone = (BeepTone)cmbBeepTone.SelectedValue;
            }
            Int32.TryParse(txtBeepDuration.Text, out duration);

            t.Beep(tone, duration);
        }

        private void btnOpenSettings_Click(object sender, EventArgs e)
        {
            t.OpenSettings();
        }

        private void fixedPinpadCb_CheckedChanged(object sender, EventArgs e)
        {
            t.isFixedPinpad = !t.isFixedPinpad;
        }

        private void btnCheckForCRR_Click(object sender, EventArgs e)
        {
            t.CheckForCRRTransaction();
        }

		private void btnStopWaitingCard_Click(object sender, EventArgs e)
		{
			RequestResult r = t.StopWaitingForCard();
			switch (r)
			{
				case RequestResult.Busy:
				case RequestResult.InvalidParams:
				case RequestResult.NotInitialized:
					MessageBox.Show("RequestResult: " + r.ToString());
					break;
				default: break;
			}
		}

		private void btnCashAdvance_Click(object sender, EventArgs e)
		{
			if (!ParseAmount() || !ParseCurrency())
			{
				MessageBox.Show("Invalid input");
			}
			else
			{
				t.SetPassword(txtPassword.Text);
				RequestResult r = t.CashAdvance(Amount, cur);
				switch (r)
				{
					case RequestResult.Busy:
					case RequestResult.InvalidParams:
					case RequestResult.NotInitialized:
						MessageBox.Show("RequestResult: " + r.ToString());
						break;
					default: break;
				}
			}
		}

		private void btnPrintExternalUTF8_Click(object sender, EventArgs e)
		{
			t.PrintExternalUTF8(txtPrintData.Text);
		}

        private void VendingAutoCycle()
        {
            RequestResult r;
            bVendingAutoCycleStopRequested = false;
            semVendingAutoCycleWaitResult = new Semaphore(0, 1);

            try
            {
                while (!bVendingAutoCycleStopRequested)
                {
                    r = t.VendingPurchase(Amount, cur, chkVendingShowAmount.Checked);
                    switch (r)
                    {
                        case RequestResult.Busy:
                        case RequestResult.InvalidParams:
                        case RequestResult.NotInitialized:
                            AddLog("RequestResult: " + r.ToString());
                            break;
                        default: break;
                    }

                    if (!semVendingAutoCycleWaitResult.WaitOne())
                    {
                        break;
                    }

                    if (!bVendingAutoCycleStopRequested)
                    {
                        semVendingAutoCycleWaitResult.WaitOne(5000);
                    }

                    if (chbVendingAutoCycleCompleteTransactions.Checked)
                    {
                        r = t.VendingComplete(Amount, cur);
                        switch (r)
                        {
                            case RequestResult.Busy:
                            case RequestResult.InvalidParams:
                            case RequestResult.NotInitialized:
                                AddLog("RequestResult: " + r.ToString());
                                break;
                            default: break;
                        }
                    }
                    else
                    {
                        r = t.VendingCancel();
                        switch (r)
                        {
                            case RequestResult.Busy:
                            case RequestResult.InvalidParams:
                            case RequestResult.NotInitialized:
                                MessageBox.Show("RequestResult: " + r.ToString());
                                break;
                            default: break;
                        }
                    }

                    if (!semVendingAutoCycleWaitResult.WaitOne())
                    {
                        break;
                    }

                    if (!bVendingAutoCycleStopRequested)
                    {
                        semVendingAutoCycleWaitResult.WaitOne(25000);
                    }
                }
            }
            finally
            {
                bVendingAutoCycleIsRunning = false;

                if (btnVendingAutoCycle.InvokeRequired)
                {
                    btnVendingAutoCycle.Invoke(
                        (MethodInvoker)delegate
                        {
                            btnVendingAutoCycle.Text = "Start Vending Autocycle";
                        });
                }
                else
                {
                    btnVendingAutoCycle.Text = "Start Vending Autocycle";
                }
            }
        }

        private void btnVendingAutoCycle_Click(object sender, EventArgs e)
        {
            if (bVendingAutoCycleIsRunning)
            {
                btnVendingAutoCycle.Text = "Stopping ...";
                bVendingAutoCycleStopRequested = true;

                t.StopWaitingForCard();
            }
            else
            {
                if (!ParseAmount() || !ParseCurrency())
                {
                    AddLog("Invalid input");
                    return;
                }

                bVendingAutoCycleIsRunning = true;
                btnVendingAutoCycle.Text = "Stop Vending Autocycle";

                thVendingAutoCycleThread = new Thread(VendingAutoCycle);
                thVendingAutoCycleThread.Start();
            }
        }

        private void btnDisplayText_Click(object sender, EventArgs e)
        {
            int Timeout = 0;            
            
            Int32.TryParse(txtDispalyTextTimeout.Text, out Timeout);

            RequestResult r = t.DisplayTextOnScreen(Timeout
                , txtDispalyTextRow1.Text, (DispalyTextRowAlign)cmbDispalyTextRow1Align.SelectedItem
                , txtDispalyTextRow2.Text, (DispalyTextRowAlign)cmbDispalyTextRow2Align.SelectedItem
                , txtDispalyTextRow3.Text, (DispalyTextRowAlign)cmbDispalyTextRow3Align.SelectedItem
                , txtDispalyTextRow4.Text, (DispalyTextRowAlign)cmbDispalyTextRow4Align.SelectedItem
                , txtDispalyTextRow5.Text, (DispalyTextRowAlign)cmbDispalyTextRow5Align.SelectedItem
                );

            switch (r)
            {
                case RequestResult.Busy:
                case RequestResult.InvalidParams:
                case RequestResult.NotInitialized:
                    MessageBox.Show("RequestResult: " + r.ToString());
                    break;
                default: break;
            }
        }

        private void btnHideText_Click(object sender, EventArgs e)
        {
            t.HideTextOnScreen();
        }

        private void btnIsWaitingForCard_Click(object sender, EventArgs e)
        {
            if (t.IsWaitingForCard())
            {
                AddLog("Is waiting for card");
            }
            else
            {
                AddLog("Not waiting for card");
            }
        }

        private void btnPurchaseAutoCycle_Click(object sender, EventArgs e)
        {
            if (bVendingAutoCycleIsRunning)
            {
                btnPurchaseAutoCycle.Text = "Stopping ...";
                bVendingAutoCycleStopRequested = true;

                t.StopWaitingForCard();
            }
            else
            {
                if (!ParseAmount() || !ParseCurrency())
                {
                    AddLog("Invalid input");
                    return;
                }

                bVendingAutoCycleIsRunning = true;
                btnPurchaseAutoCycle.Text = "Stop Purchase Autocycle";

                thVendingAutoCycleThread = new Thread(PurchaseAutoCycle);
                thVendingAutoCycleThread.Start();
            }
        }

        private void PurchaseAutoCycle()
        {
            RequestResult r;
            bVendingAutoCycleStopRequested = false;
            semVendingAutoCycleWaitResult = new Semaphore(0, 1);

            double Tip = 0;
            ReferenceNumberType refNumType = ReferenceNumberType.None;
            string refNumValue = "";
            string operCode = "";

            if (cmbReferenceType.InvokeRequired)
            {
                cmbReferenceType.Invoke(
                        (MethodInvoker)delegate
                        {
                            Double.TryParse(txtTipAmount.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out Tip);
                            refNumType = (ReferenceNumberType)cmbReferenceType.SelectedItem;
                            refNumValue = txtReferenceNumber.Text;
                            operCode = txtOperatorCode.Text;
                        });
            }
            else
            {
                Double.TryParse(txtTipAmount.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out Tip);
                refNumType = (ReferenceNumberType)cmbReferenceType.SelectedItem;
                refNumValue = txtReferenceNumber.Text;
                operCode = txtOperatorCode.Text;
            }

            try
            {
                while (!bVendingAutoCycleStopRequested)
                {
                    r = t.Purchase(Amount, Tip, cur, refNumType, refNumValue, operCode);
                    switch (r)
                    {
                        case RequestResult.Busy:
                        case RequestResult.InvalidParams:
                        case RequestResult.NotInitialized:
                            AddLog("RequestResult: " + r.ToString());
                            break;
                        case RequestResult.Processing:
                            if (!semVendingAutoCycleWaitResult.WaitOne())
                            {
                                break;
                            }
                            break;
                        default: break;
                    }

                    if (!bVendingAutoCycleStopRequested)
                    {
                        semVendingAutoCycleWaitResult.WaitOne(20000);
                    }
                }
            }
            finally
            {
                bVendingAutoCycleIsRunning = false;

                if (btnPurchaseAutoCycle.InvokeRequired)
                {
                    btnPurchaseAutoCycle.Invoke(
                        (MethodInvoker)delegate
                        {
                            btnPurchaseAutoCycle.Text = "Start Purchase Autocycle";
                        });
                }
                else
                {
                    btnPurchaseAutoCycle.Text = "Start Purchase Autocycle";
                }
            }
        }

        private void btnTwintPurchase_Click(object sender, EventArgs e)
        {

            if (!ParseAmount() || !ParseCurrency())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {

                RequestResult r = t.TwintPurchase(Amount, cur);
                switch (r)
                {
                    case RequestResult.Busy:
                    case RequestResult.InvalidParams:
                    case RequestResult.NotInitialized:
                        MessageBox.Show("RequestResult: " + r.ToString());
                        break;
                    default: break;
                }
            }
        }
    }
}
