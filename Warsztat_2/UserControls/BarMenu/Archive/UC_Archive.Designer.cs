namespace Warsztat_2.UserControls.BarMenu.Archive
{
    partial class UC_Archive
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
            ViewActualData = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            BtnDelete = new DataGridViewButtonColumn();
            Przyjęty_Column = new DataGridViewCheckBoxColumn();
            OczekujeNaOdbiór_Column = new DataGridViewCheckBoxColumn();
            DataPrzyjęcie_Column = new DataGridViewTextBoxColumn();
            Imię_Column = new DataGridViewTextBoxColumn();
            Nazwisko_Column = new DataGridViewTextBoxColumn();
            Telefon_Column = new DataGridViewTextBoxColumn();
            Marka_Column = new DataGridViewTextBoxColumn();
            Model_Column = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            KosztZMarżą_Column = new DataGridViewTextBoxColumn();
            VIN_Column = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ViewActualData).BeginInit();
            SuspendLayout();
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
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewActualData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewActualData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewActualData.Columns.AddRange(new DataGridViewColumn[] { ID, BtnDelete, Przyjęty_Column, OczekujeNaOdbiór_Column, DataPrzyjęcie_Column, Imię_Column, Nazwisko_Column, Telefon_Column, Marka_Column, Model_Column, Column7, KosztZMarżą_Column, VIN_Column });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ViewActualData.DefaultCellStyle = dataGridViewCellStyle2;
            ViewActualData.EnableHeadersVisualStyles = false;
            ViewActualData.Location = new Point(0, 138);
            ViewActualData.Name = "ViewActualData";
            ViewActualData.RowTemplate.Height = 25;
            ViewActualData.Size = new Size(1043, 477);
            ViewActualData.TabIndex = 31;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Usuń zgłoszenie";
            BtnDelete.Name = "BtnDelete";
            // 
            // Przyjęty_Column
            // 
            Przyjęty_Column.DataPropertyName = "Przyjęty";
            Przyjęty_Column.FalseValue = "0";
            Przyjęty_Column.HeaderText = "Przyjęty";
            Przyjęty_Column.Name = "Przyjęty_Column";
            Przyjęty_Column.Resizable = DataGridViewTriState.True;
            Przyjęty_Column.SortMode = DataGridViewColumnSortMode.Automatic;
            Przyjęty_Column.TrueValue = "1";
            // 
            // OczekujeNaOdbiór_Column
            // 
            OczekujeNaOdbiór_Column.DataPropertyName = "OczekujeNaOdbiór";
            OczekujeNaOdbiór_Column.FalseValue = "0";
            OczekujeNaOdbiór_Column.HeaderText = "Oczekuje na odbiór";
            OczekujeNaOdbiór_Column.Name = "OczekujeNaOdbiór_Column";
            OczekujeNaOdbiór_Column.Resizable = DataGridViewTriState.True;
            OczekujeNaOdbiór_Column.SortMode = DataGridViewColumnSortMode.Automatic;
            OczekujeNaOdbiór_Column.TrueValue = "1";
            // 
            // DataPrzyjęcie_Column
            // 
            DataPrzyjęcie_Column.DataPropertyName = "DataPrzyjęcie";
            DataPrzyjęcie_Column.HeaderText = "DataPrzyjęcia";
            DataPrzyjęcie_Column.Name = "DataPrzyjęcie_Column";
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
            Telefon_Column.DataPropertyName = "Telefon";
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
            // KosztZMarżą_Column
            // 
            KosztZMarżą_Column.DataPropertyName = "KosztZMarżą";
            KosztZMarżą_Column.HeaderText = "Koszt naprawy";
            KosztZMarżą_Column.Name = "KosztZMarżą_Column";
            // 
            // VIN_Column
            // 
            VIN_Column.DataPropertyName = "VIN";
            VIN_Column.HeaderText = "VIN";
            VIN_Column.Name = "VIN_Column";
            // 
            // UC_Archive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(ViewActualData);
            Name = "UC_Archive";
            Size = new Size(1043, 615);
            Load += UC_Archive_Load;
            ((System.ComponentModel.ISupportInitialize)ViewActualData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ViewActualData;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewCheckBoxColumn Przyjęty_Column;
        private DataGridViewCheckBoxColumn OczekujeNaOdbiór_Column;
        private DataGridViewTextBoxColumn DataPrzyjęcie_Column;
        private DataGridViewTextBoxColumn Imię_Column;
        private DataGridViewTextBoxColumn Nazwisko_Column;
        private DataGridViewTextBoxColumn Telefon_Column;
        private DataGridViewTextBoxColumn Marka_Column;
        private DataGridViewTextBoxColumn Model_Column;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn KosztZMarżą_Column;
        private DataGridViewTextBoxColumn VIN_Column;
    }
}
