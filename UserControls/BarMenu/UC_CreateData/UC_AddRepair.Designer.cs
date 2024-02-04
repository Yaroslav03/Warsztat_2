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
            ButtonOrderRepairSave = new Button();
            ViewRepair = new DataGridView();
            Usuń = new DataGridViewButtonColumn();
            ID = new DataGridViewTextBoxColumn();
            Wykonane_Checked = new DataGridViewCheckBoxColumn();
            Opis_Column = new DataGridViewTextBoxColumn();
            NrCzęści_Column = new DataGridViewTextBoxColumn();
            Cena_Column = new DataGridViewTextBoxColumn();
            Ilość_Column = new DataGridViewTextBoxColumn();
            label6 = new Label();
            VIN_label = new Label();
            ViewCar = new DataGridView();
            ID_Column = new DataGridViewTextBoxColumn();
            Marka_Column = new DataGridViewTextBoxColumn();
            Model_Column = new DataGridViewTextBoxColumn();
            RokProdukcji_Column = new DataGridViewTextBoxColumn();
            VIN_Column = new DataGridViewTextBoxColumn();
            panelDodatkowy = new Panel();
            NrPartTextBox = new TextBox();
            panel1 = new Panel();
            DescriptionTextBox = new TextBox();
            AttentionLabel = new Label();
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
            IloscNumericUpDown.Location = new Point(102, 190);
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
            PriceNumericUpDown.Location = new Point(12, 190);
            PriceNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(70, 23);
            PriceNumericUpDown.TabIndex = 25;
            // 
            // StanCheckBox
            // 
            StanCheckBox.AutoSize = true;
            StanCheckBox.Location = new Point(12, 229);
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
            label4.Location = new Point(116, 166);
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
            label2.Location = new Point(23, 166);
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
            ButtonOrderRepairSave.Location = new Point(12, 3);
            ButtonOrderRepairSave.Name = "ButtonOrderRepairSave";
            ButtonOrderRepairSave.Size = new Size(239, 30);
            ButtonOrderRepairSave.TabIndex = 22;
            ButtonOrderRepairSave.Text = "Zapisz";
            ButtonOrderRepairSave.UseVisualStyleBackColor = false;
            ButtonOrderRepairSave.Click += ButtonOrderRepairSave_Click;
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
            ViewRepair.Columns.AddRange(new DataGridViewColumn[] { Usuń, ID, Wykonane_Checked, Opis_Column, NrCzęści_Column, Cena_Column, Ilość_Column });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(100, 88, 255);
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
            // label6
            // 
            label6.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(3, 271);
            label6.Name = "label6";
            label6.Size = new Size(314, 28);
            label6.TabIndex = 25;
            label6.Text = "Dane zostaną przypisane do samochodu VIN:";
            // 
            // VIN_label
            // 
            VIN_label.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            VIN_label.ForeColor = Color.FromArgb(224, 224, 224);
            VIN_label.Location = new Point(311, 271);
            VIN_label.Name = "VIN_label";
            VIN_label.Size = new Size(161, 27);
            VIN_label.TabIndex = 25;
            VIN_label.Text = "Brak";
            VIN_label.TextChanged += VIN_label_TextChanged;
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
            panelDodatkowy.Controls.Add(NrPartTextBox);
            panelDodatkowy.Controls.Add(panel1);
            panelDodatkowy.Controls.Add(IloscNumericUpDown);
            panelDodatkowy.Controls.Add(label2);
            panelDodatkowy.Controls.Add(ButtonOrderRepairSave);
            panelDodatkowy.Controls.Add(label4);
            panelDodatkowy.Controls.Add(DescriptionTextBox);
            panelDodatkowy.Controls.Add(PriceNumericUpDown);
            panelDodatkowy.Controls.Add(StanCheckBox);
            panelDodatkowy.ForeColor = Color.DimGray;
            panelDodatkowy.Location = new Point(784, 3);
            panelDodatkowy.Name = "panelDodatkowy";
            panelDodatkowy.Size = new Size(256, 261);
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
            NrPartTextBox.Location = new Point(12, 108);
            NrPartTextBox.Name = "NrPartTextBox";
            NrPartTextBox.PlaceholderText = "Numer części";
            NrPartTextBox.Size = new Size(199, 23);
            NrPartTextBox.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Location = new Point(12, 134);
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
            DescriptionTextBox.Location = new Point(12, 52);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.PlaceholderText = "Opis";
            DescriptionTextBox.Size = new Size(182, 30);
            DescriptionTextBox.TabIndex = 13;
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
            // UC_AddRepair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panelDodatkowy);
            Controls.Add(ViewCar);
            Controls.Add(AttentionLabel);
            Controls.Add(ViewRepair);
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
        private Button ButtonOrderRepairSave;
        private DataGridView ViewRepair;
        private NumericUpDown IloscNumericUpDown;
        private NumericUpDown PriceNumericUpDown;
        private Label label6;
        private Label VIN_label;
        private DataGridView ViewCar;
        private Panel panelDodatkowy;
        private TextBox DescriptionTextBox;
        private TextBox NrPartTextBox;
        private Panel panel1;
        private Label AttentionLabel;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewTextBoxColumn Marka_Column;
        private DataGridViewTextBoxColumn Model_Column;
        private DataGridViewTextBoxColumn RokProdukcji_Column;
        private DataGridViewTextBoxColumn VIN_Column;
        private DataGridViewButtonColumn Usuń;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewCheckBoxColumn Wykonane_Checked;
        private DataGridViewTextBoxColumn Opis_Column;
        private DataGridViewTextBoxColumn NrCzęści_Column;
        private DataGridViewTextBoxColumn Cena_Column;
        private DataGridViewTextBoxColumn Ilość_Column;
    }
}
