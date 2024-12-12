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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ViewClients = new DataGridView();
            BtnDelete = new DataGridViewButtonColumn();
            UniqueKey_Column = new DataGridViewTextBoxColumn();
            ID_Column = new DataGridViewTextBoxColumn();
            Name_Column = new DataGridViewTextBoxColumn();
            Surname_Column = new DataGridViewTextBoxColumn();
            Telephone_Column = new DataGridViewTextBoxColumn();
            Adress_Column = new DataGridViewTextBoxColumn();
            NIP_Column = new DataGridViewTextBoxColumn();
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
            TextBoxSearchClientData = new TextBox();
            panel9 = new Panel();
            panel10 = new Panel();
            label1 = new Label();
            label2 = new Label();
            ClearPanel = new Button();
            ButtonClientUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)ViewClients).BeginInit();
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
            ViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewClients.BorderStyle = BorderStyle.None;
            ViewClients.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ViewClients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewClients.Columns.AddRange(new DataGridViewColumn[] { BtnDelete, UniqueKey_Column, ID_Column, Name_Column, Surname_Column, Telephone_Column, Adress_Column, NIP_Column });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ViewClients.DefaultCellStyle = dataGridViewCellStyle2;
            ViewClients.EnableHeadersVisualStyles = false;
            ViewClients.Location = new Point(10, 45);
            ViewClients.Name = "ViewClients";
            ViewClients.RowTemplate.Height = 25;
            ViewClients.Size = new Size(955, 262);
            ViewClients.TabIndex = 3;
            ViewClients.CellContentClick += ViewClients_CellContentClick;
            ViewClients.CellDoubleClick += ViewClients_CellDoubleClick;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Usuń";
            BtnDelete.Name = "BtnDelete";
            // 
            // UniqueKey_Column
            // 
            UniqueKey_Column.DataPropertyName = "UniqueKey";
            UniqueKey_Column.HeaderText = "Unikatowy klucz";
            UniqueKey_Column.Name = "UniqueKey_Column";
            UniqueKey_Column.Visible = false;
            // 
            // ID_Column
            // 
            ID_Column.DataPropertyName = "ID";
            ID_Column.HeaderText = "Nr Klienta";
            ID_Column.Name = "ID_Column";
            ID_Column.ReadOnly = true;
            // 
            // Name_Column
            // 
            Name_Column.DataPropertyName = "Imię";
            Name_Column.HeaderText = "Imię";
            Name_Column.Name = "Name_Column";
            Name_Column.ReadOnly = true;
            // 
            // Surname_Column
            // 
            Surname_Column.DataPropertyName = "Nazwisko";
            Surname_Column.HeaderText = "Nazwisko";
            Surname_Column.Name = "Surname_Column";
            Surname_Column.ReadOnly = true;
            // 
            // Telephone_Column
            // 
            Telephone_Column.DataPropertyName = "NrTelefonu";
            Telephone_Column.HeaderText = "Nr Telefonu";
            Telephone_Column.Name = "Telephone_Column";
            Telephone_Column.ReadOnly = true;
            // 
            // Adress_Column
            // 
            Adress_Column.DataPropertyName = "AdresFirmy";
            Adress_Column.HeaderText = "Adress";
            Adress_Column.Name = "Adress_Column";
            Adress_Column.ReadOnly = true;
            // 
            // NIP_Column
            // 
            NIP_Column.DataPropertyName = "NIP";
            NIP_Column.HeaderText = "NIP";
            NIP_Column.Name = "NIP_Column";
            NIP_Column.ReadOnly = true;
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
            ButtonClientSave.Size = new Size(333, 35);
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
            panelDodatkowy.Location = new Point(678, 3);
            panelDodatkowy.Name = "panelDodatkowy";
            panelDodatkowy.Size = new Size(322, 203);
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
            panel8.Size = new Size(283, 10);
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
            AdressCompanyTextBox.Size = new Size(283, 23);
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
            panel1.Controls.Add(ViewClients);
            panel1.Controls.Add(TextBoxSearchClientData);
            panel1.Controls.Add(panel9);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(3, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 341);
            panel1.TabIndex = 4;
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
            panel10.Size = new Size(341, 195);
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
            ClearPanel.Size = new Size(333, 35);
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
            ButtonClientUpdate.Size = new Size(333, 35);
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
            MinimumSize = new Size(915, 580);
            Name = "UC_AddClient";
            Size = new Size(1040, 580);
            Load += UC_AddClient_Load;
            ((System.ComponentModel.ISupportInitialize)ViewClients).EndInit();
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
        private Label label1;
        private Button ClearPanel;
        private Label label2;
        private Button ButtonClientUpdate;
        private Label label3;
        protected Label ID_Client_label;
        protected Label ID_Client_label_0;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewTextBoxColumn UniqueKey_Column;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewTextBoxColumn Name_Column;
        private DataGridViewTextBoxColumn Surname_Column;
        private DataGridViewTextBoxColumn Telephone_Column;
        private DataGridViewTextBoxColumn Adress_Column;
        private DataGridViewTextBoxColumn NIP_Column;
        }
}
