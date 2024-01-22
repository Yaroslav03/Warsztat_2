namespace Warsztat_2._0.UserControls.UC_CreateData
{
    partial class UC_AddOrderRepair
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            IloscNumericUpDown = new NumericUpDown();
            PriceNumericUpDown = new NumericUpDown();
            StanCheckBox = new CheckBox();
            label4 = new Label();
            label2 = new Label();
            ButtonOrderRepairSave = new Button();
            ViewHistoriRepair = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            VIN_label = new Label();
            ID_label = new Label();
            ViewCar = new DataGridView();
            panelDodatkowy = new Panel();
            NrPartTextBox = new TextBox();
            panel1 = new Panel();
            DescriptionTextBox = new TextBox();
            RepairTextBox = new TextBox();
            DiagnosticTextBox = new TextBox();
            OrderTextBox = new TextBox();
            AttentionLabel = new Label();
            Usuń = new DataGridViewButtonColumn();
            ID = new DataGridViewTextBoxColumn();
            Wykonane_Checked = new DataGridViewCheckBoxColumn();
            Naprawa_Column = new DataGridViewTextBoxColumn();
            Diagnostyka_Column = new DataGridViewTextBoxColumn();
            Zlecenie_Column = new DataGridViewTextBoxColumn();
            Opis_Column = new DataGridViewTextBoxColumn();
            NrCzęści_Column = new DataGridViewTextBoxColumn();
            Cena_Column = new DataGridViewTextBoxColumn();
            Ilość_Column = new DataGridViewTextBoxColumn();
            ID_Column = new DataGridViewTextBoxColumn();
            NrRejestracji_Column = new DataGridViewTextBoxColumn();
            Marka_Column = new DataGridViewTextBoxColumn();
            Model_Column = new DataGridViewTextBoxColumn();
            RokProdukcji_Column = new DataGridViewTextBoxColumn();
            VIN_Column = new DataGridViewTextBoxColumn();
            Przebieg_Column = new DataGridViewTextBoxColumn();
            DokumentySamochodu_Column = new DataGridViewCheckBoxColumn();
            KluczykiSamochodu_Column = new DataGridViewCheckBoxColumn();
            TestDrive_Column = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)IloscNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewHistoriRepair).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewCar).BeginInit();
            panelDodatkowy.SuspendLayout();
            SuspendLayout();
            // 
            // IloscNumericUpDown
            // 
            IloscNumericUpDown.BackColor = Color.White;
            IloscNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            IloscNumericUpDown.Location = new Point(854, 113);
            IloscNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            IloscNumericUpDown.Name = "IloscNumericUpDown";
            IloscNumericUpDown.Size = new Size(84, 23);
            IloscNumericUpDown.TabIndex = 25;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.BackColor = Color.White;
            PriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            PriceNumericUpDown.Location = new Point(764, 113);
            PriceNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(70, 23);
            PriceNumericUpDown.TabIndex = 25;
            // 
            // StanCheckBox
            // 
            StanCheckBox.AutoSize = true;
            StanCheckBox.Location = new Point(764, 163);
            StanCheckBox.Name = "StanCheckBox";
            StanCheckBox.Size = new Size(82, 19);
            StanCheckBox.TabIndex = 21;
            StanCheckBox.Text = "Wykonane";
            StanCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(868, 89);
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
            label2.Location = new Point(775, 89);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 1;
            label2.Text = "Cena";
            // 
            // ButtonOrderRepairSave
            // 
            ButtonOrderRepairSave.BackColor = Color.FromArgb(94, 148, 255);
            ButtonOrderRepairSave.FlatAppearance.BorderSize = 0;
            ButtonOrderRepairSave.FlatStyle = FlatStyle.Flat;
            ButtonOrderRepairSave.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonOrderRepairSave.ForeColor = Color.LightGray;
            ButtonOrderRepairSave.Location = new Point(896, 163);
            ButtonOrderRepairSave.Name = "ButtonOrderRepairSave";
            ButtonOrderRepairSave.Size = new Size(109, 30);
            ButtonOrderRepairSave.TabIndex = 22;
            ButtonOrderRepairSave.Text = "Zapisz";
            ButtonOrderRepairSave.UseVisualStyleBackColor = false;
            ButtonOrderRepairSave.Click += ButtonOrderRepairSave_Click;
            // 
            // ViewHistoriRepair
            // 
            ViewHistoriRepair.AllowUserToAddRows = false;
            ViewHistoriRepair.AllowUserToDeleteRows = false;
            ViewHistoriRepair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewHistoriRepair.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewHistoriRepair.BackgroundColor = Color.FromArgb(64, 64, 70);
            ViewHistoriRepair.BorderStyle = BorderStyle.None;
            ViewHistoriRepair.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ViewHistoriRepair.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewHistoriRepair.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewHistoriRepair.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewHistoriRepair.Columns.AddRange(new DataGridViewColumn[] { Usuń, ID, Wykonane_Checked, Naprawa_Column, Diagnostyka_Column, Zlecenie_Column, Opis_Column, NrCzęści_Column, Cena_Column, Ilość_Column });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ViewHistoriRepair.DefaultCellStyle = dataGridViewCellStyle3;
            ViewHistoriRepair.EnableHeadersVisualStyles = false;
            ViewHistoriRepair.Location = new Point(0, 406);
            ViewHistoriRepair.Name = "ViewHistoriRepair";
            ViewHistoriRepair.RowTemplate.Height = 25;
            ViewHistoriRepair.Size = new Size(1040, 174);
            ViewHistoriRepair.TabIndex = 23;
            // 
            // label6
            // 
            label6.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(12, 7);
            label6.Name = "label6";
            label6.Size = new Size(314, 28);
            label6.TabIndex = 25;
            label6.Text = "Dane zostaną przypisane do samochodu VIN:";
            // 
            // label5
            // 
            label5.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(417, 7);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 25;
            label5.Text = "Nr samochodu:";
            // 
            // VIN_label
            // 
            VIN_label.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            VIN_label.ForeColor = Color.FromArgb(224, 224, 224);
            VIN_label.Location = new Point(313, 7);
            VIN_label.Name = "VIN_label";
            VIN_label.Size = new Size(161, 27);
            VIN_label.TabIndex = 25;
            VIN_label.Text = "Brak";
            VIN_label.TextChanged += VIN_label_TextChanged;
            // 
            // ID_label
            // 
            ID_label.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ID_label.ForeColor = Color.FromArgb(224, 224, 224);
            ID_label.Location = new Point(525, 7);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(63, 28);
            ID_label.TabIndex = 25;
            ID_label.Text = "0";
            // 
            // ViewCar
            // 
            ViewCar.AllowUserToAddRows = false;
            ViewCar.AllowUserToDeleteRows = false;
            ViewCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewCar.BackgroundColor = Color.FromArgb(64, 64, 70);
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
            ViewCar.Columns.AddRange(new DataGridViewColumn[] { ID_Column, NrRejestracji_Column, Marka_Column, Model_Column, RokProdukcji_Column, VIN_Column, Przebieg_Column, DokumentySamochodu_Column, KluczykiSamochodu_Column, TestDrive_Column });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ViewCar.DefaultCellStyle = dataGridViewCellStyle6;
            ViewCar.EnableHeadersVisualStyles = false;
            ViewCar.Location = new Point(0, 3);
            ViewCar.Name = "ViewCar";
            ViewCar.RowTemplate.Height = 25;
            ViewCar.Size = new Size(1040, 150);
            ViewCar.TabIndex = 26;
            ViewCar.CellClick += ViewCar_CellClick;
            ViewCar.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panelDodatkowy
            // 
            panelDodatkowy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelDodatkowy.BackColor = Color.FromArgb(64, 64, 70);
            panelDodatkowy.BorderStyle = BorderStyle.FixedSingle;
            panelDodatkowy.Controls.Add(NrPartTextBox);
            panelDodatkowy.Controls.Add(panel1);
            panelDodatkowy.Controls.Add(ID_label);
            panelDodatkowy.Controls.Add(IloscNumericUpDown);
            panelDodatkowy.Controls.Add(label2);
            panelDodatkowy.Controls.Add(label5);
            panelDodatkowy.Controls.Add(label4);
            panelDodatkowy.Controls.Add(VIN_label);
            panelDodatkowy.Controls.Add(DescriptionTextBox);
            panelDodatkowy.Controls.Add(label6);
            panelDodatkowy.Controls.Add(RepairTextBox);
            panelDodatkowy.Controls.Add(ButtonOrderRepairSave);
            panelDodatkowy.Controls.Add(PriceNumericUpDown);
            panelDodatkowy.Controls.Add(StanCheckBox);
            panelDodatkowy.Controls.Add(DiagnosticTextBox);
            panelDodatkowy.Controls.Add(OrderTextBox);
            panelDodatkowy.ForeColor = Color.DimGray;
            panelDodatkowy.Location = new Point(0, 187);
            panelDodatkowy.Name = "panelDodatkowy";
            panelDodatkowy.Size = new Size(1019, 203);
            panelDodatkowy.TabIndex = 27;
            // 
            // NrPartTextBox
            // 
            NrPartTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NrPartTextBox.BorderStyle = BorderStyle.None;
            NrPartTextBox.CausesValidation = false;
            NrPartTextBox.Cursor = Cursors.IBeam;
            NrPartTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NrPartTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NrPartTextBox.Location = new Point(764, 37);
            NrPartTextBox.Name = "NrPartTextBox";
            NrPartTextBox.PlaceholderText = "Numer części";
            NrPartTextBox.Size = new Size(199, 23);
            NrPartTextBox.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Location = new Point(764, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 10);
            panel1.TabIndex = 27;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BackColor = Color.FromArgb(64, 64, 70);
            DescriptionTextBox.CausesValidation = false;
            DescriptionTextBox.Cursor = Cursors.IBeam;
            DescriptionTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            DescriptionTextBox.Location = new Point(576, 38);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.PlaceholderText = "Opis";
            DescriptionTextBox.Size = new Size(182, 144);
            DescriptionTextBox.TabIndex = 13;
            // 
            // RepairTextBox
            // 
            RepairTextBox.BackColor = Color.FromArgb(64, 64, 70);
            RepairTextBox.CausesValidation = false;
            RepairTextBox.Cursor = Cursors.IBeam;
            RepairTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RepairTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            RepairTextBox.Location = new Point(388, 38);
            RepairTextBox.Multiline = true;
            RepairTextBox.Name = "RepairTextBox";
            RepairTextBox.PlaceholderText = "Naprawa";
            RepairTextBox.Size = new Size(182, 144);
            RepairTextBox.TabIndex = 13;
            // 
            // DiagnosticTextBox
            // 
            DiagnosticTextBox.BackColor = Color.FromArgb(64, 64, 70);
            DiagnosticTextBox.CausesValidation = false;
            DiagnosticTextBox.Cursor = Cursors.IBeam;
            DiagnosticTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DiagnosticTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            DiagnosticTextBox.Location = new Point(200, 38);
            DiagnosticTextBox.Multiline = true;
            DiagnosticTextBox.Name = "DiagnosticTextBox";
            DiagnosticTextBox.PlaceholderText = "Diagnostyka";
            DiagnosticTextBox.Size = new Size(182, 144);
            DiagnosticTextBox.TabIndex = 13;
            // 
            // OrderTextBox
            // 
            OrderTextBox.BackColor = Color.FromArgb(64, 64, 70);
            OrderTextBox.CausesValidation = false;
            OrderTextBox.Cursor = Cursors.IBeam;
            OrderTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            OrderTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            OrderTextBox.Location = new Point(12, 38);
            OrderTextBox.Multiline = true;
            OrderTextBox.Name = "OrderTextBox";
            OrderTextBox.PlaceholderText = "Zlecenie";
            OrderTextBox.Size = new Size(182, 144);
            OrderTextBox.TabIndex = 13;
            // 
            // AttentionLabel
            // 
            AttentionLabel.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AttentionLabel.ForeColor = Color.FromArgb(224, 224, 224);
            AttentionLabel.Location = new Point(3, 156);
            AttentionLabel.Name = "AttentionLabel";
            AttentionLabel.Size = new Size(452, 28);
            AttentionLabel.TabIndex = 25;
            // 
            // Usuń
            // 
            Usuń.HeaderText = "Usuń";
            Usuń.Name = "Usuń";
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
            Wykonane_Checked.DataPropertyName = "Wykonane";
            Wykonane_Checked.HeaderText = "Wykonane";
            Wykonane_Checked.Name = "Wykonane_Checked";
            // 
            // Naprawa_Column
            // 
            Naprawa_Column.DataPropertyName = "Naprawa";
            Naprawa_Column.HeaderText = "Naprawa";
            Naprawa_Column.Name = "Naprawa_Column";
            // 
            // Diagnostyka_Column
            // 
            Diagnostyka_Column.DataPropertyName = "Diagnostyka";
            Diagnostyka_Column.HeaderText = "Diagnostyka";
            Diagnostyka_Column.Name = "Diagnostyka_Column";
            // 
            // Zlecenie_Column
            // 
            Zlecenie_Column.DataPropertyName = "Zlecenie";
            Zlecenie_Column.HeaderText = "Zlecenie";
            Zlecenie_Column.Name = "Zlecenie_Column";
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
            // ID_Column
            // 
            ID_Column.DataPropertyName = "ID";
            ID_Column.HeaderText = "ID";
            ID_Column.Name = "ID_Column";
            ID_Column.Visible = false;
            // 
            // NrRejestracji_Column
            // 
            NrRejestracji_Column.DataPropertyName = "NrRejestracji";
            NrRejestracji_Column.HeaderText = "Nr Rejestracji";
            NrRejestracji_Column.Name = "NrRejestracji_Column";
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
            // Przebieg_Column
            // 
            Przebieg_Column.DataPropertyName = "Przebieg";
            Przebieg_Column.HeaderText = "Przebieg";
            Przebieg_Column.Name = "Przebieg_Column";
            // 
            // DokumentySamochodu_Column
            // 
            DokumentySamochodu_Column.DataPropertyName = "DokumentySamochodu";
            DokumentySamochodu_Column.HeaderText = "Dokumenty Samochodu";
            DokumentySamochodu_Column.Name = "DokumentySamochodu_Column";
            DokumentySamochodu_Column.Resizable = DataGridViewTriState.True;
            DokumentySamochodu_Column.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // KluczykiSamochodu_Column
            // 
            KluczykiSamochodu_Column.DataPropertyName = "KluczykiSamochodu";
            KluczykiSamochodu_Column.HeaderText = "Kluczyki";
            KluczykiSamochodu_Column.Name = "KluczykiSamochodu_Column";
            KluczykiSamochodu_Column.Resizable = DataGridViewTriState.True;
            KluczykiSamochodu_Column.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TestDrive_Column
            // 
            TestDrive_Column.DataPropertyName = "TestDrive";
            TestDrive_Column.HeaderText = "TestDrive";
            TestDrive_Column.Name = "TestDrive_Column";
            TestDrive_Column.Resizable = DataGridViewTriState.True;
            TestDrive_Column.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // UC_AddOrderRepair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panelDodatkowy);
            Controls.Add(ViewCar);
            Controls.Add(AttentionLabel);
            Controls.Add(ViewHistoriRepair);
            Name = "UC_AddOrderRepair";
            Size = new Size(1040, 580);
            Load += UC_AddOrderRepair_Load;
            ((System.ComponentModel.ISupportInitialize)IloscNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewHistoriRepair).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewCar).EndInit();
            panelDodatkowy.ResumeLayout(false);
            panelDodatkowy.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label4;
        private CheckBox StanCheckBox;
        private Button ButtonOrderRepairSave;
        private DataGridView ViewHistoriRepair;
        private NumericUpDown IloscNumericUpDown;
        private NumericUpDown PriceNumericUpDown;
        private Label label6;
        private Label label5;
        private Label VIN_label;
        private Label ID_label;
        private DataGridView ViewCar;
        private Panel panelDodatkowy;
        private TextBox OrderTextBox;
        private TextBox DescriptionTextBox;
        private TextBox RepairTextBox;
        private TextBox DiagnosticTextBox;
        private TextBox NrPartTextBox;
        private Panel panel1;
        private Label AttentionLabel;
        private DataGridViewButtonColumn Usuń;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewCheckBoxColumn Wykonane_Checked;
        private DataGridViewTextBoxColumn Naprawa_Column;
        private DataGridViewTextBoxColumn Diagnostyka_Column;
        private DataGridViewTextBoxColumn Zlecenie_Column;
        private DataGridViewTextBoxColumn Opis_Column;
        private DataGridViewTextBoxColumn NrCzęści_Column;
        private DataGridViewTextBoxColumn Cena_Column;
        private DataGridViewTextBoxColumn Ilość_Column;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewTextBoxColumn NrRejestracji_Column;
        private DataGridViewTextBoxColumn Marka_Column;
        private DataGridViewTextBoxColumn Model_Column;
        private DataGridViewTextBoxColumn RokProdukcji_Column;
        private DataGridViewTextBoxColumn VIN_Column;
        private DataGridViewTextBoxColumn Przebieg_Column;
        private DataGridViewCheckBoxColumn DokumentySamochodu_Column;
        private DataGridViewCheckBoxColumn KluczykiSamochodu_Column;
        private DataGridViewCheckBoxColumn TestDrive_Column;
    }
}
