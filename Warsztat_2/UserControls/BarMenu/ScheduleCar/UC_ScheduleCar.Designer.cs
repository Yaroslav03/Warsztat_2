namespace Warsztat_2.UserControls.BarMenu.ScheduleCar
{
    partial class UC_ScheduleCar
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
            ScheduleCarAddButton = new Button();
            ID_label = new Label();
            ScheduleCarButton = new Button();
            helpTelephoneLabel = new Label();
            label20 = new Label();
            label22 = new Label();
            ProblemCar = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            ViewScheduleCarButton = new Button();
            CarComboBox = new ComboBox();
            CarButton = new Button();
            ScheduleModelTextBox0 = new TextBox();
            label28 = new Label();
            ScheduleTimePicker = new DateTimePicker();
            label11 = new Label();
            label18 = new Label();
            label15 = new Label();
            TelephonTextBox = new TextBox();
            label19 = new Label();
            label16 = new Label();
            SurnameTextBox = new TextBox();
            label21 = new Label();
            label6 = new Label();
            label25 = new Label();
            DataScheduleView = new DataGridView();
            ViewData = new Panel();
            SearchScheduleCar = new TextBox();
            helpingLabel = new Label();
            NameTextBox = new TextBox();
            label24 = new Label();
            label17 = new Label();
            panel2 = new Panel();
            label23 = new Label();
            EditData = new Panel();
            btnAdd = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            DataPrzyjecia_Column = new DataGridViewTextBoxColumn();
            ID_Column = new DataGridViewTextBoxColumn();
            Imie_Column = new DataGridViewTextBoxColumn();
            Nazwisko_Column = new DataGridViewTextBoxColumn();
            Telefon_Column = new DataGridViewTextBoxColumn();
            Marka_Column = new DataGridViewTextBoxColumn();
            Model_Column = new DataGridViewTextBoxColumn();
            Problem_Column = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataScheduleView).BeginInit();
            ViewData.SuspendLayout();
            panel2.SuspendLayout();
            EditData.SuspendLayout();
            SuspendLayout();
            // 
            // ScheduleCarAddButton
            // 
            ScheduleCarAddButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScheduleCarAddButton.BackColor = Color.FromArgb(94, 148, 255);
            ScheduleCarAddButton.FlatAppearance.BorderSize = 0;
            ScheduleCarAddButton.FlatStyle = FlatStyle.Flat;
            ScheduleCarAddButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ScheduleCarAddButton.ForeColor = Color.LightGray;
            ScheduleCarAddButton.ImeMode = ImeMode.NoControl;
            ScheduleCarAddButton.Location = new Point(722, 0);
            ScheduleCarAddButton.Name = "ScheduleCarAddButton";
            ScheduleCarAddButton.Size = new Size(280, 32);
            ScheduleCarAddButton.TabIndex = 30;
            ScheduleCarAddButton.Text = "Zapłanuj samochód";
            ScheduleCarAddButton.UseVisualStyleBackColor = false;
            ScheduleCarAddButton.Click += ScheduleCarAddButton_Click;
            // 
            // ID_label
            // 
            ID_label.Anchor = AnchorStyles.Top;
            ID_label.AutoSize = true;
            ID_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ID_label.ForeColor = Color.FromArgb(224, 224, 224);
            ID_label.ImeMode = ImeMode.NoControl;
            ID_label.Location = new Point(607, 58);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(19, 21);
            ID_label.TabIndex = 0;
            ID_label.Text = "0";
            // 
            // ScheduleCarButton
            // 
            ScheduleCarButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ScheduleCarButton.BackColor = Color.FromArgb(94, 148, 255);
            ScheduleCarButton.FlatAppearance.BorderSize = 0;
            ScheduleCarButton.FlatStyle = FlatStyle.Flat;
            ScheduleCarButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ScheduleCarButton.ForeColor = Color.LightGray;
            ScheduleCarButton.ImeMode = ImeMode.NoControl;
            ScheduleCarButton.Location = new Point(0, 14);
            ScheduleCarButton.Name = "ScheduleCarButton";
            ScheduleCarButton.Size = new Size(1007, 32);
            ScheduleCarButton.TabIndex = 24;
            ScheduleCarButton.Text = "Zapłanuj samochód";
            ScheduleCarButton.UseVisualStyleBackColor = false;
            ScheduleCarButton.Click += ScheduleCarButton_Click;
            // 
            // helpTelephoneLabel
            // 
            helpTelephoneLabel.AutoSize = true;
            helpTelephoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            helpTelephoneLabel.ForeColor = Color.FromArgb(224, 224, 224);
            helpTelephoneLabel.ImeMode = ImeMode.NoControl;
            helpTelephoneLabel.Location = new Point(30, 352);
            helpTelephoneLabel.Name = "helpTelephoneLabel";
            helpTelephoneLabel.Size = new Size(17, 21);
            helpTelephoneLabel.TabIndex = 0;
            helpTelephoneLabel.Text = "*";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(224, 224, 224);
            label20.ImeMode = ImeMode.NoControl;
            label20.Location = new Point(381, 57);
            label20.Name = "label20";
            label20.Size = new Size(230, 21);
            label20.TabIndex = 0;
            label20.Text = "ID zaplanowanego samochodu: ";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.FromArgb(224, 224, 224);
            label22.ImeMode = ImeMode.NoControl;
            label22.Location = new Point(77, 16);
            label22.Name = "label22";
            label22.Size = new Size(114, 21);
            label22.TabIndex = 0;
            label22.Text = "Opis Problemu";
            // 
            // ProblemCar
            // 
            ProblemCar.AutoCompleteCustomSource.AddRange(new string[] { "Acura", "Alfa Romeo", "Aston Martin", "Audi", "Bentley", "BMW", "Bugatti", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Citroën", "Dodge", "Ferrari", "Fiat", "Ford", "Genesis", "GMC", "Honda", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Lincoln", "Maserati", "Mazda", "McLaren", "Mercedes-Benz", "Mini", "Mitsubishi", "Nissan", "Pagani", "Peugeot", "Porsche", "RAM", "Renault", "Rolls-Royce", "Saab", "Subaru", "Suzuki", "Tesla", "Toyota", "Volkswagen (VW)", "Volvo" });
            ProblemCar.BackColor = Color.FromArgb(64, 64, 70);
            ProblemCar.CausesValidation = false;
            ProblemCar.Cursor = Cursors.IBeam;
            ProblemCar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ProblemCar.ForeColor = Color.FromArgb(224, 224, 224);
            ProblemCar.Location = new Point(55, 63);
            ProblemCar.Margin = new Padding(3, 4, 3, 4);
            ProblemCar.Multiline = true;
            ProblemCar.Name = "ProblemCar";
            ProblemCar.Size = new Size(867, 78);
            ProblemCar.TabIndex = 22;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(396, 9);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 0;
            label2.Text = "Dane Firmy";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(64, 64, 70);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label22);
            panel1.Controls.Add(ProblemCar);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(3, 376);
            panel1.MinimumSize = new Size(923, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 216);
            panel1.TabIndex = 30;
            // 
            // ViewScheduleCarButton
            // 
            ViewScheduleCarButton.BackColor = Color.FromArgb(94, 148, 255);
            ViewScheduleCarButton.FlatAppearance.BorderSize = 0;
            ViewScheduleCarButton.FlatStyle = FlatStyle.Flat;
            ViewScheduleCarButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ViewScheduleCarButton.ForeColor = Color.LightGray;
            ViewScheduleCarButton.ImeMode = ImeMode.NoControl;
            ViewScheduleCarButton.Location = new Point(1, 3);
            ViewScheduleCarButton.Name = "ViewScheduleCarButton";
            ViewScheduleCarButton.Size = new Size(291, 32);
            ViewScheduleCarButton.TabIndex = 31;
            ViewScheduleCarButton.Text = "przegłąd zaplanowanych samochód";
            ViewScheduleCarButton.UseVisualStyleBackColor = false;
            ViewScheduleCarButton.Click += ViewScheduleCarButton_Click;
            // 
            // CarComboBox
            // 
            CarComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CarComboBox.BackColor = Color.FromArgb(94, 148, 255);
            CarComboBox.FlatStyle = FlatStyle.Flat;
            CarComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CarComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            CarComboBox.FormattingEnabled = true;
            CarComboBox.ItemHeight = 21;
            CarComboBox.Items.AddRange(new object[] { "Elektronik", "Elektryk", "Mechanik", "Mechatronik", "Programista" });
            CarComboBox.Location = new Point(682, 88);
            CarComboBox.Name = "CarComboBox";
            CarComboBox.Size = new Size(140, 29);
            CarComboBox.TabIndex = 31;
            // 
            // CarButton
            // 
            CarButton.Anchor = AnchorStyles.Top;
            CarButton.BackColor = Color.FromArgb(94, 148, 255);
            CarButton.FlatAppearance.BorderSize = 0;
            CarButton.FlatStyle = FlatStyle.Flat;
            CarButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CarButton.ForeColor = Color.LightGray;
            CarButton.ImeMode = ImeMode.NoControl;
            CarButton.Location = new Point(396, 136);
            CarButton.Name = "CarButton";
            CarButton.Size = new Size(181, 32);
            CarButton.TabIndex = 24;
            CarButton.Text = "Autouzupełnianie";
            CarButton.UseVisualStyleBackColor = false;
            // 
            // ScheduleModelTextBox0
            // 
            ScheduleModelTextBox0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScheduleModelTextBox0.AutoCompleteCustomSource.AddRange(new string[] { "Acura", "Alfa Romeo", "Aston Martin", "Audi", "Bentley", "BMW", "Bugatti", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Citroën", "Dodge", "Ferrari", "Fiat", "Ford", "Genesis", "GMC", "Honda", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Lincoln", "Maserati", "Mazda", "McLaren", "Mercedes-Benz", "Mini", "Mitsubishi", "Nissan", "Pagani", "Peugeot", "Porsche", "RAM", "Renault", "Rolls-Royce", "Saab", "Subaru", "Suzuki", "Tesla", "Toyota", "Volkswagen (VW)", "Volvo" });
            ScheduleModelTextBox0.BackColor = Color.FromArgb(64, 64, 70);
            ScheduleModelTextBox0.CausesValidation = false;
            ScheduleModelTextBox0.Cursor = Cursors.IBeam;
            ScheduleModelTextBox0.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ScheduleModelTextBox0.ForeColor = Color.FromArgb(224, 224, 224);
            ScheduleModelTextBox0.Location = new Point(828, 86);
            ScheduleModelTextBox0.Margin = new Padding(3, 4, 3, 4);
            ScheduleModelTextBox0.Name = "ScheduleModelTextBox0";
            ScheduleModelTextBox0.PlaceholderText = "Model";
            ScheduleModelTextBox0.Size = new Size(157, 30);
            ScheduleModelTextBox0.TabIndex = 21;
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top;
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label28.ForeColor = Color.FromArgb(224, 224, 224);
            label28.ImeMode = ImeMode.NoControl;
            label28.Location = new Point(352, 171);
            label28.Name = "label28";
            label28.Size = new Size(273, 34);
            label28.TabIndex = 28;
            label28.Text = "* Autouzupełnianie wyszuka osobę po wpisaniu \r\nnumeru numeru telefonu";
            // 
            // ScheduleTimePicker
            // 
            ScheduleTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScheduleTimePicker.CalendarMonthBackground = Color.FromArgb(94, 148, 255);
            ScheduleTimePicker.CalendarTitleBackColor = SystemColors.ControlText;
            ScheduleTimePicker.CalendarTitleForeColor = Color.FromArgb(94, 148, 255);
            ScheduleTimePicker.CustomFormat = "dddd , dd MMMM yyyy";
            ScheduleTimePicker.Location = new Point(673, 165);
            ScheduleTimePicker.Name = "ScheduleTimePicker";
            ScheduleTimePicker.Size = new Size(247, 23);
            ScheduleTimePicker.TabIndex = 30;
            ScheduleTimePicker.Value = new DateTime(2024, 1, 16, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(224, 224, 224);
            label11.ImeMode = ImeMode.NoControl;
            label11.Location = new Point(682, 136);
            label11.Name = "label11";
            label11.Size = new Size(202, 21);
            label11.TabIndex = 0;
            label11.Text = "Zaplanowana data przyjęcia";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top;
            label18.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ImeMode = ImeMode.NoControl;
            label18.Location = new Point(396, 19);
            label18.Name = "label18";
            label18.Size = new Size(172, 28);
            label18.TabIndex = 19;
            label18.Text = "Zaproponowane dane";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(224, 224, 224);
            label15.ImeMode = ImeMode.NoControl;
            label15.Location = new Point(682, 56);
            label15.Name = "label15";
            label15.Size = new Size(54, 21);
            label15.TabIndex = 0;
            label15.Text = "Marka";
            // 
            // TelephonTextBox
            // 
            TelephonTextBox.BackColor = Color.FromArgb(64, 64, 70);
            TelephonTextBox.CausesValidation = false;
            TelephonTextBox.Cursor = Cursors.IBeam;
            TelephonTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TelephonTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            TelephonTextBox.Location = new Point(15, 160);
            TelephonTextBox.Margin = new Padding(3, 4, 3, 4);
            TelephonTextBox.Name = "TelephonTextBox";
            TelephonTextBox.PlaceholderText = "Telefon";
            TelephonTextBox.Size = new Size(171, 30);
            TelephonTextBox.TabIndex = 21;
            TelephonTextBox.MouseLeave += TelephonTextBox_MouseLeave;
            TelephonTextBox.MouseHover += TelephonTextBox_MouseHover;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ImeMode = ImeMode.NoControl;
            label19.Location = new Point(733, 8);
            label19.Name = "label19";
            label19.Size = new Size(176, 28);
            label19.TabIndex = 0;
            label19.Text = "Dane samochodu";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(224, 224, 224);
            label16.ImeMode = ImeMode.NoControl;
            label16.Location = new Point(394, 59);
            label16.Name = "label16";
            label16.Size = new Size(119, 21);
            label16.TabIndex = 25;
            label16.Text = "Imię i Nazwisko";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.BackColor = Color.FromArgb(64, 64, 70);
            SurnameTextBox.CausesValidation = false;
            SurnameTextBox.Cursor = Cursors.IBeam;
            SurnameTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            SurnameTextBox.Location = new Point(13, 102);
            SurnameTextBox.Margin = new Padding(3, 4, 3, 4);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.PlaceholderText = "Nazwisko";
            SurnameTextBox.Size = new Size(171, 30);
            SurnameTextBox.TabIndex = 21;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.FromArgb(224, 224, 224);
            label21.ImeMode = ImeMode.NoControl;
            label21.Location = new Point(394, 80);
            label21.Name = "label21";
            label21.Size = new Size(93, 21);
            label21.TabIndex = 24;
            label21.Text = "nr. Telefonu:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(36, 8);
            label6.Name = "label6";
            label6.Size = new Size(178, 28);
            label6.TabIndex = 0;
            label6.Text = "Dane Kontaktowe";
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Top;
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label25.ForeColor = Color.FromArgb(224, 224, 224);
            label25.ImeMode = ImeMode.NoControl;
            label25.Location = new Point(510, 101);
            label25.Name = "label25";
            label25.Size = new Size(41, 21);
            label25.TabIndex = 20;
            label25.Text = "brak";
            // 
            // DataScheduleView
            // 
            DataScheduleView.AllowUserToAddRows = false;
            DataScheduleView.AllowUserToDeleteRows = false;
            DataScheduleView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataScheduleView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataScheduleView.BorderStyle = BorderStyle.None;
            DataScheduleView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataScheduleView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataScheduleView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataScheduleView.Columns.AddRange(new DataGridViewColumn[] { btnAdd, BtnDelete, DataPrzyjecia_Column, ID_Column, Imie_Column, Nazwisko_Column, Telefon_Column, Marka_Column, Model_Column, Problem_Column });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataScheduleView.DefaultCellStyle = dataGridViewCellStyle2;
            DataScheduleView.EnableHeadersVisualStyles = false;
            DataScheduleView.Location = new Point(3, 43);
            DataScheduleView.Name = "DataScheduleView";
            DataScheduleView.RowTemplate.Height = 25;
            DataScheduleView.Size = new Size(1001, 530);
            DataScheduleView.TabIndex = 30;
            DataScheduleView.CellContentClick += DataScheduleView_CellContentClick;
            DataScheduleView.CellDoubleClick += DataScheduleView_CellDoubleClick;
            // 
            // ViewData
            // 
            ViewData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewData.Controls.Add(DataScheduleView);
            ViewData.Controls.Add(SearchScheduleCar);
            ViewData.Controls.Add(helpingLabel);
            ViewData.Location = new Point(1, 41);
            ViewData.Name = "ViewData";
            ViewData.Size = new Size(1007, 580);
            ViewData.TabIndex = 28;
            // 
            // SearchScheduleCar
            // 
            SearchScheduleCar.BackColor = Color.FromArgb(64, 64, 70);
            SearchScheduleCar.CausesValidation = false;
            SearchScheduleCar.Cursor = Cursors.IBeam;
            SearchScheduleCar.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SearchScheduleCar.ForeColor = Color.FromArgb(224, 224, 224);
            SearchScheduleCar.Location = new Point(3, 7);
            SearchScheduleCar.Name = "SearchScheduleCar";
            SearchScheduleCar.PlaceholderText = "Imię";
            SearchScheduleCar.Size = new Size(171, 30);
            SearchScheduleCar.TabIndex = 26;
            SearchScheduleCar.TextChanged += SearchScheduleCar_TextChanged;
            SearchScheduleCar.MouseLeave += SearchScheduleCar_MouseLeave;
            SearchScheduleCar.MouseHover += SearchScheduleCar_MouseHover;
            // 
            // helpingLabel
            // 
            helpingLabel.AutoSize = true;
            helpingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            helpingLabel.ForeColor = Color.FromArgb(224, 224, 224);
            helpingLabel.ImeMode = ImeMode.NoControl;
            helpingLabel.Location = new Point(193, 12);
            helpingLabel.Name = "helpingLabel";
            helpingLabel.Size = new Size(17, 21);
            helpingLabel.TabIndex = 0;
            helpingLabel.Text = "*";
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NameTextBox.CausesValidation = false;
            NameTextBox.Cursor = Cursors.IBeam;
            NameTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NameTextBox.Location = new Point(15, 51);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Imię";
            NameTextBox.Size = new Size(171, 30);
            NameTextBox.TabIndex = 21;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top;
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.FromArgb(224, 224, 224);
            label24.ImeMode = ImeMode.NoControl;
            label24.Location = new Point(394, 101);
            label24.Name = "label24";
            label24.Size = new Size(110, 21);
            label24.TabIndex = 23;
            label24.Text = "Marka i model";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(224, 224, 224);
            label17.ImeMode = ImeMode.NoControl;
            label17.Location = new Point(510, 59);
            label17.Name = "label17";
            label17.Size = new Size(41, 21);
            label17.TabIndex = 22;
            label17.Text = "brak";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(64, 64, 70);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(CarComboBox);
            panel2.Controls.Add(CarButton);
            panel2.Controls.Add(ScheduleModelTextBox0);
            panel2.Controls.Add(label28);
            panel2.Controls.Add(ScheduleTimePicker);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(TelephonTextBox);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(SurnameTextBox);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label25);
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(label24);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label23);
            panel2.ForeColor = Color.DimGray;
            panel2.Location = new Point(3, 94);
            panel2.MinimumSize = new Size(923, 216);
            panel2.Name = "panel2";
            panel2.Size = new Size(1001, 216);
            panel2.TabIndex = 31;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.ForeColor = Color.FromArgb(224, 224, 224);
            label23.ImeMode = ImeMode.NoControl;
            label23.Location = new Point(485, 80);
            label23.Name = "label23";
            label23.Size = new Size(41, 21);
            label23.TabIndex = 21;
            label23.Text = "brak";
            // 
            // EditData
            // 
            EditData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditData.Controls.Add(panel2);
            EditData.Controls.Add(panel1);
            EditData.Controls.Add(ID_label);
            EditData.Controls.Add(ScheduleCarButton);
            EditData.Controls.Add(helpTelephoneLabel);
            EditData.Controls.Add(label20);
            EditData.Location = new Point(1, 45);
            EditData.Name = "EditData";
            EditData.Size = new Size(1007, 595);
            EditData.TabIndex = 29;
            // 
            // btnAdd
            // 
            btnAdd.HeaderText = "Dodaj dane do bazy";
            btnAdd.Name = "btnAdd";
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Usuń";
            BtnDelete.Name = "BtnDelete";
            // 
            // DataPrzyjecia_Column
            // 
            DataPrzyjecia_Column.DataPropertyName = "DataPrzyjęcia";
            DataPrzyjecia_Column.HeaderText = "Zaplanowana data przyjęcia";
            DataPrzyjecia_Column.Name = "DataPrzyjecia_Column";
            // 
            // ID_Column
            // 
            ID_Column.DataPropertyName = "ID";
            ID_Column.HeaderText = "ID";
            ID_Column.Name = "ID_Column";
            ID_Column.Visible = false;
            // 
            // Imie_Column
            // 
            Imie_Column.DataPropertyName = "Imię";
            Imie_Column.HeaderText = "Imię";
            Imie_Column.Name = "Imie_Column";
            // 
            // Nazwisko_Column
            // 
            Nazwisko_Column.DataPropertyName = "Nazwisko";
            Nazwisko_Column.HeaderText = "Nazwisko";
            Nazwisko_Column.Name = "Nazwisko_Column";
            // 
            // Telefon_Column
            // 
            Telefon_Column.DataPropertyName = "Telefon";
            Telefon_Column.HeaderText = "Telefon";
            Telefon_Column.Name = "Telefon_Column";
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
            // Problem_Column
            // 
            Problem_Column.DataPropertyName = "Problem";
            Problem_Column.HeaderText = "Problem";
            Problem_Column.Name = "Problem_Column";
            // 
            // UC_ScheduleCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(ScheduleCarAddButton);
            Controls.Add(ViewScheduleCarButton);
            Controls.Add(ViewData);
            Controls.Add(EditData);
            Name = "UC_ScheduleCar";
            Size = new Size(1007, 643);
            Load += UC_ScheduleCarSelectTab_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataScheduleView).EndInit();
            ViewData.ResumeLayout(false);
            ViewData.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            EditData.ResumeLayout(false);
            EditData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ScheduleCarAddButton;
        public Label ID_label;
        private Button ScheduleCarButton;
        public Label helpTelephoneLabel;
        private Label label20;
        private Label label22;
        public TextBox ProblemCar;
        private Label label2;
        private Panel panel1;
        private Button ViewScheduleCarButton;
        public ComboBox CarComboBox;
        private Button CarButton;
        public TextBox ScheduleModelTextBox0;
        private Label label28;
        public DateTimePicker ScheduleTimePicker;
        private Label label11;
        private Label label18;
        private Label label15;
        public TextBox TelephonTextBox;
        private Label label19;
        private Label label16;
        public TextBox SurnameTextBox;
        private Label label21;
        private Label label6;
        private Label label25;
        private DataGridView DataScheduleView;
        public Panel ViewData;
        private TextBox SearchScheduleCar;
        public Label helpingLabel;
        public TextBox NameTextBox;
        private Label label24;
        private Label label17;
        private Panel panel2;
        private Label label23;
        public Panel EditData;
        private DataGridViewButtonColumn btnAdd;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewTextBoxColumn DataPrzyjecia_Column;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewTextBoxColumn Imie_Column;
        private DataGridViewTextBoxColumn Nazwisko_Column;
        private DataGridViewTextBoxColumn Telefon_Column;
        private DataGridViewTextBoxColumn Marka_Column;
        private DataGridViewTextBoxColumn Model_Column;
        private DataGridViewTextBoxColumn Problem_Column;
    }
}
