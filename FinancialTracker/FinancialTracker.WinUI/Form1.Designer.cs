namespace FinancialTracker.WinUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxTransactions = new ListBox();
            btnAuthenticate = new Button();
            datePicker = new DateTimePicker();
            label1 = new Label();
            txtDescription = new TextBox();
            label2 = new Label();
            txtAmount = new TextBox();
            label3 = new Label();
            cboCategory = new ComboBox();
            label4 = new Label();
            cboTransactionType = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cboCurrency = new ComboBox();
            cboPaymentType = new ComboBox();
            BtnAddTransaction = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            C = new TabControl();
            Main_page = new TabPage();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            label8 = new Label();
            Calculator = new TabPage();
            panel24 = new Panel();
            panel25 = new Panel();
            panel22 = new Panel();
            panel23 = new Panel();
            panel20 = new Panel();
            panel21 = new Panel();
            panel18 = new Panel();
            panel19 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel1 = new Panel();
            label9 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            tb_show = new TextBox();
            buttonK = new Button();
            buttonDor = new Button();
            buttonDi = new Button();
            buttonM = new Button();
            buttonV = new Button();
            buttonD = new Button();
            buttonDel = new Button();
            buttonCE = new Button();
            buttonC = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button_2 = new Button();
            button_1 = new Button();
            button_0 = new Button();
            C.SuspendLayout();
            Main_page.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            Calculator.SuspendLayout();
            panel24.SuspendLayout();
            panel22.SuspendLayout();
            panel20.SuspendLayout();
            panel18.SuspendLayout();
            panel16.SuspendLayout();
            panel14.SuspendLayout();
            panel12.SuspendLayout();
            panel10.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxTransactions
            // 
            listBoxTransactions.FormattingEnabled = true;
            listBoxTransactions.ItemHeight = 15;
            listBoxTransactions.Location = new Point(267, 40);
            listBoxTransactions.Name = "listBoxTransactions";
            listBoxTransactions.Size = new Size(521, 184);
            listBoxTransactions.TabIndex = 0;
            // 
            // btnAuthenticate
            // 
            btnAuthenticate.BackColor = Color.ForestGreen;
            btnAuthenticate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAuthenticate.ForeColor = SystemColors.Control;
            btnAuthenticate.Location = new Point(670, 4);
            btnAuthenticate.Name = "btnAuthenticate";
            btnAuthenticate.Size = new Size(111, 27);
            btnAuthenticate.TabIndex = 1;
            btnAuthenticate.Text = "Authentication";
            btnAuthenticate.UseVisualStyleBackColor = false;
            btnAuthenticate.Click += btnAuthenticate_Click;
            // 
            // datePicker
            // 
            datePicker.CalendarMonthBackground = SystemColors.ActiveCaption;
            datePicker.Location = new Point(7, 31);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 8);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 3;
            label1.Text = "Date";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(3, 31);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(253, 23);
            txtDescription.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(7, 28);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(148, 23);
            txtAmount.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(7, 1);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 7;
            label3.Text = "Amount";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "food", "transport", "dwelling", "entertainment ", "recreation", "health", "сlothes", "technologies", "utilities", "communication (internet)", "everyday life", "education", "leisure", "other" });
            cboCategory.Location = new Point(3, 34);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(121, 23);
            cboCategory.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 9;
            label4.Text = "Category";
            // 
            // cboTransactionType
            // 
            cboTransactionType.FormattingEnabled = true;
            cboTransactionType.Items.AddRange(new object[] { "purchase", "transfer", "income", "payment", "other" });
            cboTransactionType.Location = new Point(127, 34);
            cboTransactionType.Name = "cboTransactionType";
            cboTransactionType.Size = new Size(113, 23);
            cboTransactionType.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(120, 7);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 11;
            label5.Text = "Transaction type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(7, 8);
            label6.Name = "label6";
            label6.Size = new Size(104, 21);
            label6.TabIndex = 12;
            label6.Text = "Payment type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(139, 7);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 13;
            label7.Text = "Currency";
            // 
            // cboCurrency
            // 
            cboCurrency.FormattingEnabled = true;
            cboCurrency.Items.AddRange(new object[] { "UAH", "USD", "EUR", "JPY", "CNY", "GBP", "BTC", "other" });
            cboCurrency.Location = new Point(139, 34);
            cboCurrency.Name = "cboCurrency";
            cboCurrency.Size = new Size(121, 23);
            cboCurrency.TabIndex = 14;
            // 
            // cboPaymentType
            // 
            cboPaymentType.FormattingEnabled = true;
            cboPaymentType.Items.AddRange(new object[] { "card", "cash", "other" });
            cboPaymentType.Location = new Point(7, 34);
            cboPaymentType.Name = "cboPaymentType";
            cboPaymentType.Size = new Size(121, 23);
            cboPaymentType.TabIndex = 15;
            // 
            // BtnAddTransaction
            // 
            BtnAddTransaction.BackColor = Color.DarkSeaGreen;
            BtnAddTransaction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddTransaction.ForeColor = Color.DarkGreen;
            BtnAddTransaction.Location = new Point(0, 8);
            BtnAddTransaction.Name = "BtnAddTransaction";
            BtnAddTransaction.Size = new Size(266, 55);
            BtnAddTransaction.TabIndex = 16;
            BtnAddTransaction.Text = "Add";
            BtnAddTransaction.UseVisualStyleBackColor = false;
            BtnAddTransaction.Click += BtnAddTransaction_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.DarkSeaGreen;
            buttonEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.DarkGreen;
            buttonEdit.Location = new Point(0, 69);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(266, 55);
            buttonEdit.TabIndex = 17;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.DarkSeaGreen;
            buttonDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.DarkGreen;
            buttonDelete.Location = new Point(0, 130);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(266, 58);
            buttonDelete.TabIndex = 18;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // C
            // 
            C.Controls.Add(Main_page);
            C.Controls.Add(Calculator);
            C.Location = new Point(0, 1);
            C.Name = "C";
            C.SelectedIndex = 0;
            C.Size = new Size(802, 452);
            C.TabIndex = 19;
            // 
            // Main_page
            // 
            Main_page.Controls.Add(panel9);
            Main_page.Controls.Add(panel8);
            Main_page.Controls.Add(panel7);
            Main_page.Controls.Add(panel6);
            Main_page.Controls.Add(panel5);
            Main_page.Controls.Add(panel4);
            Main_page.Controls.Add(panel3);
            Main_page.Controls.Add(listBoxTransactions);
            Main_page.Location = new Point(4, 24);
            Main_page.Name = "Main_page";
            Main_page.Padding = new Padding(3);
            Main_page.Size = new Size(794, 424);
            Main_page.TabIndex = 0;
            Main_page.Text = "Main_page";
            Main_page.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.BackColor = Color.ForestGreen;
            panel9.Controls.Add(cboPaymentType);
            panel9.Controls.Add(label6);
            panel9.Controls.Add(cboCurrency);
            panel9.Controls.Add(label7);
            panel9.Location = new Point(524, 230);
            panel9.Name = "panel9";
            panel9.Size = new Size(264, 192);
            panel9.TabIndex = 26;
            // 
            // panel8
            // 
            panel8.BackColor = Color.ForestGreen;
            panel8.Controls.Add(cboCategory);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(cboTransactionType);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(275, 230);
            panel8.Name = "panel8";
            panel8.Size = new Size(243, 192);
            panel8.TabIndex = 25;
            // 
            // panel7
            // 
            panel7.BackColor = Color.ForestGreen;
            panel7.Controls.Add(label3);
            panel7.Controls.Add(txtAmount);
            panel7.Location = new Point(6, 362);
            panel7.Name = "panel7";
            panel7.Size = new Size(263, 60);
            panel7.TabIndex = 24;
            // 
            // panel6
            // 
            panel6.BackColor = Color.ForestGreen;
            panel6.Controls.Add(txtDescription);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(6, 296);
            panel6.Name = "panel6";
            panel6.Size = new Size(263, 60);
            panel6.TabIndex = 23;
            // 
            // panel5
            // 
            panel5.BackColor = Color.ForestGreen;
            panel5.Controls.Add(datePicker);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(6, 230);
            panel5.Name = "panel5";
            panel5.Size = new Size(263, 60);
            panel5.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BackColor = Color.ForestGreen;
            panel4.Controls.Add(buttonEdit);
            panel4.Controls.Add(BtnAddTransaction);
            panel4.Controls.Add(buttonDelete);
            panel4.Location = new Point(3, 36);
            panel4.Name = "panel4";
            panel4.Size = new Size(266, 188);
            panel4.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(btnAuthenticate);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(788, 34);
            panel3.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.ForestGreen;
            label8.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.HighlightText;
            label8.Location = new Point(0, 3);
            label8.Name = "label8";
            label8.Size = new Size(180, 31);
            label8.TabIndex = 19;
            label8.Text = "Financial tracker";
            // 
            // Calculator
            // 
            Calculator.BackColor = Color.White;
            Calculator.Controls.Add(panel24);
            Calculator.Controls.Add(panel22);
            Calculator.Controls.Add(panel20);
            Calculator.Controls.Add(panel18);
            Calculator.Controls.Add(panel16);
            Calculator.Controls.Add(panel14);
            Calculator.Controls.Add(panel12);
            Calculator.Controls.Add(panel10);
            Calculator.Controls.Add(panel1);
            Calculator.Controls.Add(pictureBox1);
            Calculator.Controls.Add(tb_show);
            Calculator.Controls.Add(buttonK);
            Calculator.Controls.Add(buttonDor);
            Calculator.Controls.Add(buttonDi);
            Calculator.Controls.Add(buttonM);
            Calculator.Controls.Add(buttonV);
            Calculator.Controls.Add(buttonD);
            Calculator.Controls.Add(buttonDel);
            Calculator.Controls.Add(buttonCE);
            Calculator.Controls.Add(buttonC);
            Calculator.Controls.Add(button9);
            Calculator.Controls.Add(button8);
            Calculator.Controls.Add(button7);
            Calculator.Controls.Add(button6);
            Calculator.Controls.Add(button5);
            Calculator.Controls.Add(button4);
            Calculator.Controls.Add(button3);
            Calculator.Controls.Add(button_2);
            Calculator.Controls.Add(button_1);
            Calculator.Controls.Add(button_0);
            Calculator.Location = new Point(4, 24);
            Calculator.Name = "Calculator";
            Calculator.Padding = new Padding(3);
            Calculator.Size = new Size(794, 424);
            Calculator.TabIndex = 1;
            Calculator.Text = "Calculator";
            // 
            // panel24
            // 
            panel24.BackColor = Color.ForestGreen;
            panel24.Controls.Add(panel25);
            panel24.Location = new Point(460, 374);
            panel24.Name = "panel24";
            panel24.Size = new Size(182, 30);
            panel24.TabIndex = 32;
            // 
            // panel25
            // 
            panel25.BackColor = Color.Orange;
            panel25.Location = new Point(351, 0);
            panel25.Name = "panel25";
            panel25.Size = new Size(157, 273);
            panel25.TabIndex = 23;
            // 
            // panel22
            // 
            panel22.BackColor = Color.ForestGreen;
            panel22.Controls.Add(panel23);
            panel22.Location = new Point(460, 324);
            panel22.Name = "panel22";
            panel22.Size = new Size(182, 30);
            panel22.TabIndex = 31;
            // 
            // panel23
            // 
            panel23.BackColor = Color.Orange;
            panel23.Location = new Point(351, 0);
            panel23.Name = "panel23";
            panel23.Size = new Size(157, 273);
            panel23.TabIndex = 23;
            // 
            // panel20
            // 
            panel20.BackColor = Color.ForestGreen;
            panel20.Controls.Add(panel21);
            panel20.Location = new Point(460, 271);
            panel20.Name = "panel20";
            panel20.Size = new Size(182, 30);
            panel20.TabIndex = 30;
            // 
            // panel21
            // 
            panel21.BackColor = Color.Orange;
            panel21.Location = new Point(351, 0);
            panel21.Name = "panel21";
            panel21.Size = new Size(157, 273);
            panel21.TabIndex = 23;
            // 
            // panel18
            // 
            panel18.BackColor = Color.ForestGreen;
            panel18.Controls.Add(panel19);
            panel18.Location = new Point(460, 220);
            panel18.Name = "panel18";
            panel18.Size = new Size(335, 30);
            panel18.TabIndex = 29;
            // 
            // panel19
            // 
            panel19.BackColor = Color.Orange;
            panel19.Location = new Point(351, 0);
            panel19.Name = "panel19";
            panel19.Size = new Size(157, 273);
            panel19.TabIndex = 23;
            // 
            // panel16
            // 
            panel16.BackColor = Color.ForestGreen;
            panel16.Controls.Add(panel17);
            panel16.Location = new Point(460, 164);
            panel16.Name = "panel16";
            panel16.Size = new Size(335, 30);
            panel16.TabIndex = 28;
            // 
            // panel17
            // 
            panel17.BackColor = Color.Orange;
            panel17.Location = new Point(351, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(157, 273);
            panel17.TabIndex = 23;
            // 
            // panel14
            // 
            panel14.BackColor = Color.ForestGreen;
            panel14.Controls.Add(panel15);
            panel14.Location = new Point(460, 108);
            panel14.Name = "panel14";
            panel14.Size = new Size(335, 30);
            panel14.TabIndex = 27;
            // 
            // panel15
            // 
            panel15.BackColor = Color.Orange;
            panel15.Location = new Point(351, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(157, 273);
            panel15.TabIndex = 23;
            // 
            // panel12
            // 
            panel12.BackColor = Color.ForestGreen;
            panel12.Controls.Add(panel13);
            panel12.Location = new Point(460, 53);
            panel12.Name = "panel12";
            panel12.Size = new Size(335, 30);
            panel12.TabIndex = 26;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Orange;
            panel13.Location = new Point(351, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(157, 273);
            panel13.TabIndex = 23;
            // 
            // panel10
            // 
            panel10.BackColor = Color.ForestGreen;
            panel10.Controls.Add(panel11);
            panel10.Location = new Point(460, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(335, 30);
            panel10.TabIndex = 25;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Orange;
            panel11.Location = new Point(351, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(157, 273);
            panel11.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(290, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 423);
            panel1.TabIndex = 22;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(16, 6);
            label9.Name = "label9";
            label9.Size = new Size(138, 30);
            label9.TabIndex = 24;
            label9.Text = "CALCULATOR";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Location = new Point(351, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(157, 273);
            panel2.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(641, 271);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // tb_show
            // 
            tb_show.Location = new Point(4, 7);
            tb_show.Multiline = true;
            tb_show.Name = "tb_show";
            tb_show.Size = new Size(280, 57);
            tb_show.TabIndex = 20;
            // 
            // buttonK
            // 
            buttonK.BackColor = Color.Honeydew;
            buttonK.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonK.ForeColor = Color.ForestGreen;
            buttonK.Location = new Point(89, 336);
            buttonK.Name = "buttonK";
            buttonK.Size = new Size(46, 48);
            buttonK.TabIndex = 18;
            buttonK.Text = ".";
            buttonK.UseVisualStyleBackColor = false;
            buttonK.Click += buttonK_Click;
            // 
            // buttonDor
            // 
            buttonDor.BackColor = Color.Honeydew;
            buttonDor.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDor.ForeColor = Color.ForestGreen;
            buttonDor.Location = new Point(161, 336);
            buttonDor.Name = "buttonDor";
            buttonDor.Size = new Size(46, 47);
            buttonDor.TabIndex = 17;
            buttonDor.Text = "=";
            buttonDor.UseVisualStyleBackColor = false;
            buttonDor.Click += buttonDor_Click;
            // 
            // buttonDi
            // 
            buttonDi.BackColor = Color.Honeydew;
            buttonDi.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDi.ForeColor = Color.ForestGreen;
            buttonDi.Location = new Point(238, 130);
            buttonDi.Name = "buttonDi";
            buttonDi.Size = new Size(46, 47);
            buttonDi.TabIndex = 16;
            buttonDi.Text = "/";
            buttonDi.UseVisualStyleBackColor = false;
            buttonDi.Click += buttonDi_Click;
            // 
            // buttonM
            // 
            buttonM.BackColor = Color.Honeydew;
            buttonM.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonM.ForeColor = Color.ForestGreen;
            buttonM.Location = new Point(238, 201);
            buttonM.Name = "buttonM";
            buttonM.Size = new Size(46, 47);
            buttonM.TabIndex = 15;
            buttonM.Text = "*";
            buttonM.UseVisualStyleBackColor = false;
            buttonM.Click += buttonM_Click;
            // 
            // buttonV
            // 
            buttonV.BackColor = Color.Honeydew;
            buttonV.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonV.ForeColor = Color.ForestGreen;
            buttonV.Location = new Point(238, 269);
            buttonV.Name = "buttonV";
            buttonV.Size = new Size(46, 47);
            buttonV.TabIndex = 14;
            buttonV.Text = "-";
            buttonV.UseVisualStyleBackColor = false;
            buttonV.Click += buttonV_Click;
            // 
            // buttonD
            // 
            buttonD.BackColor = Color.Honeydew;
            buttonD.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonD.ForeColor = Color.ForestGreen;
            buttonD.Location = new Point(238, 336);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(46, 47);
            buttonD.TabIndex = 13;
            buttonD.Text = "+";
            buttonD.UseVisualStyleBackColor = false;
            buttonD.Click += buttonD_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.Honeydew;
            buttonDel.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDel.ForeColor = Color.ForestGreen;
            buttonDel.Location = new Point(238, 70);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(46, 48);
            buttonDel.TabIndex = 12;
            buttonDel.Text = "Del";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonCE
            // 
            buttonCE.BackColor = Color.Honeydew;
            buttonCE.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCE.ForeColor = Color.ForestGreen;
            buttonCE.Location = new Point(8, 70);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(46, 47);
            buttonCE.TabIndex = 11;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = false;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.Honeydew;
            buttonC.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonC.ForeColor = Color.ForestGreen;
            buttonC.Location = new Point(70, 70);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(46, 48);
            buttonC.TabIndex = 10;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Honeydew;
            button9.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.ForestGreen;
            button9.Location = new Point(161, 130);
            button9.Name = "button9";
            button9.Size = new Size(46, 47);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Honeydew;
            button8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.ForestGreen;
            button8.Location = new Point(86, 130);
            button8.Name = "button8";
            button8.Size = new Size(46, 47);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Honeydew;
            button7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.ForestGreen;
            button7.Location = new Point(8, 130);
            button7.Name = "button7";
            button7.Size = new Size(46, 48);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Honeydew;
            button6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.ForestGreen;
            button6.Location = new Point(161, 201);
            button6.Name = "button6";
            button6.Size = new Size(46, 48);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Honeydew;
            button5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.ForestGreen;
            button5.Location = new Point(86, 201);
            button5.Name = "button5";
            button5.Size = new Size(46, 48);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Honeydew;
            button4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.ForestGreen;
            button4.Location = new Point(8, 202);
            button4.Name = "button4";
            button4.Size = new Size(46, 48);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Honeydew;
            button3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.ForestGreen;
            button3.Location = new Point(161, 269);
            button3.Name = "button3";
            button3.Size = new Size(46, 48);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button_2
            // 
            button_2.BackColor = Color.Honeydew;
            button_2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_2.ForeColor = Color.ForestGreen;
            button_2.Location = new Point(86, 269);
            button_2.Name = "button_2";
            button_2.Size = new Size(46, 48);
            button_2.TabIndex = 2;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = false;
            button_2.Click += button_2_Click;
            // 
            // button_1
            // 
            button_1.BackColor = Color.Honeydew;
            button_1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_1.ForeColor = Color.ForestGreen;
            button_1.Location = new Point(8, 269);
            button_1.Name = "button_1";
            button_1.Size = new Size(46, 48);
            button_1.TabIndex = 1;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = false;
            button_1.Click += button_1_Click;
            // 
            // button_0
            // 
            button_0.BackColor = Color.Honeydew;
            button_0.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_0.ForeColor = Color.ForestGreen;
            button_0.Location = new Point(8, 337);
            button_0.Name = "button_0";
            button_0.Size = new Size(46, 48);
            button_0.TabIndex = 0;
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = false;
            button_0.Click += button_0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(C);
            Name = "Form1";
            Text = "Form1";
            C.ResumeLayout(false);
            Main_page.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            Calculator.ResumeLayout(false);
            Calculator.PerformLayout();
            panel24.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxTransactions;
        private Button btnAuthenticate;
        private DateTimePicker datePicker;
        private Label label1;
        private TextBox txtDescription;
        private Label label2;
        private TextBox txtAmount;
        private Label label3;
        private ComboBox cboCategory;
        private Label label4;
        private ComboBox cboTransactionType;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cboCurrency;
        private ComboBox cboPaymentType;
        private Button BtnAddTransaction;
        private Button buttonEdit;
        private Button buttonDelete;
        private TabControl C;
        private TabPage Main_page;
        private TabPage Calculator;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button_2;
        private Button button_1;
        private Button button_0;
        private Button buttonDor;
        private Button buttonDi;
        private Button buttonM;
        private Button buttonV;
        private Button buttonD;
        private Button buttonDel;
        private Button buttonCE;
        private Button buttonC;
        private Button buttonK;
        private TextBox tb_show;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label8;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel9;
        private Label label9;
        private Panel panel24;
        private Panel panel25;
        private Panel panel22;
        private Panel panel23;
        private Panel panel20;
        private Panel panel21;
        private Panel panel18;
        private Panel panel19;
        private Panel panel16;
        private Panel panel17;
        private Panel panel14;
        private Panel panel15;
        private Panel panel12;
        private Panel panel13;
        private Panel panel10;
        private Panel panel11;
    }
}
