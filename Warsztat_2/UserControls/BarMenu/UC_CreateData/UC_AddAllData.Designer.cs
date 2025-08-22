namespace Warsztat_2.UserControls.BarMenu.UC_CreateData
{
    partial class UC_AddAllData
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelKontaktowy = new Panel();
            label22 = new Label();
            CompanyNameTextBox = new TextBox();
            label6 = new Label();
            AdressCompanyTextBox = new TextBox();
            label3 = new Label();
            NIPTextBox = new TextBox();
            label5 = new Label();
            TelephoneTextBox = new TextBox();
            label4 = new Label();
            SurnameTextBox = new TextBox();
            label2 = new Label();
            NameTextBox = new TextBox();
            label1 = new Label();
            panelDodatkowy = new Panel();
            label8 = new Label();
            YearNumericUpDown = new NumericUpDown();
            VINTextBox = new TextBox();
            label10 = new Label();
            NumLenghtNadwoziaLabel = new Label();
            EngineTextBox = new TextBox();
            ModelTextBox = new TextBox();
            label11 = new Label();
            label9 = new Label();
            MarkaTextBox = new TextBox();
            label12 = new Label();
            label7 = new Label();
            panel5 = new Panel();
            DateAdoptionTimePicker = new DateTimePicker();
            label15 = new Label();
            MileageTextBox = new TextBox();
            label19 = new Label();
            label21 = new Label();
            label20 = new Label();
            TestDriveChceck = new CheckBox();
            label18 = new Label();
            RegistrationNumberTextBox = new TextBox();
            LeftKeyChceck = new CheckBox();
            LeftDocumentsCheck = new CheckBox();
            RepairTextBox = new TextBox();
            label14 = new Label();
            DiagnosticTextBox = new TextBox();
            OrderTextBox = new TextBox();
            label13 = new Label();
            SaveButton = new Button();
            ViewRepair = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Wykonane_Checked = new DataGridViewCheckBoxColumn();
            Type_Column = new DataGridViewTextBoxColumn();
            Nazwa_Column_ = new DataGridViewTextBoxColumn();
            Opis_Column = new DataGridViewTextBoxColumn();
            NrCzęści_Column = new DataGridViewTextBoxColumn();
            Cena_Column = new DataGridViewTextBoxColumn();
            Ilość_Column = new DataGridViewTextBoxColumn();
            EarningParts_Columns = new DataGridViewTextBoxColumn();
            SumaZarobku_Column = new DataGridViewTextBoxColumn();
            Suma_Column = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            SelectPartButton = new Button();
            label16 = new Label();
            panel6 = new Panel();
            SelectServiceButton = new Button();
            ServiceHistoryView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Price_Column = new DataGridViewTextBoxColumn();
            label17 = new Label();
            ButtonOrderManagement = new Button();
            panel1 = new Panel();
            numericUpDown1 = new NumericUpDown();
            panelKontaktowy.SuspendLayout();
            panelDodatkowy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YearNumericUpDown).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewRepair).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceHistoryView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panelKontaktowy
            // 
            panelKontaktowy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelKontaktowy.BackColor = Color.FromArgb(64, 64, 70);
            panelKontaktowy.BorderStyle = BorderStyle.FixedSingle;
            panelKontaktowy.Controls.Add(label22);
            panelKontaktowy.Controls.Add(CompanyNameTextBox);
            panelKontaktowy.Controls.Add(label6);
            panelKontaktowy.Controls.Add(AdressCompanyTextBox);
            panelKontaktowy.Controls.Add(label3);
            panelKontaktowy.Controls.Add(NIPTextBox);
            panelKontaktowy.Controls.Add(label5);
            panelKontaktowy.Controls.Add(TelephoneTextBox);
            panelKontaktowy.Controls.Add(label4);
            panelKontaktowy.Controls.Add(SurnameTextBox);
            panelKontaktowy.Controls.Add(label2);
            panelKontaktowy.Controls.Add(NameTextBox);
            panelKontaktowy.ForeColor = Color.DimGray;
            panelKontaktowy.Location = new Point(3, 37);
            panelKontaktowy.Name = "panelKontaktowy";
            panelKontaktowy.Size = new Size(962, 128);
            panelKontaktowy.TabIndex = 5;
            // 
            // label22
            // 
            label22.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.FromArgb(224, 224, 224);
            label22.Location = new Point(366, 69);
            label22.Name = "label22";
            label22.Size = new Size(119, 28);
            label22.TabIndex = 33;
            label22.Text = "Nazwa Firmy:";
            // 
            // CompanyNameTextBox
            // 
            CompanyNameTextBox.BackColor = Color.FromArgb(64, 64, 70);
            CompanyNameTextBox.BorderStyle = BorderStyle.None;
            CompanyNameTextBox.CausesValidation = false;
            CompanyNameTextBox.Cursor = Cursors.IBeam;
            CompanyNameTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CompanyNameTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            CompanyNameTextBox.Location = new Point(491, 71);
            CompanyNameTextBox.Name = "CompanyNameTextBox";
            CompanyNameTextBox.PlaceholderText = "Wpisz Adres Firmy";
            CompanyNameTextBox.Size = new Size(459, 23);
            CompanyNameTextBox.TabIndex = 32;
            // 
            // label6
            // 
            label6.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(366, 97);
            label6.Name = "label6";
            label6.Size = new Size(119, 28);
            label6.TabIndex = 31;
            label6.Text = "Adres Firmy:";
            // 
            // AdressCompanyTextBox
            // 
            AdressCompanyTextBox.BackColor = Color.FromArgb(64, 64, 70);
            AdressCompanyTextBox.BorderStyle = BorderStyle.None;
            AdressCompanyTextBox.CausesValidation = false;
            AdressCompanyTextBox.Cursor = Cursors.IBeam;
            AdressCompanyTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AdressCompanyTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            AdressCompanyTextBox.Location = new Point(491, 99);
            AdressCompanyTextBox.Name = "AdressCompanyTextBox";
            AdressCompanyTextBox.PlaceholderText = "Wpisz Adres Firmy";
            AdressCompanyTextBox.Size = new Size(459, 23);
            AdressCompanyTextBox.TabIndex = 30;
            // 
            // label3
            // 
            label3.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(366, 41);
            label3.Name = "label3";
            label3.Size = new Size(41, 28);
            label3.TabIndex = 29;
            label3.Text = "NIP:";
            // 
            // NIPTextBox
            // 
            NIPTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NIPTextBox.BorderStyle = BorderStyle.None;
            NIPTextBox.CausesValidation = false;
            NIPTextBox.Cursor = Cursors.IBeam;
            NIPTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NIPTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NIPTextBox.Location = new Point(411, 41);
            NIPTextBox.Name = "NIPTextBox";
            NIPTextBox.PlaceholderText = "Wpisz NIP";
            NIPTextBox.Size = new Size(155, 23);
            NIPTextBox.TabIndex = 28;
            // 
            // label5
            // 
            label5.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(4, 98);
            label5.Name = "label5";
            label5.Size = new Size(130, 28);
            label5.TabIndex = 27;
            label5.Text = "* Nr. komórkowy:";
            // 
            // TelephoneTextBox
            // 
            TelephoneTextBox.BackColor = Color.FromArgb(64, 64, 70);
            TelephoneTextBox.BorderStyle = BorderStyle.None;
            TelephoneTextBox.CausesValidation = false;
            TelephoneTextBox.Cursor = Cursors.IBeam;
            TelephoneTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TelephoneTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            TelephoneTextBox.Location = new Point(140, 100);
            TelephoneTextBox.Name = "TelephoneTextBox";
            TelephoneTextBox.PlaceholderText = "Wpisz nr. telefonu";
            TelephoneTextBox.Size = new Size(164, 23);
            TelephoneTextBox.TabIndex = 26;
            // 
            // label4
            // 
            label4.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(4, 69);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 25;
            label4.Text = "Nazwisko:";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.BackColor = Color.FromArgb(64, 64, 70);
            SurnameTextBox.BorderStyle = BorderStyle.None;
            SurnameTextBox.CausesValidation = false;
            SurnameTextBox.Cursor = Cursors.IBeam;
            SurnameTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            SurnameTextBox.Location = new Point(94, 70);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.PlaceholderText = "Wpisz nazwisko";
            SurnameTextBox.Size = new Size(155, 23);
            SurnameTextBox.TabIndex = 24;
            // 
            // label2
            // 
            label2.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(4, 41);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 23;
            label2.Text = "* Imię:";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.CausesValidation = false;
            NameTextBox.Cursor = Cursors.IBeam;
            NameTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NameTextBox.Location = new Point(64, 41);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Wpisz imię";
            NameTextBox.Size = new Size(155, 23);
            NameTextBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(435, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 34);
            label1.TabIndex = 0;
            label1.Text = "Dane Klienta";
            // 
            // panelDodatkowy
            // 
            panelDodatkowy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDodatkowy.BackColor = Color.FromArgb(64, 64, 70);
            panelDodatkowy.BorderStyle = BorderStyle.FixedSingle;
            panelDodatkowy.Controls.Add(label8);
            panelDodatkowy.Controls.Add(YearNumericUpDown);
            panelDodatkowy.Controls.Add(VINTextBox);
            panelDodatkowy.Controls.Add(label10);
            panelDodatkowy.Controls.Add(NumLenghtNadwoziaLabel);
            panelDodatkowy.Controls.Add(EngineTextBox);
            panelDodatkowy.Controls.Add(ModelTextBox);
            panelDodatkowy.Controls.Add(label11);
            panelDodatkowy.Controls.Add(label9);
            panelDodatkowy.Controls.Add(MarkaTextBox);
            panelDodatkowy.Controls.Add(label12);
            panelDodatkowy.ForeColor = Color.DimGray;
            panelDodatkowy.Location = new Point(0, 209);
            panelDodatkowy.Name = "panelDodatkowy";
            panelDodatkowy.Size = new Size(962, 123);
            panelDodatkowy.TabIndex = 6;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(469, 25);
            label8.Name = "label8";
            label8.Size = new Size(110, 21);
            label8.TabIndex = 55;
            label8.Text = "Rok Produkcji";
            // 
            // YearNumericUpDown
            // 
            YearNumericUpDown.BackColor = Color.White;
            YearNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            YearNumericUpDown.Location = new Point(475, 49);
            YearNumericUpDown.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            YearNumericUpDown.Minimum = new decimal(new int[] { 1960, 0, 0, 0 });
            YearNumericUpDown.Name = "YearNumericUpDown";
            YearNumericUpDown.Size = new Size(70, 23);
            YearNumericUpDown.TabIndex = 54;
            YearNumericUpDown.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // VINTextBox
            // 
            VINTextBox.BackColor = Color.FromArgb(64, 64, 70);
            VINTextBox.BorderStyle = BorderStyle.None;
            VINTextBox.CausesValidation = false;
            VINTextBox.CharacterCasing = CharacterCasing.Upper;
            VINTextBox.Cursor = Cursors.IBeam;
            VINTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            VINTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            VINTextBox.Location = new Point(290, 78);
            VINTextBox.Name = "VINTextBox";
            VINTextBox.PlaceholderText = "Wpisz tu Nr. VIN";
            VINTextBox.Size = new Size(255, 23);
            VINTextBox.TabIndex = 47;
            VINTextBox.TextChanged += VINTextBox_TextChanged;
            // 
            // label10
            // 
            label10.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(224, 224, 224);
            label10.Location = new Point(239, 78);
            label10.Name = "label10";
            label10.Size = new Size(45, 21);
            label10.TabIndex = 46;
            label10.Text = "* VIN:";
            // 
            // NumLenghtNadwoziaLabel
            // 
            NumLenghtNadwoziaLabel.ForeColor = Color.Silver;
            NumLenghtNadwoziaLabel.Location = new Point(244, 104);
            NumLenghtNadwoziaLabel.Name = "NumLenghtNadwoziaLabel";
            NumLenghtNadwoziaLabel.Size = new Size(34, 16);
            NumLenghtNadwoziaLabel.TabIndex = 45;
            NumLenghtNadwoziaLabel.Text = "0";
            // 
            // EngineTextBox
            // 
            EngineTextBox.BackColor = Color.FromArgb(64, 64, 70);
            EngineTextBox.BorderStyle = BorderStyle.None;
            EngineTextBox.CausesValidation = false;
            EngineTextBox.Cursor = Cursors.IBeam;
            EngineTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EngineTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            EngineTextBox.Location = new Point(301, 47);
            EngineTextBox.Margin = new Padding(3, 4, 3, 4);
            EngineTextBox.Name = "EngineTextBox";
            EngineTextBox.PlaceholderText = "1.6 THP";
            EngineTextBox.Size = new Size(144, 23);
            EngineTextBox.TabIndex = 53;
            // 
            // ModelTextBox
            // 
            ModelTextBox.BackColor = Color.FromArgb(64, 64, 70);
            ModelTextBox.BorderStyle = BorderStyle.None;
            ModelTextBox.CausesValidation = false;
            ModelTextBox.Cursor = Cursors.IBeam;
            ModelTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ModelTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            ModelTextBox.Location = new Point(105, 74);
            ModelTextBox.Margin = new Padding(3, 4, 3, 4);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.PlaceholderText = "508";
            ModelTextBox.Size = new Size(127, 23);
            ModelTextBox.TabIndex = 51;
            // 
            // label11
            // 
            label11.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(224, 224, 224);
            label11.Location = new Point(27, 74);
            label11.Name = "label11";
            label11.Size = new Size(72, 21);
            label11.TabIndex = 50;
            label11.Text = "* Model:";
            // 
            // label9
            // 
            label9.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(244, 47);
            label9.Name = "label9";
            label9.Size = new Size(65, 21);
            label9.TabIndex = 52;
            label9.Text = "Silnik:";
            // 
            // MarkaTextBox
            // 
            MarkaTextBox.BackColor = Color.FromArgb(64, 64, 70);
            MarkaTextBox.BorderStyle = BorderStyle.None;
            MarkaTextBox.CausesValidation = false;
            MarkaTextBox.Cursor = Cursors.IBeam;
            MarkaTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MarkaTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            MarkaTextBox.Location = new Point(99, 44);
            MarkaTextBox.Margin = new Padding(3, 4, 3, 4);
            MarkaTextBox.Name = "MarkaTextBox";
            MarkaTextBox.PlaceholderText = "Peugeout";
            MarkaTextBox.Size = new Size(139, 23);
            MarkaTextBox.TabIndex = 49;
            // 
            // label12
            // 
            label12.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(224, 224, 224);
            label12.Location = new Point(27, 44);
            label12.Name = "label12";
            label12.Size = new Size(66, 21);
            label12.TabIndex = 48;
            label12.Text = "* Marka:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(398, 168);
            label7.Name = "label7";
            label7.Size = new Size(187, 35);
            label7.TabIndex = 32;
            label7.Text = "Dane Samochodu";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(64, 64, 70);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(DateAdoptionTimePicker);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(MileageTextBox);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label21);
            panel5.Controls.Add(label20);
            panel5.Controls.Add(TestDriveChceck);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(RegistrationNumberTextBox);
            panel5.Controls.Add(LeftKeyChceck);
            panel5.Controls.Add(LeftDocumentsCheck);
            panel5.Controls.Add(RepairTextBox);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(DiagnosticTextBox);
            panel5.Controls.Add(OrderTextBox);
            panel5.ForeColor = Color.DimGray;
            panel5.Location = new Point(3, 369);
            panel5.Name = "panel5";
            panel5.Size = new Size(960, 324);
            panel5.TabIndex = 37;
            // 
            // DateAdoptionTimePicker
            // 
            DateAdoptionTimePicker.CalendarMonthBackground = Color.FromArgb(94, 148, 255);
            DateAdoptionTimePicker.CalendarTitleBackColor = SystemColors.ControlText;
            DateAdoptionTimePicker.CalendarTitleForeColor = Color.FromArgb(94, 148, 255);
            DateAdoptionTimePicker.Cursor = Cursors.Hand;
            DateAdoptionTimePicker.CustomFormat = "";
            DateAdoptionTimePicker.Location = new Point(380, 227);
            DateAdoptionTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DateAdoptionTimePicker.Name = "DateAdoptionTimePicker";
            DateAdoptionTimePicker.Size = new Size(239, 23);
            DateAdoptionTimePicker.TabIndex = 23;
            DateAdoptionTimePicker.Value = new DateTime(2024, 1, 16, 0, 0, 0, 0);
            // 
            // label15
            // 
            label15.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(224, 224, 224);
            label15.Location = new Point(444, 200);
            label15.Name = "label15";
            label15.Size = new Size(107, 28);
            label15.TabIndex = 24;
            label15.Text = "Data przyjęcia";
            // 
            // MileageTextBox
            // 
            MileageTextBox.BackColor = Color.FromArgb(64, 64, 70);
            MileageTextBox.BorderStyle = BorderStyle.None;
            MileageTextBox.CausesValidation = false;
            MileageTextBox.Cursor = Cursors.IBeam;
            MileageTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MileageTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            MileageTextBox.Location = new Point(108, 274);
            MileageTextBox.Name = "MileageTextBox";
            MileageTextBox.PlaceholderText = "Przebieg";
            MileageTextBox.Size = new Size(199, 23);
            MileageTextBox.TabIndex = 1;
            // 
            // label19
            // 
            label19.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(224, 224, 224);
            label19.Location = new Point(605, 16);
            label19.Name = "label19";
            label19.Size = new Size(77, 28);
            label19.TabIndex = 22;
            label19.Text = "Naprawa";
            // 
            // label21
            // 
            label21.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.FromArgb(224, 224, 224);
            label21.Location = new Point(14, 273);
            label21.Name = "label21";
            label21.Size = new Size(89, 24);
            label21.TabIndex = 46;
            label21.Text = "* Przebieg:";
            // 
            // label20
            // 
            label20.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(224, 224, 224);
            label20.Location = new Point(14, 226);
            label20.Name = "label20";
            label20.Size = new Size(155, 21);
            label20.TabIndex = 46;
            label20.Text = "* Numer Rejestracji:";
            // 
            // TestDriveChceck
            // 
            TestDriveChceck.BackColor = Color.FromArgb(64, 64, 70);
            TestDriveChceck.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TestDriveChceck.ForeColor = Color.DimGray;
            TestDriveChceck.Location = new Point(641, 253);
            TestDriveChceck.Name = "TestDriveChceck";
            TestDriveChceck.Size = new Size(230, 25);
            TestDriveChceck.TabIndex = 5;
            TestDriveChceck.Text = "Klient wyraża zgodę na TestDrive";
            TestDriveChceck.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            label18.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(224, 224, 224);
            label18.Location = new Point(300, 16);
            label18.Name = "label18";
            label18.Size = new Size(99, 28);
            label18.TabIndex = 21;
            label18.Text = "Diagnostyka";
            // 
            // RegistrationNumberTextBox
            // 
            RegistrationNumberTextBox.BackColor = Color.FromArgb(64, 64, 70);
            RegistrationNumberTextBox.BorderStyle = BorderStyle.None;
            RegistrationNumberTextBox.CausesValidation = false;
            RegistrationNumberTextBox.CharacterCasing = CharacterCasing.Upper;
            RegistrationNumberTextBox.Cursor = Cursors.IBeam;
            RegistrationNumberTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistrationNumberTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            RegistrationNumberTextBox.Location = new Point(175, 226);
            RegistrationNumberTextBox.Name = "RegistrationNumberTextBox";
            RegistrationNumberTextBox.PlaceholderText = "Numer Rejestracji";
            RegistrationNumberTextBox.Size = new Size(199, 23);
            RegistrationNumberTextBox.TabIndex = 0;
            // 
            // LeftKeyChceck
            // 
            LeftKeyChceck.BackColor = Color.FromArgb(64, 64, 70);
            LeftKeyChceck.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LeftKeyChceck.ForeColor = Color.DimGray;
            LeftKeyChceck.Location = new Point(641, 228);
            LeftKeyChceck.Name = "LeftKeyChceck";
            LeftKeyChceck.Size = new Size(230, 25);
            LeftKeyChceck.TabIndex = 4;
            LeftKeyChceck.Text = "Pozostawione Kluczyki samochodu";
            LeftKeyChceck.UseVisualStyleBackColor = false;
            // 
            // LeftDocumentsCheck
            // 
            LeftDocumentsCheck.BackColor = Color.FromArgb(64, 64, 70);
            LeftDocumentsCheck.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LeftDocumentsCheck.ForeColor = Color.DimGray;
            LeftDocumentsCheck.Location = new Point(642, 203);
            LeftDocumentsCheck.Name = "LeftDocumentsCheck";
            LeftDocumentsCheck.Size = new Size(230, 25);
            LeftDocumentsCheck.TabIndex = 3;
            LeftDocumentsCheck.Text = "Pozostawione Dokumenty samochodu";
            LeftDocumentsCheck.UseVisualStyleBackColor = false;
            // 
            // RepairTextBox
            // 
            RepairTextBox.BackColor = Color.FromArgb(64, 64, 70);
            RepairTextBox.CausesValidation = false;
            RepairTextBox.Cursor = Cursors.IBeam;
            RepairTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RepairTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            RepairTextBox.Location = new Point(605, 47);
            RepairTextBox.MinimumSize = new Size(160, 144);
            RepairTextBox.Multiline = true;
            RepairTextBox.Name = "RepairTextBox";
            RepairTextBox.PlaceholderText = "Naprawa";
            RepairTextBox.Size = new Size(350, 144);
            RepairTextBox.TabIndex = 8;
            // 
            // label14
            // 
            label14.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(224, 224, 224);
            label14.Location = new Point(14, 14);
            label14.Name = "label14";
            label14.Size = new Size(77, 28);
            label14.TabIndex = 20;
            label14.Text = "* Zlecenie";
            // 
            // DiagnosticTextBox
            // 
            DiagnosticTextBox.BackColor = Color.FromArgb(64, 64, 70);
            DiagnosticTextBox.CausesValidation = false;
            DiagnosticTextBox.Cursor = Cursors.IBeam;
            DiagnosticTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DiagnosticTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            DiagnosticTextBox.Location = new Point(300, 47);
            DiagnosticTextBox.MinimumSize = new Size(160, 144);
            DiagnosticTextBox.Multiline = true;
            DiagnosticTextBox.Name = "DiagnosticTextBox";
            DiagnosticTextBox.PlaceholderText = "Diagnostyka";
            DiagnosticTextBox.Size = new Size(299, 144);
            DiagnosticTextBox.TabIndex = 7;
            // 
            // OrderTextBox
            // 
            OrderTextBox.BackColor = Color.FromArgb(64, 64, 70);
            OrderTextBox.CausesValidation = false;
            OrderTextBox.Cursor = Cursors.IBeam;
            OrderTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OrderTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            OrderTextBox.Location = new Point(7, 47);
            OrderTextBox.MinimumSize = new Size(160, 144);
            OrderTextBox.Multiline = true;
            OrderTextBox.Name = "OrderTextBox";
            OrderTextBox.PlaceholderText = "Zlecenie";
            OrderTextBox.Size = new Size(287, 144);
            OrderTextBox.TabIndex = 6;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(224, 224, 224);
            label13.Location = new Point(428, 335);
            label13.Name = "label13";
            label13.Size = new Size(89, 31);
            label13.TabIndex = 56;
            label13.Text = "Historia";
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SaveButton.BackColor = Color.FromArgb(94, 148, 255);
            SaveButton.Cursor = Cursors.Hand;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.LightGray;
            SaveButton.Location = new Point(1, 712);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(962, 35);
            SaveButton.TabIndex = 57;
            SaveButton.Text = "Zapisz";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
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
            ViewRepair.Columns.AddRange(new DataGridViewColumn[] { ID, Wykonane_Checked, Type_Column, Nazwa_Column_, Opis_Column, NrCzęści_Column, Cena_Column, Ilość_Column, EarningParts_Columns, SumaZarobku_Column, Suma_Column });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            ViewRepair.DefaultCellStyle = dataGridViewCellStyle4;
            ViewRepair.EnableHeadersVisualStyles = false;
            ViewRepair.Location = new Point(9, 44);
            ViewRepair.Name = "ViewRepair";
            ViewRepair.RowTemplate.Height = 25;
            ViewRepair.Size = new Size(930, 222);
            ViewRepair.TabIndex = 58;
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
            // EarningParts_Columns
            // 
            EarningParts_Columns.DataPropertyName = "ZarobekCzęści";
            EarningParts_Columns.HeaderText = "Dochód z częsci";
            EarningParts_Columns.Name = "EarningParts_Columns";
            EarningParts_Columns.Visible = false;
            // 
            // SumaZarobku_Column
            // 
            SumaZarobku_Column.DataPropertyName = "SumaZarobku";
            SumaZarobku_Column.HeaderText = "SumaZarobku";
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
            Suma_Column.HeaderText = "Suma";
            Suma_Column.Name = "Suma_Column";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(64, 64, 70);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(SelectPartButton);
            panel2.Controls.Add(ViewRepair);
            panel2.ForeColor = Color.WhiteSmoke;
            panel2.Location = new Point(8, 784);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 271);
            panel2.TabIndex = 59;
            // 
            // SelectPartButton
            // 
            SelectPartButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectPartButton.BackColor = Color.FromArgb(94, 148, 255);
            SelectPartButton.Cursor = Cursors.Hand;
            SelectPartButton.FlatAppearance.BorderSize = 0;
            SelectPartButton.FlatStyle = FlatStyle.Flat;
            SelectPartButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SelectPartButton.ForeColor = Color.LightGray;
            SelectPartButton.Location = new Point(9, 3);
            SelectPartButton.Name = "SelectPartButton";
            SelectPartButton.Size = new Size(930, 35);
            SelectPartButton.TabIndex = 59;
            SelectPartButton.Text = "Wybierz części z magazynu";
            SelectPartButton.UseVisualStyleBackColor = false;
            SelectPartButton.Click += SelectPartButton_Click;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(224, 224, 224);
            label16.Location = new Point(359, 750);
            label16.Name = "label16";
            label16.Size = new Size(211, 31);
            label16.TabIndex = 60;
            label16.Text = "Części z magazynu";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.FromArgb(64, 64, 70);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(SelectServiceButton);
            panel6.Controls.Add(ServiceHistoryView);
            panel6.ForeColor = Color.WhiteSmoke;
            panel6.Location = new Point(8, 1092);
            panel6.Name = "panel6";
            panel6.Size = new Size(948, 221);
            panel6.TabIndex = 62;
            // 
            // SelectServiceButton
            // 
            SelectServiceButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectServiceButton.BackColor = Color.FromArgb(94, 148, 255);
            SelectServiceButton.Cursor = Cursors.Hand;
            SelectServiceButton.FlatAppearance.BorderSize = 0;
            SelectServiceButton.FlatStyle = FlatStyle.Flat;
            SelectServiceButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SelectServiceButton.ForeColor = Color.LightGray;
            SelectServiceButton.Location = new Point(9, 13);
            SelectServiceButton.Name = "SelectServiceButton";
            SelectServiceButton.Size = new Size(930, 35);
            SelectServiceButton.TabIndex = 60;
            SelectServiceButton.Text = "Wybierz usługę";
            SelectServiceButton.UseVisualStyleBackColor = false;
            SelectServiceButton.Click += SelectServiceButton_Click;
            // 
            // ServiceHistoryView
            // 
            ServiceHistoryView.AllowUserToAddRows = false;
            ServiceHistoryView.AllowUserToDeleteRows = false;
            ServiceHistoryView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ServiceHistoryView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ServiceHistoryView.BorderStyle = BorderStyle.None;
            ServiceHistoryView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.LightGray;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ServiceHistoryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ServiceHistoryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceHistoryView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Price_Column });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            ServiceHistoryView.DefaultCellStyle = dataGridViewCellStyle7;
            ServiceHistoryView.EnableHeadersVisualStyles = false;
            ServiceHistoryView.Location = new Point(9, 54);
            ServiceHistoryView.Name = "ServiceHistoryView";
            ServiceHistoryView.RowTemplate.Height = 25;
            ServiceHistoryView.Size = new Size(930, 162);
            ServiceHistoryView.TabIndex = 59;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "ServiceName";
            dataGridViewTextBoxColumn2.FillWeight = 83.94669F;
            dataGridViewTextBoxColumn2.HeaderText = "Rodzaj usługi";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Price_Column
            // 
            Price_Column.DataPropertyName = "Price";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            Price_Column.DefaultCellStyle = dataGridViewCellStyle6;
            Price_Column.HeaderText = "Cena";
            Price_Column.Name = "Price_Column";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top;
            label17.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(224, 224, 224);
            label17.Location = new Point(344, 1058);
            label17.Name = "label17";
            label17.Size = new Size(211, 31);
            label17.TabIndex = 63;
            label17.Text = "Usługi warsztatu";
            // 
            // ButtonOrderManagement
            // 
            ButtonOrderManagement.Anchor = AnchorStyles.Right;
            ButtonOrderManagement.BackColor = Color.FromArgb(94, 148, 255);
            ButtonOrderManagement.Cursor = Cursors.Hand;
            ButtonOrderManagement.FlatAppearance.BorderSize = 0;
            ButtonOrderManagement.FlatStyle = FlatStyle.Flat;
            ButtonOrderManagement.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonOrderManagement.ForeColor = Color.LightGray;
            ButtonOrderManagement.Location = new Point(3, 3);
            ButtonOrderManagement.Name = "ButtonOrderManagement";
            ButtonOrderManagement.Size = new Size(576, 35);
            ButtonOrderManagement.TabIndex = 65;
            ButtonOrderManagement.Text = "Zarządzaj zleceniem";
            ButtonOrderManagement.UseVisualStyleBackColor = false;
            ButtonOrderManagement.Click += ButtonOrderManagement_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(64, 64, 70);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(ButtonOrderManagement);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(155, 1321);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 45);
            panel1.TabIndex = 66;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top;
            numericUpDown1.BackColor = Color.FromArgb(64, 64, 70);
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.Location = new Point(879, 48);
            numericUpDown1.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1960, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(70, 23);
            numericUpDown1.TabIndex = 54;
            numericUpDown1.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // UC_AddAllData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Controls.Add(label17);
            Controls.Add(SaveButton);
            Controls.Add(panel6);
            Controls.Add(label16);
            Controls.Add(panel2);
            Controls.Add(label13);
            Controls.Add(panel5);
            Controls.Add(panelKontaktowy);
            Controls.Add(panelDodatkowy);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "UC_AddAllData";
            Size = new Size(963, 1366);
            Load += UC_AddAllData_Load;
            panelKontaktowy.ResumeLayout(false);
            panelKontaktowy.PerformLayout();
            panelDodatkowy.ResumeLayout(false);
            panelDodatkowy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YearNumericUpDown).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewRepair).EndInit();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ServiceHistoryView).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            }

        #endregion

        private Panel panelKontaktowy;
        private TextBox NameTextBox;
        private Panel panelDodatkowy;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox TelephoneTextBox;
        private Label label4;
        private TextBox SurnameTextBox;
        private Label label3;
        private TextBox NIPTextBox;
        private Label label6;
        private TextBox AdressCompanyTextBox;
        private Label label7;
        private Label label8;
        public NumericUpDown YearNumericUpDown;
        public Label NumLenghtNadwoziaLabel;
        public TextBox EngineTextBox;
        private Label label9;
        private Label label10;
        public TextBox ModelTextBox;
        private TextBox VINTextBox;
        private Label label11;
        public TextBox MarkaTextBox;
        private Label label12;
        private Panel panel5;
        private Label label19;
        private Label label18;
        private TextBox MileageTextBox;
        private CheckBox TestDriveChceck;
        private CheckBox LeftKeyChceck;
        private CheckBox LeftDocumentsCheck;
        private TextBox RegistrationNumberTextBox;
        private TextBox RepairTextBox;
        private Label label14;
        private TextBox DiagnosticTextBox;
        private TextBox OrderTextBox;
        private Label label13;
        public DateTimePicker DateAdoptionTimePicker;
        private Label label15;
        private Button SaveButton;
        private DataGridView ViewRepair;
        private Panel panel2;
        private Label label16;
        private Button SelectPartButton;
        private Panel panel6;
        private Button SelectServiceButton;
        private DataGridView ServiceHistoryView;
        private Label label17;
        private Button ButtonOrderManagement;
        private Label label21;
        private Label label20;
        private Panel panel1;
        public NumericUpDown numericUpDown1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Price_Column;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewCheckBoxColumn Wykonane_Checked;
        private DataGridViewTextBoxColumn Type_Column;
        private DataGridViewTextBoxColumn Nazwa_Column_;
        private DataGridViewTextBoxColumn Opis_Column;
        private DataGridViewTextBoxColumn NrCzęści_Column;
        private DataGridViewTextBoxColumn Cena_Column;
        private DataGridViewTextBoxColumn Ilość_Column;
        private DataGridViewTextBoxColumn EarningParts_Columns;
        private DataGridViewTextBoxColumn SumaZarobku_Column;
        private DataGridViewTextBoxColumn Suma_Column;
        private Label label22;
        private TextBox CompanyNameTextBox;
        }
}
