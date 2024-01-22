namespace Warsztat_2._0.UserControls
{
    partial class UC_AddCar
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
            PojemnośćSilnikaSearch = new TextBox();
            MarkaSearch = new TextBox();
            ModelSearch = new TextBox();
            RokProdukcjiListBox = new ListBox();
            ModelListBox = new ListBox();
            EngineListBox = new ListBox();
            MarkaListBox = new ListBox();
            ButtoCarSave = new Button();
            panelDodatkowy = new Panel();
            RokProdukcjitextBox = new TextBox();
            LeftDocumentsCheck = new CheckBox();
            label6 = new Label();
            AddVinToClient = new Button();
            VINTextBox = new TextBox();
            panel2 = new Panel();
            MileageTextBox = new TextBox();
            panel1 = new Panel();
            RegistrationNumberTextBox = new TextBox();
            panel4 = new Panel();
            ClientsList = new ListBox();
            label2 = new Label();
            NumLenghtNadwoziaLabel = new Label();
            panel3 = new Panel();
            TestDriveChceck = new CheckBox();
            LeftKeyChceck = new CheckBox();
            panelDodatkowy.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // PojemnośćSilnikaSearch
            // 
            PojemnośćSilnikaSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PojemnośćSilnikaSearch.Location = new Point(384, 36);
            PojemnośćSilnikaSearch.Name = "PojemnośćSilnikaSearch";
            PojemnośćSilnikaSearch.Size = new Size(169, 23);
            PojemnośćSilnikaSearch.TabIndex = 5;
            // 
            // MarkaSearch
            // 
            MarkaSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MarkaSearch.Location = new Point(34, 36);
            MarkaSearch.Name = "MarkaSearch";
            MarkaSearch.Size = new Size(169, 23);
            MarkaSearch.TabIndex = 5;
            // 
            // ModelSearch
            // 
            ModelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ModelSearch.Location = new Point(208, 36);
            ModelSearch.Name = "ModelSearch";
            ModelSearch.Size = new Size(169, 23);
            ModelSearch.TabIndex = 5;
            // 
            // RokProdukcjiListBox
            // 
            RokProdukcjiListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RokProdukcjiListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RokProdukcjiListBox.FormattingEnabled = true;
            RokProdukcjiListBox.ItemHeight = 21;
            RokProdukcjiListBox.Items.AddRange(new object[] { "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020" });
            RokProdukcjiListBox.Location = new Point(559, 57);
            RokProdukcjiListBox.Name = "RokProdukcjiListBox";
            RokProdukcjiListBox.Size = new Size(169, 361);
            RokProdukcjiListBox.TabIndex = 4;
            // 
            // ModelListBox
            // 
            ModelListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ModelListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModelListBox.FormattingEnabled = true;
            ModelListBox.ItemHeight = 21;
            ModelListBox.Location = new Point(209, 57);
            ModelListBox.Name = "ModelListBox";
            ModelListBox.Size = new Size(169, 361);
            ModelListBox.TabIndex = 4;
            ModelListBox.Click += ModelListBox_Click;
            // 
            // EngineListBox
            // 
            EngineListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            EngineListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EngineListBox.FormattingEnabled = true;
            EngineListBox.ItemHeight = 21;
            EngineListBox.Location = new Point(384, 57);
            EngineListBox.Name = "EngineListBox";
            EngineListBox.Size = new Size(169, 361);
            EngineListBox.TabIndex = 4;
            // 
            // MarkaListBox
            // 
            MarkaListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MarkaListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MarkaListBox.ItemHeight = 21;
            MarkaListBox.Location = new Point(34, 57);
            MarkaListBox.Name = "MarkaListBox";
            MarkaListBox.Size = new Size(169, 361);
            MarkaListBox.TabIndex = 4;
            MarkaListBox.Click += MarkaListBox_Click;
            // 
            // ButtoCarSave
            // 
            ButtoCarSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtoCarSave.BackColor = Color.FromArgb(94, 148, 255);
            ButtoCarSave.FlatAppearance.BorderSize = 0;
            ButtoCarSave.FlatStyle = FlatStyle.Flat;
            ButtoCarSave.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtoCarSave.ForeColor = Color.LightGray;
            ButtoCarSave.Location = new Point(0, 0);
            ButtoCarSave.Name = "ButtoCarSave";
            ButtoCarSave.Size = new Size(1019, 34);
            ButtoCarSave.TabIndex = 27;
            ButtoCarSave.Text = "Zapisz";
            ButtoCarSave.UseVisualStyleBackColor = false;
            ButtoCarSave.Click += ButtoCarSave_Click;
            // 
            // panelDodatkowy
            // 
            panelDodatkowy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelDodatkowy.BackColor = Color.FromArgb(64, 64, 70);
            panelDodatkowy.BorderStyle = BorderStyle.FixedSingle;
            panelDodatkowy.Controls.Add(RokProdukcjitextBox);
            panelDodatkowy.Controls.Add(PojemnośćSilnikaSearch);
            panelDodatkowy.Controls.Add(MarkaListBox);
            panelDodatkowy.Controls.Add(MarkaSearch);
            panelDodatkowy.Controls.Add(EngineListBox);
            panelDodatkowy.Controls.Add(ModelSearch);
            panelDodatkowy.Controls.Add(ModelListBox);
            panelDodatkowy.Controls.Add(RokProdukcjiListBox);
            panelDodatkowy.ForeColor = Color.DimGray;
            panelDodatkowy.Location = new Point(3, 39);
            panelDodatkowy.Name = "panelDodatkowy";
            panelDodatkowy.Size = new Size(744, 534);
            panelDodatkowy.TabIndex = 28;
            // 
            // RokProdukcjitextBox
            // 
            RokProdukcjitextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            RokProdukcjitextBox.Location = new Point(559, 36);
            RokProdukcjitextBox.Name = "RokProdukcjitextBox";
            RokProdukcjitextBox.Size = new Size(169, 23);
            RokProdukcjitextBox.TabIndex = 5;
            // 
            // LeftDocumentsCheck
            // 
            LeftDocumentsCheck.BackColor = Color.FromArgb(64, 64, 70);
            LeftDocumentsCheck.Checked = true;
            LeftDocumentsCheck.CheckState = CheckState.Checked;
            LeftDocumentsCheck.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LeftDocumentsCheck.ForeColor = Color.DimGray;
            LeftDocumentsCheck.Location = new Point(15, 244);
            LeftDocumentsCheck.Name = "LeftDocumentsCheck";
            LeftDocumentsCheck.Size = new Size(230, 25);
            LeftDocumentsCheck.TabIndex = 22;
            LeftDocumentsCheck.Text = "Pozostawione Dokumenty samochodu";
            LeftDocumentsCheck.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(105, 9);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 20;
            label6.Text = "Dane Techniczne";
            // 
            // AddVinToClient
            // 
            AddVinToClient.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddVinToClient.BackColor = Color.FromArgb(94, 148, 255);
            AddVinToClient.FlatAppearance.BorderSize = 0;
            AddVinToClient.FlatStyle = FlatStyle.Flat;
            AddVinToClient.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddVinToClient.ForeColor = Color.LightGray;
            AddVinToClient.Location = new Point(15, 335);
            AddVinToClient.Name = "AddVinToClient";
            AddVinToClient.Size = new Size(243, 35);
            AddVinToClient.TabIndex = 19;
            AddVinToClient.Text = "Przypisz samochód do klienta";
            AddVinToClient.TextAlign = ContentAlignment.MiddleLeft;
            AddVinToClient.UseVisualStyleBackColor = false;
            AddVinToClient.Click += AddVinToClient_Click;
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
            VINTextBox.Location = new Point(40, 202);
            VINTextBox.Name = "VINTextBox";
            VINTextBox.PlaceholderText = "VIN";
            VINTextBox.Size = new Size(199, 23);
            VINTextBox.TabIndex = 17;
            VINTextBox.TextChanged += VINTextBox_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GrayText;
            panel2.Location = new Point(40, 228);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 10);
            panel2.TabIndex = 18;
            // 
            // MileageTextBox
            // 
            MileageTextBox.BackColor = Color.FromArgb(64, 64, 70);
            MileageTextBox.BorderStyle = BorderStyle.None;
            MileageTextBox.CausesValidation = false;
            MileageTextBox.Cursor = Cursors.IBeam;
            MileageTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MileageTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            MileageTextBox.Location = new Point(40, 118);
            MileageTextBox.Name = "MileageTextBox";
            MileageTextBox.PlaceholderText = "Przebieg";
            MileageTextBox.Size = new Size(199, 23);
            MileageTextBox.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Location = new Point(40, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 10);
            panel1.TabIndex = 16;
            // 
            // RegistrationNumberTextBox
            // 
            RegistrationNumberTextBox.BackColor = Color.FromArgb(64, 64, 70);
            RegistrationNumberTextBox.BorderStyle = BorderStyle.None;
            RegistrationNumberTextBox.CausesValidation = false;
            RegistrationNumberTextBox.Cursor = Cursors.IBeam;
            RegistrationNumberTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistrationNumberTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            RegistrationNumberTextBox.Location = new Point(40, 59);
            RegistrationNumberTextBox.Name = "RegistrationNumberTextBox";
            RegistrationNumberTextBox.PlaceholderText = "Numer Rejestracji";
            RegistrationNumberTextBox.Size = new Size(199, 23);
            RegistrationNumberTextBox.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GrayText;
            panel4.Location = new Point(40, 85);
            panel4.Name = "panel4";
            panel4.Size = new Size(199, 10);
            panel4.TabIndex = 16;
            // 
            // ClientsList
            // 
            ClientsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ClientsList.FormattingEnabled = true;
            ClientsList.ItemHeight = 15;
            ClientsList.Location = new Point(14, 376);
            ClientsList.Name = "ClientsList";
            ClientsList.Size = new Size(244, 154);
            ClientsList.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(37, 178);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 10;
            label2.Text = "VIN:";
            // 
            // NumLenghtNadwoziaLabel
            // 
            NumLenghtNadwoziaLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NumLenghtNadwoziaLabel.ForeColor = Color.Silver;
            NumLenghtNadwoziaLabel.Location = new Point(73, 183);
            NumLenghtNadwoziaLabel.Name = "NumLenghtNadwoziaLabel";
            NumLenghtNadwoziaLabel.Size = new Size(34, 16);
            NumLenghtNadwoziaLabel.TabIndex = 0;
            NumLenghtNadwoziaLabel.Text = "0";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(64, 64, 70);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TestDriveChceck);
            panel3.Controls.Add(LeftKeyChceck);
            panel3.Controls.Add(LeftDocumentsCheck);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(NumLenghtNadwoziaLabel);
            panel3.Controls.Add(AddVinToClient);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(VINTextBox);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(MileageTextBox);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(ClientsList);
            panel3.Controls.Add(RegistrationNumberTextBox);
            panel3.Controls.Add(panel4);
            panel3.ForeColor = Color.DimGray;
            panel3.Location = new Point(745, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 534);
            panel3.TabIndex = 29;
            // 
            // TestDriveChceck
            // 
            TestDriveChceck.BackColor = Color.FromArgb(64, 64, 70);
            TestDriveChceck.Checked = true;
            TestDriveChceck.CheckState = CheckState.Checked;
            TestDriveChceck.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TestDriveChceck.ForeColor = Color.DimGray;
            TestDriveChceck.Location = new Point(14, 294);
            TestDriveChceck.Name = "TestDriveChceck";
            TestDriveChceck.Size = new Size(230, 25);
            TestDriveChceck.TabIndex = 23;
            TestDriveChceck.Text = "Klient wyraża zgodę na TestDrive";
            TestDriveChceck.UseVisualStyleBackColor = false;
            // 
            // LeftKeyChceck
            // 
            LeftKeyChceck.BackColor = Color.FromArgb(64, 64, 70);
            LeftKeyChceck.Checked = true;
            LeftKeyChceck.CheckState = CheckState.Checked;
            LeftKeyChceck.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LeftKeyChceck.ForeColor = Color.DimGray;
            LeftKeyChceck.Location = new Point(14, 269);
            LeftKeyChceck.Name = "LeftKeyChceck";
            LeftKeyChceck.Size = new Size(230, 25);
            LeftKeyChceck.TabIndex = 23;
            LeftKeyChceck.Text = "Pozostawione Kluczyki samochodu";
            LeftKeyChceck.UseVisualStyleBackColor = false;
            // 
            // UC_AddCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 70);
            Controls.Add(ButtoCarSave);
            Controls.Add(panelDodatkowy);
            Controls.Add(panel3);
            Name = "UC_AddCar";
            Size = new Size(1019, 580);
            Load += UC_AddCar_Load;
            panelDodatkowy.ResumeLayout(false);
            panelDodatkowy.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public ListBox CategoryListBox;
        public ListBox RokProdukcjiListBox;
        public ListBox ModelListBox;
        private ListBox MarkaListBox;
        private TextBox PojemnośćSilnikaSearch;
        private TextBox MarkaSearch;
        private TextBox ModelSearch;
        public ListBox EngineListBox;
        private Button ButtoCarSave;
        private Panel panelDodatkowy;
        private CheckBox LeftDocumentsCheck;
        private Label label6;
        private Button AddVinToClient;
        private TextBox VINTextBox;
        private Panel panel2;
        private TextBox MileageTextBox;
        private Panel panel1;
        private TextBox RegistrationNumberTextBox;
        private Panel panel4;
        private ListBox ClientsList;
        private Label label2;
        public Label NumLenghtNadwoziaLabel;
        private Panel panel3;
        private CheckBox TestDriveChceck;
        private CheckBox LeftKeyChceck;
        private TextBox RokProdukcjitextBox;
    }
}
