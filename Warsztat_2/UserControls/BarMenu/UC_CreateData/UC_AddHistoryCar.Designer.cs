namespace Warsztat_2.UserControls.BarMenu.UC_CreateData
{
    partial class UC_AddHistoryCar
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
            panel3 = new Panel();
            MileageTextBox = new TextBox();
            TestDriveChceck = new CheckBox();
            LeftKeyChceck = new CheckBox();
            LeftDocumentsCheck = new CheckBox();
            label6 = new Label();
            NumLenghtNadwoziaLabel = new Label();
            label2 = new Label();
            VINTextBox = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            RegistrationNumberTextBox = new TextBox();
            panel4 = new Panel();
            ViewHistory = new DataGridView();
            BtnDelete = new DataGridViewButtonColumn();
            ID_Column = new DataGridViewTextBoxColumn();
            DataPrzyjęcia_Column = new DataGridViewTextBoxColumn();
            NrRejestracji_Column = new DataGridViewTextBoxColumn();
            Przebieg_Column = new DataGridViewTextBoxColumn();
            Documents_Column = new DataGridViewCheckBoxColumn();
            Key_Column = new DataGridViewCheckBoxColumn();
            TestDrive_Column = new DataGridViewCheckBoxColumn();
            Zlecenie_Column = new DataGridViewTextBoxColumn();
            Diagnostic_Column = new DataGridViewTextBoxColumn();
            Repair_Column = new DataGridViewTextBoxColumn();
            SaveHistoryButton = new Button();
            DiagnosticTextBox = new TextBox();
            OrderTextBox = new TextBox();
            panel5 = new Panel();
            ScheduleTimePicker = new DateTimePicker();
            RepairTextBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            ViewAllCar = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            VIN_Car_Column = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewHistory).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewAllCar).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(64, 64, 70);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(MileageTextBox);
            panel3.Controls.Add(TestDriveChceck);
            panel3.Controls.Add(LeftKeyChceck);
            panel3.Controls.Add(LeftDocumentsCheck);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(NumLenghtNadwoziaLabel);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(VINTextBox);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(RegistrationNumberTextBox);
            panel3.Controls.Add(panel4);
            panel3.ForeColor = Color.DimGray;
            panel3.Location = new Point(763, 36);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 329);
            panel3.TabIndex = 30;
            // 
            // MileageTextBox
            // 
            MileageTextBox.BackColor = Color.FromArgb(64, 64, 70);
            MileageTextBox.BorderStyle = BorderStyle.None;
            MileageTextBox.CausesValidation = false;
            MileageTextBox.Cursor = Cursors.IBeam;
            MileageTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MileageTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            MileageTextBox.Location = new Point(40, 115);
            MileageTextBox.Name = "MileageTextBox";
            MileageTextBox.PlaceholderText = "Przebieg";
            MileageTextBox.Size = new Size(199, 23);
            MileageTextBox.TabIndex = 1;
            // 
            // TestDriveChceck
            // 
            TestDriveChceck.BackColor = Color.FromArgb(64, 64, 70);
            TestDriveChceck.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TestDriveChceck.ForeColor = Color.DimGray;
            TestDriveChceck.Location = new Point(14, 294);
            TestDriveChceck.Name = "TestDriveChceck";
            TestDriveChceck.Size = new Size(230, 25);
            TestDriveChceck.TabIndex = 5;
            TestDriveChceck.Text = "Klient wyraża zgodę na TestDrive";
            TestDriveChceck.UseVisualStyleBackColor = false;
            // 
            // LeftKeyChceck
            // 
            LeftKeyChceck.BackColor = Color.FromArgb(64, 64, 70);
            LeftKeyChceck.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LeftKeyChceck.ForeColor = Color.DimGray;
            LeftKeyChceck.Location = new Point(14, 269);
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
            LeftDocumentsCheck.Location = new Point(15, 244);
            LeftDocumentsCheck.Name = "LeftDocumentsCheck";
            LeftDocumentsCheck.Size = new Size(230, 25);
            LeftDocumentsCheck.TabIndex = 3;
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
            // NumLenghtNadwoziaLabel
            // 
            NumLenghtNadwoziaLabel.ForeColor = Color.Silver;
            NumLenghtNadwoziaLabel.Location = new Point(52, 185);
            NumLenghtNadwoziaLabel.Name = "NumLenghtNadwoziaLabel";
            NumLenghtNadwoziaLabel.Size = new Size(34, 16);
            NumLenghtNadwoziaLabel.TabIndex = 0;
            NumLenghtNadwoziaLabel.Text = "0";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(16, 180);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 10;
            label2.Text = "VIN:";
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
            VINTextBox.Location = new Point(14, 202);
            VINTextBox.Name = "VINTextBox";
            VINTextBox.PlaceholderText = "VIN";
            VINTextBox.Size = new Size(225, 23);
            VINTextBox.TabIndex = 2;
            VINTextBox.TextChanged += VINTextBox_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GrayText;
            panel2.Location = new Point(14, 228);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 10);
            panel2.TabIndex = 18;
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
            RegistrationNumberTextBox.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GrayText;
            panel4.Location = new Point(40, 85);
            panel4.Name = "panel4";
            panel4.Size = new Size(199, 10);
            panel4.TabIndex = 16;
            // 
            // ViewHistory
            // 
            ViewHistory.AllowUserToAddRows = false;
            ViewHistory.AllowUserToDeleteRows = false;
            ViewHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewHistory.BorderStyle = BorderStyle.None;
            ViewHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewHistory.Columns.AddRange(new DataGridViewColumn[] { BtnDelete, ID_Column, DataPrzyjęcia_Column, NrRejestracji_Column, Przebieg_Column, Documents_Column, Key_Column, TestDrive_Column, Zlecenie_Column, Diagnostic_Column, Repair_Column });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            ViewHistory.DefaultCellStyle = dataGridViewCellStyle4;
            ViewHistory.EnableHeadersVisualStyles = false;
            ViewHistory.Location = new Point(3, 371);
            ViewHistory.Name = "ViewHistory";
            ViewHistory.RowTemplate.Height = 25;
            ViewHistory.Size = new Size(1037, 206);
            ViewHistory.TabIndex = 31;
            ViewHistory.CellContentClick += ViewHistory_CellContentClick;
            ViewHistory.MouseDoubleClick += ViewHistory_MouseDoubleClick;
            // 
            // BtnDelete
            // 
            BtnDelete.FillWeight = 76.14214F;
            BtnDelete.HeaderText = "Usuń";
            BtnDelete.Name = "BtnDelete";
            // 
            // ID_Column
            // 
            ID_Column.DataPropertyName = "ID";
            ID_Column.HeaderText = "ID";
            ID_Column.Name = "ID_Column";
            ID_Column.Visible = false;
            // 
            // DataPrzyjęcia_Column
            // 
            DataPrzyjęcia_Column.DataPropertyName = "DataPrzyjęcia";
            DataPrzyjęcia_Column.FillWeight = 115.675964F;
            DataPrzyjęcia_Column.HeaderText = "DataPrzyjęcia";
            DataPrzyjęcia_Column.Name = "DataPrzyjęcia_Column";
            // 
            // NrRejestracji_Column
            // 
            NrRejestracji_Column.DataPropertyName = "NrRejestracji";
            NrRejestracji_Column.FillWeight = 115.675964F;
            NrRejestracji_Column.HeaderText = "Nr Rejestracji";
            NrRejestracji_Column.Name = "NrRejestracji_Column";
            // 
            // Przebieg_Column
            // 
            Przebieg_Column.DataPropertyName = "Przebieg";
            dataGridViewCellStyle2.NullValue = null;
            Przebieg_Column.DefaultCellStyle = dataGridViewCellStyle2;
            Przebieg_Column.FillWeight = 115.675964F;
            Przebieg_Column.HeaderText = "Przebieg";
            Przebieg_Column.Name = "Przebieg_Column";
            // 
            // Documents_Column
            // 
            Documents_Column.DataPropertyName = "DokumentySamochodu";
            Documents_Column.FalseValue = "0";
            Documents_Column.FillWeight = 85.8036F;
            Documents_Column.HeaderText = "Dokumenty";
            Documents_Column.Name = "Documents_Column";
            Documents_Column.Resizable = DataGridViewTriState.True;
            Documents_Column.SortMode = DataGridViewColumnSortMode.Automatic;
            Documents_Column.TrueValue = "1";
            // 
            // Key_Column
            // 
            Key_Column.DataPropertyName = "KluczykiSamochodu";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "km";
            dataGridViewCellStyle3.NullValue = false;
            Key_Column.DefaultCellStyle = dataGridViewCellStyle3;
            Key_Column.FalseValue = "0";
            Key_Column.FillWeight = 63.3218651F;
            Key_Column.HeaderText = "Kluczyki";
            Key_Column.Name = "Key_Column";
            Key_Column.Resizable = DataGridViewTriState.True;
            Key_Column.SortMode = DataGridViewColumnSortMode.Automatic;
            Key_Column.TrueValue = "1";
            // 
            // TestDrive_Column
            // 
            TestDrive_Column.DataPropertyName = "TestDrive";
            TestDrive_Column.FalseValue = "0";
            TestDrive_Column.FillWeight = 80.6766739F;
            TestDrive_Column.HeaderText = "TestDrive";
            TestDrive_Column.Name = "TestDrive_Column";
            TestDrive_Column.Resizable = DataGridViewTriState.True;
            TestDrive_Column.SortMode = DataGridViewColumnSortMode.Automatic;
            TestDrive_Column.TrueValue = "1";
            // 
            // Zlecenie_Column
            // 
            Zlecenie_Column.DataPropertyName = "Zlecenie";
            Zlecenie_Column.FillWeight = 115.675964F;
            Zlecenie_Column.HeaderText = "Zlecenie";
            Zlecenie_Column.Name = "Zlecenie_Column";
            // 
            // Diagnostic_Column
            // 
            Diagnostic_Column.DataPropertyName = "Diagnostyka";
            Diagnostic_Column.FillWeight = 115.675964F;
            Diagnostic_Column.HeaderText = "Diagnostyka";
            Diagnostic_Column.Name = "Diagnostic_Column";
            // 
            // Repair_Column
            // 
            Repair_Column.DataPropertyName = "Naprawa";
            Repair_Column.HeaderText = "Naprawa";
            Repair_Column.Name = "Repair_Column";
            // 
            // SaveHistoryButton
            // 
            SaveHistoryButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SaveHistoryButton.BackColor = Color.FromArgb(94, 148, 255);
            SaveHistoryButton.FlatAppearance.BorderSize = 0;
            SaveHistoryButton.FlatStyle = FlatStyle.Flat;
            SaveHistoryButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SaveHistoryButton.ForeColor = Color.LightGray;
            SaveHistoryButton.Location = new Point(0, 0);
            SaveHistoryButton.Name = "SaveHistoryButton";
            SaveHistoryButton.Size = new Size(1040, 34);
            SaveHistoryButton.TabIndex = 32;
            SaveHistoryButton.Text = "Zapisz";
            SaveHistoryButton.UseVisualStyleBackColor = false;
            SaveHistoryButton.Click += SaveHistoryButton_Click;
            // 
            // DiagnosticTextBox
            // 
            DiagnosticTextBox.BackColor = Color.FromArgb(64, 64, 70);
            DiagnosticTextBox.CausesValidation = false;
            DiagnosticTextBox.Cursor = Cursors.IBeam;
            DiagnosticTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DiagnosticTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            DiagnosticTextBox.Location = new Point(259, 33);
            DiagnosticTextBox.MinimumSize = new Size(160, 144);
            DiagnosticTextBox.Multiline = true;
            DiagnosticTextBox.Name = "DiagnosticTextBox";
            DiagnosticTextBox.PlaceholderText = "Diagnostyka";
            DiagnosticTextBox.Size = new Size(241, 144);
            DiagnosticTextBox.TabIndex = 7;
            // 
            // OrderTextBox
            // 
            OrderTextBox.BackColor = Color.FromArgb(64, 64, 70);
            OrderTextBox.CausesValidation = false;
            OrderTextBox.Cursor = Cursors.IBeam;
            OrderTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OrderTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            OrderTextBox.Location = new Point(14, 34);
            OrderTextBox.MinimumSize = new Size(160, 144);
            OrderTextBox.Multiline = true;
            OrderTextBox.Name = "OrderTextBox";
            OrderTextBox.PlaceholderText = "Zlecenie";
            OrderTextBox.Size = new Size(241, 144);
            OrderTextBox.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(64, 64, 70);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(ScheduleTimePicker);
            panel5.Controls.Add(RepairTextBox);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(DiagnosticTextBox);
            panel5.Controls.Add(OrderTextBox);
            panel5.ForeColor = Color.DimGray;
            panel5.Location = new Point(7, 181);
            panel5.Name = "panel5";
            panel5.Size = new Size(750, 184);
            panel5.TabIndex = 35;
            // 
            // ScheduleTimePicker
            // 
            ScheduleTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ScheduleTimePicker.CalendarMonthBackground = Color.FromArgb(94, 148, 255);
            ScheduleTimePicker.CalendarTitleBackColor = SystemColors.ControlText;
            ScheduleTimePicker.CalendarTitleForeColor = Color.FromArgb(94, 148, 255);
            ScheduleTimePicker.Cursor = Cursors.Hand;
            ScheduleTimePicker.CustomFormat = "";
            ScheduleTimePicker.Location = new Point(470, 5);
            ScheduleTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            ScheduleTimePicker.Name = "ScheduleTimePicker";
            ScheduleTimePicker.Size = new Size(239, 23);
            ScheduleTimePicker.TabIndex = 9;
            ScheduleTimePicker.Value = new DateTime(2024, 1, 16, 0, 0, 0, 0);
            // 
            // RepairTextBox
            // 
            RepairTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RepairTextBox.BackColor = Color.FromArgb(64, 64, 70);
            RepairTextBox.CausesValidation = false;
            RepairTextBox.Cursor = Cursors.IBeam;
            RepairTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RepairTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            RepairTextBox.Location = new Point(504, 33);
            RepairTextBox.MinimumSize = new Size(160, 144);
            RepairTextBox.Multiline = true;
            RepairTextBox.Name = "RepairTextBox";
            RepairTextBox.PlaceholderText = "Naprawa";
            RepairTextBox.Size = new Size(241, 144);
            RepairTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(355, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 20;
            label3.Text = "Data przyjęcia";
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(14, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 20;
            label1.Text = "Historia";
            // 
            // ViewAllCar
            // 
            ViewAllCar.AllowUserToAddRows = false;
            ViewAllCar.AllowUserToDeleteRows = false;
            ViewAllCar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ViewAllCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewAllCar.BorderStyle = BorderStyle.None;
            ViewAllCar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.LightGray;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ViewAllCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ViewAllCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewAllCar.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, VIN_Car_Column });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            ViewAllCar.DefaultCellStyle = dataGridViewCellStyle7;
            ViewAllCar.EnableHeadersVisualStyles = false;
            ViewAllCar.Location = new Point(3, 46);
            ViewAllCar.Name = "ViewAllCar";
            ViewAllCar.RowTemplate.Height = 25;
            ViewAllCar.Size = new Size(752, 118);
            ViewAllCar.TabIndex = 36;
            ViewAllCar.CellClick += ViewCar_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Marka";
            dataGridViewTextBoxColumn2.HeaderText = "Marka";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Model";
            dataGridViewTextBoxColumn3.HeaderText = "Model";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "RokProdukcji";
            dataGridViewTextBoxColumn4.HeaderText = "RokProdukcji";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // VIN_Car_Column
            // 
            VIN_Car_Column.DataPropertyName = "VIN";
            dataGridViewCellStyle6.Format = "km";
            dataGridViewCellStyle6.NullValue = null;
            VIN_Car_Column.DefaultCellStyle = dataGridViewCellStyle6;
            VIN_Car_Column.HeaderText = "VIN";
            VIN_Car_Column.Name = "VIN_Car_Column";
            // 
            // UC_AddHistoryCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 70);
            Controls.Add(ViewAllCar);
            Controls.Add(panel5);
            Controls.Add(SaveHistoryButton);
            Controls.Add(ViewHistory);
            Controls.Add(panel3);
            MinimumSize = new Size(1040, 580);
            Name = "UC_AddHistoryCar";
            Size = new Size(1040, 580);
            Load += UC_AddHistoryCar_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewHistory).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewAllCar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private CheckBox TestDriveChceck;
        private CheckBox LeftKeyChceck;
        private CheckBox LeftDocumentsCheck;
        private Label label6;
        public Label NumLenghtNadwoziaLabel;
        private Label label2;
        private TextBox VINTextBox;
        private Panel panel2;
        private Panel panel1;
        private TextBox RegistrationNumberTextBox;
        private Panel panel4;
        private DataGridView ViewHistory;
        private Button SaveHistoryButton;
        private TextBox DiagnosticTextBox;
        private TextBox OrderTextBox;
        private Panel panel5;
        private Label label1;
        private DataGridView ViewAllCar;
        private TextBox RepairTextBox;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn VIN_Car_Column;
        private Label label3;
        public DateTimePicker ScheduleTimePicker;
        private TextBox MileageTextBox;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewTextBoxColumn DataPrzyjęcia_Column;
        private DataGridViewTextBoxColumn NrRejestracji_Column;
        private DataGridViewTextBoxColumn Przebieg_Column;
        private DataGridViewCheckBoxColumn Documents_Column;
        private DataGridViewCheckBoxColumn Key_Column;
        private DataGridViewCheckBoxColumn TestDrive_Column;
        private DataGridViewTextBoxColumn Zlecenie_Column;
        private DataGridViewTextBoxColumn Diagnostic_Column;
        private DataGridViewTextBoxColumn Repair_Column;
    }
}
