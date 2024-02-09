namespace Warsztat_2._0.UserControls.UC_CreateData
{
    partial class UC_AddClient
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
            ViewClients = new DataGridView();
            BtnDelete = new DataGridViewButtonColumn();
            ID_Column = new DataGridViewTextBoxColumn();
            Name_Column = new DataGridViewTextBoxColumn();
            Surname_Column = new DataGridViewTextBoxColumn();
            Telephone_Column = new DataGridViewTextBoxColumn();
            Adress_Column = new DataGridViewTextBoxColumn();
            NIP_Column = new DataGridViewTextBoxColumn();
            VIN_Client_Column = new DataGridViewTextBoxColumn();
            ViewCar = new DataGridView();
            BtnDeleteCar = new DataGridViewButtonColumn();
            ID_CAR = new DataGridViewTextBoxColumn();
            Marka_Column = new DataGridViewTextBoxColumn();
            Model_Column = new DataGridViewTextBoxColumn();
            Engine_Column = new DataGridViewTextBoxColumn();
            YearOfProduction_Column = new DataGridViewTextBoxColumn();
            VIN_Column = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            panel3 = new Panel();
            NameTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            label6 = new Label();
            label12 = new Label();
            DaneKlientaTxt = new Label();
            TelephoneTextBox = new MaskedTextBox();
            panelKontaktowy = new Panel();
            ID_Client_label = new Label();
            ButtonClientSave = new Button();
            panelDodatkowy = new Panel();
            NIPTextBox = new TextBox();
            panel7 = new Panel();
            panel8 = new Panel();
            AdressCompanyTextBox = new TextBox();
            ID_Client_label_0 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            setCarToClientButton = new Button();
            HelpMessage = new Label();
            SetCarToClientCheckBox = new CheckBox();
            SearchCarTextBox = new TextBox();
            panel2 = new Panel();
            TextBoxSearchClientData = new TextBox();
            panel9 = new Panel();
            panel10 = new Panel();
            label1 = new Label();
            label2 = new Label();
            ClearPanel = new Button();
            ButtonClientUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)ViewClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewCar).BeginInit();
            panelKontaktowy.SuspendLayout();
            panelDodatkowy.SuspendLayout();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // ViewClients
            // 
            ViewClients.AllowUserToAddRows = false;
            ViewClients.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ViewClients.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(94, 148, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewClients.Columns.AddRange(new DataGridViewColumn[] { BtnDelete, ID_Column, Name_Column, Surname_Column, Telephone_Column, Adress_Column, NIP_Column, VIN_Client_Column });
            ViewClients.Location = new Point(10, 45);
            ViewClients.Name = "ViewClients";
            ViewClients.RowTemplate.Height = 25;
            ViewClients.Size = new Size(807, 262);
            ViewClients.TabIndex = 3;
            ViewClients.CellContentClick += ViewClients_CellContentClick;
            ViewClients.CellDoubleClick += ViewClients_CellDoubleClick;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Usuń";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Width = 50;
            // 
            // ID_Column
            // 
            ID_Column.DataPropertyName = "ID";
            ID_Column.HeaderText = "Nr Klienta";
            ID_Column.Name = "ID_Column";
            ID_Column.ReadOnly = true;
            ID_Column.Width = 50;
            // 
            // Name_Column
            // 
            Name_Column.DataPropertyName = "Imię";
            Name_Column.HeaderText = "Imię";
            Name_Column.Name = "Name_Column";
            Name_Column.ReadOnly = true;
            Name_Column.Width = 150;
            // 
            // Surname_Column
            // 
            Surname_Column.DataPropertyName = "Nazwisko";
            Surname_Column.HeaderText = "Nazwisko";
            Surname_Column.Name = "Surname_Column";
            Surname_Column.ReadOnly = true;
            Surname_Column.Width = 150;
            // 
            // Telephone_Column
            // 
            Telephone_Column.DataPropertyName = "NrTelefonu";
            Telephone_Column.HeaderText = "Nr Telefonu";
            Telephone_Column.Name = "Telephone_Column";
            Telephone_Column.ReadOnly = true;
            Telephone_Column.Width = 150;
            // 
            // Adress_Column
            // 
            Adress_Column.DataPropertyName = "AdresFirmy";
            Adress_Column.HeaderText = "Adress";
            Adress_Column.Name = "Adress_Column";
            Adress_Column.ReadOnly = true;
            Adress_Column.Width = 200;
            // 
            // NIP_Column
            // 
            NIP_Column.DataPropertyName = "NIP";
            NIP_Column.HeaderText = "NIP";
            NIP_Column.Name = "NIP_Column";
            NIP_Column.ReadOnly = true;
            NIP_Column.Width = 150;
            // 
            // VIN_Client_Column
            // 
            VIN_Client_Column.DataPropertyName = "VIN_Samochodu";
            VIN_Client_Column.HeaderText = "VIN";
            VIN_Client_Column.Name = "VIN_Client_Column";
            // 
            // ViewCar
            // 
            ViewCar.AllowUserToAddRows = false;
            ViewCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewCar.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            ViewCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewCar.Columns.AddRange(new DataGridViewColumn[] { BtnDeleteCar, ID_CAR, Marka_Column, Model_Column, Engine_Column, YearOfProduction_Column, VIN_Column });
            ViewCar.Location = new Point(10, 365);
            ViewCar.Name = "ViewCar";
            ViewCar.RowTemplate.Height = 25;
            ViewCar.Size = new Size(807, 273);
            ViewCar.TabIndex = 22;
            ViewCar.CellContentClick += ViewCar_CellContentClick;
            // 
            // BtnDeleteCar
            // 
            BtnDeleteCar.HeaderText = "Usuń";
            BtnDeleteCar.Name = "BtnDeleteCar";
            BtnDeleteCar.Width = 50;
            // 
            // ID_CAR
            // 
            ID_CAR.DataPropertyName = "ID";
            ID_CAR.HeaderText = "ID";
            ID_CAR.Name = "ID_CAR";
            ID_CAR.ReadOnly = true;
            ID_CAR.Visible = false;
            // 
            // Marka_Column
            // 
            Marka_Column.DataPropertyName = "Marka";
            Marka_Column.HeaderText = "Marka";
            Marka_Column.Name = "Marka_Column";
            Marka_Column.ReadOnly = true;
            Marka_Column.Width = 150;
            // 
            // Model_Column
            // 
            Model_Column.DataPropertyName = "Model";
            Model_Column.HeaderText = "Model";
            Model_Column.Name = "Model_Column";
            Model_Column.ReadOnly = true;
            Model_Column.Width = 150;
            // 
            // Engine_Column
            // 
            Engine_Column.DataPropertyName = "Silnik";
            Engine_Column.HeaderText = "Silnik";
            Engine_Column.Name = "Engine_Column";
            Engine_Column.ReadOnly = true;
            Engine_Column.Width = 150;
            // 
            // YearOfProduction_Column
            // 
            YearOfProduction_Column.DataPropertyName = "RokProdukcji";
            YearOfProduction_Column.HeaderText = "Rok Produkcji";
            YearOfProduction_Column.Name = "YearOfProduction_Column";
            // 
            // VIN_Column
            // 
            VIN_Column.DataPropertyName = "VIN";
            VIN_Column.HeaderText = "VIN";
            VIN_Column.Name = "VIN_Column";
            VIN_Column.ReadOnly = true;
            VIN_Column.Width = 200;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GrayText;
            panel4.Location = new Point(4, 79);
            panel4.Name = "panel4";
            panel4.Size = new Size(155, 10);
            panel4.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GrayText;
            panel3.Location = new Point(4, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 10);
            panel3.TabIndex = 14;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.CausesValidation = false;
            NameTextBox.Cursor = Cursors.IBeam;
            NameTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NameTextBox.Location = new Point(4, 53);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Imię";
            NameTextBox.Size = new Size(155, 23);
            NameTextBox.TabIndex = 13;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.BackColor = Color.FromArgb(64, 64, 70);
            SurnameTextBox.BorderStyle = BorderStyle.None;
            SurnameTextBox.CausesValidation = false;
            SurnameTextBox.Cursor = Cursors.IBeam;
            SurnameTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            SurnameTextBox.Location = new Point(4, 110);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.PlaceholderText = "Nazwisko";
            SurnameTextBox.Size = new Size(155, 23);
            SurnameTextBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(98, 7);
            label6.Name = "label6";
            label6.Size = new Size(179, 28);
            label6.TabIndex = 0;
            label6.Text = "Dane kontaktowe klienta:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(224, 224, 224);
            label12.Location = new Point(4, 165);
            label12.Name = "label12";
            label12.Size = new Size(142, 24);
            label12.TabIndex = 0;
            label12.Text = "Telefon komórkowy:";
            // 
            // DaneKlientaTxt
            // 
            DaneKlientaTxt.BackColor = Color.FromArgb(94, 148, 255);
            DaneKlientaTxt.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DaneKlientaTxt.ForeColor = Color.LightGray;
            DaneKlientaTxt.Location = new Point(5, 4);
            DaneKlientaTxt.Name = "DaneKlientaTxt";
            DaneKlientaTxt.Size = new Size(119, 25);
            DaneKlientaTxt.TabIndex = 0;
            DaneKlientaTxt.Tag = "";
            DaneKlientaTxt.Text = "Dane Klienta";
            // 
            // TelephoneTextBox
            // 
            TelephoneTextBox.BackColor = Color.FromArgb(64, 64, 70);
            TelephoneTextBox.BorderStyle = BorderStyle.None;
            TelephoneTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TelephoneTextBox.ForeColor = Color.LightGray;
            TelephoneTextBox.Location = new Point(152, 168);
            TelephoneTextBox.Mask = "000-000-000";
            TelephoneTextBox.Name = "TelephoneTextBox";
            TelephoneTextBox.Size = new Size(125, 23);
            TelephoneTextBox.TabIndex = 15;
            // 
            // panelKontaktowy
            // 
            panelKontaktowy.BackColor = Color.FromArgb(64, 64, 70);
            panelKontaktowy.BorderStyle = BorderStyle.FixedSingle;
            panelKontaktowy.Controls.Add(TelephoneTextBox);
            panelKontaktowy.Controls.Add(NameTextBox);
            panelKontaktowy.Controls.Add(label12);
            panelKontaktowy.Controls.Add(panel4);
            panelKontaktowy.Controls.Add(ID_Client_label);
            panelKontaktowy.Controls.Add(label6);
            panelKontaktowy.Controls.Add(panel3);
            panelKontaktowy.Controls.Add(SurnameTextBox);
            panelKontaktowy.ForeColor = Color.DimGray;
            panelKontaktowy.Location = new Point(3, 3);
            panelKontaktowy.Name = "panelKontaktowy";
            panelKontaktowy.Size = new Size(322, 203);
            panelKontaktowy.TabIndex = 4;
            // 
            // ID_Client_label
            // 
            ID_Client_label.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ID_Client_label.ForeColor = Color.FromArgb(224, 224, 224);
            ID_Client_label.Location = new Point(278, 7);
            ID_Client_label.Name = "ID_Client_label";
            ID_Client_label.Size = new Size(35, 28);
            ID_Client_label.TabIndex = 0;
            ID_Client_label.Tag = "";
            ID_Client_label.Text = "0";
            // 
            // ButtonClientSave
            // 
            ButtonClientSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonClientSave.BackColor = Color.FromArgb(94, 148, 255);
            ButtonClientSave.FlatAppearance.BorderSize = 0;
            ButtonClientSave.FlatStyle = FlatStyle.Flat;
            ButtonClientSave.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonClientSave.ForeColor = Color.LightGray;
            ButtonClientSave.Location = new Point(5, 4);
            ButtonClientSave.MinimumSize = new Size(203, 35);
            ButtonClientSave.Name = "ButtonClientSave";
            ButtonClientSave.Size = new Size(206, 35);
            ButtonClientSave.TabIndex = 17;
            ButtonClientSave.Text = "Zapisz";
            ButtonClientSave.TextAlign = ContentAlignment.MiddleRight;
            ButtonClientSave.UseVisualStyleBackColor = false;
            ButtonClientSave.Click += ButtonClientSave_Click;
            // 
            // panelDodatkowy
            // 
            panelDodatkowy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelDodatkowy.BackColor = Color.FromArgb(64, 64, 70);
            panelDodatkowy.BorderStyle = BorderStyle.FixedSingle;
            panelDodatkowy.Controls.Add(NIPTextBox);
            panelDodatkowy.Controls.Add(panel7);
            panelDodatkowy.Controls.Add(panel8);
            panelDodatkowy.Controls.Add(AdressCompanyTextBox);
            panelDodatkowy.Controls.Add(ID_Client_label_0);
            panelDodatkowy.Controls.Add(label3);
            panelDodatkowy.ForeColor = Color.DimGray;
            panelDodatkowy.Location = new Point(550, 3);
            panelDodatkowy.Name = "panelDodatkowy";
            panelDodatkowy.Size = new Size(280, 203);
            panelDodatkowy.TabIndex = 4;
            // 
            // NIPTextBox
            // 
            NIPTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NIPTextBox.BorderStyle = BorderStyle.None;
            NIPTextBox.CausesValidation = false;
            NIPTextBox.Cursor = Cursors.IBeam;
            NIPTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NIPTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NIPTextBox.Location = new Point(19, 53);
            NIPTextBox.Name = "NIPTextBox";
            NIPTextBox.PlaceholderText = "NIP";
            NIPTextBox.Size = new Size(155, 23);
            NIPTextBox.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.GrayText;
            panel7.Location = new Point(19, 79);
            panel7.Name = "panel7";
            panel7.Size = new Size(155, 10);
            panel7.TabIndex = 14;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.GrayText;
            panel8.Location = new Point(19, 162);
            panel8.Name = "panel8";
            panel8.Size = new Size(226, 10);
            panel8.TabIndex = 14;
            // 
            // AdressCompanyTextBox
            // 
            AdressCompanyTextBox.BackColor = Color.FromArgb(64, 64, 70);
            AdressCompanyTextBox.BorderStyle = BorderStyle.None;
            AdressCompanyTextBox.CausesValidation = false;
            AdressCompanyTextBox.Cursor = Cursors.IBeam;
            AdressCompanyTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AdressCompanyTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            AdressCompanyTextBox.Location = new Point(19, 136);
            AdressCompanyTextBox.Name = "AdressCompanyTextBox";
            AdressCompanyTextBox.PlaceholderText = "Adres Firmy";
            AdressCompanyTextBox.Size = new Size(226, 23);
            AdressCompanyTextBox.TabIndex = 13;
            // 
            // ID_Client_label_0
            // 
            ID_Client_label_0.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ID_Client_label_0.ForeColor = Color.FromArgb(224, 224, 224);
            ID_Client_label_0.Location = new Point(255, 10);
            ID_Client_label_0.Name = "ID_Client_label_0";
            ID_Client_label_0.Size = new Size(35, 28);
            ID_Client_label_0.TabIndex = 0;
            ID_Client_label_0.Tag = "";
            ID_Client_label_0.Text = "0";
            // 
            // label3
            // 
            label3.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(82, 10);
            label3.Name = "label3";
            label3.Size = new Size(179, 28);
            label3.TabIndex = 0;
            label3.Text = "Dane dodatkowe klienta:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(64, 64, 68);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(setCarToClientButton);
            panel1.Controls.Add(HelpMessage);
            panel1.Controls.Add(SetCarToClientCheckBox);
            panel1.Controls.Add(ViewCar);
            panel1.Controls.Add(ViewClients);
            panel1.Controls.Add(SearchCarTextBox);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(TextBoxSearchClientData);
            panel1.Controls.Add(panel9);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(3, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 666);
            panel1.TabIndex = 4;
            // 
            // setCarToClientButton
            // 
            setCarToClientButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            setCarToClientButton.BackColor = Color.FromArgb(94, 148, 255);
            setCarToClientButton.FlatAppearance.BorderSize = 0;
            setCarToClientButton.FlatStyle = FlatStyle.Flat;
            setCarToClientButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            setCarToClientButton.ForeColor = Color.LightGray;
            setCarToClientButton.Location = new Point(698, 9);
            setCarToClientButton.Name = "setCarToClientButton";
            setCarToClientButton.Size = new Size(119, 35);
            setCarToClientButton.TabIndex = 26;
            setCarToClientButton.Text = "Przypisz";
            setCarToClientButton.UseVisualStyleBackColor = false;
            setCarToClientButton.Click += setCarToClientButton_Click;
            // 
            // HelpMessage
            // 
            HelpMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            HelpMessage.AutoSize = true;
            HelpMessage.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            HelpMessage.ForeColor = Color.Gray;
            HelpMessage.Location = new Point(480, 20);
            HelpMessage.Name = "HelpMessage";
            HelpMessage.Size = new Size(86, 24);
            HelpMessage.TabIndex = 25;
            HelpMessage.Text = "Wskazówka";
            HelpMessage.Click += HelpMessage_Click;
            // 
            // SetCarToClientCheckBox
            // 
            SetCarToClientCheckBox.AutoSize = true;
            SetCarToClientCheckBox.ForeColor = Color.FromArgb(224, 224, 224);
            SetCarToClientCheckBox.Location = new Point(460, 3);
            SetCarToClientCheckBox.Name = "SetCarToClientCheckBox";
            SetCarToClientCheckBox.Size = new Size(182, 19);
            SetCarToClientCheckBox.TabIndex = 24;
            SetCarToClientCheckBox.Text = "Przypisz samochód do klienta";
            SetCarToClientCheckBox.UseVisualStyleBackColor = true;
            SetCarToClientCheckBox.CheckedChanged += SetCarToClientCheckBox_CheckedChanged;
            // 
            // SearchCarTextBox
            // 
            SearchCarTextBox.BackColor = Color.FromArgb(64, 64, 70);
            SearchCarTextBox.BorderStyle = BorderStyle.None;
            SearchCarTextBox.CausesValidation = false;
            SearchCarTextBox.Cursor = Cursors.IBeam;
            SearchCarTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SearchCarTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            SearchCarTextBox.Location = new Point(10, 323);
            SearchCarTextBox.Name = "SearchCarTextBox";
            SearchCarTextBox.PlaceholderText = "Szukaj samochód";
            SearchCarTextBox.Size = new Size(405, 23);
            SearchCarTextBox.TabIndex = 1;
            SearchCarTextBox.TextChanged += SearchCarTextBox_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 68);
            panel2.Location = new Point(10, 349);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 10);
            panel2.TabIndex = 0;
            // 
            // TextBoxSearchClientData
            // 
            TextBoxSearchClientData.BackColor = Color.FromArgb(64, 64, 70);
            TextBoxSearchClientData.BorderStyle = BorderStyle.None;
            TextBoxSearchClientData.CausesValidation = false;
            TextBoxSearchClientData.Cursor = Cursors.IBeam;
            TextBoxSearchClientData.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxSearchClientData.ForeColor = Color.FromArgb(224, 224, 224);
            TextBoxSearchClientData.Location = new Point(4, 3);
            TextBoxSearchClientData.Name = "TextBoxSearchClientData";
            TextBoxSearchClientData.PlaceholderText = "Szukaj Klienta";
            TextBoxSearchClientData.Size = new Size(411, 23);
            TextBoxSearchClientData.TabIndex = 0;
            TextBoxSearchClientData.TextChanged += TextBoxSearchClientData_TextChanged;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(64, 64, 68);
            panel9.Location = new Point(4, 29);
            panel9.Name = "panel9";
            panel9.Size = new Size(411, 10);
            panel9.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.Controls.Add(label1);
            panel10.Controls.Add(label2);
            panel10.Controls.Add(DaneKlientaTxt);
            panel10.Controls.Add(ClearPanel);
            panel10.Controls.Add(ButtonClientUpdate);
            panel10.Controls.Add(ButtonClientSave);
            panel10.Location = new Point(331, 11);
            panel10.MinimumSize = new Size(215, 195);
            panel10.Name = "panel10";
            panel10.Size = new Size(215, 195);
            panel10.TabIndex = 25;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(94, 148, 255);
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(8, 162);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Tag = "";
            label1.Text = "Panel";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(94, 148, 255);
            label2.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(7, 82);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 0;
            label2.Tag = "";
            label2.Text = "Dane Klienta";
            // 
            // ClearPanel
            // 
            ClearPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ClearPanel.BackColor = Color.FromArgb(94, 148, 255);
            ClearPanel.FlatAppearance.BorderSize = 0;
            ClearPanel.FlatStyle = FlatStyle.Flat;
            ClearPanel.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ClearPanel.ForeColor = Color.LightGray;
            ClearPanel.Location = new Point(5, 157);
            ClearPanel.MinimumSize = new Size(203, 35);
            ClearPanel.Name = "ClearPanel";
            ClearPanel.Size = new Size(206, 35);
            ClearPanel.TabIndex = 17;
            ClearPanel.Text = "Wyczyść";
            ClearPanel.TextAlign = ContentAlignment.MiddleRight;
            ClearPanel.UseVisualStyleBackColor = false;
            ClearPanel.Click += ClearPanel_Click;
            // 
            // ButtonClientUpdate
            // 
            ButtonClientUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonClientUpdate.BackColor = Color.FromArgb(94, 148, 255);
            ButtonClientUpdate.FlatAppearance.BorderSize = 0;
            ButtonClientUpdate.FlatStyle = FlatStyle.Flat;
            ButtonClientUpdate.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonClientUpdate.ForeColor = Color.LightGray;
            ButtonClientUpdate.Location = new Point(5, 81);
            ButtonClientUpdate.MinimumSize = new Size(203, 35);
            ButtonClientUpdate.Name = "ButtonClientUpdate";
            ButtonClientUpdate.Size = new Size(206, 35);
            ButtonClientUpdate.TabIndex = 17;
            ButtonClientUpdate.Text = "Odśwież";
            ButtonClientUpdate.TextAlign = ContentAlignment.MiddleRight;
            ButtonClientUpdate.UseVisualStyleBackColor = false;
            ButtonClientUpdate.Click += ButtonClientUpdate_Click;
            // 
            // UC_AddClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Controls.Add(panel10);
            Controls.Add(panelKontaktowy);
            Controls.Add(panelDodatkowy);
            MinimumSize = new Size(870, 580);
            Name = "UC_AddClient";
            Size = new Size(853, 580);
            Load += UC_AddClient_Load;
            ((System.ComponentModel.ISupportInitialize)ViewClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewCar).EndInit();
            panelKontaktowy.ResumeLayout(false);
            panelKontaktowy.PerformLayout();
            panelDodatkowy.ResumeLayout(false);
            panelDodatkowy.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private Label label12;
        private Label DaneKlientaTxt;
        private DataGridView ViewClients;
        private DataGridView ViewCar;
        private TextBox SurnameTextBox;
        private Panel panel3;
        private Panel panel4;
        private TextBox NameTextBox;
        private MaskedTextBox TelephoneTextBox;
        private Panel panelKontaktowy;
        private Button ButtonClientSave;
        private Panel panelDodatkowy;
        private TextBox NIPTextBox;
        private Panel panel7;
        private Panel panel8;
        private TextBox AdressCompanyTextBox;
        private Panel panel1;
        private TextBox TextBoxSearchClientData;
        private Panel panel9;
        private Panel panel10;
        private TextBox SearchCarTextBox;
        private Panel panel2;
        private Label label1;
        private Button ClearPanel;
        private Label label2;
        private Button ButtonClientUpdate;
        private Label label3;
        protected Label ID_Client_label;
        protected Label ID_Client_label_0;
        private CheckBox SetCarToClientCheckBox;
        private Label HelpMessage;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewTextBoxColumn Name_Column;
        private DataGridViewTextBoxColumn Surname_Column;
        private DataGridViewTextBoxColumn Telephone_Column;
        private DataGridViewTextBoxColumn Adress_Column;
        private DataGridViewTextBoxColumn NIP_Column;
        private DataGridViewTextBoxColumn VIN_Client_Column;
        private Button setCarToClientButton;
        private DataGridViewButtonColumn BtnDeleteCar;
        private DataGridViewTextBoxColumn ID_CAR;
        private DataGridViewTextBoxColumn Marka_Column;
        private DataGridViewTextBoxColumn Model_Column;
        private DataGridViewTextBoxColumn Engine_Column;
        private DataGridViewTextBoxColumn YearOfProduction_Column;
        private DataGridViewTextBoxColumn VIN_Column;
    }
}
