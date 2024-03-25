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
            Opis_Column = new DataGridViewTextBoxColumn();
            NrCzęści_Column = new DataGridViewTextBoxColumn();
            Cena_Column = new DataGridViewTextBoxColumn();
            Ilość_Column = new DataGridViewTextBoxColumn();
            Suma_Column = new DataGridViewTextBoxColumn();
            DateRepair = new DataGridViewTextBoxColumn();
            label6 = new Label();
            VIN_label = new Label();
            ViewCar = new DataGridView();
            ID_Column = new DataGridViewTextBoxColumn();
            Marka_Column = new DataGridViewTextBoxColumn();
            Model_Column = new DataGridViewTextBoxColumn();
            RokProdukcji_Column = new DataGridViewTextBoxColumn();
            VIN_Column = new DataGridViewTextBoxColumn();
            panelDodatkowy = new Panel();
            SumLabel = new Label();
            label5 = new Label();
            label3 = new Label();
            NrPartTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            RepairTimePicker = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)IloscNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewRepair).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewCar).BeginInit();
            panelDodatkowy.SuspendLayout();
            SuspendLayout();
            // 
            // IloscNumericUpDown
            // 
            IloscNumericUpDown.BackColor = Color.White;
            IloscNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            IloscNumericUpDown.Location = new Point(96, 190);
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
            PriceNumericUpDown.BackColor = Color.White;
            PriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PriceNumericUpDown.DecimalPlaces = 2;
            PriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            PriceNumericUpDown.Location = new Point(3, 190);
            PriceNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(70, 23);
            PriceNumericUpDown.TabIndex = 2;
            PriceNumericUpDown.ValueChanged += PriceNumericUpDown_ValueChanged;
            // 
            // StanCheckBox
            // 
            StanCheckBox.AutoSize = true;
            StanCheckBox.Location = new Point(12, 229);
            StanCheckBox.Name = "StanCheckBox";
            StanCheckBox.Size = new Size(82, 19);
            StanCheckBox.TabIndex = 4;
            StanCheckBox.Text = "Wykonane";
            StanCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(111, 166);
            label4.Name = "label4";
            label4.Size = new Size(41, 21);
            label4.TabIndex = 1;
            label4.Text = "Ilość";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(12, 166);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 1;
            label2.Text = "Cena";
            // 
            // ButtonRepairSave
            // 
            ButtonRepairSave.BackColor = Color.FromArgb(94, 148, 255);
            ButtonRepairSave.FlatAppearance.BorderSize = 0;
            ButtonRepairSave.FlatStyle = FlatStyle.Flat;
            ButtonRepairSave.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRepairSave.ForeColor = Color.LightGray;
            ButtonRepairSave.Location = new Point(12, 3);
            ButtonRepairSave.Name = "ButtonRepairSave";
            ButtonRepairSave.Size = new Size(239, 30);
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
            ViewRepair.Columns.AddRange(new DataGridViewColumn[] { BtnDelete, ID, Wykonane_Checked, Opis_Column, NrCzęści_Column, Cena_Column, Ilość_Column, Suma_Column, DateRepair });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ViewRepair.DefaultCellStyle = dataGridViewCellStyle3;
            ViewRepair.EnableHeadersVisualStyles = false;
            ViewRepair.Location = new Point(0, 305);
            ViewRepair.Name = "ViewRepair";
            ViewRepair.RowTemplate.Height = 25;
            ViewRepair.Size = new Size(1040, 275);
            ViewRepair.TabIndex = 23;
            ViewRepair.CellContentClick += ViewRepair_CellContentClick;
            ViewRepair.MouseDoubleClick += ViewRepair_MouseDoubleClick;
            // 
            // BtnDelete
            // 
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
            Wykonane_Checked.HeaderText = "Wykonane";
            Wykonane_Checked.Name = "Wykonane_Checked";
            Wykonane_Checked.TrueValue = "1";
            // 
            // Opis_Column
            // 
            Opis_Column.DataPropertyName = "Opis";
            Opis_Column.HeaderText = "Opis";
            Opis_Column.Name = "Opis_Column";
            // 
            // NrCzęści_Column
            // 
            NrCzęści_Column.DataPropertyName = "NumerCzęści";
            NrCzęści_Column.HeaderText = "Numer Części";
            NrCzęści_Column.Name = "NrCzęści_Column";
            // 
            // Cena_Column
            // 
            Cena_Column.DataPropertyName = "Cena";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            Cena_Column.DefaultCellStyle = dataGridViewCellStyle2;
            Cena_Column.HeaderText = "Cena";
            Cena_Column.Name = "Cena_Column";
            // 
            // Ilość_Column
            // 
            Ilość_Column.DataPropertyName = "Ilość";
            Ilość_Column.HeaderText = "Ilość";
            Ilość_Column.Name = "Ilość_Column";
            // 
            // Suma_Column
            // 
            Suma_Column.DataPropertyName = "Suma";
            Suma_Column.HeaderText = "Suma";
            Suma_Column.Name = "Suma_Column";
            // 
            // DateRepair
            // 
            DateRepair.DataPropertyName = "DataNapraw";
            DateRepair.HeaderText = "DataNapraw";
            DateRepair.Name = "DateRepair";
            // 
            // label6
            // 
            label6.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(3, 271);
            label6.Name = "label6";
            label6.Size = new Size(302, 28);
            label6.TabIndex = 25;
            label6.Text = "Dane zostaną przypisane do samochodu VIN:";
            // 
            // VIN_label
            // 
            VIN_label.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            VIN_label.ForeColor = Color.FromArgb(224, 224, 224);
            VIN_label.Location = new Point(311, 271);
            VIN_label.Name = "VIN_label";
            VIN_label.Size = new Size(187, 27);
            VIN_label.TabIndex = 25;
            VIN_label.Text = "Brak";
            VIN_label.Click += VIN_label_Click;
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
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ViewCar.DefaultCellStyle = dataGridViewCellStyle6;
            ViewCar.EnableHeadersVisualStyles = false;
            ViewCar.Location = new Point(0, 0);
            ViewCar.Name = "ViewCar";
            ViewCar.RowTemplate.Height = 25;
            ViewCar.Size = new Size(766, 252);
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
            panelDodatkowy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelDodatkowy.BackColor = Color.FromArgb(64, 64, 70);
            panelDodatkowy.BorderStyle = BorderStyle.FixedSingle;
            panelDodatkowy.Controls.Add(IloscNumericUpDown);
            panelDodatkowy.Controls.Add(label2);
            panelDodatkowy.Controls.Add(ButtonRepairSave);
            panelDodatkowy.Controls.Add(SumLabel);
            panelDodatkowy.Controls.Add(label5);
            panelDodatkowy.Controls.Add(label3);
            panelDodatkowy.Controls.Add(label4);
            panelDodatkowy.Controls.Add(NrPartTextBox);
            panelDodatkowy.Controls.Add(DescriptionTextBox);
            panelDodatkowy.Controls.Add(PriceNumericUpDown);
            panelDodatkowy.Controls.Add(StanCheckBox);
            panelDodatkowy.ForeColor = Color.DimGray;
            panelDodatkowy.Location = new Point(784, 3);
            panelDodatkowy.Name = "panelDodatkowy";
            panelDodatkowy.Size = new Size(256, 261);
            panelDodatkowy.TabIndex = 27;
            // 
            // SumLabel
            // 
            SumLabel.AutoSize = true;
            SumLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SumLabel.ForeColor = Color.FromArgb(224, 224, 224);
            SumLabel.Location = new Point(203, 192);
            SumLabel.Name = "SumLabel";
            SumLabel.Size = new Size(19, 21);
            SumLabel.TabIndex = 1;
            SumLabel.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(182, 192);
            label5.Name = "label5";
            label5.Size = new Size(21, 21);
            label5.TabIndex = 1;
            label5.Text = "=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(77, 192);
            label3.Name = "label3";
            label3.Size = new Size(17, 21);
            label3.TabIndex = 1;
            label3.Text = "*";
            // 
            // NrPartTextBox
            // 
            NrPartTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NrPartTextBox.CausesValidation = false;
            NrPartTextBox.Cursor = Cursors.IBeam;
            NrPartTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NrPartTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NrPartTextBox.Location = new Point(12, 109);
            NrPartTextBox.Name = "NrPartTextBox";
            NrPartTextBox.PlaceholderText = "Numer części";
            NrPartTextBox.Size = new Size(227, 30);
            NrPartTextBox.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BackColor = Color.FromArgb(64, 64, 70);
            DescriptionTextBox.CausesValidation = false;
            DescriptionTextBox.Cursor = Cursors.IBeam;
            DescriptionTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            DescriptionTextBox.Location = new Point(12, 52);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.PlaceholderText = "Opis";
            DescriptionTextBox.Size = new Size(227, 30);
            DescriptionTextBox.TabIndex = 0;
            // 
            // RepairTimePicker
            // 
            RepairTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RepairTimePicker.CalendarMonthBackground = Color.FromArgb(94, 148, 255);
            RepairTimePicker.CalendarTitleBackColor = SystemColors.ControlText;
            RepairTimePicker.CalendarTitleForeColor = Color.FromArgb(94, 148, 255);
            RepairTimePicker.Cursor = Cursors.Hand;
            RepairTimePicker.CustomFormat = "";
            RepairTimePicker.Location = new Point(527, 271);
            RepairTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            RepairTimePicker.Name = "RepairTimePicker";
            RepairTimePicker.Size = new Size(239, 23);
            RepairTimePicker.TabIndex = 5;
            RepairTimePicker.Value = new DateTime(2024, 1, 16, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(818, 270);
            label1.Name = "label1";
            label1.Size = new Size(170, 28);
            label1.TabIndex = 25;
            label1.Text = "Zarządzenie Zleceniem";
            // 
            // UC_AddRepair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(RepairTimePicker);
            Controls.Add(panelDodatkowy);
            Controls.Add(ViewCar);
            Controls.Add(ViewRepair);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(VIN_label);
            Name = "UC_AddRepair";
            Size = new Size(1040, 580);
            Load += UC_AddOrderRepair_Load;
            ((System.ComponentModel.ISupportInitialize)IloscNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewRepair).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewCar).EndInit();
            panelDodatkowy.ResumeLayout(false);
            panelDodatkowy.PerformLayout();
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
        private Label label6;
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
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewCheckBoxColumn Wykonane_Checked;
        private DataGridViewTextBoxColumn Opis_Column;
        private DataGridViewTextBoxColumn NrCzęści_Column;
        private DataGridViewTextBoxColumn Cena_Column;
        private DataGridViewTextBoxColumn Ilość_Column;
        private DataGridViewTextBoxColumn Suma_Column;
        private DataGridViewTextBoxColumn DateRepair;
    }
}
