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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            label3 = new Label();
            PathButton = new Button();
            OrderButton = new Button();
            button3 = new Button();
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
            panelDodatkowy = new Panel();
            ((System.ComponentModel.ISupportInitialize)ViewActualData).BeginInit();
            panelDodatkowy.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(722, 12);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Plik PDF";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(868, 12);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 3;
            label3.Text = "Stwórz PDF";
            // 
            // PathButton
            // 
            PathButton.BackColor = Color.FromArgb(94, 148, 255);
            PathButton.FlatAppearance.BorderSize = 0;
            PathButton.FlatStyle = FlatStyle.Flat;
            PathButton.ForeColor = Color.LightGray;
            PathButton.Location = new Point(725, 30);
            PathButton.Name = "PathButton";
            PathButton.Size = new Size(84, 22);
            PathButton.TabIndex = 15;
            PathButton.Text = "Lokalizacja";
            PathButton.UseVisualStyleBackColor = false;
            PathButton.Click += PathButton_Click;
            // 
            // OrderButton
            // 
            OrderButton.BackColor = Color.FromArgb(94, 148, 255);
            OrderButton.FlatAppearance.BorderSize = 0;
            OrderButton.FlatStyle = FlatStyle.Flat;
            OrderButton.ForeColor = Color.LightGray;
            OrderButton.Location = new Point(815, 30);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(84, 22);
            OrderButton.TabIndex = 15;
            OrderButton.Text = "Zlecenie";
            OrderButton.UseVisualStyleBackColor = false;
            OrderButton.Click += OrderButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(94, 148, 255);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.LightGray;
            button3.Location = new Point(905, 31);
            button3.Name = "button3";
            button3.Size = new Size(84, 22);
            button3.TabIndex = 15;
            button3.Text = "Faktura";
            button3.UseVisualStyleBackColor = false;
            // 
            // ViewActualData
            // 
            ViewActualData.AllowUserToAddRows = false;
            ViewActualData.AllowUserToDeleteRows = false;
            ViewActualData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewActualData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewActualData.BorderStyle = BorderStyle.None;
            ViewActualData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ViewActualData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ViewActualData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewActualData.Columns.AddRange(new DataGridViewColumn[] { ID_Column, BtnDelete, BtnFinish, DataPrzyjęcia_Column, DataOczekiwaniaOdbioru_Column, Imię_Column, Nazwisko_Column, Telefon_Column, Marka_Column, Model_Column, Column7, WykonawaPracy_Column, KosztKońcowy_Column, VIN_Column });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            ViewActualData.DefaultCellStyle = dataGridViewCellStyle4;
            ViewActualData.EnableHeadersVisualStyles = false;
            ViewActualData.Location = new Point(3, 59);
            ViewActualData.Name = "ViewActualData";
            ViewActualData.RowTemplate.Height = 25;
            ViewActualData.Size = new Size(983, 548);
            ViewActualData.TabIndex = 30;
            ViewActualData.CellContentClick += ViewActualData_CellContentClick;
            ViewActualData.MouseDoubleClick += ViewActualData_MouseDoubleClick;
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
            KosztKońcowy_Column.HeaderText = "Koszt Końcowy";
            KosztKońcowy_Column.Name = "KosztKońcowy_Column";
            // 
            // VIN_Column
            // 
            VIN_Column.DataPropertyName = "VIN";
            VIN_Column.HeaderText = "VIN";
            VIN_Column.Name = "VIN_Column";
            // 
            // panelDodatkowy
            // 
            panelDodatkowy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDodatkowy.BackColor = Color.FromArgb(64, 64, 70);
            panelDodatkowy.BorderStyle = BorderStyle.FixedSingle;
            panelDodatkowy.Controls.Add(ViewActualData);
            panelDodatkowy.Controls.Add(button3);
            panelDodatkowy.Controls.Add(label3);
            panelDodatkowy.Controls.Add(OrderButton);
            panelDodatkowy.Controls.Add(label1);
            panelDodatkowy.Controls.Add(PathButton);
            panelDodatkowy.ForeColor = Color.DimGray;
            panelDodatkowy.Location = new Point(4, 3);
            panelDodatkowy.Name = "panelDodatkowy";
            panelDodatkowy.Size = new Size(993, 612);
            panelDodatkowy.TabIndex = 31;
            // 
            // UC_ViewDataCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panelDodatkowy);
            Name = "UC_ViewDataCar";
            Size = new Size(1000, 615);
            Load += UC_ViewDataCar_Load;
            ((System.ComponentModel.ISupportInitialize)ViewActualData).EndInit();
            panelDodatkowy.ResumeLayout(false);
            panelDodatkowy.PerformLayout();
            ResumeLayout(false);
            }

        #endregion

        private Label label1;
        private Label label3;
        private Button PathButton;
        private Button OrderButton;
        private Button button3;
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
        private Panel panelDodatkowy;
        }
    }
