namespace Warsztat_2._0.UserControls.UC_CreateData
{
    partial class UC_AddOrderManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            WorkerListBox = new ListBox();
            label7 = new Label();
            panelDodatkowy = new Panel();
            WorkPerfomedTextBox = new TextBox();
            ButtonRepairSave = new Button();
            OrderAddoptedCheck = new CheckBox();
            panel1 = new Panel();
            OrderAddoptedTimePicker = new DateTimePicker();
            CarRealiseTimePicker = new DateTimePicker();
            label13 = new Label();
            realiseOrderCheck = new CheckBox();
            panel3 = new Panel();
            DateOfPay = new DateTimePicker();
            label2 = new Label();
            OtherDatePayCheck = new CheckBox();
            TodayPaycheck = new CheckBox();
            CardCheck = new CheckBox();
            CashCheck = new CheckBox();
            panel4 = new Panel();
            label15 = new Label();
            label16 = new Label();
            label10 = new Label();
            label4 = new Label();
            FinallPriceNumericUpDown = new NumericUpDown();
            EstimatedCostNumericUpDown = new NumericUpDown();
            label3 = new Label();
            ViewCar = new DataGridView();
            ID_Column = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewButtonColumn();
            Przyjęty_Column = new DataGridViewCheckBoxColumn();
            OczekujeNaOdbiór_Column = new DataGridViewCheckBoxColumn();
            DataPrzyjęcia_Column = new DataGridViewTextBoxColumn();
            DataWydania_Column = new DataGridViewTextBoxColumn();
            DataPayer_Column = new DataGridViewTextBoxColumn();
            TypPłatności_Column = new DataGridViewTextBoxColumn();
            KosztSzacunkowy_Column = new DataGridViewTextBoxColumn();
            KosztKońcowy_Column = new DataGridViewTextBoxColumn();
            ZMarżą_Column = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panelDodatkowy.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FinallPriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EstimatedCostNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewCar).BeginInit();
            SuspendLayout();
            // 
            // WorkerListBox
            // 
            WorkerListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WorkerListBox.FormattingEnabled = true;
            WorkerListBox.ItemHeight = 21;
            WorkerListBox.Items.AddRange(new object[] { "Yaroslav Mechatronik", "Yaroslav Mechanik", "Yaroslav Elektronik", "Yaroslav  Programista" });
            WorkerListBox.Location = new Point(3, 80);
            WorkerListBox.Name = "WorkerListBox";
            WorkerListBox.Size = new Size(228, 151);
            WorkerListBox.TabIndex = 7;
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
            // panelDodatkowy
            // 
            panelDodatkowy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelDodatkowy.BackColor = Color.FromArgb(64, 64, 70);
            panelDodatkowy.BorderStyle = BorderStyle.FixedSingle;
            panelDodatkowy.Controls.Add(label7);
            panelDodatkowy.Controls.Add(WorkerListBox);
            panelDodatkowy.Controls.Add(WorkPerfomedTextBox);
            panelDodatkowy.ForeColor = Color.DimGray;
            panelDodatkowy.Location = new Point(670, 37);
            panelDodatkowy.Name = "panelDodatkowy";
            panelDodatkowy.Size = new Size(304, 245);
            panelDodatkowy.TabIndex = 28;
            // 
            // WorkPerfomedTextBox
            // 
            WorkPerfomedTextBox.BackColor = Color.FromArgb(64, 64, 70);
            WorkPerfomedTextBox.CausesValidation = false;
            WorkPerfomedTextBox.Cursor = Cursors.IBeam;
            WorkPerfomedTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WorkPerfomedTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            WorkPerfomedTextBox.Location = new Point(3, 44);
            WorkPerfomedTextBox.Name = "WorkPerfomedTextBox";
            WorkPerfomedTextBox.PlaceholderText = "Wykonana czyność pracy";
            WorkPerfomedTextBox.Size = new Size(283, 30);
            WorkPerfomedTextBox.TabIndex = 13;
            // 
            // ButtonRepairSave
            // 
            ButtonRepairSave.BackColor = Color.FromArgb(94, 148, 255);
            ButtonRepairSave.FlatAppearance.BorderSize = 0;
            ButtonRepairSave.FlatStyle = FlatStyle.Flat;
            ButtonRepairSave.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRepairSave.ForeColor = Color.LightGray;
            ButtonRepairSave.Location = new Point(0, 0);
            ButtonRepairSave.Name = "ButtonRepairSave";
            ButtonRepairSave.Size = new Size(933, 30);
            ButtonRepairSave.TabIndex = 22;
            ButtonRepairSave.Text = "Zapisz";
            ButtonRepairSave.UseVisualStyleBackColor = false;
            // 
            // OrderAddoptedCheck
            // 
            OrderAddoptedCheck.AutoSize = true;
            OrderAddoptedCheck.Location = new Point(22, 44);
            OrderAddoptedCheck.Name = "OrderAddoptedCheck";
            OrderAddoptedCheck.Size = new Size(67, 19);
            OrderAddoptedCheck.TabIndex = 21;
            OrderAddoptedCheck.Text = "Przyjęty";
            OrderAddoptedCheck.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 70);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(OrderAddoptedTimePicker);
            panel1.Controls.Add(CarRealiseTimePicker);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(realiseOrderCheck);
            panel1.Controls.Add(OrderAddoptedCheck);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(0, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 192);
            panel1.TabIndex = 28;
            // 
            // OrderAddoptedTimePicker
            // 
            OrderAddoptedTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OrderAddoptedTimePicker.CalendarMonthBackground = Color.FromArgb(94, 148, 255);
            OrderAddoptedTimePicker.CalendarTitleBackColor = SystemColors.ControlText;
            OrderAddoptedTimePicker.CalendarTitleForeColor = Color.FromArgb(94, 148, 255);
            OrderAddoptedTimePicker.Cursor = Cursors.Hand;
            OrderAddoptedTimePicker.CustomFormat = "";
            OrderAddoptedTimePicker.Location = new Point(3, 93);
            OrderAddoptedTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            OrderAddoptedTimePicker.Name = "OrderAddoptedTimePicker";
            OrderAddoptedTimePicker.Size = new Size(239, 23);
            OrderAddoptedTimePicker.TabIndex = 39;
            OrderAddoptedTimePicker.Value = new DateTime(2024, 1, 16, 0, 0, 0, 0);
            // 
            // CarRealiseTimePicker
            // 
            CarRealiseTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CarRealiseTimePicker.CalendarMonthBackground = Color.FromArgb(94, 148, 255);
            CarRealiseTimePicker.CalendarTitleBackColor = SystemColors.ControlText;
            CarRealiseTimePicker.CalendarTitleForeColor = Color.FromArgb(94, 148, 255);
            CarRealiseTimePicker.Cursor = Cursors.Hand;
            CarRealiseTimePicker.CustomFormat = "";
            CarRealiseTimePicker.Location = new Point(3, 127);
            CarRealiseTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            CarRealiseTimePicker.Name = "CarRealiseTimePicker";
            CarRealiseTimePicker.Size = new Size(239, 23);
            CarRealiseTimePicker.TabIndex = 38;
            CarRealiseTimePicker.Value = new DateTime(2024, 1, 16, 0, 0, 0, 0);
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(140, 4);
            label13.Name = "label13";
            label13.Size = new Size(159, 28);
            label13.TabIndex = 0;
            label13.Text = "Status Zlecenia";
            // 
            // realiseOrderCheck
            // 
            realiseOrderCheck.AutoSize = true;
            realiseOrderCheck.Location = new Point(103, 44);
            realiseOrderCheck.Name = "realiseOrderCheck";
            realiseOrderCheck.Size = new Size(128, 19);
            realiseOrderCheck.TabIndex = 21;
            realiseOrderCheck.Text = "Oczekuje na odbiór";
            realiseOrderCheck.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(64, 64, 70);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(DateOfPay);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(OtherDatePayCheck);
            panel3.Controls.Add(TodayPaycheck);
            panel3.ForeColor = Color.DimGray;
            panel3.Location = new Point(338, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(304, 93);
            panel3.TabIndex = 28;
            // 
            // DateOfPay
            // 
            DateOfPay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateOfPay.CalendarMonthBackground = Color.FromArgb(94, 148, 255);
            DateOfPay.CalendarTitleBackColor = SystemColors.ControlText;
            DateOfPay.CalendarTitleForeColor = Color.FromArgb(94, 148, 255);
            DateOfPay.Cursor = Cursors.Hand;
            DateOfPay.CustomFormat = "";
            DateOfPay.Location = new Point(3, 57);
            DateOfPay.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DateOfPay.Name = "DateOfPay";
            DateOfPay.Size = new Size(239, 23);
            DateOfPay.TabIndex = 39;
            DateOfPay.Value = new DateTime(2024, 1, 16, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(140, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 0;
            label2.Text = "Data Płatności";
            // 
            // OtherDatePayCheck
            // 
            OtherDatePayCheck.AutoSize = true;
            OtherDatePayCheck.Location = new Point(68, 32);
            OtherDatePayCheck.Name = "OtherDatePayCheck";
            OtherDatePayCheck.Size = new Size(75, 19);
            OtherDatePayCheck.TabIndex = 21;
            OtherDatePayCheck.Text = "Inna data";
            OtherDatePayCheck.UseVisualStyleBackColor = true;
            // 
            // TodayPaycheck
            // 
            TodayPaycheck.AutoSize = true;
            TodayPaycheck.Location = new Point(3, 32);
            TodayPaycheck.Name = "TodayPaycheck";
            TodayPaycheck.Size = new Size(59, 19);
            TodayPaycheck.TabIndex = 21;
            TodayPaycheck.Text = "Dzisiaj";
            TodayPaycheck.UseVisualStyleBackColor = true;
            // 
            // CardCheck
            // 
            CardCheck.AutoSize = true;
            CardCheck.Location = new Point(22, 33);
            CardCheck.Name = "CardCheck";
            CardCheck.Size = new Size(53, 19);
            CardCheck.TabIndex = 21;
            CardCheck.Text = "Kartą";
            CardCheck.UseVisualStyleBackColor = true;
            // 
            // CashCheck
            // 
            CashCheck.AutoSize = true;
            CashCheck.Location = new Point(103, 33);
            CashCheck.Name = "CashCheck";
            CashCheck.Size = new Size(73, 19);
            CashCheck.TabIndex = 21;
            CashCheck.Text = "Gotówką";
            CashCheck.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(64, 64, 70);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(FinallPriceNumericUpDown);
            panel4.Controls.Add(EstimatedCostNumericUpDown);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(CashCheck);
            panel4.Controls.Add(CardCheck);
            panel4.ForeColor = Color.DimGray;
            panel4.Location = new Point(338, 135);
            panel4.Name = "panel4";
            panel4.Size = new Size(304, 147);
            panel4.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(224, 224, 224);
            label15.Location = new Point(3, 101);
            label15.Name = "label15";
            label15.Size = new Size(206, 21);
            label15.TabIndex = 27;
            label15.Text = "Cena za części wraz z Marżą:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(224, 224, 224);
            label16.Location = new Point(212, 101);
            label16.Name = "label16";
            label16.Size = new Size(19, 21);
            label16.TabIndex = 27;
            label16.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(224, 224, 224);
            label10.Location = new Point(160, 53);
            label10.Name = "label10";
            label10.Size = new Size(113, 21);
            label10.TabIndex = 27;
            label10.Text = "Koszt końcowy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(3, 53);
            label4.Name = "label4";
            label4.Size = new Size(137, 21);
            label4.TabIndex = 27;
            label4.Text = "Koszt Szacunkowy";
            // 
            // FinallPriceNumericUpDown
            // 
            FinallPriceNumericUpDown.BackColor = Color.White;
            FinallPriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            FinallPriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            FinallPriceNumericUpDown.Location = new Point(160, 74);
            FinallPriceNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            FinallPriceNumericUpDown.Name = "FinallPriceNumericUpDown";
            FinallPriceNumericUpDown.Size = new Size(70, 23);
            FinallPriceNumericUpDown.TabIndex = 26;
            // 
            // EstimatedCostNumericUpDown
            // 
            EstimatedCostNumericUpDown.BackColor = Color.White;
            EstimatedCostNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            EstimatedCostNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            EstimatedCostNumericUpDown.Location = new Point(3, 74);
            EstimatedCostNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            EstimatedCostNumericUpDown.Name = "EstimatedCostNumericUpDown";
            EstimatedCostNumericUpDown.Size = new Size(70, 23);
            EstimatedCostNumericUpDown.TabIndex = 26;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(103, 0);
            label3.Name = "label3";
            label3.Size = new Size(196, 28);
            label3.TabIndex = 0;
            label3.Text = "Sposób Płatności";
            // 
            // ViewCar
            // 
            ViewCar.AllowUserToAddRows = false;
            ViewCar.AllowUserToDeleteRows = false;
            ViewCar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewCar.BorderStyle = BorderStyle.None;
            ViewCar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewCar.Columns.AddRange(new DataGridViewColumn[] { ID_Column, Column7, Przyjęty_Column, OczekujeNaOdbiór_Column, DataPrzyjęcia_Column, DataWydania_Column, DataPayer_Column, TypPłatności_Column, KosztSzacunkowy_Column, KosztKońcowy_Column, ZMarżą_Column, Column5, Column6 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ViewCar.DefaultCellStyle = dataGridViewCellStyle3;
            ViewCar.EnableHeadersVisualStyles = false;
            ViewCar.Location = new Point(0, 288);
            ViewCar.Name = "ViewCar";
            ViewCar.RowTemplate.Height = 25;
            ViewCar.Size = new Size(1040, 292);
            ViewCar.TabIndex = 29;
            // 
            // ID_Column
            // 
            ID_Column.DataPropertyName = "ID";
            ID_Column.HeaderText = "ID";
            ID_Column.Name = "ID_Column";
            ID_Column.Visible = false;
            // 
            // Column7
            // 
            Column7.HeaderText = "Usuń";
            Column7.Name = "Column7";
            // 
            // Przyjęty_Column
            // 
            Przyjęty_Column.FalseValue = "0";
            Przyjęty_Column.HeaderText = "Przyjęty";
            Przyjęty_Column.Name = "Przyjęty_Column";
            Przyjęty_Column.Resizable = DataGridViewTriState.True;
            Przyjęty_Column.SortMode = DataGridViewColumnSortMode.Automatic;
            Przyjęty_Column.TrueValue = "1";
            // 
            // OczekujeNaOdbiór_Column
            // 
            OczekujeNaOdbiór_Column.DataPropertyName = "Model";
            OczekujeNaOdbiór_Column.FalseValue = "0";
            OczekujeNaOdbiór_Column.HeaderText = "Oczekuje na odbiór";
            OczekujeNaOdbiór_Column.Name = "OczekujeNaOdbiór_Column";
            OczekujeNaOdbiór_Column.Resizable = DataGridViewTriState.True;
            OczekujeNaOdbiór_Column.SortMode = DataGridViewColumnSortMode.Automatic;
            OczekujeNaOdbiór_Column.TrueValue = "1";
            // 
            // DataPrzyjęcia_Column
            // 
            DataPrzyjęcia_Column.DataPropertyName = "RokProdukcji";
            DataPrzyjęcia_Column.HeaderText = "Data 1";
            DataPrzyjęcia_Column.Name = "DataPrzyjęcia_Column";
            // 
            // DataWydania_Column
            // 
            DataWydania_Column.DataPropertyName = "VIN";
            dataGridViewCellStyle2.Format = "km";
            dataGridViewCellStyle2.NullValue = null;
            DataWydania_Column.DefaultCellStyle = dataGridViewCellStyle2;
            DataWydania_Column.HeaderText = "Data 2";
            DataWydania_Column.Name = "DataWydania_Column";
            // 
            // DataPayer_Column
            // 
            DataPayer_Column.HeaderText = "Data Płatności";
            DataPayer_Column.Name = "DataPayer_Column";
            // 
            // TypPłatności_Column
            // 
            TypPłatności_Column.HeaderText = "Metoda płatności";
            TypPłatności_Column.Name = "TypPłatności_Column";
            // 
            // KosztSzacunkowy_Column
            // 
            KosztSzacunkowy_Column.HeaderText = "koszt szacunkowy";
            KosztSzacunkowy_Column.Name = "KosztSzacunkowy_Column";
            // 
            // KosztKońcowy_Column
            // 
            KosztKońcowy_Column.HeaderText = "koszt końcowy";
            KosztKońcowy_Column.Name = "KosztKońcowy_Column";
            // 
            // ZMarżą_Column
            // 
            ZMarżą_Column.HeaderText = "Koszt z marżą";
            ZMarżą_Column.Name = "ZMarżą_Column";
            // 
            // Column5
            // 
            Column5.HeaderText = "Co bylo robione";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Pracownik który wykonał";
            Column6.Name = "Column6";
            // 
            // UC_AddOrderManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(ViewCar);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panelDodatkowy);
            Controls.Add(ButtonRepairSave);
            Name = "UC_AddOrderManagement";
            Size = new Size(1040, 580);
            panelDodatkowy.ResumeLayout(false);
            panelDodatkowy.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FinallPriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)EstimatedCostNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewCar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label7;
        private ListBox WorkerListBox;
        private Panel panelDodatkowy;
        private Button ButtonRepairSave;
        private TextBox WorkPerfomedTextBox;
        private CheckBox OrderAddoptedCheck;
        private Panel panel1;
        private Label label13;
        private CheckBox realiseOrderCheck;
        public DateTimePicker OrderAddoptedTimePicker;
        public DateTimePicker CarRealiseTimePicker;
        private Panel panel3;
        public DateTimePicker DateOfPay;
        private Label label2;
        private CheckBox OtherDatePayCheck;
        private CheckBox TodayPaycheck;
        private CheckBox CardCheck;
        private CheckBox CashCheck;
        private Panel panel4;
        private Label label3;
        private NumericUpDown EstimatedCostNumericUpDown;
        private Label label15;
        private Label label10;
        private Label label4;
        private NumericUpDown FinallPriceNumericUpDown;
        private Label label16;
        private DataGridView ViewCar;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewButtonColumn Column7;
        private DataGridViewCheckBoxColumn Przyjęty_Column;
        private DataGridViewCheckBoxColumn OczekujeNaOdbiór_Column;
        private DataGridViewTextBoxColumn DataPrzyjęcia_Column;
        private DataGridViewTextBoxColumn DataWydania_Column;
        private DataGridViewTextBoxColumn DataPayer_Column;
        private DataGridViewTextBoxColumn TypPłatności_Column;
        private DataGridViewTextBoxColumn KosztSzacunkowy_Column;
        private DataGridViewTextBoxColumn KosztKońcowy_Column;
        private DataGridViewTextBoxColumn ZMarżą_Column;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
