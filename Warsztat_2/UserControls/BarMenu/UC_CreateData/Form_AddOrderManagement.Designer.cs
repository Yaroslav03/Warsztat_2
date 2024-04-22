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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            CardCheck = new RadioButton();
            LabelTotalCostOfParts = new Label();
            LabelPriceWithMarża = new Label();
            WykonawcaPracy_Column = new DataGridViewTextBoxColumn();
            ViewOrderManagement = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            BtnDelete = new DataGridViewButtonColumn();
            Przyjęty_Column = new DataGridViewCheckBoxColumn();
            OczekujeNaOdbiór_Column = new DataGridViewCheckBoxColumn();
            DataPrzyjęcia_Column = new DataGridViewTextBoxColumn();
            DataWydania_Column = new DataGridViewTextBoxColumn();
            DataPayer_Column = new DataGridViewTextBoxColumn();
            TypPłatności_Column = new DataGridViewTextBoxColumn();
            KosztSzacunkowy_Column = new DataGridViewTextBoxColumn();
            KosztKońcowy_Column = new DataGridViewTextBoxColumn();
            ZMarżą_Column = new DataGridViewTextBoxColumn();
            TotalPriceOfPart_Column = new DataGridViewTextBoxColumn();
            WykonanaPraca_Column = new DataGridViewTextBoxColumn();
            VIN_Column = new DataGridViewTextBoxColumn();
            CashCheck = new RadioButton();
            label1 = new Label();
            label7 = new Label();
            WorkerListBox = new ListBox();
            panelDodatkowy = new Panel();
            WorkPerfomedTextBox = new TextBox();
            ButtonOrderManagementSave = new Button();
            OrderAddoptedCheck = new CheckBox();
            panel1 = new Panel();
            OrderAddoptedTimePicker = new DateTimePicker();
            CarRealiseTimePicker = new DateTimePicker();
            label13 = new Label();
            realiseOrderCheck = new CheckBox();
            Vin_Label = new Label();
            panel3 = new Panel();
            OtherDatePayCheck = new RadioButton();
            TodayPaycheck = new RadioButton();
            DateOfPay = new DateTimePicker();
            label2 = new Label();
            label10 = new Label();
            EstimatedCostNumericUpDown = new NumericUpDown();
            LabelPricePart = new Label();
            label4 = new Label();
            FinallPriceNumericUpDown = new NumericUpDown();
            label3 = new Label();
            panel4 = new Panel();
            CloseOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)ViewOrderManagement).BeginInit();
            panelDodatkowy.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EstimatedCostNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FinallPriceNumericUpDown).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // CardCheck
            // 
            CardCheck.AutoSize = true;
            CardCheck.Location = new Point(157, 25);
            CardCheck.Name = "CardCheck";
            CardCheck.Size = new Size(52, 19);
            CardCheck.TabIndex = 30;
            CardCheck.Text = "Kartą";
            CardCheck.UseVisualStyleBackColor = true;
            // 
            // LabelTotalCostOfParts
            // 
            LabelTotalCostOfParts.AutoSize = true;
            LabelTotalCostOfParts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTotalCostOfParts.ForeColor = Color.FromArgb(224, 224, 224);
            LabelTotalCostOfParts.Location = new Point(121, 47);
            LabelTotalCostOfParts.Name = "LabelTotalCostOfParts";
            LabelTotalCostOfParts.Size = new Size(19, 21);
            LabelTotalCostOfParts.TabIndex = 27;
            LabelTotalCostOfParts.Text = "0";
            // 
            // LabelPriceWithMarża
            // 
            LabelPriceWithMarża.AutoSize = true;
            LabelPriceWithMarża.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPriceWithMarża.ForeColor = Color.FromArgb(224, 224, 224);
            LabelPriceWithMarża.Location = new Point(182, 68);
            LabelPriceWithMarża.Name = "LabelPriceWithMarża";
            LabelPriceWithMarża.Size = new Size(19, 21);
            LabelPriceWithMarża.TabIndex = 27;
            LabelPriceWithMarża.Text = "0";
            // 
            // WykonawcaPracy_Column
            // 
            WykonawcaPracy_Column.DataPropertyName = "WykonawcaPracy";
            WykonawcaPracy_Column.HeaderText = "Pracownik który wykonał";
            WykonawcaPracy_Column.Name = "WykonawcaPracy_Column";
            // 
            // ViewOrderManagement
            // 
            ViewOrderManagement.AllowUserToAddRows = false;
            ViewOrderManagement.AllowUserToDeleteRows = false;
            ViewOrderManagement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewOrderManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewOrderManagement.BorderStyle = BorderStyle.None;
            ViewOrderManagement.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewOrderManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewOrderManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewOrderManagement.Columns.AddRange(new DataGridViewColumn[] { ID, BtnDelete, Przyjęty_Column, OczekujeNaOdbiór_Column, DataPrzyjęcia_Column, DataWydania_Column, DataPayer_Column, TypPłatności_Column, KosztSzacunkowy_Column, KosztKońcowy_Column, ZMarżą_Column, TotalPriceOfPart_Column, WykonanaPraca_Column, WykonawcaPracy_Column, VIN_Column });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ViewOrderManagement.DefaultCellStyle = dataGridViewCellStyle3;
            ViewOrderManagement.EnableHeadersVisualStyles = false;
            ViewOrderManagement.Location = new Point(12, 309);
            ViewOrderManagement.Name = "ViewOrderManagement";
            ViewOrderManagement.RowTemplate.Height = 25;
            ViewOrderManagement.Size = new Size(1012, 97);
            ViewOrderManagement.TabIndex = 35;
            ViewOrderManagement.MouseDoubleClick += ViewOrderManagement_MouseDoubleClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Usuń";
            BtnDelete.Name = "BtnDelete";
            // 
            // Przyjęty_Column
            // 
            Przyjęty_Column.DataPropertyName = "Przyjęty";
            Przyjęty_Column.FalseValue = "0";
            Przyjęty_Column.HeaderText = "Przyjęty";
            Przyjęty_Column.Name = "Przyjęty_Column";
            Przyjęty_Column.Resizable = DataGridViewTriState.True;
            Przyjęty_Column.SortMode = DataGridViewColumnSortMode.Automatic;
            Przyjęty_Column.TrueValue = "1";
            // 
            // OczekujeNaOdbiór_Column
            // 
            OczekujeNaOdbiór_Column.DataPropertyName = "OczekujeNaOdbiór";
            OczekujeNaOdbiór_Column.FalseValue = "0";
            OczekujeNaOdbiór_Column.HeaderText = "Oczekuje na odbiór";
            OczekujeNaOdbiór_Column.Name = "OczekujeNaOdbiór_Column";
            OczekujeNaOdbiór_Column.Resizable = DataGridViewTriState.True;
            OczekujeNaOdbiór_Column.SortMode = DataGridViewColumnSortMode.Automatic;
            OczekujeNaOdbiór_Column.TrueValue = "1";
            // 
            // DataPrzyjęcia_Column
            // 
            DataPrzyjęcia_Column.DataPropertyName = "DataPrzyjęcie";
            DataPrzyjęcia_Column.HeaderText = "Data 1";
            DataPrzyjęcia_Column.Name = "DataPrzyjęcia_Column";
            // 
            // DataWydania_Column
            // 
            DataWydania_Column.DataPropertyName = "DataOczekiwaniaOdbioru";
            dataGridViewCellStyle2.Format = "km";
            dataGridViewCellStyle2.NullValue = null;
            DataWydania_Column.DefaultCellStyle = dataGridViewCellStyle2;
            DataWydania_Column.HeaderText = "Data 2";
            DataWydania_Column.Name = "DataWydania_Column";
            DataWydania_Column.Visible = false;
            // 
            // DataPayer_Column
            // 
            DataPayer_Column.DataPropertyName = "DataPłatności";
            DataPayer_Column.HeaderText = "Data Płatności";
            DataPayer_Column.Name = "DataPayer_Column";
            DataPayer_Column.Visible = false;
            // 
            // TypPłatności_Column
            // 
            TypPłatności_Column.DataPropertyName = "MetodaPłatności";
            TypPłatności_Column.HeaderText = "Metoda płatności";
            TypPłatności_Column.Name = "TypPłatności_Column";
            TypPłatności_Column.Visible = false;
            // 
            // KosztSzacunkowy_Column
            // 
            KosztSzacunkowy_Column.DataPropertyName = "KosztSzacunkowy";
            KosztSzacunkowy_Column.HeaderText = "koszt szacunkowy";
            KosztSzacunkowy_Column.Name = "KosztSzacunkowy_Column";
            // 
            // KosztKońcowy_Column
            // 
            KosztKońcowy_Column.DataPropertyName = "KosztKońcowy";
            KosztKońcowy_Column.HeaderText = "koszt końcowy";
            KosztKońcowy_Column.Name = "KosztKońcowy_Column";
            // 
            // ZMarżą_Column
            // 
            ZMarżą_Column.DataPropertyName = "KosztZMarżą";
            ZMarżą_Column.HeaderText = "Koszt z marżą";
            ZMarżą_Column.Name = "ZMarżą_Column";
            // 
            // TotalPriceOfPart_Column
            // 
            TotalPriceOfPart_Column.DataPropertyName = "KosztCałkowityCzęści";
            TotalPriceOfPart_Column.HeaderText = "Koszt Całkowity Części";
            TotalPriceOfPart_Column.Name = "TotalPriceOfPart_Column";
            TotalPriceOfPart_Column.Visible = false;
            // 
            // WykonanaPraca_Column
            // 
            WykonanaPraca_Column.DataPropertyName = "WykonanaPraca";
            WykonanaPraca_Column.HeaderText = "Co bylo robione";
            WykonanaPraca_Column.Name = "WykonanaPraca_Column";
            // 
            // VIN_Column
            // 
            VIN_Column.DataPropertyName = "VIN";
            VIN_Column.HeaderText = "VIN";
            VIN_Column.Name = "VIN_Column";
            VIN_Column.Visible = false;
            // 
            // CashCheck
            // 
            CashCheck.AutoSize = true;
            CashCheck.Checked = true;
            CashCheck.Location = new Point(21, 25);
            CashCheck.Name = "CashCheck";
            CashCheck.Size = new Size(72, 19);
            CashCheck.TabIndex = 30;
            CashCheck.TabStop = true;
            CashCheck.Text = "Gotówką";
            CashCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(3, 68);
            label1.Name = "label1";
            label1.Size = new Size(174, 21);
            label1.TabIndex = 27;
            label1.Text = "Koszt końcowy z Marżą:";
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
            WorkerListBox.Location = new Point(3, 87);
            WorkerListBox.Name = "WorkerListBox";
            WorkerListBox.Size = new Size(283, 151);
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
            panelDodatkowy.Size = new Size(304, 245);
            panelDodatkowy.TabIndex = 31;
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
            // OrderAddoptedCheck
            // 
            OrderAddoptedCheck.AutoSize = true;
            OrderAddoptedCheck.Location = new Point(23, 73);
            OrderAddoptedCheck.Name = "OrderAddoptedCheck";
            OrderAddoptedCheck.Size = new Size(67, 19);
            OrderAddoptedCheck.TabIndex = 21;
            OrderAddoptedCheck.Text = "Przyjęty";
            OrderAddoptedCheck.UseVisualStyleBackColor = true;
            OrderAddoptedCheck.CheckedChanged += OrderAddoptedCheck_CheckedChanged;
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
            panel1.Controls.Add(Vin_Label);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(12, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 245);
            panel1.TabIndex = 32;
            // 
            // OrderAddoptedTimePicker
            // 
            OrderAddoptedTimePicker.Location = new Point(23, 176);
            OrderAddoptedTimePicker.Name = "OrderAddoptedTimePicker";
            OrderAddoptedTimePicker.Size = new Size(269, 23);
            OrderAddoptedTimePicker.TabIndex = 23;
            // 
            // CarRealiseTimePicker
            // 
            CarRealiseTimePicker.Location = new Point(23, 98);
            CarRealiseTimePicker.Name = "CarRealiseTimePicker";
            CarRealiseTimePicker.Size = new Size(269, 23);
            CarRealiseTimePicker.TabIndex = 23;
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
            realiseOrderCheck.Location = new Point(23, 151);
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
            Vin_Label.Location = new Point(23, 30);
            Vin_Label.Name = "Vin_Label";
            Vin_Label.Size = new Size(196, 28);
            Vin_Label.TabIndex = 0;
            Vin_Label.TextChanged += Vin_Label_TextChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(64, 64, 70);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(OtherDatePayCheck);
            panel3.Controls.Add(TodayPaycheck);
            panel3.Controls.Add(DateOfPay);
            panel3.Controls.Add(label2);
            panel3.ForeColor = Color.DimGray;
            panel3.Location = new Point(414, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 93);
            panel3.TabIndex = 33;
            // 
            // OtherDatePayCheck
            // 
            OtherDatePayCheck.AutoSize = true;
            OtherDatePayCheck.Location = new Point(168, 30);
            OtherDatePayCheck.Name = "OtherDatePayCheck";
            OtherDatePayCheck.Size = new Size(74, 19);
            OtherDatePayCheck.TabIndex = 40;
            OtherDatePayCheck.TabStop = true;
            OtherDatePayCheck.Text = "Inna data";
            OtherDatePayCheck.UseVisualStyleBackColor = true;
            OtherDatePayCheck.CheckedChanged += OtherDatePayCheck_CheckedChanged;
            // 
            // TodayPaycheck
            // 
            TodayPaycheck.AutoSize = true;
            TodayPaycheck.Location = new Point(3, 30);
            TodayPaycheck.Name = "TodayPaycheck";
            TodayPaycheck.Size = new Size(58, 19);
            TodayPaycheck.TabIndex = 40;
            TodayPaycheck.TabStop = true;
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
            DateOfPay.Location = new Point(3, 57);
            DateOfPay.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DateOfPay.Name = "DateOfPay";
            DateOfPay.Size = new Size(258, 23);
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(224, 224, 224);
            label10.Location = new Point(182, 90);
            label10.Name = "label10";
            label10.Size = new Size(113, 21);
            label10.TabIndex = 27;
            label10.Text = "Koszt końcowy";
            // 
            // EstimatedCostNumericUpDown
            // 
            EstimatedCostNumericUpDown.BackColor = Color.White;
            EstimatedCostNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            EstimatedCostNumericUpDown.DecimalPlaces = 2;
            EstimatedCostNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            EstimatedCostNumericUpDown.Location = new Point(3, 117);
            EstimatedCostNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            EstimatedCostNumericUpDown.Name = "EstimatedCostNumericUpDown";
            EstimatedCostNumericUpDown.Size = new Size(70, 23);
            EstimatedCostNumericUpDown.TabIndex = 26;
            // 
            // LabelPricePart
            // 
            LabelPricePart.AutoSize = true;
            LabelPricePart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPricePart.ForeColor = Color.FromArgb(224, 224, 224);
            LabelPricePart.Location = new Point(3, 47);
            LabelPricePart.Name = "LabelPricePart";
            LabelPricePart.Size = new Size(113, 21);
            LabelPricePart.TabIndex = 27;
            LabelPricePart.Text = "Koszt za części:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(3, 90);
            label4.Name = "label4";
            label4.Size = new Size(137, 21);
            label4.TabIndex = 27;
            label4.Text = "Koszt Szacunkowy";
            // 
            // FinallPriceNumericUpDown
            // 
            FinallPriceNumericUpDown.BackColor = Color.White;
            FinallPriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            FinallPriceNumericUpDown.DecimalPlaces = 2;
            FinallPriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            FinallPriceNumericUpDown.Location = new Point(182, 117);
            FinallPriceNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            FinallPriceNumericUpDown.Name = "FinallPriceNumericUpDown";
            FinallPriceNumericUpDown.Size = new Size(70, 23);
            FinallPriceNumericUpDown.TabIndex = 26;
            FinallPriceNumericUpDown.ValueChanged += FinallPriceNumericUpDown_ValueChanged;
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
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(64, 64, 70);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(CashCheck);
            panel4.Controls.Add(CardCheck);
            panel4.Controls.Add(LabelTotalCostOfParts);
            panel4.Controls.Add(LabelPriceWithMarża);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(EstimatedCostNumericUpDown);
            panel4.Controls.Add(LabelPricePart);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(FinallPriceNumericUpDown);
            panel4.Controls.Add(label3);
            panel4.ForeColor = Color.DimGray;
            panel4.Location = new Point(414, 147);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 147);
            panel4.TabIndex = 34;
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
            // Form_AddOrderManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1036, 418);
            Controls.Add(CloseOrder);
            Controls.Add(ViewOrderManagement);
            Controls.Add(panelDodatkowy);
            Controls.Add(ButtonOrderManagementSave);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "Form_AddOrderManagement";
            Text = "Form_AddOrderManagement";
            Load += UC_AddOrderManagement_Load;
            ((System.ComponentModel.ISupportInitialize)ViewOrderManagement).EndInit();
            panelDodatkowy.ResumeLayout(false);
            panelDodatkowy.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EstimatedCostNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)FinallPriceNumericUpDown).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton CardCheck;
        private Label LabelTotalCostOfParts;
        private Label LabelPriceWithMarża;
        private DataGridViewTextBoxColumn WykonawcaPracy_Column;
        private DataGridView ViewOrderManagement;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewCheckBoxColumn Przyjęty_Column;
        private DataGridViewCheckBoxColumn OczekujeNaOdbiór_Column;
        private DataGridViewTextBoxColumn DataPrzyjęcia_Column;
        private DataGridViewTextBoxColumn DataWydania_Column;
        private DataGridViewTextBoxColumn DataPayer_Column;
        private DataGridViewTextBoxColumn TypPłatności_Column;
        private DataGridViewTextBoxColumn KosztSzacunkowy_Column;
        private DataGridViewTextBoxColumn KosztKońcowy_Column;
        private DataGridViewTextBoxColumn ZMarżą_Column;
        private DataGridViewTextBoxColumn TotalPriceOfPart_Column;
        private DataGridViewTextBoxColumn WykonanaPraca_Column;
        private DataGridViewTextBoxColumn VIN_Column;
        private RadioButton CashCheck;
        private Label label1;
        private Label label7;
        private ListBox WorkerListBox;
        private Panel panelDodatkowy;
        private TextBox WorkPerfomedTextBox;
        private Button ButtonOrderManagementSave;
        private CheckBox OrderAddoptedCheck;
        private Panel panel1;
        private DateTimePicker OrderAddoptedTimePicker;
        private DateTimePicker CarRealiseTimePicker;
        private Label label13;
        private CheckBox realiseOrderCheck;
        private Label Vin_Label;
        private Panel panel3;
        private RadioButton OtherDatePayCheck;
        private RadioButton TodayPaycheck;
        public DateTimePicker DateOfPay;
        private Label label2;
        private Label label10;
        private NumericUpDown EstimatedCostNumericUpDown;
        private Label LabelPricePart;
        private Label label4;
        public NumericUpDown FinallPriceNumericUpDown;
        private Label label3;
        private Panel panel4;
        private Button CloseOrder;
    }
}