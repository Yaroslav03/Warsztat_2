namespace Warsztat_2._0.UserControls
{
    partial class UC_Settings
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label4 = new Label();
            panel1 = new Panel();
            SaveDataButton = new Button();
            MarzaTextBox = new TextBox();
            NrTelefonuTextBox = new TextBox();
            NIPTextBox = new TextBox();
            AdresFirmyTextBox = new TextBox();
            KontoBankoweTextBox = new TextBox();
            NumerBDOTextBox = new TextBox();
            NazwaFirmyTextBox = new TextBox();
            label13 = new Label();
            panel2 = new Panel();
            label12 = new Label();
            NumerTelefonuTextBox = new MaskedTextBox();
            ViewEmployers = new DataGridView();
            ID_Column = new DataGridViewTextBoxColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ArchiveBtn = new DataGridViewButtonColumn();
            Name_Column = new DataGridViewTextBoxColumn();
            Surname_Column = new DataGridViewTextBoxColumn();
            Telephone_Column = new DataGridViewTextBoxColumn();
            Stanowisko_Column = new DataGridViewTextBoxColumn();
            Earning_Column = new DataGridViewTextBoxColumn();
            DateOfEmployment_Column = new DataGridViewTextBoxColumn();
            EarningPriceNumericUpDown = new NumericUpDown();
            DateOfEmploymentTimePicker = new DateTimePicker();
            label1 = new Label();
            StanowiskoSelect = new ComboBox();
            EmployerAddButton = new Button();
            SurnameTextBox = new TextBox();
            ImiePracownikaTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewEmployers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EarningPriceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(384, 43);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 15;
            label4.Text = "Stanowisko";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(64, 64, 70);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(SaveDataButton);
            panel1.Controls.Add(MarzaTextBox);
            panel1.Controls.Add(NrTelefonuTextBox);
            panel1.Controls.Add(NIPTextBox);
            panel1.Controls.Add(AdresFirmyTextBox);
            panel1.Controls.Add(KontoBankoweTextBox);
            panel1.Controls.Add(NumerBDOTextBox);
            panel1.Controls.Add(NazwaFirmyTextBox);
            panel1.Controls.Add(label13);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 190);
            panel1.TabIndex = 29;
            // 
            // SaveDataButton
            // 
            SaveDataButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SaveDataButton.BackColor = Color.FromArgb(94, 148, 255);
            SaveDataButton.FlatAppearance.BorderSize = 0;
            SaveDataButton.FlatStyle = FlatStyle.Flat;
            SaveDataButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDataButton.ForeColor = Color.LightGray;
            SaveDataButton.Location = new Point(830, 151);
            SaveDataButton.Name = "SaveDataButton";
            SaveDataButton.Size = new Size(125, 30);
            SaveDataButton.TabIndex = 7;
            SaveDataButton.Text = "Zapisz";
            SaveDataButton.UseVisualStyleBackColor = false;
            SaveDataButton.Click += SaveDataButton_Click;
            // 
            // MarzaTextBox
            // 
            MarzaTextBox.BackColor = Color.FromArgb(64, 64, 70);
            MarzaTextBox.CausesValidation = false;
            MarzaTextBox.Cursor = Cursors.IBeam;
            MarzaTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MarzaTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            MarzaTextBox.Location = new Point(797, 102);
            MarzaTextBox.Name = "MarzaTextBox";
            MarzaTextBox.PlaceholderText = "Marża";
            MarzaTextBox.Size = new Size(181, 30);
            MarzaTextBox.TabIndex = 6;
            // 
            // NrTelefonuTextBox
            // 
            NrTelefonuTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NrTelefonuTextBox.CausesValidation = false;
            NrTelefonuTextBox.Cursor = Cursors.IBeam;
            NrTelefonuTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NrTelefonuTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NrTelefonuTextBox.Location = new Point(802, 38);
            NrTelefonuTextBox.Name = "NrTelefonuTextBox";
            NrTelefonuTextBox.PlaceholderText = "Nr. Telefonu";
            NrTelefonuTextBox.Size = new Size(176, 30);
            NrTelefonuTextBox.TabIndex = 3;
            // 
            // NIPTextBox
            // 
            NIPTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NIPTextBox.CausesValidation = false;
            NIPTextBox.Cursor = Cursors.IBeam;
            NIPTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NIPTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NIPTextBox.Location = new Point(576, 38);
            NIPTextBox.Name = "NIPTextBox";
            NIPTextBox.PlaceholderText = "NIP";
            NIPTextBox.Size = new Size(201, 30);
            NIPTextBox.TabIndex = 2;
            // 
            // AdresFirmyTextBox
            // 
            AdresFirmyTextBox.BackColor = Color.FromArgb(64, 64, 70);
            AdresFirmyTextBox.CausesValidation = false;
            AdresFirmyTextBox.Cursor = Cursors.IBeam;
            AdresFirmyTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AdresFirmyTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            AdresFirmyTextBox.Location = new Point(229, 38);
            AdresFirmyTextBox.Name = "AdresFirmyTextBox";
            AdresFirmyTextBox.PlaceholderText = "Adres Firmy";
            AdresFirmyTextBox.Size = new Size(326, 30);
            AdresFirmyTextBox.TabIndex = 1;
            // 
            // KontoBankoweTextBox
            // 
            KontoBankoweTextBox.BackColor = Color.FromArgb(64, 64, 70);
            KontoBankoweTextBox.CausesValidation = false;
            KontoBankoweTextBox.Cursor = Cursors.IBeam;
            KontoBankoweTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            KontoBankoweTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            KontoBankoweTextBox.Location = new Point(395, 102);
            KontoBankoweTextBox.Name = "KontoBankoweTextBox";
            KontoBankoweTextBox.PlaceholderText = "Konto Bankowe";
            KontoBankoweTextBox.Size = new Size(326, 30);
            KontoBankoweTextBox.TabIndex = 5;
            // 
            // NumerBDOTextBox
            // 
            NumerBDOTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NumerBDOTextBox.CausesValidation = false;
            NumerBDOTextBox.Cursor = Cursors.IBeam;
            NumerBDOTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NumerBDOTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NumerBDOTextBox.Location = new Point(16, 102);
            NumerBDOTextBox.Name = "NumerBDOTextBox";
            NumerBDOTextBox.PlaceholderText = "Numer BDO";
            NumerBDOTextBox.Size = new Size(307, 30);
            NumerBDOTextBox.TabIndex = 4;
            // 
            // NazwaFirmyTextBox
            // 
            NazwaFirmyTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NazwaFirmyTextBox.CausesValidation = false;
            NazwaFirmyTextBox.Cursor = Cursors.IBeam;
            NazwaFirmyTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NazwaFirmyTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NazwaFirmyTextBox.Location = new Point(16, 38);
            NazwaFirmyTextBox.Name = "NazwaFirmyTextBox";
            NazwaFirmyTextBox.PlaceholderText = "Nazwa";
            NazwaFirmyTextBox.Size = new Size(171, 30);
            NazwaFirmyTextBox.TabIndex = 0;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(396, 9);
            label13.Name = "label13";
            label13.Size = new Size(159, 28);
            label13.TabIndex = 0;
            label13.Text = "Dane Firmy";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(64, 64, 70);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label12);
            panel2.Controls.Add(NumerTelefonuTextBox);
            panel2.Controls.Add(ViewEmployers);
            panel2.Controls.Add(EarningPriceNumericUpDown);
            panel2.Controls.Add(DateOfEmploymentTimePicker);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(StanowiskoSelect);
            panel2.Controls.Add(EmployerAddButton);
            panel2.Controls.Add(SurnameTextBox);
            panel2.Controls.Add(ImiePracownikaTextBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.ForeColor = Color.DimGray;
            panel2.Location = new Point(0, 269);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 374);
            panel2.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(224, 224, 224);
            label12.Location = new Point(197, 38);
            label12.Name = "label12";
            label12.Size = new Size(142, 24);
            label12.TabIndex = 44;
            label12.Text = "Telefon komórkowy:";
            // 
            // NumerTelefonuTextBox
            // 
            NumerTelefonuTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NumerTelefonuTextBox.BorderStyle = BorderStyle.FixedSingle;
            NumerTelefonuTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NumerTelefonuTextBox.ForeColor = Color.LightGray;
            NumerTelefonuTextBox.Location = new Point(197, 65);
            NumerTelefonuTextBox.Mask = "000-000-000";
            NumerTelefonuTextBox.Name = "NumerTelefonuTextBox";
            NumerTelefonuTextBox.Size = new Size(126, 30);
            NumerTelefonuTextBox.TabIndex = 43;
            // 
            // ViewEmployers
            // 
            ViewEmployers.AllowUserToAddRows = false;
            ViewEmployers.AllowUserToDeleteRows = false;
            ViewEmployers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ViewEmployers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewEmployers.BorderStyle = BorderStyle.None;
            ViewEmployers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewEmployers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewEmployers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewEmployers.Columns.AddRange(new DataGridViewColumn[] { ID_Column, BtnDelete, ArchiveBtn, Name_Column, Surname_Column, Telephone_Column, Stanowisko_Column, Earning_Column, DateOfEmployment_Column });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ViewEmployers.DefaultCellStyle = dataGridViewCellStyle2;
            ViewEmployers.EnableHeadersVisualStyles = false;
            ViewEmployers.Location = new Point(3, 118);
            ViewEmployers.Name = "ViewEmployers";
            ViewEmployers.RowTemplate.Height = 25;
            ViewEmployers.Size = new Size(1008, 251);
            ViewEmployers.TabIndex = 42;
            ViewEmployers.CellContentClick += ViewEmployers_CellContentClick;
            // 
            // ID_Column
            // 
            ID_Column.DataPropertyName = "ID";
            ID_Column.HeaderText = "ID";
            ID_Column.Name = "ID_Column";
            ID_Column.Visible = false;
            // 
            // BtnDelete
            // 
            BtnDelete.FillWeight = 50F;
            BtnDelete.HeaderText = "Usuń";
            BtnDelete.Name = "BtnDelete";
            // 
            // ArchiveBtn
            // 
            ArchiveBtn.FillWeight = 50F;
            ArchiveBtn.HeaderText = "Archiwum";
            ArchiveBtn.Name = "ArchiveBtn";
            // 
            // Name_Column
            // 
            Name_Column.DataPropertyName = "Imię";
            Name_Column.HeaderText = "Imię";
            Name_Column.Name = "Name_Column";
            // 
            // Surname_Column
            // 
            Surname_Column.DataPropertyName = "Nazwisko";
            Surname_Column.HeaderText = "Nazwisko";
            Surname_Column.Name = "Surname_Column";
            // 
            // Telephone_Column
            // 
            Telephone_Column.DataPropertyName = "Telefon";
            Telephone_Column.HeaderText = "Nr. Telefonu";
            Telephone_Column.Name = "Telephone_Column";
            // 
            // Stanowisko_Column
            // 
            Stanowisko_Column.DataPropertyName = "Stanowisko";
            Stanowisko_Column.HeaderText = "Stanowisko";
            Stanowisko_Column.Name = "Stanowisko_Column";
            // 
            // Earning_Column
            // 
            Earning_Column.DataPropertyName = "Zarobek";
            Earning_Column.HeaderText = "Pensja miesięczna";
            Earning_Column.Name = "Earning_Column";
            // 
            // DateOfEmployment_Column
            // 
            DateOfEmployment_Column.DataPropertyName = "DataZatrudnienia";
            DateOfEmployment_Column.HeaderText = "Data zatrudnienia";
            DateOfEmployment_Column.Name = "DateOfEmployment_Column";
            // 
            // EarningPriceNumericUpDown
            // 
            EarningPriceNumericUpDown.BackColor = Color.White;
            EarningPriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            EarningPriceNumericUpDown.DecimalPlaces = 2;
            EarningPriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            EarningPriceNumericUpDown.Location = new Point(564, 73);
            EarningPriceNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            EarningPriceNumericUpDown.Name = "EarningPriceNumericUpDown";
            EarningPriceNumericUpDown.Size = new Size(90, 23);
            EarningPriceNumericUpDown.TabIndex = 41;
            // 
            // DateOfEmploymentTimePicker
            // 
            DateOfEmploymentTimePicker.Format = DateTimePickerFormat.Short;
            DateOfEmploymentTimePicker.Location = new Point(690, 75);
            DateOfEmploymentTimePicker.Name = "DateOfEmploymentTimePicker";
            DateOfEmploymentTimePicker.Size = new Size(106, 23);
            DateOfEmploymentTimePicker.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(687, 51);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 39;
            label1.Text = "Data zatrudnienia";
            // 
            // StanowiskoSelect
            // 
            StanowiskoSelect.BackColor = Color.FromArgb(94, 148, 255);
            StanowiskoSelect.FlatStyle = FlatStyle.Flat;
            StanowiskoSelect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StanowiskoSelect.ForeColor = Color.FromArgb(68, 88, 112);
            StanowiskoSelect.FormattingEnabled = true;
            StanowiskoSelect.Items.AddRange(new object[] { "Elektronik", "Elektryk", "Mechanik", "Mechatronik", "Programista" });
            StanowiskoSelect.Location = new Point(384, 67);
            StanowiskoSelect.Name = "StanowiskoSelect";
            StanowiskoSelect.Size = new Size(160, 29);
            StanowiskoSelect.TabIndex = 3;
            // 
            // EmployerAddButton
            // 
            EmployerAddButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmployerAddButton.BackColor = Color.FromArgb(94, 148, 255);
            EmployerAddButton.FlatAppearance.BorderSize = 0;
            EmployerAddButton.FlatStyle = FlatStyle.Flat;
            EmployerAddButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EmployerAddButton.ForeColor = Color.LightGray;
            EmployerAddButton.Location = new Point(830, 68);
            EmployerAddButton.Name = "EmployerAddButton";
            EmployerAddButton.Size = new Size(181, 30);
            EmployerAddButton.TabIndex = 4;
            EmployerAddButton.Text = "Dodaj Pracownika";
            EmployerAddButton.UseVisualStyleBackColor = false;
            EmployerAddButton.Click += EmployerAddButton_Click;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.BackColor = Color.FromArgb(64, 64, 70);
            SurnameTextBox.CausesValidation = false;
            SurnameTextBox.Cursor = Cursors.IBeam;
            SurnameTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            SurnameTextBox.Location = new Point(10, 65);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.PlaceholderText = "Nazwisko";
            SurnameTextBox.Size = new Size(181, 30);
            SurnameTextBox.TabIndex = 1;
            // 
            // ImiePracownikaTextBox
            // 
            ImiePracownikaTextBox.BackColor = Color.FromArgb(64, 64, 70);
            ImiePracownikaTextBox.CausesValidation = false;
            ImiePracownikaTextBox.Cursor = Cursors.IBeam;
            ImiePracownikaTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ImiePracownikaTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            ImiePracownikaTextBox.Location = new Point(10, 29);
            ImiePracownikaTextBox.Name = "ImiePracownikaTextBox";
            ImiePracownikaTextBox.PlaceholderText = "Imię";
            ImiePracownikaTextBox.Size = new Size(181, 30);
            ImiePracownikaTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(371, 6);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 0;
            label2.Text = "Pracownicy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(547, 49);
            label3.Name = "label3";
            label3.Size = new Size(134, 21);
            label3.TabIndex = 15;
            label3.Text = "Pensja miesięczna";
            // 
            // UC_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_Settings";
            Size = new Size(1019, 643);
            Load += UC_Settings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewEmployers).EndInit();
            ((System.ComponentModel.ISupportInitialize)EarningPriceNumericUpDown).EndInit();
            ResumeLayout(false);
            }

        #endregion
        private Label label4;
        private TextBox MarzaTextBox;
        private TextBox KontoBankoweTextBox;
        private TextBox NrTelefonuTextBox;
        private TextBox NIPTextBox;
        private TextBox AdresFirmyTextBox;
        private TextBox NazwaFirmyTextBox;
        private Panel panel1;
        private Label label13;
        private TextBox NumerBDOTextBox;
        private Button SaveDataButton;
        private Panel panel2;
        private Label label2;
        private Button EmployerAddButton;
        private TextBox ImiePracownikaTextBox;
        private ComboBox StanowiskoSelect;
        private DateTimePicker DateOfEmploymentTimePicker;
        private Label label1;
        private NumericUpDown EarningPriceNumericUpDown;
        private Label label3;
        private DataGridView ViewEmployers;
        private TextBox SurnameTextBox;
        public MaskedTextBox NumerTelefonuTextBox;
        private Label label12;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewButtonColumn ArchiveBtn;
        private DataGridViewTextBoxColumn Name_Column;
        private DataGridViewTextBoxColumn Surname_Column;
        private DataGridViewTextBoxColumn Telephone_Column;
        private DataGridViewTextBoxColumn Stanowisko_Column;
        private DataGridViewTextBoxColumn Earning_Column;
        private DataGridViewTextBoxColumn DateOfEmployment_Column;
        }
}
