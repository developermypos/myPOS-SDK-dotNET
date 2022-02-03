namespace myPOSDemoApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbComPorts = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnReversal = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnReprint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbReceiptMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtPrintData = new System.Windows.Forms.TextBox();
            this.btnPrintExternal = new System.Windows.Forms.Button();
            this.btnPreauth = new System.Windows.Forms.Button();
            this.txtPreauthCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPreauthComplete = new System.Windows.Forms.Button();
            this.btnPreauthCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPan = new System.Windows.Forms.TextBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.btnMotoPurchase = new System.Windows.Forms.Button();
            this.btnMotoRefund = new System.Windows.Forms.Button();
            this.btnMotoPreauth = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.btnReboot = new System.Windows.Forms.Button();
            this.btnGiftActivation = new System.Windows.Forms.Button();
            this.btnGiftDeactivation = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTipAmount = new System.Windows.Forms.TextBox();
            this.cmbReferenceType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReferenceNumber = new System.Windows.Forms.TextBox();
            this.btnBigPurchase = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOperatorCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGSM = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btnPaymentRequest = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.btnCheckCard = new System.Windows.Forms.Button();
            this.btnOriginalCredit = new System.Windows.Forms.Button();
            this.btnSendLog = new System.Windows.Forms.Button();
            this.btnVendingPurchase = new System.Windows.Forms.Button();
            this.btnVendingStop = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.chkWriteLog = new System.Windows.Forms.CheckBox();
            this.btnBeep = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbBeepTone = new System.Windows.Forms.ComboBox();
            this.txtBeepDuration = new System.Windows.Forms.TextBox();
            this.btnVendingComplete = new System.Windows.Forms.Button();
            this.btnVendingCancel = new System.Windows.Forms.Button();
            this.btnOpenSettings = new System.Windows.Forms.Button();
            this.fixedPinpadCb = new System.Windows.Forms.CheckBox();
            this.btnCheckForCRR = new System.Windows.Forms.Button();
            this.btnStopWaitingCard = new System.Windows.Forms.Button();
            this.btnCashAdvance = new System.Windows.Forms.Button();
            this.btnPrintExternalUTF8 = new System.Windows.Forms.Button();
            this.chkVendingShowAmount = new System.Windows.Forms.CheckBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbComPorts
            // 
            this.cmbComPorts.FormattingEnabled = true;
            this.cmbComPorts.Location = new System.Drawing.Point(74, 10);
            this.cmbComPorts.Name = "cmbComPorts";
            this.cmbComPorts.Size = new System.Drawing.Size(176, 21);
            this.cmbComPorts.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(256, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(337, 8);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(24, 295);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 23);
            this.btnPurchase.TabIndex = 3;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Location = new System.Drawing.Point(12, 424);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(1379, 555);
            this.txtLog.TabIndex = 4;
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(24, 395);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 6;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Location = new System.Drawing.Point(24, 56);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(75, 23);
            this.btnGetStatus.TabIndex = 8;
            this.btnGetStatus.Text = "Get Status";
            this.btnGetStatus.UseVisualStyleBackColor = true;
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(114, 56);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "COM port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Currency";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(114, 133);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(164, 20);
            this.txtAmount.TabIndex = 13;
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(114, 185);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(164, 21);
            this.cmbCurrency.TabIndex = 14;
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(114, 295);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(75, 23);
            this.btnRefund.TabIndex = 15;
            this.btnRefund.Text = "Refund";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnReversal
            // 
            this.btnReversal.Location = new System.Drawing.Point(203, 295);
            this.btnReversal.Name = "btnReversal";
            this.btnReversal.Size = new System.Drawing.Size(75, 23);
            this.btnReversal.TabIndex = 16;
            this.btnReversal.Text = "Reversal";
            this.btnReversal.UseVisualStyleBackColor = true;
            this.btnReversal.Click += new System.EventHandler(this.btnReversal_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(203, 56);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(75, 23);
            this.btnActivate.TabIndex = 17;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Location = new System.Drawing.Point(294, 56);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(75, 23);
            this.btnDeactivate.TabIndex = 17;
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // btnReprint
            // 
            this.btnReprint.Location = new System.Drawing.Point(227, 395);
            this.btnReprint.Name = "btnReprint";
            this.btnReprint.Size = new System.Drawing.Size(117, 23);
            this.btnReprint.TabIndex = 18;
            this.btnReprint.Text = "Reprint receipt";
            this.btnReprint.UseVisualStyleBackColor = true;
            this.btnReprint.Click += new System.EventHandler(this.btnReprint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Receipt mode";
            // 
            // cmbReceiptMode
            // 
            this.cmbReceiptMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceiptMode.FormattingEnabled = true;
            this.cmbReceiptMode.Location = new System.Drawing.Point(114, 106);
            this.cmbReceiptMode.Name = "cmbReceiptMode";
            this.cmbReceiptMode.Size = new System.Drawing.Size(164, 21);
            this.cmbReceiptMode.TabIndex = 14;
            this.cmbReceiptMode.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Reference";
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(114, 215);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(164, 20);
            this.txtReference.TabIndex = 22;
            // 
            // txtPrintData
            // 
            this.txtPrintData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrintData.Location = new System.Drawing.Point(1142, 13);
            this.txtPrintData.Multiline = true;
            this.txtPrintData.Name = "txtPrintData";
            this.txtPrintData.Size = new System.Drawing.Size(249, 254);
            this.txtPrintData.TabIndex = 23;
            this.txtPrintData.Text = resources.GetString("txtPrintData.Text");
            // 
            // btnPrintExternal
            // 
            this.btnPrintExternal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintExternal.Location = new System.Drawing.Point(1142, 273);
            this.btnPrintExternal.Name = "btnPrintExternal";
            this.btnPrintExternal.Size = new System.Drawing.Size(128, 23);
            this.btnPrintExternal.TabIndex = 24;
            this.btnPrintExternal.Text = "Print external ASCII";
            this.btnPrintExternal.UseVisualStyleBackColor = true;
            this.btnPrintExternal.Click += new System.EventHandler(this.btnPrintExternal_Click);
            // 
            // btnPreauth
            // 
            this.btnPreauth.Location = new System.Drawing.Point(24, 325);
            this.btnPreauth.Name = "btnPreauth";
            this.btnPreauth.Size = new System.Drawing.Size(75, 23);
            this.btnPreauth.TabIndex = 25;
            this.btnPreauth.Text = "Preauth";
            this.btnPreauth.UseVisualStyleBackColor = true;
            this.btnPreauth.Click += new System.EventHandler(this.btnPreauth_Click);
            // 
            // txtPreauthCode
            // 
            this.txtPreauthCode.Location = new System.Drawing.Point(114, 241);
            this.txtPreauthCode.Name = "txtPreauthCode";
            this.txtPreauthCode.Size = new System.Drawing.Size(164, 20);
            this.txtPreauthCode.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Preauth Code";
            // 
            // btnPreauthComplete
            // 
            this.btnPreauthComplete.Location = new System.Drawing.Point(114, 325);
            this.btnPreauthComplete.Name = "btnPreauthComplete";
            this.btnPreauthComplete.Size = new System.Drawing.Size(146, 23);
            this.btnPreauthComplete.TabIndex = 26;
            this.btnPreauthComplete.Text = "Preauth completion";
            this.btnPreauthComplete.UseVisualStyleBackColor = true;
            this.btnPreauthComplete.Click += new System.EventHandler(this.btnPreauthComplete_Click);
            // 
            // btnPreauthCancel
            // 
            this.btnPreauthCancel.Location = new System.Drawing.Point(266, 325);
            this.btnPreauthCancel.Name = "btnPreauthCancel";
            this.btnPreauthCancel.Size = new System.Drawing.Size(146, 23);
            this.btnPreauthCancel.TabIndex = 27;
            this.btnPreauthCancel.Text = "Preauth cancelation";
            this.btnPreauthCancel.UseVisualStyleBackColor = true;
            this.btnPreauthCancel.Click += new System.EventHandler(this.btnPreauthCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "PAN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "ExpiryDate (MMYY)";
            // 
            // txtPan
            // 
            this.txtPan.Location = new System.Drawing.Point(433, 106);
            this.txtPan.Name = "txtPan";
            this.txtPan.Size = new System.Drawing.Size(164, 20);
            this.txtPan.TabIndex = 22;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(433, 132);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(164, 20);
            this.txtExpiryDate.TabIndex = 22;
            // 
            // btnMotoPurchase
            // 
            this.btnMotoPurchase.Location = new System.Drawing.Point(504, 295);
            this.btnMotoPurchase.Name = "btnMotoPurchase";
            this.btnMotoPurchase.Size = new System.Drawing.Size(149, 23);
            this.btnMotoPurchase.TabIndex = 28;
            this.btnMotoPurchase.Text = "Moto Purchase";
            this.btnMotoPurchase.UseVisualStyleBackColor = true;
            this.btnMotoPurchase.Click += new System.EventHandler(this.btnMotoPurchase_Click);
            // 
            // btnMotoRefund
            // 
            this.btnMotoRefund.Location = new System.Drawing.Point(504, 325);
            this.btnMotoRefund.Name = "btnMotoRefund";
            this.btnMotoRefund.Size = new System.Drawing.Size(149, 23);
            this.btnMotoRefund.TabIndex = 28;
            this.btnMotoRefund.Text = "Moto Refund";
            this.btnMotoRefund.UseVisualStyleBackColor = true;
            this.btnMotoRefund.Click += new System.EventHandler(this.btnMotoRefund_Click);
            // 
            // btnMotoPreauth
            // 
            this.btnMotoPreauth.Location = new System.Drawing.Point(504, 354);
            this.btnMotoPreauth.Name = "btnMotoPreauth";
            this.btnMotoPreauth.Size = new System.Drawing.Size(149, 23);
            this.btnMotoPreauth.TabIndex = 28;
            this.btnMotoPreauth.Text = "Moto Preauth";
            this.btnMotoPreauth.UseVisualStyleBackColor = true;
            this.btnMotoPreauth.Click += new System.EventHandler(this.btnMotoPreauth_Click);
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(388, 56);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 17;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // btnReboot
            // 
            this.btnReboot.Location = new System.Drawing.Point(478, 56);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(75, 23);
            this.btnReboot.TabIndex = 29;
            this.btnReboot.Text = "Reboot";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnGiftActivation
            // 
            this.btnGiftActivation.Location = new System.Drawing.Point(24, 355);
            this.btnGiftActivation.Name = "btnGiftActivation";
            this.btnGiftActivation.Size = new System.Drawing.Size(122, 23);
            this.btnGiftActivation.TabIndex = 30;
            this.btnGiftActivation.Text = "Giftcard Activation";
            this.btnGiftActivation.UseVisualStyleBackColor = true;
            this.btnGiftActivation.Click += new System.EventHandler(this.btnGiftActivation_Click);
            // 
            // btnGiftDeactivation
            // 
            this.btnGiftDeactivation.Location = new System.Drawing.Point(156, 355);
            this.btnGiftDeactivation.Name = "btnGiftDeactivation";
            this.btnGiftDeactivation.Size = new System.Drawing.Size(122, 23);
            this.btnGiftDeactivation.TabIndex = 30;
            this.btnGiftDeactivation.Text = "Giftcard Deactivation";
            this.btnGiftDeactivation.UseVisualStyleBackColor = true;
            this.btnGiftDeactivation.Click += new System.EventHandler(this.btnGiftDeactivation_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(289, 355);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(122, 23);
            this.btnCheckBalance.TabIndex = 30;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Amount tip";
            // 
            // txtTipAmount
            // 
            this.txtTipAmount.Location = new System.Drawing.Point(114, 159);
            this.txtTipAmount.Name = "txtTipAmount";
            this.txtTipAmount.Size = new System.Drawing.Size(164, 20);
            this.txtTipAmount.TabIndex = 13;
            // 
            // cmbReferenceType
            // 
            this.cmbReferenceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReferenceType.FormattingEnabled = true;
            this.cmbReferenceType.Location = new System.Drawing.Point(433, 158);
            this.cmbReferenceType.Name = "cmbReferenceType";
            this.cmbReferenceType.Size = new System.Drawing.Size(164, 21);
            this.cmbReferenceType.TabIndex = 14;
            this.cmbReferenceType.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Reference type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(320, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Reference number";
            // 
            // txtReferenceNumber
            // 
            this.txtReferenceNumber.Location = new System.Drawing.Point(433, 185);
            this.txtReferenceNumber.Name = "txtReferenceNumber";
            this.txtReferenceNumber.Size = new System.Drawing.Size(164, 20);
            this.txtReferenceNumber.TabIndex = 22;
            // 
            // btnBigPurchase
            // 
            this.btnBigPurchase.Location = new System.Drawing.Point(289, 296);
            this.btnBigPurchase.Name = "btnBigPurchase";
            this.btnBigPurchase.Size = new System.Drawing.Size(122, 23);
            this.btnBigPurchase.TabIndex = 31;
            this.btnBigPurchase.Text = "Purcase + Tip";
            this.btnBigPurchase.UseVisualStyleBackColor = true;
            this.btnBigPurchase.Click += new System.EventHandler(this.btnBigPurchase_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(320, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Operator code";
            // 
            // txtOperatorCode
            // 
            this.txtOperatorCode.Location = new System.Drawing.Point(433, 210);
            this.txtOperatorCode.Name = "txtOperatorCode";
            this.txtOperatorCode.Size = new System.Drawing.Size(164, 20);
            this.txtOperatorCode.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(320, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(433, 236);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(164, 20);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(619, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "GSM";
            // 
            // txtGSM
            // 
            this.txtGSM.Location = new System.Drawing.Point(695, 106);
            this.txtGSM.Name = "txtGSM";
            this.txtGSM.Size = new System.Drawing.Size(164, 20);
            this.txtGSM.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(619, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "EMail";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(695, 133);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(164, 20);
            this.txtEMail.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(619, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Recipient";
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(695, 159);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(164, 20);
            this.txtRecipient.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(619, 213);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Days";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(695, 211);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(164, 20);
            this.txtDays.TabIndex = 22;
            // 
            // btnPaymentRequest
            // 
            this.btnPaymentRequest.Location = new System.Drawing.Point(695, 244);
            this.btnPaymentRequest.Name = "btnPaymentRequest";
            this.btnPaymentRequest.Size = new System.Drawing.Size(164, 23);
            this.btnPaymentRequest.TabIndex = 28;
            this.btnPaymentRequest.Text = "Payment Request";
            this.btnPaymentRequest.UseVisualStyleBackColor = true;
            this.btnPaymentRequest.Click += new System.EventHandler(this.btnPaymentRequest_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(619, 187);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Reason";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(695, 185);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(164, 20);
            this.txtReason.TabIndex = 22;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(709, 56);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(160, 21);
            this.cmbLanguage.TabIndex = 32;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // btnCheckCard
            // 
            this.btnCheckCard.Location = new System.Drawing.Point(681, 295);
            this.btnCheckCard.Name = "btnCheckCard";
            this.btnCheckCard.Size = new System.Drawing.Size(149, 23);
            this.btnCheckCard.TabIndex = 28;
            this.btnCheckCard.Text = "Check Card";
            this.btnCheckCard.UseVisualStyleBackColor = true;
            this.btnCheckCard.Click += new System.EventHandler(this.btnCheckCard_Click);
            // 
            // btnOriginalCredit
            // 
            this.btnOriginalCredit.Location = new System.Drawing.Point(681, 325);
            this.btnOriginalCredit.Name = "btnOriginalCredit";
            this.btnOriginalCredit.Size = new System.Drawing.Size(149, 23);
            this.btnOriginalCredit.TabIndex = 28;
            this.btnOriginalCredit.Text = "Original Credit";
            this.btnOriginalCredit.UseVisualStyleBackColor = true;
            this.btnOriginalCredit.Click += new System.EventHandler(this.btnOriginalCredit_Click);
            // 
            // btnSendLog
            // 
            this.btnSendLog.Location = new System.Drawing.Point(532, 8);
            this.btnSendLog.Name = "btnSendLog";
            this.btnSendLog.Size = new System.Drawing.Size(100, 23);
            this.btnSendLog.TabIndex = 33;
            this.btnSendLog.Text = "Send Log";
            this.btnSendLog.UseVisualStyleBackColor = true;
            this.btnSendLog.Click += new System.EventHandler(this.btnSendLog_Click);
            // 
            // btnVendingPurchase
            // 
            this.btnVendingPurchase.Location = new System.Drawing.Point(854, 296);
            this.btnVendingPurchase.Name = "btnVendingPurchase";
            this.btnVendingPurchase.Size = new System.Drawing.Size(149, 23);
            this.btnVendingPurchase.TabIndex = 34;
            this.btnVendingPurchase.Text = "Vending Purchase";
            this.btnVendingPurchase.UseVisualStyleBackColor = true;
            this.btnVendingPurchase.Click += new System.EventHandler(this.btnVendingPurchase_Click);
            // 
            // btnVendingStop
            // 
            this.btnVendingStop.Location = new System.Drawing.Point(854, 325);
            this.btnVendingStop.Name = "btnVendingStop";
            this.btnVendingStop.Size = new System.Drawing.Size(149, 23);
            this.btnVendingStop.TabIndex = 35;
            this.btnVendingStop.Text = "Vending Stop";
            this.btnVendingStop.UseVisualStyleBackColor = true;
            this.btnVendingStop.Click += new System.EventHandler(this.btnVendingStop_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(1259, 384);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(132, 23);
            this.btnClearLog.TabIndex = 36;
            this.btnClearLog.Text = "Clear log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // chkWriteLog
            // 
            this.chkWriteLog.AutoSize = true;
            this.chkWriteLog.Checked = true;
            this.chkWriteLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWriteLog.Location = new System.Drawing.Point(1290, 361);
            this.chkWriteLog.Name = "chkWriteLog";
            this.chkWriteLog.Size = new System.Drawing.Size(101, 17);
            this.chkWriteLog.TabIndex = 37;
            this.chkWriteLog.Text = "Write debug log";
            this.chkWriteLog.UseVisualStyleBackColor = true;
            // 
            // btnBeep
            // 
            this.btnBeep.Location = new System.Drawing.Point(961, 162);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(113, 23);
            this.btnBeep.TabIndex = 38;
            this.btnBeep.Text = "Beep";
            this.btnBeep.UseVisualStyleBackColor = true;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(887, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Tone";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(887, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "Duration (ms)";
            // 
            // cmbBeepTone
            // 
            this.cmbBeepTone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeepTone.FormattingEnabled = true;
            this.cmbBeepTone.Location = new System.Drawing.Point(961, 105);
            this.cmbBeepTone.Name = "cmbBeepTone";
            this.cmbBeepTone.Size = new System.Drawing.Size(113, 21);
            this.cmbBeepTone.TabIndex = 41;
            // 
            // txtBeepDuration
            // 
            this.txtBeepDuration.Location = new System.Drawing.Point(961, 133);
            this.txtBeepDuration.Name = "txtBeepDuration";
            this.txtBeepDuration.Size = new System.Drawing.Size(113, 20);
            this.txtBeepDuration.TabIndex = 42;
            // 
            // btnVendingComplete
            // 
            this.btnVendingComplete.Location = new System.Drawing.Point(854, 355);
            this.btnVendingComplete.Name = "btnVendingComplete";
            this.btnVendingComplete.Size = new System.Drawing.Size(149, 23);
            this.btnVendingComplete.TabIndex = 35;
            this.btnVendingComplete.Text = "Vending Complete";
            this.btnVendingComplete.UseVisualStyleBackColor = true;
            this.btnVendingComplete.Click += new System.EventHandler(this.btnVendingComplete_Click);
            // 
            // btnVendingCancel
            // 
            this.btnVendingCancel.Location = new System.Drawing.Point(854, 384);
            this.btnVendingCancel.Name = "btnVendingCancel";
            this.btnVendingCancel.Size = new System.Drawing.Size(149, 23);
            this.btnVendingCancel.TabIndex = 35;
            this.btnVendingCancel.Text = "Vending Cancel";
            this.btnVendingCancel.UseVisualStyleBackColor = true;
            this.btnVendingCancel.Click += new System.EventHandler(this.btnVendingCancel_Click);
            // 
            // btnOpenSettings
            // 
            this.btnOpenSettings.Location = new System.Drawing.Point(572, 56);
            this.btnOpenSettings.Name = "btnOpenSettings";
            this.btnOpenSettings.Size = new System.Drawing.Size(99, 23);
            this.btnOpenSettings.TabIndex = 29;
            this.btnOpenSettings.Text = "Open settings";
            this.btnOpenSettings.UseVisualStyleBackColor = true;
            this.btnOpenSettings.Click += new System.EventHandler(this.btnOpenSettings_Click);
            // 
            // fixedPinpadCb
            // 
            this.fixedPinpadCb.AutoSize = true;
            this.fixedPinpadCb.Checked = true;
            this.fixedPinpadCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fixedPinpadCb.Location = new System.Drawing.Point(961, 209);
            this.fixedPinpadCb.Name = "fixedPinpadCb";
            this.fixedPinpadCb.Size = new System.Drawing.Size(87, 17);
            this.fixedPinpadCb.TabIndex = 43;
            this.fixedPinpadCb.Text = "Fixed Pinpad";
            this.fixedPinpadCb.UseVisualStyleBackColor = true;
            this.fixedPinpadCb.CheckedChanged += new System.EventHandler(this.fixedPinpadCb_CheckedChanged);
            // 
            // btnCheckForCRR
            // 
            this.btnCheckForCRR.Location = new System.Drawing.Point(1142, 303);
            this.btnCheckForCRR.Name = "btnCheckForCRR";
            this.btnCheckForCRR.Size = new System.Drawing.Size(249, 23);
            this.btnCheckForCRR.TabIndex = 44;
            this.btnCheckForCRR.Text = "Check for CRR transaction";
            this.btnCheckForCRR.UseVisualStyleBackColor = true;
            this.btnCheckForCRR.Click += new System.EventHandler(this.btnCheckForCRR_Click);
            // 
            // btnStopWaitingCard
            // 
            this.btnStopWaitingCard.Location = new System.Drawing.Point(105, 395);
            this.btnStopWaitingCard.Name = "btnStopWaitingCard";
            this.btnStopWaitingCard.Size = new System.Drawing.Size(116, 23);
            this.btnStopWaitingCard.TabIndex = 45;
            this.btnStopWaitingCard.Text = "Stop waiting card";
            this.btnStopWaitingCard.UseVisualStyleBackColor = true;
            this.btnStopWaitingCard.Click += new System.EventHandler(this.btnStopWaitingCard_Click);
            // 
            // btnCashAdvance
            // 
            this.btnCashAdvance.Location = new System.Drawing.Point(681, 354);
            this.btnCashAdvance.Name = "btnCashAdvance";
            this.btnCashAdvance.Size = new System.Drawing.Size(149, 23);
            this.btnCashAdvance.TabIndex = 46;
            this.btnCashAdvance.Text = "Cash Advance";
            this.btnCashAdvance.UseVisualStyleBackColor = true;
            this.btnCashAdvance.Click += new System.EventHandler(this.btnCashAdvance_Click);
            // 
            // btnPrintExternalUTF8
            // 
            this.btnPrintExternalUTF8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintExternalUTF8.Location = new System.Drawing.Point(1276, 273);
            this.btnPrintExternalUTF8.Name = "btnPrintExternalUTF8";
            this.btnPrintExternalUTF8.Size = new System.Drawing.Size(115, 23);
            this.btnPrintExternalUTF8.TabIndex = 24;
            this.btnPrintExternalUTF8.Text = "Print external UTF8";
            this.btnPrintExternalUTF8.UseVisualStyleBackColor = true;
            this.btnPrintExternalUTF8.Click += new System.EventHandler(this.btnPrintExternalUTF8_Click);
            // 
            // chkVendingShowAmount
            // 
            this.chkVendingShowAmount.AutoSize = true;
            this.chkVendingShowAmount.Location = new System.Drawing.Point(836, 273);
            this.chkVendingShowAmount.Name = "chkVendingShowAmount";
            this.chkVendingShowAmount.Size = new System.Drawing.Size(194, 17);
            this.chkVendingShowAmount.TabIndex = 47;
            this.chkVendingShowAmount.Text = "Show amount on vending purchase";
            this.chkVendingShowAmount.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(418, 8);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 48;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 991);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.chkVendingShowAmount);
            this.Controls.Add(this.btnCashAdvance);
            this.Controls.Add(this.btnStopWaitingCard);
            this.Controls.Add(this.btnCheckForCRR);
            this.Controls.Add(this.fixedPinpadCb);
            this.Controls.Add(this.txtBeepDuration);
            this.Controls.Add(this.cmbBeepTone);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnBeep);
            this.Controls.Add(this.chkWriteLog);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnVendingCancel);
            this.Controls.Add(this.btnVendingComplete);
            this.Controls.Add(this.btnVendingStop);
            this.Controls.Add(this.btnVendingPurchase);
            this.Controls.Add(this.btnSendLog);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.btnBigPurchase);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnGiftDeactivation);
            this.Controls.Add(this.btnGiftActivation);
            this.Controls.Add(this.btnOpenSettings);
            this.Controls.Add(this.btnReboot);
            this.Controls.Add(this.btnMotoPreauth);
            this.Controls.Add(this.btnOriginalCredit);
            this.Controls.Add(this.btnCheckCard);
            this.Controls.Add(this.btnMotoRefund);
            this.Controls.Add(this.btnPaymentRequest);
            this.Controls.Add(this.btnMotoPurchase);
            this.Controls.Add(this.btnPreauthCancel);
            this.Controls.Add(this.btnPreauthComplete);
            this.Controls.Add(this.btnPreauth);
            this.Controls.Add(this.btnPrintExternalUTF8);
            this.Controls.Add(this.btnPrintExternal);
            this.Controls.Add(this.txtPrintData);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtOperatorCode);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.txtGSM);
            this.Controls.Add(this.txtReferenceNumber);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPreauthCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReprint);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnReversal);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.cmbReferenceType);
            this.Controls.Add(this.cmbReceiptMode);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.txtTipAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetStatus);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbComPorts);
            this.Name = "Form1";
            this.Text = "Test Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbComPorts;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnGetStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnReversal;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnReprint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbReceiptMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.TextBox txtPrintData;
        private System.Windows.Forms.Button btnPrintExternal;
        private System.Windows.Forms.Button btnPreauth;
        private System.Windows.Forms.TextBox txtPreauthCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPreauthComplete;
        private System.Windows.Forms.Button btnPreauthCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPan;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.Button btnMotoPurchase;
        private System.Windows.Forms.Button btnMotoRefund;
        private System.Windows.Forms.Button btnMotoPreauth;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.Button btnGiftActivation;
        private System.Windows.Forms.Button btnGiftDeactivation;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTipAmount;
        private System.Windows.Forms.ComboBox cmbReferenceType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtReferenceNumber;
        private System.Windows.Forms.Button btnBigPurchase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOperatorCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGSM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button btnPaymentRequest;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Button btnCheckCard;
        private System.Windows.Forms.Button btnOriginalCredit;
        private System.Windows.Forms.Button btnSendLog;
        private System.Windows.Forms.Button btnVendingPurchase;
        private System.Windows.Forms.Button btnVendingStop;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.CheckBox chkWriteLog;
        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbBeepTone;
        private System.Windows.Forms.TextBox txtBeepDuration;
        private System.Windows.Forms.Button btnVendingComplete;
        private System.Windows.Forms.Button btnVendingCancel;
		private System.Windows.Forms.Button btnOpenSettings;
		private System.Windows.Forms.CheckBox fixedPinpadCb;
		private System.Windows.Forms.Button btnCheckForCRR;
		private System.Windows.Forms.Button btnStopWaitingCard;
		private System.Windows.Forms.Button btnCashAdvance;
		private System.Windows.Forms.Button btnPrintExternalUTF8;
		private System.Windows.Forms.CheckBox chkVendingShowAmount;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

