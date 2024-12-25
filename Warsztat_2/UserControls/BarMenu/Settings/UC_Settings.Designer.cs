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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ListBoxEmployer = new ListBox();
            label4 = new Label();
            label1 = new Label();
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
            StanowiskoSelect = new ComboBox();
            EmployerAddButton = new Button();
            UpdateEmployerButton = new Button();
            RemoveEmployerButton = new Button();
            NumerTelefonuTextBox = new TextBox();
            ImiePracownikaTextBox = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            DateOfDeductionCalendar = new DateTimePicker();
            label7 = new Label();
            ViewDataOfDeduction = new DataGridView();
            ID_Column = new DataGridViewTextBoxColumn();
            BtnDelete = new DataGridViewButtonColumn();
            NazwaWydatku_Column = new DataGridViewTextBoxColumn();
            CenaWydatku_Column = new DataGridViewTextBoxColumn();
            DataPotrącenia_Column = new DataGridViewTextBoxColumn();
            ExpenseNameTextBox = new TextBox();
            PriceNumericUpDown = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            BtnSaveDateOfDeduction = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewDataOfDeduction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // ListBoxEmployer
            // 
            ListBoxEmployer.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxEmployer.FormattingEnabled = true;
            ListBoxEmployer.ItemHeight = 23;
            ListBoxEmployer.Location = new Point(16, 43);
            ListBoxEmployer.Name = "ListBoxEmployer";
            ListBoxEmployer.Size = new Size(324, 165);
            ListBoxEmployer.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(630, 30);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 15;
            label4.Text = "Stanowisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(393, 95);
            label1.Name = "label1";
            label1.Size = new Size(204, 21);
            label1.TabIndex = 15;
            label1.Text = "Numer telefonu pracownika";
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
            panel2.Controls.Add(StanowiskoSelect);
            panel2.Controls.Add(EmployerAddButton);
            panel2.Controls.Add(UpdateEmployerButton);
            panel2.Controls.Add(RemoveEmployerButton);
            panel2.Controls.Add(NumerTelefonuTextBox);
            panel2.Controls.Add(ListBoxEmployer);
            panel2.Controls.Add(ImiePracownikaTextBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.DimGray;
            panel2.Location = new Point(0, 427);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 216);
            panel2.TabIndex = 29;
            // 
            // StanowiskoSelect
            // 
            StanowiskoSelect.BackColor = Color.FromArgb(94, 148, 255);
            StanowiskoSelect.FlatStyle = FlatStyle.Flat;
            StanowiskoSelect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StanowiskoSelect.ForeColor = Color.FromArgb(68, 88, 112);
            StanowiskoSelect.FormattingEnabled = true;
            StanowiskoSelect.Items.AddRange(new object[] { "Elektronik", "Elektryk", "Mechanik", "Mechatronik", "Programista" });
            StanowiskoSelect.Location = new Point(620, 57);
            StanowiskoSelect.Name = "StanowiskoSelect";
            StanowiskoSelect.Size = new Size(171, 29);
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
            EmployerAddButton.Location = new Point(823, 49);
            EmployerAddButton.Name = "EmployerAddButton";
            EmployerAddButton.Size = new Size(139, 30);
            EmployerAddButton.TabIndex = 4;
            EmployerAddButton.Text = "Dodaj Pracownika";
            EmployerAddButton.UseVisualStyleBackColor = false;
            EmployerAddButton.Click += EmployerAddButton_Click;
            // 
            // UpdateEmployerButton
            // 
            UpdateEmployerButton.BackColor = Color.FromArgb(94, 148, 255);
            UpdateEmployerButton.FlatAppearance.BorderSize = 0;
            UpdateEmployerButton.FlatStyle = FlatStyle.Flat;
            UpdateEmployerButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateEmployerButton.ForeColor = Color.LightGray;
            UpdateEmployerButton.Location = new Point(16, 6);
            UpdateEmployerButton.Name = "UpdateEmployerButton";
            UpdateEmployerButton.Size = new Size(324, 30);
            UpdateEmployerButton.TabIndex = 0;
            UpdateEmployerButton.Text = "Odśwież listę";
            UpdateEmployerButton.UseVisualStyleBackColor = false;
            UpdateEmployerButton.Click += UpdateEmployerButton_Click;
            // 
            // RemoveEmployerButton
            // 
            RemoveEmployerButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RemoveEmployerButton.BackColor = Color.FromArgb(94, 148, 255);
            RemoveEmployerButton.FlatAppearance.BorderSize = 0;
            RemoveEmployerButton.FlatStyle = FlatStyle.Flat;
            RemoveEmployerButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveEmployerButton.ForeColor = Color.LightGray;
            RemoveEmployerButton.Location = new Point(823, 85);
            RemoveEmployerButton.Name = "RemoveEmployerButton";
            RemoveEmployerButton.Size = new Size(139, 30);
            RemoveEmployerButton.TabIndex = 5;
            RemoveEmployerButton.Text = "Usuń Pracownika";
            RemoveEmployerButton.UseVisualStyleBackColor = false;
            RemoveEmployerButton.Click += RemoveEmployerButton_Click;
            // 
            // NumerTelefonuTextBox
            // 
            NumerTelefonuTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NumerTelefonuTextBox.CausesValidation = false;
            NumerTelefonuTextBox.Cursor = Cursors.IBeam;
            NumerTelefonuTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NumerTelefonuTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NumerTelefonuTextBox.Location = new Point(393, 119);
            NumerTelefonuTextBox.Name = "NumerTelefonuTextBox";
            NumerTelefonuTextBox.PlaceholderText = "Nr. telefonu ";
            NumerTelefonuTextBox.Size = new Size(181, 30);
            NumerTelefonuTextBox.TabIndex = 2;
            NumerTelefonuTextBox.TextChanged += NumerTelefonuTextBox_TextChanged;
            // 
            // ImiePracownikaTextBox
            // 
            ImiePracownikaTextBox.BackColor = Color.FromArgb(64, 64, 70);
            ImiePracownikaTextBox.CausesValidation = false;
            ImiePracownikaTextBox.Cursor = Cursors.IBeam;
            ImiePracownikaTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ImiePracownikaTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            ImiePracownikaTextBox.Location = new Point(393, 55);
            ImiePracownikaTextBox.Name = "ImiePracownikaTextBox";
            ImiePracownikaTextBox.PlaceholderText = "Imię pracownika";
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
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(64, 64, 70);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(DateOfDeductionCalendar);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(ViewDataOfDeduction);
            panel3.Controls.Add(ExpenseNameTextBox);
            panel3.Controls.Add(PriceNumericUpDown);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(BtnSaveDateOfDeduction);
            panel3.Controls.Add(label3);
            panel3.ForeColor = Color.DimGray;
            panel3.Location = new Point(3, 199);
            panel3.Name = "panel3";
            panel3.Size = new Size(1013, 222);
            panel3.TabIndex = 29;
            // 
            // DateOfDeductionCalendar
            // 
            DateOfDeductionCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateOfDeductionCalendar.Format = DateTimePickerFormat.Short;
            DateOfDeductionCalendar.Location = new Point(560, 42);
            DateOfDeductionCalendar.Name = "DateOfDeductionCalendar";
            DateOfDeductionCalendar.Size = new Size(200, 23);
            DateOfDeductionCalendar.TabIndex = 38;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(597, 18);
            label7.Name = "label7";
            label7.Size = new Size(119, 21);
            label7.TabIndex = 36;
            label7.Text = "Data potrącenia";
            // 
            // ViewDataOfDeduction
            // 
            ViewDataOfDeduction.AllowUserToAddRows = false;
            ViewDataOfDeduction.AllowUserToDeleteRows = false;
            ViewDataOfDeduction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ViewDataOfDeduction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewDataOfDeduction.BorderStyle = BorderStyle.None;
            ViewDataOfDeduction.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewDataOfDeduction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewDataOfDeduction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewDataOfDeduction.Columns.AddRange(new DataGridViewColumn[] { ID_Column, BtnDelete, NazwaWydatku_Column, CenaWydatku_Column, DataPotrącenia_Column });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ViewDataOfDeduction.DefaultCellStyle = dataGridViewCellStyle3;
            ViewDataOfDeduction.EnableHeadersVisualStyles = false;
            ViewDataOfDeduction.Location = new Point(13, 31);
            ViewDataOfDeduction.Name = "ViewDataOfDeduction";
            ViewDataOfDeduction.RowTemplate.Height = 25;
            ViewDataOfDeduction.Size = new Size(477, 174);
            ViewDataOfDeduction.TabIndex = 34;
            ViewDataOfDeduction.CellContentClick += ViewDataOfDeduction_CellContentClick;
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
            BtnDelete.HeaderText = "Usuń";
            BtnDelete.Name = "BtnDelete";
            // 
            // NazwaWydatku_Column
            // 
            NazwaWydatku_Column.DataPropertyName = "NazwaWydatku";
            NazwaWydatku_Column.HeaderText = "Nazwa Wydatku";
            NazwaWydatku_Column.Name = "NazwaWydatku_Column";
            // 
            // CenaWydatku_Column
            // 
            CenaWydatku_Column.DataPropertyName = "CenaWydatku";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            CenaWydatku_Column.DefaultCellStyle = dataGridViewCellStyle2;
            CenaWydatku_Column.HeaderText = "Stała kwota potręcenia";
            CenaWydatku_Column.Name = "CenaWydatku_Column";
            // 
            // DataPotrącenia_Column
            // 
            DataPotrącenia_Column.DataPropertyName = "DataPotrącenia";
            DataPotrącenia_Column.HeaderText = "Data";
            DataPotrącenia_Column.Name = "DataPotrącenia_Column";
            // 
            // ExpenseNameTextBox
            // 
            ExpenseNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExpenseNameTextBox.BackColor = Color.FromArgb(64, 64, 70);
            ExpenseNameTextBox.CausesValidation = false;
            ExpenseNameTextBox.Cursor = Cursors.IBeam;
            ExpenseNameTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ExpenseNameTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            ExpenseNameTextBox.Location = new Point(820, 43);
            ExpenseNameTextBox.Name = "ExpenseNameTextBox";
            ExpenseNameTextBox.Size = new Size(181, 30);
            ExpenseNameTextBox.TabIndex = 33;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriceNumericUpDown.BackColor = Color.White;
            PriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PriceNumericUpDown.DecimalPlaces = 2;
            PriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            PriceNumericUpDown.Location = new Point(903, 100);
            PriceNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(98, 23);
            PriceNumericUpDown.TabIndex = 32;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(818, 76);
            label6.Name = "label6";
            label6.Size = new Size(183, 21);
            label6.TabIndex = 31;
            label6.Text = "Stały wydatek za miesiąc:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(820, 19);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 31;
            label5.Text = "Nazwa wydatku:";
            // 
            // BtnSaveDateOfDeduction
            // 
            BtnSaveDateOfDeduction.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSaveDateOfDeduction.BackColor = Color.FromArgb(94, 148, 255);
            BtnSaveDateOfDeduction.FlatAppearance.BorderSize = 0;
            BtnSaveDateOfDeduction.FlatStyle = FlatStyle.Flat;
            BtnSaveDateOfDeduction.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSaveDateOfDeduction.ForeColor = Color.LightGray;
            BtnSaveDateOfDeduction.Location = new Point(886, 175);
            BtnSaveDateOfDeduction.Name = "BtnSaveDateOfDeduction";
            BtnSaveDateOfDeduction.Size = new Size(122, 30);
            BtnSaveDateOfDeduction.TabIndex = 7;
            BtnSaveDateOfDeduction.Text = "Zapisz";
            BtnSaveDateOfDeduction.UseVisualStyleBackColor = false;
            BtnSaveDateOfDeduction.Click += BtnSaveDateOfDeduction_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(335, -1);
            label3.Name = "label3";
            label3.Size = new Size(192, 28);
            label3.TabIndex = 0;
            label3.Text = "Wydatki stałe firmy";
            label3.Click += label3_Click;
            // 
            // UC_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "UC_Settings";
            Size = new Size(1019, 643);
            Load += UC_Settings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewDataOfDeduction).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            ResumeLayout(false);
            }

        #endregion
        private Label label4;
        private Label label1;
        private TextBox MarzaTextBox;
        private TextBox KontoBankoweTextBox;
        private TextBox NrTelefonuTextBox;
        private TextBox NIPTextBox;
        private TextBox AdresFirmyTextBox;
        private TextBox NazwaFirmyTextBox;
        private ListBox ListBoxEmployer;
        private Panel panel1;
        private Label label13;
        private TextBox NumerBDOTextBox;
        private Button SaveDataButton;
        private Panel panel2;
        private Label label2;
        private Button UpdateEmployerButton;
        private Button EmployerAddButton;
        private Button RemoveEmployerButton;
        private TextBox NumerTelefonuTextBox;
        private TextBox ImiePracownikaTextBox;
        private ComboBox StanowiskoSelect;
        private Panel panel3;
        private Button BtnSaveDateOfDeduction;
        private Label label5;
        private Label label6;
        private Label label3;
        private TextBox ExpenseNameTextBox;
        private NumericUpDown PriceNumericUpDown;
        private DataGridView ViewDataOfDeduction;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewTextBoxColumn NazwaWydatku_Column;
        private DataGridViewTextBoxColumn CenaWydatku_Column;
        private DataGridViewTextBoxColumn DataPotrącenia_Column;
        private Label label7;
        private DateTimePicker DateOfDeductionCalendar;
        }
}
