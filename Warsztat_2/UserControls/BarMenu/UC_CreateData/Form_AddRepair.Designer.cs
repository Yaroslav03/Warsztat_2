namespace Warsztat_2.UserControls.BarMenu.UC_CreateData
{
    partial class Form_AddRepair
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            TypeTextBox = new TextBox();
            IloscNumericUpDown = new NumericUpDown();
            label1 = new Label();
            ButtonRepairSave = new Button();
            SumLabel = new Label();
            label3 = new Label();
            label5 = new Label();
            NazwaTextBox = new TextBox();
            NrPartTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            PriceNumericUpDown = new NumericUpDown();
            StanCheckBox = new CheckBox();
            label2 = new Label();
            PriceEarningNumericUpDown = new NumericUpDown();
            ViewRepair = new DataGridView();
            BtnDelete = new DataGridViewButtonColumn();
            ID_Column_ = new DataGridViewTextBoxColumn();
            Wykonane_Checked = new DataGridViewCheckBoxColumn();
            Type_Column = new DataGridViewTextBoxColumn();
            Nazwa_Column = new DataGridViewTextBoxColumn();
            Opis_Column = new DataGridViewTextBoxColumn();
            NrCzęści_Column = new DataGridViewTextBoxColumn();
            Cena_Column_ = new DataGridViewTextBoxColumn();
            Ilość_Column_ = new DataGridViewTextBoxColumn();
            EarningParts_Column_ = new DataGridViewTextBoxColumn();
            SumaZarobku_Column = new DataGridViewTextBoxColumn();
            Suma_Column = new DataGridViewTextBoxColumn();
            WarehouseView = new DataGridView();
            BtnDelete_Warehouse_ = new DataGridViewButtonColumn();
            SelectButton = new DataGridViewButtonColumn();
            ID_Column = new DataGridViewTextBoxColumn();
            Typ_column = new DataGridViewTextBoxColumn();
            Nazwa_column_ = new DataGridViewTextBoxColumn();
            NumerCzęści_column = new DataGridViewTextBoxColumn();
            Opis_Column_ = new DataGridViewTextBoxColumn();
            Ilość_column = new DataGridViewTextBoxColumn();
            Cena_column = new DataGridViewTextBoxColumn();
            EarningParts_Column = new DataGridViewTextBoxColumn();
            SumaZarobku_Column_Warehouse = new DataGridViewTextBoxColumn();
            Sum_Column = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            textBox1 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)IloscNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceEarningNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewRepair).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarehouseView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // TypeTextBox
            // 
            TypeTextBox.BackColor = Color.FromArgb(48, 48, 54);
            TypeTextBox.BorderStyle = BorderStyle.FixedSingle;
            TypeTextBox.CausesValidation = false;
            TypeTextBox.Dock = DockStyle.Fill;
            TypeTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TypeTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            TypeTextBox.Location = new Point(123, 108);
            TypeTextBox.Name = "TypeTextBox";
            TypeTextBox.Size = new Size(276, 30);
            TypeTextBox.TabIndex = 7;
            // 
            // IloscNumericUpDown
            // 
            IloscNumericUpDown.BackColor = Color.FromArgb(48, 48, 54);
            IloscNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            IloscNumericUpDown.Dock = DockStyle.Fill;
            IloscNumericUpDown.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            IloscNumericUpDown.ForeColor = Color.FromArgb(224, 224, 224);
            IloscNumericUpDown.Location = new Point(516, 108);
            IloscNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            IloscNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            IloscNumericUpDown.Name = "IloscNumericUpDown";
            IloscNumericUpDown.Size = new Size(99, 31);
            IloscNumericUpDown.TabIndex = 3;
            IloscNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            IloscNumericUpDown.ValueChanged += IloscNumericUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(406, 1);
            label1.Name = "label1";
            label1.Size = new Size(103, 49);
            label1.TabIndex = 1;
            label1.Text = "Cena zakupu";
            // 
            // ButtonRepairSave
            // 
            ButtonRepairSave.BackColor = Color.FromArgb(94, 148, 255);
            ButtonRepairSave.Dock = DockStyle.Fill;
            ButtonRepairSave.FlatAppearance.BorderSize = 0;
            ButtonRepairSave.FlatStyle = FlatStyle.Flat;
            ButtonRepairSave.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRepairSave.ForeColor = Color.LightGray;
            ButtonRepairSave.Location = new Point(3, 45);
            ButtonRepairSave.Name = "ButtonRepairSave";
            ButtonRepairSave.Size = new Size(154, 37);
            ButtonRepairSave.TabIndex = 6;
            ButtonRepairSave.Text = "Zapisz";
            ButtonRepairSave.UseVisualStyleBackColor = false;
            ButtonRepairSave.Click += ButtonRepairSave_Click;
            // 
            // SumLabel
            // 
            SumLabel.AutoSize = true;
            SumLabel.Dock = DockStyle.Fill;
            SumLabel.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SumLabel.ForeColor = Color.FromArgb(224, 224, 224);
            SumLabel.Location = new Point(516, 149);
            SumLabel.Name = "SumLabel";
            SumLabel.Size = new Size(99, 34);
            SumLabel.TabIndex = 1;
            SumLabel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(406, 149);
            label3.Name = "label3";
            label3.Size = new Size(103, 34);
            label3.TabIndex = 1;
            label3.Text = "Cena NETTO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(406, 105);
            label5.Name = "label5";
            label5.Size = new Size(103, 43);
            label5.TabIndex = 1;
            label5.Text = "Ilość";
            // 
            // NazwaTextBox
            // 
            NazwaTextBox.BackColor = Color.FromArgb(48, 48, 54);
            NazwaTextBox.BorderStyle = BorderStyle.FixedSingle;
            NazwaTextBox.CausesValidation = false;
            NazwaTextBox.Dock = DockStyle.Fill;
            NazwaTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NazwaTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NazwaTextBox.Location = new Point(123, 152);
            NazwaTextBox.Name = "NazwaTextBox";
            NazwaTextBox.Size = new Size(276, 30);
            NazwaTextBox.TabIndex = 1;
            // 
            // NrPartTextBox
            // 
            NrPartTextBox.BackColor = Color.FromArgb(48, 48, 54);
            NrPartTextBox.BorderStyle = BorderStyle.FixedSingle;
            NrPartTextBox.CausesValidation = false;
            NrPartTextBox.Dock = DockStyle.Fill;
            NrPartTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NrPartTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NrPartTextBox.Location = new Point(123, 4);
            NrPartTextBox.Name = "NrPartTextBox";
            NrPartTextBox.Size = new Size(276, 30);
            NrPartTextBox.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BackColor = Color.FromArgb(48, 48, 54);
            DescriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
            DescriptionTextBox.CausesValidation = false;
            DescriptionTextBox.Dock = DockStyle.Fill;
            DescriptionTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            DescriptionTextBox.Location = new Point(123, 54);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(276, 30);
            DescriptionTextBox.TabIndex = 0;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.BackColor = Color.FromArgb(48, 48, 54);
            PriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PriceNumericUpDown.DecimalPlaces = 2;
            PriceNumericUpDown.Dock = DockStyle.Fill;
            PriceNumericUpDown.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PriceNumericUpDown.ForeColor = Color.FromArgb(224, 224, 224);
            PriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            PriceNumericUpDown.Location = new Point(516, 4);
            PriceNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(99, 31);
            PriceNumericUpDown.TabIndex = 2;
            PriceNumericUpDown.ValueChanged += PriceNumericUpDown_ValueChanged;
            // 
            // StanCheckBox
            // 
            StanCheckBox.AutoSize = true;
            StanCheckBox.BackColor = Color.FromArgb(48, 48, 54);
            StanCheckBox.Dock = DockStyle.Top;
            StanCheckBox.FlatStyle = FlatStyle.Flat;
            StanCheckBox.ForeColor = Color.FromArgb(224, 224, 224);
            StanCheckBox.Location = new Point(4, 4);
            StanCheckBox.Name = "StanCheckBox";
            StanCheckBox.Size = new Size(159, 19);
            StanCheckBox.TabIndex = 4;
            StanCheckBox.Text = "Wykonane";
            StanCheckBox.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(406, 51);
            label2.Name = "label2";
            label2.Size = new Size(103, 53);
            label2.TabIndex = 9;
            label2.Text = "Cena  sprzedaży";
            // 
            // PriceEarningNumericUpDown
            // 
            PriceEarningNumericUpDown.BackColor = Color.FromArgb(48, 48, 54);
            PriceEarningNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PriceEarningNumericUpDown.DecimalPlaces = 2;
            PriceEarningNumericUpDown.Dock = DockStyle.Fill;
            PriceEarningNumericUpDown.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PriceEarningNumericUpDown.ForeColor = Color.FromArgb(224, 224, 224);
            PriceEarningNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            PriceEarningNumericUpDown.Location = new Point(516, 54);
            PriceEarningNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            PriceEarningNumericUpDown.Name = "PriceEarningNumericUpDown";
            PriceEarningNumericUpDown.Size = new Size(99, 31);
            PriceEarningNumericUpDown.TabIndex = 8;
            PriceEarningNumericUpDown.ValueChanged += PriceEarningNumericUpDown_ValueChanged;
            // 
            // ViewRepair
            // 
            ViewRepair.AllowUserToAddRows = false;
            ViewRepair.AllowUserToDeleteRows = false;
            ViewRepair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewRepair.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewRepair.BorderStyle = BorderStyle.None;
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
            ViewRepair.Columns.AddRange(new DataGridViewColumn[] { BtnDelete, ID_Column_, Wykonane_Checked, Type_Column, Nazwa_Column, Opis_Column, NrCzęści_Column, Cena_Column_, Ilość_Column_, EarningParts_Column_, SumaZarobku_Column, Suma_Column });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            ViewRepair.DefaultCellStyle = dataGridViewCellStyle4;
            ViewRepair.EnableHeadersVisualStyles = false;
            ViewRepair.Location = new Point(3, 199);
            ViewRepair.Name = "ViewRepair";
            ViewRepair.RowTemplate.Height = 25;
            ViewRepair.Size = new Size(965, 251);
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
            // ID_Column_
            // 
            ID_Column_.DataPropertyName = "ID";
            ID_Column_.HeaderText = "ID";
            ID_Column_.Name = "ID_Column_";
            ID_Column_.Visible = false;
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
            // Nazwa_Column
            // 
            Nazwa_Column.DataPropertyName = "Nazwa";
            Nazwa_Column.HeaderText = "Nazwa";
            Nazwa_Column.Name = "Nazwa_Column";
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
            // Cena_Column_
            // 
            Cena_Column_.DataPropertyName = "Cena";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            Cena_Column_.DefaultCellStyle = dataGridViewCellStyle2;
            Cena_Column_.FillWeight = 40F;
            Cena_Column_.HeaderText = "Cena 1 szt.";
            Cena_Column_.Name = "Cena_Column_";
            // 
            // Ilość_Column_
            // 
            Ilość_Column_.DataPropertyName = "Ilość";
            Ilość_Column_.FillWeight = 40F;
            Ilość_Column_.HeaderText = "Ilość";
            Ilość_Column_.Name = "Ilość_Column_";
            // 
            // EarningParts_Column_
            // 
            EarningParts_Column_.DataPropertyName = "ZarobekCzęści";
            EarningParts_Column_.HeaderText = "koszt własny netto / szt.";
            EarningParts_Column_.Name = "EarningParts_Column_";
            EarningParts_Column_.Visible = false;
            // 
            // SumaZarobku_Column
            // 
            SumaZarobku_Column.DataPropertyName = "SumaZarobku";
            SumaZarobku_Column.HeaderText = "Suma zarobku części";
            SumaZarobku_Column.Name = "SumaZarobku_Column";
            SumaZarobku_Column.Visible = false;
            // 
            // Suma_Column
            // 
            Suma_Column.DataPropertyName = "Suma";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            Suma_Column.DefaultCellStyle = dataGridViewCellStyle3;
            Suma_Column.FillWeight = 40F;
            Suma_Column.HeaderText = "Cena netto";
            Suma_Column.Name = "Suma_Column";
            // 
            // WarehouseView
            // 
            WarehouseView.AllowUserToAddRows = false;
            WarehouseView.AllowUserToDeleteRows = false;
            WarehouseView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WarehouseView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WarehouseView.BorderStyle = BorderStyle.None;
            WarehouseView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            WarehouseView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            WarehouseView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WarehouseView.Columns.AddRange(new DataGridViewColumn[] { BtnDelete_Warehouse_, SelectButton, ID_Column, Typ_column, Nazwa_column_, NumerCzęści_column, Opis_Column_, Ilość_column, Cena_column, EarningParts_Column, SumaZarobku_Column_Warehouse, Sum_Column });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            WarehouseView.DefaultCellStyle = dataGridViewCellStyle8;
            WarehouseView.EnableHeadersVisualStyles = false;
            WarehouseView.Location = new Point(3, 499);
            WarehouseView.Name = "WarehouseView";
            WarehouseView.RowTemplate.Height = 25;
            WarehouseView.Size = new Size(965, 278);
            WarehouseView.TabIndex = 38;
            WarehouseView.CellContentClick += WarehouseView_CellContentClick;
            // 
            // BtnDelete_Warehouse_
            // 
            BtnDelete_Warehouse_.FillWeight = 97.01071F;
            BtnDelete_Warehouse_.HeaderText = "Usuń";
            BtnDelete_Warehouse_.Name = "BtnDelete_Warehouse_";
            // 
            // SelectButton
            // 
            SelectButton.FillWeight = 97.01071F;
            SelectButton.HeaderText = "Wybierz";
            SelectButton.Name = "SelectButton";
            // 
            // ID_Column
            // 
            ID_Column.DataPropertyName = "ID";
            ID_Column.HeaderText = "ID";
            ID_Column.Name = "ID_Column";
            ID_Column.Visible = false;
            // 
            // Typ_column
            // 
            Typ_column.DataPropertyName = "Typ";
            Typ_column.FillWeight = 97.01071F;
            Typ_column.HeaderText = "Typ";
            Typ_column.Name = "Typ_column";
            // 
            // Nazwa_column_
            // 
            Nazwa_column_.DataPropertyName = "Nazwa";
            Nazwa_column_.FillWeight = 97.01071F;
            Nazwa_column_.HeaderText = "Nazwa";
            Nazwa_column_.Name = "Nazwa_column_";
            // 
            // NumerCzęści_column
            // 
            NumerCzęści_column.DataPropertyName = "NumerCzęści";
            NumerCzęści_column.FillWeight = 97.01071F;
            NumerCzęści_column.HeaderText = "Numer Części";
            NumerCzęści_column.Name = "NumerCzęści_column";
            // 
            // Opis_Column_
            // 
            Opis_Column_.DataPropertyName = "Opis";
            Opis_Column_.FillWeight = 97.01071F;
            Opis_Column_.HeaderText = "Opis";
            Opis_Column_.Name = "Opis_Column_";
            // 
            // Ilość_column
            // 
            Ilość_column.DataPropertyName = "Ilość";
            Ilość_column.FillWeight = 97.01071F;
            Ilość_column.HeaderText = "Ilość";
            Ilość_column.Name = "Ilość_column";
            // 
            // Cena_column
            // 
            Cena_column.DataPropertyName = "Cena";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            Cena_column.DefaultCellStyle = dataGridViewCellStyle6;
            Cena_column.FillWeight = 97.01071F;
            Cena_column.HeaderText = "Cena";
            Cena_column.Name = "Cena_column";
            // 
            // EarningParts_Column
            // 
            EarningParts_Column.DataPropertyName = "ZarobekCzęści";
            EarningParts_Column.FillWeight = 126.903564F;
            EarningParts_Column.HeaderText = "koszt własny netto / szt.";
            EarningParts_Column.Name = "EarningParts_Column";
            EarningParts_Column.Visible = false;
            // 
            // SumaZarobku_Column_Warehouse
            // 
            SumaZarobku_Column_Warehouse.DataPropertyName = "SumaZarobku";
            SumaZarobku_Column_Warehouse.HeaderText = "Suma zarobku części";
            SumaZarobku_Column_Warehouse.Name = "SumaZarobku_Column_Warehouse";
            SumaZarobku_Column_Warehouse.Visible = false;
            // 
            // Sum_Column
            // 
            Sum_Column.DataPropertyName = "Suma";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            Sum_Column.DefaultCellStyle = dataGridViewCellStyle7;
            Sum_Column.FillWeight = 97.01071F;
            Sum_Column.HeaderText = "Cena Netto";
            Sum_Column.Name = "Sum_Column";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.44297F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.55703F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(label8, 0, 2);
            tableLayoutPanel1.Controls.Add(IloscNumericUpDown, 3, 2);
            tableLayoutPanel1.Controls.Add(SumLabel, 3, 3);
            tableLayoutPanel1.Controls.Add(label2, 2, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 3);
            tableLayoutPanel1.Controls.Add(NrPartTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 2);
            tableLayoutPanel1.Controls.Add(PriceEarningNumericUpDown, 3, 1);
            tableLayoutPanel1.Controls.Add(DescriptionTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(TypeTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
            tableLayoutPanel1.Controls.Add(NazwaTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(PriceNumericUpDown, 3, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.52941F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.47059F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new Size(619, 184);
            tableLayoutPanel1.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(4, 149);
            label9.Name = "label9";
            label9.Size = new Size(112, 34);
            label9.TabIndex = 13;
            label9.Text = "Krótka nazwa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(4, 105);
            label8.Name = "label8";
            label8.Size = new Size(112, 43);
            label8.TabIndex = 12;
            label8.Text = "Typ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(4, 51);
            label7.Name = "label7";
            label7.Size = new Size(112, 53);
            label7.TabIndex = 11;
            label7.Text = "Opis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(4, 1);
            label4.Name = "label4";
            label4.Size = new Size(112, 49);
            label4.TabIndex = 10;
            label4.Text = "Numer części";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 1, 0);
            tableLayoutPanel2.Controls.Add(StanCheckBox, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(628, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(334, 184);
            tableLayoutPanel2.TabIndex = 31;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(button1, 0, 0);
            tableLayoutPanel7.Controls.Add(button2, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(170, 4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(160, 84);
            tableLayoutPanel7.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(94, 148, 255);
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(154, 36);
            button1.TabIndex = 7;
            button1.Text = "Wybierz plik xml";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(94, 148, 255);
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.LightGray;
            button2.Location = new Point(3, 45);
            button2.Name = "button2";
            button2.Size = new Size(154, 36);
            button2.TabIndex = 7;
            button2.Text = "Wybierz z allegro";
            button2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(ButtonRepairSave, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(170, 95);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(160, 85);
            tableLayoutPanel6.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(64, 64, 70);
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.78405F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.2159462F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(965, 190);
            tableLayoutPanel3.TabIndex = 32;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel4.Controls.Add(ViewRepair, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel4.Controls.Add(WarehouseView, 0, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 43.26711F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 56.73289F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 283F));
            tableLayoutPanel4.Size = new Size(971, 780);
            tableLayoutPanel4.TabIndex = 33;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.9452057F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.0547943F));
            tableLayoutPanel5.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Location = new Point(3, 456);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(438, 37);
            tableLayoutPanel5.TabIndex = 39;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(48, 48, 54);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.CausesValidation = false;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(224, 224, 224);
            textBox1.Location = new Point(213, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Szukaj";
            textBox1.Size = new Size(222, 30);
            textBox1.TabIndex = 27;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(204, 37);
            label6.TabIndex = 26;
            label6.Text = "Aktulalny stan na magazynie";
            // 
            // Form_AddRepair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(971, 780);
            Controls.Add(tableLayoutPanel4);
            Name = "Form_AddRepair";
            Text = "Form_AddRepair";
            Load += Form_AddRepair_Load;
            ((System.ComponentModel.ISupportInitialize)IloscNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceEarningNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewRepair).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarehouseView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TypeTextBox;
        private NumericUpDown IloscNumericUpDown;
        private Label label1;
        private Button ButtonRepairSave;
        private Label SumLabel;
        private Label label3;
        private Label label5;
        private TextBox NazwaTextBox;
        private TextBox NrPartTextBox;
        private TextBox DescriptionTextBox;
        private NumericUpDown PriceNumericUpDown;
        private CheckBox StanCheckBox;
        private DataGridView ViewRepair;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridView WarehouseView;
        private DataGridViewButtonColumn _BtnDelete_Warehouse_;
        private DataGridViewTextBoxColumn _ID_Column;
        private Label label2;
        private NumericUpDown PriceEarningNumericUpDown;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewTextBoxColumn ID_Column_;
        private DataGridViewCheckBoxColumn Wykonane_Checked;
        private DataGridViewTextBoxColumn Type_Column;
        private DataGridViewTextBoxColumn Nazwa_Column;
        private DataGridViewTextBoxColumn Opis_Column;
        private DataGridViewTextBoxColumn NrCzęści_Column;
        private DataGridViewTextBoxColumn Cena_Column_;
        private DataGridViewTextBoxColumn Ilość_Column_;
        private DataGridViewTextBoxColumn EarningParts_Column_;
        private DataGridViewTextBoxColumn SumaZarobku_Column;
        private DataGridViewTextBoxColumn Suma_Column;
        private DataGridViewButtonColumn BtnDelete_Warehouse_;
        private DataGridViewButtonColumn SelectButton;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewTextBoxColumn Typ_column;
        private DataGridViewTextBoxColumn Nazwa_column_;
        private DataGridViewTextBoxColumn NumerCzęści_column;
        private DataGridViewTextBoxColumn Opis_Column_;
        private DataGridViewTextBoxColumn Ilość_column;
        private DataGridViewTextBoxColumn Cena_column;
        private DataGridViewTextBoxColumn EarningParts_Column;
        private DataGridViewTextBoxColumn SumaZarobku_Column_Warehouse;
        private DataGridViewTextBoxColumn Sum_Column;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox textBox1;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel7;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel6;
    }
}