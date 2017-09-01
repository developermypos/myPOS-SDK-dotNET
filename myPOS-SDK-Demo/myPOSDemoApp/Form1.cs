using myPOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPOSDemoApp
{
    public partial class Form1 : Form
    {
        double Amount;
        Currencies cur;
        Version version = Assembly.GetEntryAssembly().GetName().Version;

        myPOSTerminal t = new myPOSTerminal();
        public Form1()
        {
            InitializeComponent();
            
            t.ProcessingFinished += ProcessResult;
            t.Log += AddLog;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshComPorts();
            cmbCurrency.DataSource = Enum.GetValues(typeof(Currencies));
            cmbCurrency.SelectedItem = Currencies.EUR;
            cmbReceiptMode.DataSource = Enum.GetValues(typeof(ReceiptMode));
            cmbReceiptMode.SelectedItem = ReceiptMode.NotConfugred;

            this.Text = "TestApp Version " + version.ToString();
            AddLog("TestApp Version: " + version.ToString());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshComPorts();
        }

        void RefreshComPorts()
        {
            cmbComPorts.Items.Clear();
            cmbComPorts.Items.AddRange(SerialPort.GetPortNames());
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
                sb.AppendFormat("Currency: {0}\r\n", r.TranData.Currency.ToString());
                sb.AppendFormat("Approval: {0}\r\n", r.TranData.Approval);
                sb.AppendFormat("Auth code: {0}\r\n", r.TranData.AuthCode);
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
                sb.AppendFormat("STAN: {0}\r\n", r.TranData.Stan);
                sb.AppendFormat("Signature Required: {0}\r\n", r.TranData.SignatureRequired ? "Yes" : "No");
            }

            AddLog(sb.ToString());
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
            }
            catch { }
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

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbComPorts.SelectedIndex < 0) return;

            t.Initialize((string)cmbComPorts.SelectedItem);
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
            if (!ParseAmount() || !ParseCurrency())
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                RequestResult r = t.Purchase(Amount, cur, txtReference.Text);
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
                RequestResult r = t.Refund(Amount, cur, txtReference.Text);
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
            RequestResult r = t.Reversal(txtReference.Text);
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
    }
}
