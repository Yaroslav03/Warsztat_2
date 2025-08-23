namespace Warsztat_2._0.UserControls {
    partial class UC_ViewDataCar
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
            if(disposing && (components != null))
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            PathButton = new Button();
            InsuranceButton = new Button();
            ViewActualData = new DataGridView();
            ID_Column = new DataGridViewTextBoxColumn();
            BtnDelete = new DataGridViewButtonColumn();
            BtnFinish = new DataGridViewButtonColumn();
            DataPrzyjęcia_Column = new DataGridViewTextBoxColumn();
            DataOczekiwaniaOdbioru_Column = new DataGridViewTextBoxColumn();
            Imię_Column = new DataGridViewTextBoxColumn();
            Nazwisko_Column = new DataGridViewTextBoxColumn();
            Telefon_Column = new DataGridViewTextBoxColumn();
            Marka_Column = new DataGridViewTextBoxColumn();
            Model_Column = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            WykonawaPracy_Column = new DataGridViewTextBoxColumn();
            KosztKońcowy_Column = new DataGridViewTextBoxColumn();
            VIN_Column = new DataGridViewTextBoxColumn();
            SearchTextBox = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ViewActualData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(888, 2);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Plik PDF";
            // 
            // PathButton
            // 
            PathButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PathButton.BackColor = Color.FromArgb(94, 148, 255);
            PathButton.FlatAppearance.BorderSize = 0;
            PathButton.FlatStyle = FlatStyle.Flat;
            PathButton.ForeColor = Color.LightGray;
            PathButton.Location = new Point(752, 20);
            PathButton.Name = "PathButton";
            PathButton.Size = new Size(84, 22);
            PathButton.TabIndex = 15;
            PathButton.Text = "Lokalizacja";
            PathButton.UseVisualStyleBackColor = false;
            PathButton.Click += PathButton_Click;
            // 
            // InsuranceButton
            // 
            InsuranceButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InsuranceButton.BackColor = Color.FromArgb(94, 148, 255);
            InsuranceButton.FlatAppearance.BorderSize = 0;
            InsuranceButton.FlatStyle = FlatStyle.Flat;
            InsuranceButton.ForeColor = Color.LightGray;
            InsuranceButton.Location = new Point(842, 20);
            InsuranceButton.Name = "InsuranceButton";
            InsuranceButton.Size = new Size(155, 22);
            InsuranceButton.TabIndex = 15;
            InsuranceButton.Text = "Umowa po  obu Stronach";
            InsuranceButton.UseVisualStyleBackColor = false;
            InsuranceButton.Click += InsuranceButton_Click;
            // 
            // ViewActualData
            // 
            ViewActualData.AllowUserToAddRows = false;
            ViewActualData.AllowUserToDeleteRows = false;
            ViewActualData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewActualData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewActualData.BorderStyle = BorderStyle.None;
            ViewActualData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewActualData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewActualData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewActualData.Columns.AddRange(new DataGridViewColumn[] { ID_Column, BtnDelete, BtnFinish, DataPrzyjęcia_Column, DataOczekiwaniaOdbioru_Column, Imię_Column, Nazwisko_Column, Telefon_Column, Marka_Column, Model_Column, Column7, WykonawaPracy_Column, KosztKońcowy_Column, VIN_Column });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ViewActualData.DefaultCellStyle = dataGridViewCellStyle3;
            ViewActualData.EnableHeadersVisualStyles = false;
            ViewActualData.Location = new Point(3, 62);
            ViewActualData.Name = "ViewActualData";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ViewActualData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ViewActualData.RowTemplate.Height = 25;
            ViewActualData.Size = new Size(994, 550);
            ViewActualData.TabIndex = 30;
            ViewActualData.CellContentClick += ViewActualData_CellContentClick;
            ViewActualData.CellContentDoubleClick += ViewActualData_CellContentDoubleClick;
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
            BtnDelete.HeaderText = "Usuń zgłoszenie";
            BtnDelete.Name = "BtnDelete";
            // 
            // BtnFinish
            // 
            BtnFinish.HeaderText = "Wykonane";
            BtnFinish.Name = "BtnFinish";
            // 
            // DataPrzyjęcia_Column
            // 
            DataPrzyjęcia_Column.DataPropertyName = "DataPrzyjęcia";
            DataPrzyjęcia_Column.HeaderText = "Data Przyjęcia";
            DataPrzyjęcia_Column.Name = "DataPrzyjęcia_Column";
            // 
            // DataOczekiwaniaOdbioru_Column
            // 
            DataOczekiwaniaOdbioru_Column.DataPropertyName = "DataOczekiwaniaOdbioru";
            DataOczekiwaniaOdbioru_Column.HeaderText = "Data oczekiwania odbioru";
            DataOczekiwaniaOdbioru_Column.Name = "DataOczekiwaniaOdbioru_Column";
            // 
            // Imię_Column
            // 
            Imię_Column.DataPropertyName = "Imię";
            Imię_Column.HeaderText = "Imię Klienta";
            Imię_Column.Name = "Imię_Column";
            // 
            // Nazwisko_Column
            // 
            Nazwisko_Column.DataPropertyName = "Nazwisko";
            Nazwisko_Column.HeaderText = "Nazwisko Klienta";
            Nazwisko_Column.Name = "Nazwisko_Column";
            // 
            // Telefon_Column
            // 
            Telefon_Column.DataPropertyName = "NrTelefonu";
            Telefon_Column.HeaderText = "Nr. telefonu";
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
            // Column7
            // 
            Column7.DataPropertyName = "Zlecenie";
            Column7.HeaderText = "Zlecenie";
            Column7.Name = "Column7";
            // 
            // WykonawaPracy_Column
            // 
            WykonawaPracy_Column.DataPropertyName = "WykonawcaPracy";
            WykonawaPracy_Column.HeaderText = "Wykonawca Pracy";
            WykonawaPracy_Column.Name = "WykonawaPracy_Column";
            // 
            // KosztKońcowy_Column
            // 
            KosztKońcowy_Column.DataPropertyName = "KosztKońcowy";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            KosztKońcowy_Column.DefaultCellStyle = dataGridViewCellStyle2;
            KosztKońcowy_Column.HeaderText = "Koszt Końcowy";
            KosztKońcowy_Column.Name = "KosztKońcowy_Column";
            // 
            // VIN_Column
            // 
            VIN_Column.DataPropertyName = "VIN";
            VIN_Column.HeaderText = "VIN";
            VIN_Column.Name = "VIN_Column";
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = Color.FromArgb(64, 64, 70);
            SearchTextBox.CausesValidation = false;
            SearchTextBox.Cursor = Cursors.IBeam;
            SearchTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            SearchTextBox.Location = new Point(3, 26);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(240, 30);
            SearchTextBox.TabIndex = 32;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 31;
            label2.Text = "Szukaj za słowem";
            // 
            // UC_ViewDataCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(SearchTextBox);
            Controls.Add(label2);
            Controls.Add(ViewActualData);
            Controls.Add(PathButton);
            Controls.Add(InsuranceButton);
            Controls.Add(label1);
            ForeColor = Color.WhiteSmoke;
            Name = "UC_ViewDataCar";
            Size = new Size(1000, 615);
            Load += UC_ViewDataCar_Load;
            VisibleChanged += UC_ViewDataCar_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)ViewActualData).EndInit();
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion

        private Label label1;
        private Button PathButton;
        private Button InsuranceButton;
        private DataGridView ViewActualData;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewButtonColumn BtnFinish;
        private DataGridViewTextBoxColumn DataPrzyjęcia_Column;
        private DataGridViewTextBoxColumn DataOczekiwaniaOdbioru_Column;
        private DataGridViewTextBoxColumn Imię_Column;
        private DataGridViewTextBoxColumn Nazwisko_Column;
        private DataGridViewTextBoxColumn Telefon_Column;
        private DataGridViewTextBoxColumn Marka_Column;
        private DataGridViewTextBoxColumn Model_Column;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn WykonawaPracy_Column;
        private DataGridViewTextBoxColumn KosztKońcowy_Column;
        private DataGridViewTextBoxColumn VIN_Column;
        private TextBox SearchTextBox;
        private Label label2;
        }
    }
