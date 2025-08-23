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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ViewActualData = new DataGridView();
            ID_Column = new DataGridViewTextBoxColumn();
            BtnDelete = new DataGridViewButtonColumn();
            BtnRecover = new DataGridViewButtonColumn();
            DataPrzyjęcia_Column = new DataGridViewTextBoxColumn();
            DataZamknięciaZlecenia_Column = new DataGridViewTextBoxColumn();
            Imię_Column = new DataGridViewTextBoxColumn();
            Nazwisko_Column = new DataGridViewTextBoxColumn();
            Telefon_Column = new DataGridViewTextBoxColumn();
            Marka_Column = new DataGridViewTextBoxColumn();
            Model_Column = new DataGridViewTextBoxColumn();
            Zlecenie_Column = new DataGridViewTextBoxColumn();
            WykonawaPracy_Column = new DataGridViewTextBoxColumn();
            KosztKońcowy_Column = new DataGridViewTextBoxColumn();
            VIN_Column = new DataGridViewTextBoxColumn();
            panelDodatkowy = new Panel();
            SearchTextBox = new TextBox();
            label1 = new Label();
            OrderButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ViewActualData).BeginInit();
            panelDodatkowy.SuspendLayout();
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
            ViewActualData.Columns.AddRange(new DataGridViewColumn[] { ID_Column, BtnDelete, BtnRecover, DataPrzyjęcia_Column, DataZamknięciaZlecenia_Column, Imię_Column, Nazwisko_Column, Telefon_Column, Marka_Column, Model_Column, Zlecenie_Column, WykonawaPracy_Column, KosztKońcowy_Column, VIN_Column });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ViewActualData.DefaultCellStyle = dataGridViewCellStyle3;
            ViewActualData.EnableHeadersVisualStyles = false;
            ViewActualData.Location = new Point(3, 64);
            ViewActualData.Name = "ViewActualData";
            ViewActualData.RowTemplate.Height = 25;
            ViewActualData.Size = new Size(1029, 540);
            ViewActualData.TabIndex = 38;
            ViewActualData.CellContentClick += ViewActualData_CellContentClick;
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
            // BtnRecover
            // 
            BtnRecover.HeaderText = "Przywróć zlecenie";
            BtnRecover.Name = "BtnRecover";
            // 
            // DataPrzyjęcia_Column
            // 
            DataPrzyjęcia_Column.DataPropertyName = "DataPrzyjęcia";
            DataPrzyjęcia_Column.HeaderText = "Data Przyjęcia";
            DataPrzyjęcia_Column.Name = "DataPrzyjęcia_Column";
            // 
            // DataZamknięciaZlecenia_Column
            // 
            DataZamknięciaZlecenia_Column.DataPropertyName = "DataZamknięciaZlecenia";
            DataZamknięciaZlecenia_Column.HeaderText = "Data Zamknięcia Zlecenia";
            DataZamknięciaZlecenia_Column.Name = "DataZamknięciaZlecenia_Column";
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
            // Zlecenie_Column
            // 
            Zlecenie_Column.DataPropertyName = "Zlecenie";
            Zlecenie_Column.HeaderText = "Zlecenie";
            Zlecenie_Column.Name = "Zlecenie_Column";
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
            // panelDodatkowy
            // 
            panelDodatkowy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDodatkowy.BackColor = Color.FromArgb(64, 64, 70);
            panelDodatkowy.BorderStyle = BorderStyle.FixedSingle;
            panelDodatkowy.Controls.Add(SearchTextBox);
            panelDodatkowy.Controls.Add(label1);
            panelDodatkowy.Controls.Add(OrderButton);
            panelDodatkowy.Controls.Add(ViewActualData);
            panelDodatkowy.ForeColor = Color.WhiteSmoke;
            panelDodatkowy.Location = new Point(3, 3);
            panelDodatkowy.Name = "panelDodatkowy";
            panelDodatkowy.Size = new Size(1037, 609);
            panelDodatkowy.TabIndex = 39;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = Color.FromArgb(64, 64, 70);
            SearchTextBox.CausesValidation = false;
            SearchTextBox.Cursor = Cursors.IBeam;
            SearchTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            SearchTextBox.Location = new Point(3, 28);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(240, 30);
            SearchTextBox.TabIndex = 26;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 0;
            label1.Text = "Szukaj za słowem";
            // 
            // OrderButton
            // 
            OrderButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OrderButton.BackColor = Color.FromArgb(94, 148, 255);
            OrderButton.FlatAppearance.BorderSize = 0;
            OrderButton.FlatStyle = FlatStyle.Flat;
            OrderButton.ForeColor = Color.LightGray;
            OrderButton.Location = new Point(877, 36);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(155, 22);
            OrderButton.TabIndex = 39;
            OrderButton.Text = "Faktura";
            OrderButton.UseVisualStyleBackColor = false;
            OrderButton.Click += OrderButton_Click;
            // 
            // UC_Archive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panelDodatkowy);
            Name = "UC_Archive";
            Size = new Size(1043, 615);
            Load += UC_Archive_Load;
            ((System.ComponentModel.ISupportInitialize)ViewActualData).EndInit();
            panelDodatkowy.ResumeLayout(false);
            panelDodatkowy.PerformLayout();
            ResumeLayout(false);
            }

        #endregion

        private DataGridView ViewActualData;
        private Panel panelDodatkowy;
        private Button OrderButton;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewButtonColumn BtnRecover;
        private DataGridViewTextBoxColumn DataPrzyjęcia_Column;
        private DataGridViewTextBoxColumn DataZamknięciaZlecenia_Column;
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
        private Label label1;
        private DataGridViewTextBoxColumn Zlecenie_Column;
        }
}
