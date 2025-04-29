namespace Warsztat_2.UserControls.BarMenu.UC_CreateData
{
    partial class Form_AddOrderManagement
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
            LabelFinallyPrice = new Label();
            label7 = new Label();
            WorkerListBox = new ListBox();
            panelDodatkowy = new Panel();
            WorkPerfomedTextBox = new TextBox();
            ButtonOrderManagementSave = new Button();
            panel1 = new Panel();
            OrderAddoptedTimePicker = new DateTimePicker();
            label13 = new Label();
            realiseOrderCheck = new CheckBox();
            Vin_Label = new Label();
            panel3 = new Panel();
            NeitherRadioButton = new RadioButton();
            OtherDatePayCheck = new RadioButton();
            TodayPaycheck = new RadioButton();
            DateOfPay = new DateTimePicker();
            label2 = new Label();
            label10 = new Label();
            LabelPricePartWithMarzha = new Label();
            FinallPriceNumericUpDown = new NumericUpDown();
            label3 = new Label();
            panel4 = new Panel();
            label1 = new Label();
            marzhaNumericUpDown = new NumericUpDown();
            labelPriceofPart = new Label();
            labelPriceofService = new Label();
            CloseOrder = new Button();
            panel2 = new Panel();
            CashRadioButton = new RadioButton();
            radioButton2 = new RadioButton();
            label5 = new Label();
            label8 = new Label();
            PaidnumericUpDown = new NumericUpDown();
            panelDodatkowy.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FinallPriceNumericUpDown).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)marzhaNumericUpDown).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaidnumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // LabelFinallyPrice
            // 
            LabelFinallyPrice.AutoSize = true;
            LabelFinallyPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelFinallyPrice.ForeColor = Color.FromArgb(224, 224, 224);
            LabelFinallyPrice.Location = new Point(175, 124);
            LabelFinallyPrice.Name = "LabelFinallyPrice";
            LabelFinallyPrice.Size = new Size(116, 21);
            LabelFinallyPrice.TabIndex = 27;
            LabelFinallyPrice.Text = "Koszt końcowy:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(185, 4);
            label7.Name = "label7";
            label7.Size = new Size(114, 28);
            label7.TabIndex = 0;
            label7.Text = "Pracownicy";
            // 
            // WorkerListBox
            // 
            WorkerListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WorkerListBox.FormattingEnabled = true;
            WorkerListBox.ItemHeight = 21;
            WorkerListBox.Location = new Point(3, 108);
            WorkerListBox.Name = "WorkerListBox";
            WorkerListBox.Size = new Size(283, 130);
            WorkerListBox.TabIndex = 7;
            // 
            // panelDodatkowy
            // 
            panelDodatkowy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelDodatkowy.BackColor = Color.FromArgb(64, 64, 70);
            panelDodatkowy.BorderStyle = BorderStyle.FixedSingle;
            panelDodatkowy.Controls.Add(label7);
            panelDodatkowy.Controls.Add(WorkerListBox);
            panelDodatkowy.Controls.Add(WorkPerfomedTextBox);
            panelDodatkowy.ForeColor = Color.DimGray;
            panelDodatkowy.Location = new Point(720, 49);
            panelDodatkowy.Name = "panelDodatkowy";
            panelDodatkowy.Size = new Size(304, 258);
            panelDodatkowy.TabIndex = 31;
            // 
            // WorkPerfomedTextBox
            // 
            WorkPerfomedTextBox.BackColor = Color.FromArgb(64, 64, 70);
            WorkPerfomedTextBox.CausesValidation = false;
            WorkPerfomedTextBox.Cursor = Cursors.IBeam;
            WorkPerfomedTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WorkPerfomedTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            WorkPerfomedTextBox.Location = new Point(3, 66);
            WorkPerfomedTextBox.Name = "WorkPerfomedTextBox";
            WorkPerfomedTextBox.PlaceholderText = "Wykonana czyność pracy";
            WorkPerfomedTextBox.Size = new Size(283, 30);
            WorkPerfomedTextBox.TabIndex = 13;
            // 
            // ButtonOrderManagementSave
            // 
            ButtonOrderManagementSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonOrderManagementSave.BackColor = Color.FromArgb(94, 148, 255);
            ButtonOrderManagementSave.FlatAppearance.BorderSize = 0;
            ButtonOrderManagementSave.FlatStyle = FlatStyle.Flat;
            ButtonOrderManagementSave.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonOrderManagementSave.ForeColor = Color.LightGray;
            ButtonOrderManagementSave.Location = new Point(12, 12);
            ButtonOrderManagementSave.Name = "ButtonOrderManagementSave";
            ButtonOrderManagementSave.Size = new Size(496, 30);
            ButtonOrderManagementSave.TabIndex = 30;
            ButtonOrderManagementSave.Text = "Zapisz";
            ButtonOrderManagementSave.UseVisualStyleBackColor = false;
            ButtonOrderManagementSave.Click += ButtonOrderManagementSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 70);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(OrderAddoptedTimePicker);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(realiseOrderCheck);
            panel1.Controls.Add(Vin_Label);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(318, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 106);
            panel1.TabIndex = 32;
            // 
            // OrderAddoptedTimePicker
            // 
            OrderAddoptedTimePicker.Location = new Point(3, 74);
            OrderAddoptedTimePicker.Name = "OrderAddoptedTimePicker";
            OrderAddoptedTimePicker.Size = new Size(288, 23);
            OrderAddoptedTimePicker.TabIndex = 23;
            OrderAddoptedTimePicker.ValueChanged += OrderAddoptedTimePicker_ValueChanged;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(153, 28);
            label13.TabIndex = 0;
            label13.Text = "Status Zlecenia";
            // 
            // realiseOrderCheck
            // 
            realiseOrderCheck.AutoSize = true;
            realiseOrderCheck.Location = new Point(3, 49);
            realiseOrderCheck.Name = "realiseOrderCheck";
            realiseOrderCheck.Size = new Size(128, 19);
            realiseOrderCheck.TabIndex = 21;
            realiseOrderCheck.Text = "Oczekuje na odbiór";
            realiseOrderCheck.UseVisualStyleBackColor = true;
            realiseOrderCheck.CheckedChanged += RealiseOrderCheck_CheckedChanged;
            // 
            // Vin_Label
            // 
            Vin_Label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Vin_Label.Location = new Point(195, 5);
            Vin_Label.Name = "Vin_Label";
            Vin_Label.Size = new Size(196, 28);
            Vin_Label.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 70);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(NeitherRadioButton);
            panel3.Controls.Add(OtherDatePayCheck);
            panel3.Controls.Add(TodayPaycheck);
            panel3.Controls.Add(DateOfPay);
            panel3.Controls.Add(label2);
            panel3.ForeColor = Color.DimGray;
            panel3.Location = new Point(12, 160);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 147);
            panel3.TabIndex = 33;
            // 
            // NeitherRadioButton
            // 
            NeitherRadioButton.AutoSize = true;
            NeitherRadioButton.Checked = true;
            NeitherRadioButton.Location = new Point(3, 29);
            NeitherRadioButton.Name = "NeitherRadioButton";
            NeitherRadioButton.Size = new Size(48, 19);
            NeitherRadioButton.TabIndex = 41;
            NeitherRadioButton.TabStop = true;
            NeitherRadioButton.Text = "Brak";
            NeitherRadioButton.UseVisualStyleBackColor = true;
            NeitherRadioButton.CheckedChanged += NeitherRadioButton_CheckedChanged;
            // 
            // OtherDatePayCheck
            // 
            OtherDatePayCheck.AutoSize = true;
            OtherDatePayCheck.Location = new Point(3, 79);
            OtherDatePayCheck.Name = "OtherDatePayCheck";
            OtherDatePayCheck.Size = new Size(74, 19);
            OtherDatePayCheck.TabIndex = 40;
            OtherDatePayCheck.Text = "Inna data";
            OtherDatePayCheck.UseVisualStyleBackColor = true;
            OtherDatePayCheck.CheckedChanged += OtherDatePayCheck_CheckedChanged;
            // 
            // TodayPaycheck
            // 
            TodayPaycheck.AutoSize = true;
            TodayPaycheck.Location = new Point(3, 54);
            TodayPaycheck.Name = "TodayPaycheck";
            TodayPaycheck.Size = new Size(58, 19);
            TodayPaycheck.TabIndex = 40;
            TodayPaycheck.Text = "Dzisiaj";
            TodayPaycheck.UseVisualStyleBackColor = true;
            TodayPaycheck.CheckedChanged += TodayPaycheck_CheckedChanged;
            // 
            // DateOfPay
            // 
            DateOfPay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DateOfPay.CalendarMonthBackground = Color.FromArgb(94, 148, 255);
            DateOfPay.CalendarTitleBackColor = SystemColors.ControlText;
            DateOfPay.CalendarTitleForeColor = Color.FromArgb(94, 148, 255);
            DateOfPay.Cursor = Cursors.Hand;
            DateOfPay.CustomFormat = "";
            DateOfPay.Location = new Point(74, 117);
            DateOfPay.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DateOfPay.Name = "DateOfPay";
            DateOfPay.Size = new Size(221, 23);
            DateOfPay.TabIndex = 39;
            DateOfPay.Value = new DateTime(2024, 1, 16, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 2);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 0;
            label2.Text = "Data Płatności";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(224, 224, 224);
            label10.Location = new Point(3, 34);
            label10.Name = "label10";
            label10.Size = new Size(142, 21);
            label10.TabIndex = 27;
            label10.Text = "Koszt ręcznej pracy";
            // 
            // LabelPricePartWithMarzha
            // 
            LabelPricePartWithMarzha.AutoSize = true;
            LabelPricePartWithMarzha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPricePartWithMarzha.ForeColor = Color.FromArgb(224, 224, 224);
            LabelPricePartWithMarzha.Location = new Point(3, 76);
            LabelPricePartWithMarzha.Name = "LabelPricePartWithMarzha";
            LabelPricePartWithMarzha.Size = new Size(171, 21);
            LabelPricePartWithMarzha.TabIndex = 27;
            LabelPricePartWithMarzha.Text = "Koszt za części z marzą:";
            // 
            // FinallPriceNumericUpDown
            // 
            FinallPriceNumericUpDown.BackColor = Color.White;
            FinallPriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            FinallPriceNumericUpDown.DecimalPlaces = 2;
            FinallPriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            FinallPriceNumericUpDown.Location = new Point(151, 32);
            FinallPriceNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            FinallPriceNumericUpDown.Name = "FinallPriceNumericUpDown";
            FinallPriceNumericUpDown.Size = new Size(70, 23);
            FinallPriceNumericUpDown.TabIndex = 26;
            FinallPriceNumericUpDown.ValueChanged += FinallPriceNumericUpDown_ValueChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 2);
            label3.Name = "label3";
            label3.Size = new Size(196, 28);
            label3.TabIndex = 0;
            label3.Text = "Wycena kosztów";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(64, 64, 70);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(marzhaNumericUpDown);
            panel4.Controls.Add(LabelFinallyPrice);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(labelPriceofPart);
            panel4.Controls.Add(labelPriceofService);
            panel4.Controls.Add(LabelPricePartWithMarzha);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(FinallPriceNumericUpDown);
            panel4.ForeColor = Color.DimGray;
            panel4.Location = new Point(318, 160);
            panel4.Name = "panel4";
            panel4.Size = new Size(396, 147);
            panel4.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 29;
            label1.Text = "Marża";
            // 
            // marzhaNumericUpDown
            // 
            marzhaNumericUpDown.BackColor = Color.White;
            marzhaNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            marzhaNumericUpDown.DecimalPlaces = 2;
            marzhaNumericUpDown.Location = new Point(291, 32);
            marzhaNumericUpDown.Name = "marzhaNumericUpDown";
            marzhaNumericUpDown.Size = new Size(70, 23);
            marzhaNumericUpDown.TabIndex = 28;
            marzhaNumericUpDown.ValueChanged += marzhaNumericUpDown_ValueChanged;
            // 
            // labelPriceofPart
            // 
            labelPriceofPart.AutoSize = true;
            labelPriceofPart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPriceofPart.ForeColor = Color.FromArgb(224, 224, 224);
            labelPriceofPart.Location = new Point(3, 55);
            labelPriceofPart.Name = "labelPriceofPart";
            labelPriceofPart.Size = new Size(113, 21);
            labelPriceofPart.TabIndex = 27;
            labelPriceofPart.Text = "Koszt za części:";
            // 
            // labelPriceofService
            // 
            labelPriceofService.AutoSize = true;
            labelPriceofService.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPriceofService.ForeColor = Color.FromArgb(224, 224, 224);
            labelPriceofService.Location = new Point(3, 97);
            labelPriceofService.Name = "labelPriceofService";
            labelPriceofService.Size = new Size(115, 21);
            labelPriceofService.TabIndex = 27;
            labelPriceofService.Text = "Koszt za usługi:";
            // 
            // CloseOrder
            // 
            CloseOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CloseOrder.BackColor = Color.FromArgb(94, 148, 255);
            CloseOrder.FlatAppearance.BorderSize = 0;
            CloseOrder.FlatStyle = FlatStyle.Flat;
            CloseOrder.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CloseOrder.ForeColor = Color.LightGray;
            CloseOrder.Location = new Point(518, 12);
            CloseOrder.Name = "CloseOrder";
            CloseOrder.Size = new Size(506, 30);
            CloseOrder.TabIndex = 36;
            CloseOrder.Text = "Zamknij Zlecenie";
            CloseOrder.UseVisualStyleBackColor = false;
            CloseOrder.Click += CloseOrder_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 70);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(CashRadioButton);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(PaidnumericUpDown);
            panel2.ForeColor = Color.DimGray;
            panel2.Location = new Point(12, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 106);
            panel2.TabIndex = 35;
            // 
            // CashRadioButton
            // 
            CashRadioButton.AutoSize = true;
            CashRadioButton.Checked = true;
            CashRadioButton.Location = new Point(21, 25);
            CashRadioButton.Name = "CashRadioButton";
            CashRadioButton.Size = new Size(72, 19);
            CashRadioButton.TabIndex = 30;
            CashRadioButton.TabStop = true;
            CashRadioButton.Text = "Gotówką";
            CashRadioButton.UseVisualStyleBackColor = true;
            CashRadioButton.CheckedChanged += RadioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(103, 25);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(52, 19);
            radioButton2.TabIndex = 30;
            radioButton2.Text = "Kartą";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += RadioButton2_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(103, 78);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 27;
            label5.Text = "Zapłacono";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(103, 0);
            label8.Name = "label8";
            label8.Size = new Size(196, 28);
            label8.TabIndex = 0;
            label8.Text = "Sposób Płatności";
            // 
            // PaidnumericUpDown
            // 
            PaidnumericUpDown.BackColor = Color.White;
            PaidnumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PaidnumericUpDown.DecimalPlaces = 2;
            PaidnumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            PaidnumericUpDown.Location = new Point(21, 78);
            PaidnumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            PaidnumericUpDown.Name = "PaidnumericUpDown";
            PaidnumericUpDown.Size = new Size(70, 23);
            PaidnumericUpDown.TabIndex = 26;
            // 
            // Form_AddOrderManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1036, 313);
            Controls.Add(panel2);
            Controls.Add(CloseOrder);
            Controls.Add(panelDodatkowy);
            Controls.Add(ButtonOrderManagementSave);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            MaximumSize = new Size(1052, 352);
            MinimumSize = new Size(1052, 352);
            Name = "Form_AddOrderManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_AddOrderManagement";
            Load += UC_AddOrderManagement_Load;
            panelDodatkowy.ResumeLayout(false);
            panelDodatkowy.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FinallPriceNumericUpDown).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)marzhaNumericUpDown).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PaidnumericUpDown).EndInit();
            ResumeLayout(false);
            }

        #endregion
        private Label LabelFinallyPrice;
        private Label label7;
        private ListBox WorkerListBox;
        private Panel panelDodatkowy;
        private TextBox WorkPerfomedTextBox;
        private Button ButtonOrderManagementSave;
        private Panel panel1;
        private DateTimePicker OrderAddoptedTimePicker;
        private Label label13;
        private CheckBox realiseOrderCheck;
        private Label Vin_Label;
        private Panel panel3;
        private RadioButton OtherDatePayCheck;
        private RadioButton TodayPaycheck;
        public DateTimePicker DateOfPay;
        private Label label2;
        private Label label10;
        private Label LabelPricePartWithMarzha;
        public NumericUpDown FinallPriceNumericUpDown;
        private Label label3;
        private Panel panel4;
        private Button CloseOrder;
        private Panel panel2;
        private RadioButton CashRadioButton;
        private RadioButton radioButton2;
        private Label label5;
        private Label label8;
        public NumericUpDown PaidnumericUpDown;
        private Label labelPriceofPart;
        private RadioButton NeitherRadioButton;
        private Label label1;
        public NumericUpDown marzhaNumericUpDown;
        private Label labelPriceofService;
        }
}