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
            label4 = new Label();
            label5 = new Label();
            NazwaTextBox = new TextBox();
            NrPartTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            PriceNumericUpDown = new NumericUpDown();
            StanCheckBox = new CheckBox();
            panel1 = new Panel();
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
            Suma_Column = new DataGridViewTextBoxColumn();
            label6 = new Label();
            panel2 = new Panel();
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
            Sum_Column = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)IloscNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewRepair).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WarehouseView).BeginInit();
            SuspendLayout();
            // 
            // TypeTextBox
            // 
            TypeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TypeTextBox.BackColor = Color.FromArgb(64, 64, 70);
            TypeTextBox.CausesValidation = false;
            TypeTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TypeTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            TypeTextBox.Location = new Point(12, 67);
            TypeTextBox.Name = "TypeTextBox";
            TypeTextBox.PlaceholderText = "Typ";
            TypeTextBox.Size = new Size(139, 30);
            TypeTextBox.TabIndex = 7;
            // 
            // IloscNumericUpDown
            // 
            IloscNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IloscNumericUpDown.BackColor = Color.White;
            IloscNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            IloscNumericUpDown.Location = new Point(604, 28);
            IloscNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            IloscNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            IloscNumericUpDown.Name = "IloscNumericUpDown";
            IloscNumericUpDown.Size = new Size(84, 23);
            IloscNumericUpDown.TabIndex = 3;
            IloscNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            IloscNumericUpDown.ValueChanged += IloscNumericUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(520, 4);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 1;
            label1.Text = "Cena";
            // 
            // ButtonRepairSave
            // 
            ButtonRepairSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonRepairSave.BackColor = Color.FromArgb(94, 148, 255);
            ButtonRepairSave.FlatAppearance.BorderSize = 0;
            ButtonRepairSave.FlatStyle = FlatStyle.Flat;
            ButtonRepairSave.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRepairSave.ForeColor = Color.LightGray;
            ButtonRepairSave.Location = new Point(811, 64);
            ButtonRepairSave.Name = "ButtonRepairSave";
            ButtonRepairSave.Size = new Size(131, 30);
            ButtonRepairSave.TabIndex = 6;
            ButtonRepairSave.Text = "Zapisz";
            ButtonRepairSave.UseVisualStyleBackColor = false;
            ButtonRepairSave.Click += ButtonRepairSave_Click;
            // 
            // SumLabel
            // 
            SumLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SumLabel.AutoSize = true;
            SumLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SumLabel.ForeColor = Color.FromArgb(224, 224, 224);
            SumLabel.Location = new Point(717, 30);
            SumLabel.Name = "SumLabel";
            SumLabel.Size = new Size(19, 21);
            SumLabel.TabIndex = 1;
            SumLabel.Text = "0";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(690, 28);
            label3.Name = "label3";
            label3.Size = new Size(21, 21);
            label3.TabIndex = 1;
            label3.Text = "=";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(585, 30);
            label4.Name = "label4";
            label4.Size = new Size(17, 21);
            label4.TabIndex = 1;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(619, 4);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 1;
            label5.Text = "Ilość";
            // 
            // NazwaTextBox
            // 
            NazwaTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NazwaTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NazwaTextBox.CausesValidation = false;
            NazwaTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NazwaTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NazwaTextBox.Location = new Point(251, 21);
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
            NrPartTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NrPartTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NrPartTextBox.Location = new Point(12, 21);
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
            DescriptionTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            DescriptionTextBox.Location = new Point(157, 67);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.PlaceholderText = "Opis";
            DescriptionTextBox.Size = new Size(327, 30);
            DescriptionTextBox.TabIndex = 0;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriceNumericUpDown.BackColor = Color.White;
            PriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PriceNumericUpDown.DecimalPlaces = 2;
            PriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            PriceNumericUpDown.Location = new Point(511, 28);
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
            StanCheckBox.Location = new Point(811, 39);
            StanCheckBox.Name = "StanCheckBox";
            StanCheckBox.Size = new Size(82, 19);
            StanCheckBox.TabIndex = 4;
            StanCheckBox.Text = "Wykonane";
            StanCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(64, 64, 70);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(TypeTextBox);
            panel1.Controls.Add(IloscNumericUpDown);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ButtonRepairSave);
            panel1.Controls.Add(SumLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(NazwaTextBox);
            panel1.Controls.Add(NrPartTextBox);
            panel1.Controls.Add(DescriptionTextBox);
            panel1.Controls.Add(PriceNumericUpDown);
            panel1.Controls.Add(StanCheckBox);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(14, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 112);
            panel1.TabIndex = 27;
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
            ViewRepair.Columns.AddRange(new DataGridViewColumn[] { BtnDelete, ID_Column_, Wykonane_Checked, Type_Column, Nazwa_Column, Opis_Column, NrCzęści_Column, Cena_Column_, Ilość_Column_, Suma_Column });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            ViewRepair.DefaultCellStyle = dataGridViewCellStyle4;
            ViewRepair.EnableHeadersVisualStyles = false;
            ViewRepair.Location = new Point(14, 14);
            ViewRepair.Name = "ViewRepair";
            ViewRepair.RowTemplate.Height = 25;
            ViewRepair.Size = new Size(945, 212);
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
            Cena_Column_.HeaderText = "Cena";
            Cena_Column_.Name = "Cena_Column_";
            // 
            // Ilość_Column_
            // 
            Ilość_Column_.DataPropertyName = "Ilość";
            Ilość_Column_.FillWeight = 40F;
            Ilość_Column_.HeaderText = "Ilość";
            Ilość_Column_.Name = "Ilość_Column_";
            // 
            // Suma_Column
            // 
            Suma_Column.DataPropertyName = "Suma";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            Suma_Column.DefaultCellStyle = dataGridViewCellStyle3;
            Suma_Column.FillWeight = 40F;
            Suma_Column.HeaderText = "Suma";
            Suma_Column.Name = "Suma_Column";
            // 
            // label6
            // 
            label6.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(678, 229);
            label6.Name = "label6";
            label6.Size = new Size(224, 28);
            label6.TabIndex = 25;
            label6.Text = "Aktulalny stan na magazynie";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(64, 64, 70);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(WarehouseView);
            panel2.Controls.Add(ViewRepair);
            panel2.Controls.Add(label6);
            panel2.ForeColor = Color.WhiteSmoke;
            panel2.Location = new Point(12, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(976, 508);
            panel2.TabIndex = 29;
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
            WarehouseView.Columns.AddRange(new DataGridViewColumn[] { BtnDelete_Warehouse_, SelectButton, ID_Column, Typ_column, Nazwa_column_, NumerCzęści_column, Opis_Column_, Ilość_column, Cena_column, Sum_Column });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            WarehouseView.DefaultCellStyle = dataGridViewCellStyle8;
            WarehouseView.EnableHeadersVisualStyles = false;
            WarehouseView.Location = new Point(3, 260);
            WarehouseView.Name = "WarehouseView";
            WarehouseView.RowTemplate.Height = 25;
            WarehouseView.Size = new Size(968, 243);
            WarehouseView.TabIndex = 38;
            WarehouseView.CellContentClick += WarehouseView_CellContentClick;
            // 
            // BtnDelete_Warehouse_
            // 
            BtnDelete_Warehouse_.HeaderText = "Usuń";
            BtnDelete_Warehouse_.Name = "BtnDelete_Warehouse_";
            // 
            // SelectButton
            // 
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
            Typ_column.HeaderText = "Typ";
            Typ_column.Name = "Typ_column";
            // 
            // Nazwa_column_
            // 
            Nazwa_column_.DataPropertyName = "Nazwa";
            Nazwa_column_.HeaderText = "Nazwa";
            Nazwa_column_.Name = "Nazwa_column_";
            // 
            // NumerCzęści_column
            // 
            NumerCzęści_column.DataPropertyName = "NumerCzęści";
            NumerCzęści_column.HeaderText = "Numer Części";
            NumerCzęści_column.Name = "NumerCzęści_column";
            // 
            // Opis_Column_
            // 
            Opis_Column_.DataPropertyName = "Opis";
            Opis_Column_.HeaderText = "Opis";
            Opis_Column_.Name = "Opis_Column_";
            // 
            // Ilość_column
            // 
            Ilość_column.DataPropertyName = "Ilość";
            Ilość_column.HeaderText = "Ilość";
            Ilość_column.Name = "Ilość_column";
            // 
            // Cena_column
            // 
            Cena_column.DataPropertyName = "Cena";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            Cena_column.DefaultCellStyle = dataGridViewCellStyle6;
            Cena_column.HeaderText = "Cena";
            Cena_column.Name = "Cena_column";
            // 
            // Sum_Column
            // 
            Sum_Column.DataPropertyName = "Suma";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            Sum_Column.DefaultCellStyle = dataGridViewCellStyle7;
            Sum_Column.HeaderText = "Suma";
            Sum_Column.Name = "Sum_Column";
            // 
            // Form_AddRepair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1000, 661);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form_AddRepair";
            Text = "Form_AddRepair";
            Load += Form_AddRepair_Load;
            Leave += Form_AddRepair_Leave;
            ((System.ComponentModel.ISupportInitialize)IloscNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewRepair).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WarehouseView).EndInit();
            ResumeLayout(false);
            }

        #endregion

        private TextBox TypeTextBox;
        private NumericUpDown IloscNumericUpDown;
        private Label label1;
        private Button ButtonRepairSave;
        private Label SumLabel;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NazwaTextBox;
        private TextBox NrPartTextBox;
        private TextBox DescriptionTextBox;
        private NumericUpDown PriceNumericUpDown;
        private CheckBox StanCheckBox;
        private Panel panel1;
        private DataGridView ViewRepair;
        private Label label6;
        private Panel panel2;
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
        private DataGridViewButtonColumn BtnDelete_Warehouse_;
        private DataGridViewButtonColumn SelectButton;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewTextBoxColumn Typ_column;
        private DataGridViewTextBoxColumn Nazwa_column_;
        private DataGridViewTextBoxColumn NumerCzęści_column;
        private DataGridViewTextBoxColumn Opis_Column_;
        private DataGridViewTextBoxColumn Ilość_column;
        private DataGridViewTextBoxColumn Cena_column;
        private DataGridViewTextBoxColumn Sum_Column;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewTextBoxColumn ID_Column_;
        private DataGridViewCheckBoxColumn Wykonane_Checked;
        private DataGridViewTextBoxColumn Type_Column;
        private DataGridViewTextBoxColumn Nazwa_Column;
        private DataGridViewTextBoxColumn Opis_Column;
        private DataGridViewTextBoxColumn NrCzęści_Column;
        private DataGridViewTextBoxColumn Cena_Column_;
        private DataGridViewTextBoxColumn Ilość_Column_;
        private DataGridViewTextBoxColumn Suma_Column;
        }
}