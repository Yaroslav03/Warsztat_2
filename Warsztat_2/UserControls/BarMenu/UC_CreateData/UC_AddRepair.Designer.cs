namespace Warsztat_2._0.UserControls.UC_CreateData
{
    partial class UC_AddRepair
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            IloscNumericUpDown = new NumericUpDown();
            PriceNumericUpDown = new NumericUpDown();
            StanCheckBox = new CheckBox();
            label4 = new Label();
            label2 = new Label();
            ButtonRepairSave = new Button();
            ViewRepair = new DataGridView();
            BtnDelete = new DataGridViewButtonColumn();
            ID = new DataGridViewTextBoxColumn();
            Wykonane_Checked = new DataGridViewCheckBoxColumn();
            Type_Column = new DataGridViewTextBoxColumn();
            Nazwa_Column_ = new DataGridViewTextBoxColumn();
            Opis_Column = new DataGridViewTextBoxColumn();
            NrCzęści_Column = new DataGridViewTextBoxColumn();
            Cena_Column = new DataGridViewTextBoxColumn();
            Ilość_Column = new DataGridViewTextBoxColumn();
            Suma_Column = new DataGridViewTextBoxColumn();
            DateRepair = new DataGridViewTextBoxColumn();
            VIN_label = new Label();
            ViewCar = new DataGridView();
            ID_Column = new DataGridViewTextBoxColumn();
            Marka_Column = new DataGridViewTextBoxColumn();
            Model_Column = new DataGridViewTextBoxColumn();
            RokProdukcji_Column = new DataGridViewTextBoxColumn();
            VIN_Column = new DataGridViewTextBoxColumn();
            panelDodatkowy = new Panel();
            RepairTimePicker = new DateTimePicker();
            ButtonOrderManagement = new Button();
            SumLabel = new Label();
            label5 = new Label();
            label3 = new Label();
            NazwaTextBox = new TextBox();
            NrPartTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            WarehouseView = new DataGridView();
            BtnDelete_Warehouse = new DataGridViewButtonColumn();
            SelectButton = new DataGridViewButtonColumn();
            ID_Column_ = new DataGridViewTextBoxColumn();
            TypCzesci_Column = new DataGridViewTextBoxColumn();
            Opis_Column_ = new DataGridViewTextBoxColumn();
            Nazwa_Column = new DataGridViewTextBoxColumn();
            NumerCzesci_Column = new DataGridViewTextBoxColumn();
            Price_Column = new DataGridViewTextBoxColumn();
            Quantity_Column = new DataGridViewTextBoxColumn();
            Sum_Column = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)IloscNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewRepair).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewCar).BeginInit();
            panelDodatkowy.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WarehouseView).BeginInit();
            SuspendLayout();
            // 
            // IloscNumericUpDown
            // 
            IloscNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IloscNumericUpDown.BackColor = Color.White;
            IloscNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            IloscNumericUpDown.Location = new Point(838, 211);
            IloscNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            IloscNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            IloscNumericUpDown.Name = "IloscNumericUpDown";
            IloscNumericUpDown.Size = new Size(84, 23);
            IloscNumericUpDown.TabIndex = 3;
            IloscNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            IloscNumericUpDown.ValueChanged += IloscNumericUpDown_ValueChanged;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriceNumericUpDown.BackColor = Color.White;
            PriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PriceNumericUpDown.DecimalPlaces = 2;
            PriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            PriceNumericUpDown.Location = new Point(745, 211);
            PriceNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(70, 23);
            PriceNumericUpDown.TabIndex = 2;
            PriceNumericUpDown.ValueChanged += PriceNumericUpDown_ValueChanged;
            // 
            // StanCheckBox
            // 
            StanCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            StanCheckBox.AutoSize = true;
            StanCheckBox.Location = new Point(745, 237);
            StanCheckBox.Name = "StanCheckBox";
            StanCheckBox.Size = new Size(82, 19);
            StanCheckBox.TabIndex = 4;
            StanCheckBox.Text = "Wykonane";
            StanCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(853, 187);
            label4.Name = "label4";
            label4.Size = new Size(41, 21);
            label4.TabIndex = 1;
            label4.Text = "Ilość";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(754, 187);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 1;
            label2.Text = "Cena";
            // 
            // ButtonRepairSave
            // 
            ButtonRepairSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonRepairSave.BackColor = Color.FromArgb(94, 148, 255);
            ButtonRepairSave.FlatAppearance.BorderSize = 0;
            ButtonRepairSave.FlatStyle = FlatStyle.Flat;
            ButtonRepairSave.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRepairSave.ForeColor = Color.LightGray;
            ButtonRepairSave.Location = new Point(853, 21);
            ButtonRepairSave.Name = "ButtonRepairSave";
            ButtonRepairSave.Size = new Size(131, 30);
            ButtonRepairSave.TabIndex = 6;
            ButtonRepairSave.Text = "Zapisz";
            ButtonRepairSave.UseVisualStyleBackColor = false;
            ButtonRepairSave.Click += ButtonOrderRepairSave_Click;
            // 
            // ViewRepair
            // 
            ViewRepair.AllowUserToAddRows = false;
            ViewRepair.AllowUserToDeleteRows = false;
            ViewRepair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewRepair.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewRepair.BorderStyle = BorderStyle.None;
            ViewRepair.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ViewRepair.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewRepair.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewRepair.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewRepair.Columns.AddRange(new DataGridViewColumn[] { BtnDelete, ID, Wykonane_Checked, Type_Column, Nazwa_Column_, Opis_Column, NrCzęści_Column, Cena_Column, Ilość_Column, Suma_Column, DateRepair });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ViewRepair.DefaultCellStyle = dataGridViewCellStyle3;
            ViewRepair.EnableHeadersVisualStyles = false;
            ViewRepair.Location = new Point(14, 14);
            ViewRepair.Name = "ViewRepair";
            ViewRepair.RowTemplate.Height = 25;
            ViewRepair.Size = new Size(970, 212);
            ViewRepair.TabIndex = 23;
            ViewRepair.CellContentClick += ViewRepair_CellContentClick;
            ViewRepair.MouseDoubleClick += ViewRepair_MouseDoubleClick;
            // 
            // BtnDelete
            // 
            BtnDelete.FillWeight = 50F;
            BtnDelete.HeaderText = "Usuń";
            BtnDelete.Name = "BtnDelete";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // Wykonane_Checked
            // 
            Wykonane_Checked.DataPropertyName = "Stan";
            Wykonane_Checked.FalseValue = "0";
            Wykonane_Checked.FillWeight = 83.94669F;
            Wykonane_Checked.HeaderText = "Wykonane";
            Wykonane_Checked.Name = "Wykonane_Checked";
            Wykonane_Checked.TrueValue = "1";
            // 
            // Type_Column
            // 
            Type_Column.DataPropertyName = "Typ";
            Type_Column.FillWeight = 83.94669F;
            Type_Column.HeaderText = "Typ";
            Type_Column.Name = "Type_Column";
            // 
            // Nazwa_Column_
            // 
            Nazwa_Column_.DataPropertyName = "Nazwa";
            Nazwa_Column_.HeaderText = "Nazwa";
            Nazwa_Column_.Name = "Nazwa_Column_";
            // 
            // Opis_Column
            // 
            Opis_Column.DataPropertyName = "Opis";
            Opis_Column.FillWeight = 83.94669F;
            Opis_Column.HeaderText = "Opis";
            Opis_Column.Name = "Opis_Column";
            // 
            // NrCzęści_Column
            // 
            NrCzęści_Column.DataPropertyName = "NumerCzęści";
            NrCzęści_Column.FillWeight = 83.94669F;
            NrCzęści_Column.HeaderText = "Numer Części";
            NrCzęści_Column.Name = "NrCzęści_Column";
            // 
            // Cena_Column
            // 
            Cena_Column.DataPropertyName = "Cena";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            Cena_Column.DefaultCellStyle = dataGridViewCellStyle2;
            Cena_Column.FillWeight = 40F;
            Cena_Column.HeaderText = "Cena";
            Cena_Column.Name = "Cena_Column";
            // 
            // Ilość_Column
            // 
            Ilość_Column.DataPropertyName = "Ilość";
            Ilość_Column.FillWeight = 40F;
            Ilość_Column.HeaderText = "Ilość";
            Ilość_Column.Name = "Ilość_Column";
            // 
            // Suma_Column
            // 
            Suma_Column.DataPropertyName = "Suma";
            Suma_Column.FillWeight = 40F;
            Suma_Column.HeaderText = "Suma";
            Suma_Column.Name = "Suma_Column";
            // 
            // DateRepair
            // 
            DateRepair.DataPropertyName = "DataNapraw";
            DateRepair.FillWeight = 83.94669F;
            DateRepair.HeaderText = "DataNapraw";
            DateRepair.Name = "DateRepair";
            // 
            // VIN_label
            // 
            VIN_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VIN_label.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            VIN_label.ForeColor = Color.FromArgb(224, 224, 224);
            VIN_label.Location = new Point(745, 54);
            VIN_label.Name = "VIN_label";
            VIN_label.Size = new Size(227, 27);
            VIN_label.TabIndex = 25;
            VIN_label.Text = "Brak";
            // 
            // ViewCar
            // 
            ViewCar.AllowUserToAddRows = false;
            ViewCar.AllowUserToDeleteRows = false;
            ViewCar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ViewCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewCar.BorderStyle = BorderStyle.None;
            ViewCar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ViewCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ViewCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewCar.Columns.AddRange(new DataGridViewColumn[] { ID_Column, Marka_Column, Model_Column, RokProdukcji_Column, VIN_Column });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ViewCar.DefaultCellStyle = dataGridViewCellStyle6;
            ViewCar.EnableHeadersVisualStyles = false;
            ViewCar.Location = new Point(14, 21);
            ViewCar.Name = "ViewCar";
            ViewCar.RowTemplate.Height = 25;
            ViewCar.Size = new Size(584, 269);
            ViewCar.TabIndex = 26;
            ViewCar.CellClick += ViewCar_CellClick;
            // 
            // ID_Column
            // 
            ID_Column.DataPropertyName = "ID";
            ID_Column.HeaderText = "ID";
            ID_Column.Name = "ID_Column";
            ID_Column.Visible = false;
            // 
            // Marka_Column
            // 
            Marka_Column.DataPropertyName = "Marka";
            Marka_Column.HeaderText = "Marka";
            Marka_Column.Name = "Marka_Column";
            // 
            // Model_Column
            // 
            Model_Column.DataPropertyName = "Model";
            Model_Column.HeaderText = "Model";
            Model_Column.Name = "Model_Column";
            // 
            // RokProdukcji_Column
            // 
            RokProdukcji_Column.DataPropertyName = "RokProdukcji";
            RokProdukcji_Column.HeaderText = "RokProdukcji";
            RokProdukcji_Column.Name = "RokProdukcji_Column";
            // 
            // VIN_Column
            // 
            VIN_Column.DataPropertyName = "VIN";
            dataGridViewCellStyle5.Format = "km";
            dataGridViewCellStyle5.NullValue = null;
            VIN_Column.DefaultCellStyle = dataGridViewCellStyle5;
            VIN_Column.HeaderText = "VIN";
            VIN_Column.Name = "VIN_Column";
            // 
            // panelDodatkowy
            // 
            panelDodatkowy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDodatkowy.BackColor = Color.FromArgb(64, 64, 70);
            panelDodatkowy.BorderStyle = BorderStyle.FixedSingle;
            panelDodatkowy.Controls.Add(IloscNumericUpDown);
            panelDodatkowy.Controls.Add(RepairTimePicker);
            panelDodatkowy.Controls.Add(ViewCar);
            panelDodatkowy.Controls.Add(ButtonOrderManagement);
            panelDodatkowy.Controls.Add(label2);
            panelDodatkowy.Controls.Add(ButtonRepairSave);
            panelDodatkowy.Controls.Add(SumLabel);
            panelDodatkowy.Controls.Add(label5);
            panelDodatkowy.Controls.Add(VIN_label);
            panelDodatkowy.Controls.Add(label3);
            panelDodatkowy.Controls.Add(label4);
            panelDodatkowy.Controls.Add(NazwaTextBox);
            panelDodatkowy.Controls.Add(NrPartTextBox);
            panelDodatkowy.Controls.Add(DescriptionTextBox);
            panelDodatkowy.Controls.Add(PriceNumericUpDown);
            panelDodatkowy.Controls.Add(StanCheckBox);
            panelDodatkowy.ForeColor = Color.DimGray;
            panelDodatkowy.Location = new Point(3, 0);
            panelDodatkowy.Name = "panelDodatkowy";
            panelDodatkowy.Size = new Size(1001, 295);
            panelDodatkowy.TabIndex = 27;
            // 
            // RepairTimePicker
            // 
            RepairTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RepairTimePicker.CalendarMonthBackground = Color.FromArgb(94, 148, 255);
            RepairTimePicker.CalendarTitleBackColor = SystemColors.ControlText;
            RepairTimePicker.CalendarTitleForeColor = Color.FromArgb(94, 148, 255);
            RepairTimePicker.Cursor = Cursors.Hand;
            RepairTimePicker.CustomFormat = "";
            RepairTimePicker.Location = new Point(751, 262);
            RepairTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            RepairTimePicker.Name = "RepairTimePicker";
            RepairTimePicker.Size = new Size(227, 23);
            RepairTimePicker.TabIndex = 5;
            RepairTimePicker.Value = new DateTime(2024, 1, 16, 0, 0, 0, 0);
            // 
            // ButtonOrderManagement
            // 
            ButtonOrderManagement.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonOrderManagement.BackColor = Color.FromArgb(94, 148, 255);
            ButtonOrderManagement.FlatAppearance.BorderSize = 0;
            ButtonOrderManagement.FlatStyle = FlatStyle.Flat;
            ButtonOrderManagement.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonOrderManagement.ForeColor = Color.LightGray;
            ButtonOrderManagement.Location = new Point(607, 21);
            ButtonOrderManagement.Name = "ButtonOrderManagement";
            ButtonOrderManagement.Size = new Size(237, 30);
            ButtonOrderManagement.TabIndex = 28;
            ButtonOrderManagement.Text = "Zarządzaj zleceniem";
            ButtonOrderManagement.UseVisualStyleBackColor = false;
            ButtonOrderManagement.Click += ButtonOrderManagement_Click;
            // 
            // SumLabel
            // 
            SumLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SumLabel.AutoSize = true;
            SumLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SumLabel.ForeColor = Color.FromArgb(224, 224, 224);
            SumLabel.Location = new Point(951, 213);
            SumLabel.Name = "SumLabel";
            SumLabel.Size = new Size(19, 21);
            SumLabel.TabIndex = 1;
            SumLabel.Text = "0";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(924, 211);
            label5.Name = "label5";
            label5.Size = new Size(21, 21);
            label5.TabIndex = 1;
            label5.Text = "=";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(819, 213);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 1;
            label3.Text = "*";
            // 
            // NazwaTextBox
            // 
            NazwaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NazwaTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NazwaTextBox.CausesValidation = false;
            NazwaTextBox.Cursor = Cursors.IBeam;
            NazwaTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NazwaTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NazwaTextBox.Location = new Point(745, 120);
            NazwaTextBox.Name = "NazwaTextBox";
            NazwaTextBox.PlaceholderText = "Krótka nazwa";
            NazwaTextBox.Size = new Size(233, 30);
            NazwaTextBox.TabIndex = 1;
            // 
            // NrPartTextBox
            // 
            NrPartTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NrPartTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NrPartTextBox.CausesValidation = false;
            NrPartTextBox.Cursor = Cursors.IBeam;
            NrPartTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NrPartTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NrPartTextBox.Location = new Point(745, 84);
            NrPartTextBox.Name = "NrPartTextBox";
            NrPartTextBox.PlaceholderText = "Numer części";
            NrPartTextBox.Size = new Size(233, 30);
            NrPartTextBox.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DescriptionTextBox.BackColor = Color.FromArgb(64, 64, 70);
            DescriptionTextBox.CausesValidation = false;
            DescriptionTextBox.Cursor = Cursors.IBeam;
            DescriptionTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            DescriptionTextBox.Location = new Point(607, 156);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.PlaceholderText = "Opis";
            DescriptionTextBox.Size = new Size(371, 30);
            DescriptionTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(678, 229);
            label1.Name = "label1";
            label1.Size = new Size(224, 28);
            label1.TabIndex = 25;
            label1.Text = "Aktulalny stan na magazynie";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(64, 64, 70);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(WarehouseView);
            panel1.Controls.Add(ViewRepair);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(3, 283);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 602);
            panel1.TabIndex = 29;
            // 
            // WarehouseView
            // 
            WarehouseView.AllowUserToAddRows = false;
            WarehouseView.AllowUserToDeleteRows = false;
            WarehouseView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WarehouseView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WarehouseView.BorderStyle = BorderStyle.None;
            WarehouseView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            WarehouseView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.LightGray;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            WarehouseView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            WarehouseView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WarehouseView.Columns.AddRange(new DataGridViewColumn[] { BtnDelete_Warehouse, SelectButton, ID_Column_, TypCzesci_Column, Opis_Column_, Nazwa_Column, NumerCzesci_Column, Price_Column, Quantity_Column, Sum_Column });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.DimGray;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            WarehouseView.DefaultCellStyle = dataGridViewCellStyle9;
            WarehouseView.EnableHeadersVisualStyles = false;
            WarehouseView.Location = new Point(14, 260);
            WarehouseView.Name = "WarehouseView";
            WarehouseView.RowTemplate.Height = 25;
            WarehouseView.Size = new Size(975, 320);
            WarehouseView.TabIndex = 26;
            WarehouseView.CellContentClick += WarehouseView_CellContentClick;
            // 
            // BtnDelete_Warehouse
            // 
            BtnDelete_Warehouse.HeaderText = "Usuń";
            BtnDelete_Warehouse.Name = "BtnDelete_Warehouse";
            // 
            // SelectButton
            // 
            SelectButton.HeaderText = "Wybierz";
            SelectButton.Name = "SelectButton";
            // 
            // ID_Column_
            // 
            ID_Column_.DataPropertyName = "ID";
            ID_Column_.HeaderText = "ID";
            ID_Column_.Name = "ID_Column_";
            ID_Column_.Visible = false;
            // 
            // TypCzesci_Column
            // 
            TypCzesci_Column.DataPropertyName = "Typ";
            TypCzesci_Column.HeaderText = "Typ";
            TypCzesci_Column.Name = "TypCzesci_Column";
            // 
            // Opis_Column_
            // 
            Opis_Column_.DataPropertyName = "Opis";
            Opis_Column_.HeaderText = "Opis";
            Opis_Column_.Name = "Opis_Column_";
            // 
            // Nazwa_Column
            // 
            Nazwa_Column.DataPropertyName = "Nazwa";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            Nazwa_Column.DefaultCellStyle = dataGridViewCellStyle8;
            Nazwa_Column.HeaderText = "Nazwa";
            Nazwa_Column.Name = "Nazwa_Column";
            // 
            // NumerCzesci_Column
            // 
            NumerCzesci_Column.DataPropertyName = "NumerCzęści";
            NumerCzesci_Column.HeaderText = "Numer";
            NumerCzesci_Column.Name = "NumerCzesci_Column";
            // 
            // Price_Column
            // 
            Price_Column.DataPropertyName = "Cena";
            Price_Column.HeaderText = "Cena";
            Price_Column.Name = "Price_Column";
            // 
            // Quantity_Column
            // 
            Quantity_Column.DataPropertyName = "Ilość";
            Quantity_Column.HeaderText = "Ilość";
            Quantity_Column.Name = "Quantity_Column";
            // 
            // Sum_Column
            // 
            Sum_Column.DataPropertyName = "Suma";
            Sum_Column.HeaderText = "Łączna cena";
            Sum_Column.Name = "Sum_Column";
            // 
            // UC_AddRepair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Controls.Add(panelDodatkowy);
            MinimumSize = new Size(1040, 580);
            Name = "UC_AddRepair";
            Size = new Size(1023, 580);
            Load += UC_AddOrderRepair_Load;
            ((System.ComponentModel.ISupportInitialize)IloscNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewRepair).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewCar).EndInit();
            panelDodatkowy.ResumeLayout(false);
            panelDodatkowy.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WarehouseView).EndInit();
            ResumeLayout(false);
            }

        #endregion
        private Label label2;
        private Label label4;
        private CheckBox StanCheckBox;
        private Button ButtonRepairSave;
        private DataGridView ViewRepair;
        private NumericUpDown IloscNumericUpDown;
        private NumericUpDown PriceNumericUpDown;
        private Label VIN_label;
        private DataGridView ViewCar;
        private Panel panelDodatkowy;
        private TextBox DescriptionTextBox;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewTextBoxColumn Marka_Column;
        private DataGridViewTextBoxColumn Model_Column;
        private DataGridViewTextBoxColumn RokProdukcji_Column;
        private DataGridViewTextBoxColumn VIN_Column;
        public DateTimePicker RepairTimePicker;
        private TextBox NrPartTextBox;
        private Label label1;
        private Label label3;
        private Label SumLabel;
        private Label label5;
        private Button ButtonOrderManagement;
        private Panel panel1;
        public DataGridView WarehouseView;
        private DataGridViewButtonColumn BtnDelete_Warehouse;
        private DataGridViewButtonColumn SelectButton;
        private DataGridViewTextBoxColumn ID_Column_;
        private DataGridViewTextBoxColumn TypCzesci_Column;
        private DataGridViewTextBoxColumn Opis_Column_;
        private DataGridViewTextBoxColumn Nazwa_Column;
        private DataGridViewTextBoxColumn NumerCzesci_Column;
        private DataGridViewTextBoxColumn Price_Column;
        private DataGridViewTextBoxColumn Quantity_Column;
        private DataGridViewTextBoxColumn Sum_Column;
        private TextBox NazwaTextBox;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewCheckBoxColumn Wykonane_Checked;
        private DataGridViewTextBoxColumn Type_Column;
        private DataGridViewTextBoxColumn Nazwa_Column_;
        private DataGridViewTextBoxColumn Opis_Column;
        private DataGridViewTextBoxColumn NrCzęści_Column;
        private DataGridViewTextBoxColumn Cena_Column;
        private DataGridViewTextBoxColumn Ilość_Column;
        private DataGridViewTextBoxColumn Suma_Column;
        private DataGridViewTextBoxColumn DateRepair;
        }
}
