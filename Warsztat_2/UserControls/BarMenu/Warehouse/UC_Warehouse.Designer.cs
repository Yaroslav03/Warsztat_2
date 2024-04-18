namespace Warsztat_2._0.UserControls.BarMenu.Warehouse
{
    partial class UC_Warehouse
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            Button AddCategoryButton;
            Button RemoveCategoryButton;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            CategorylistBox = new ListBox();
            label4 = new Label();
            UpdateCategoryList = new Label();
            WarehouseAddButton = new Button();
            WarehouseView = new DataGridView();
            BtnDelete = new DataGridViewButtonColumn();
            ID_Column_ = new DataGridViewTextBoxColumn();
            TypCzesci_Column = new DataGridViewTextBoxColumn();
            NrCzęści_Column = new DataGridViewTextBoxColumn();
            Nazwa_Column = new DataGridViewTextBoxColumn();
            Opis_Column = new DataGridViewTextBoxColumn();
            Quantity_Column = new DataGridViewTextBoxColumn();
            Price_Column = new DataGridViewTextBoxColumn();
            SearchTextBox = new TextBox();
            label1 = new Label();
            CategoryTextBox = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            AddCategoryButton = new Button();
            RemoveCategoryButton = new Button();
            ((System.ComponentModel.ISupportInitialize)WarehouseView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // AddCategoryButton
            // 
            AddCategoryButton.BackColor = Color.FromArgb(94, 148, 255);
            AddCategoryButton.BackgroundImageLayout = ImageLayout.None;
            AddCategoryButton.FlatStyle = FlatStyle.Flat;
            AddCategoryButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddCategoryButton.ForeColor = Color.LightGray;
            AddCategoryButton.Location = new Point(17, 72);
            AddCategoryButton.Name = "AddCategoryButton";
            AddCategoryButton.Size = new Size(169, 26);
            AddCategoryButton.TabIndex = 15;
            AddCategoryButton.Text = "+";
            AddCategoryButton.TextAlign = ContentAlignment.TopCenter;
            AddCategoryButton.UseVisualStyleBackColor = false;
            AddCategoryButton.Click += AddCategoryButton_Click;
            // 
            // RemoveCategoryButton
            // 
            RemoveCategoryButton.BackColor = Color.FromArgb(94, 148, 255);
            RemoveCategoryButton.BackgroundImageLayout = ImageLayout.None;
            RemoveCategoryButton.FlatStyle = FlatStyle.Flat;
            RemoveCategoryButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveCategoryButton.ForeColor = Color.LightGray;
            RemoveCategoryButton.Location = new Point(15, 111);
            RemoveCategoryButton.Name = "RemoveCategoryButton";
            RemoveCategoryButton.Size = new Size(169, 26);
            RemoveCategoryButton.TabIndex = 15;
            RemoveCategoryButton.Text = "-";
            RemoveCategoryButton.TextAlign = ContentAlignment.TopCenter;
            RemoveCategoryButton.UseVisualStyleBackColor = false;
            RemoveCategoryButton.Click += RemoveCategoryButton_Click;
            // 
            // CategorylistBox
            // 
            CategorylistBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CategorylistBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CategorylistBox.FormattingEnabled = true;
            CategorylistBox.ItemHeight = 21;
            CategorylistBox.Location = new Point(8, 164);
            CategorylistBox.Name = "CategorylistBox";
            CategorylistBox.Size = new Size(167, 193);
            CategorylistBox.TabIndex = 14;
            CategorylistBox.MouseClick += CategorylistBox_MouseClick;
            CategorylistBox.MouseDoubleClick += CategorylistBox_MouseDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(7, 140);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 0;
            label4.Text = "Filtruj części:";
            // 
            // UpdateCategoryList
            // 
            UpdateCategoryList.AutoSize = true;
            UpdateCategoryList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateCategoryList.ForeColor = Color.FromArgb(224, 224, 224);
            UpdateCategoryList.Location = new Point(15, 4);
            UpdateCategoryList.Name = "UpdateCategoryList";
            UpdateCategoryList.Size = new Size(69, 21);
            UpdateCategoryList.TabIndex = 0;
            UpdateCategoryList.Text = "Odśwież";
            UpdateCategoryList.Click += UpdateCategoryList_Click;
            // 
            // WarehouseAddButton
            // 
            WarehouseAddButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WarehouseAddButton.BackColor = Color.FromArgb(94, 148, 255);
            WarehouseAddButton.FlatAppearance.BorderSize = 0;
            WarehouseAddButton.FlatStyle = FlatStyle.Flat;
            WarehouseAddButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WarehouseAddButton.ForeColor = Color.LightGray;
            WarehouseAddButton.Location = new Point(6, 3);
            WarehouseAddButton.Name = "WarehouseAddButton";
            WarehouseAddButton.Size = new Size(192, 30);
            WarehouseAddButton.TabIndex = 24;
            WarehouseAddButton.Text = "Zapisz";
            WarehouseAddButton.UseVisualStyleBackColor = false;
            WarehouseAddButton.Click += WarehouseAddButton_Click;
            // 
            // WarehouseView
            // 
            WarehouseView.AllowUserToAddRows = false;
            WarehouseView.AllowUserToDeleteRows = false;
            WarehouseView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WarehouseView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WarehouseView.BorderStyle = BorderStyle.None;
            WarehouseView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            WarehouseView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            WarehouseView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            WarehouseView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WarehouseView.Columns.AddRange(new DataGridViewColumn[] { BtnDelete, ID_Column_, TypCzesci_Column, NrCzęści_Column, Nazwa_Column, Opis_Column, Quantity_Column, Price_Column });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            WarehouseView.DefaultCellStyle = dataGridViewCellStyle3;
            WarehouseView.EnableHeadersVisualStyles = false;
            WarehouseView.Location = new Point(215, 0);
            WarehouseView.Name = "WarehouseView";
            WarehouseView.RowTemplate.Height = 25;
            WarehouseView.Size = new Size(792, 640);
            WarehouseView.TabIndex = 25;
            WarehouseView.CellContentClick += WarehouseView_CellContentClick;
            WarehouseView.DoubleClick += WarehouseView_DoubleClick;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Usuń";
            BtnDelete.Name = "BtnDelete";
            // 
            // ID_Column_
            // 
            ID_Column_.DataPropertyName = "ID";
            ID_Column_.HeaderText = "ID";
            ID_Column_.Name = "ID_Column_";
            ID_Column_.Visible = false;
            // 
            // TypCzesci_Column
            // 
            TypCzesci_Column.DataPropertyName = "Typ";
            TypCzesci_Column.HeaderText = "Typ";
            TypCzesci_Column.Name = "TypCzesci_Column";
            // 
            // NrCzęści_Column
            // 
            NrCzęści_Column.DataPropertyName = "NumerCzęści";
            NrCzęści_Column.HeaderText = "Numer";
            NrCzęści_Column.Name = "NrCzęści_Column";
            // 
            // Nazwa_Column
            // 
            Nazwa_Column.DataPropertyName = "Nazwa";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            Nazwa_Column.DefaultCellStyle = dataGridViewCellStyle2;
            Nazwa_Column.HeaderText = "Nazwa";
            Nazwa_Column.Name = "Nazwa_Column";
            // 
            // Opis_Column
            // 
            Opis_Column.DataPropertyName = "Opis";
            Opis_Column.HeaderText = "Opis";
            Opis_Column.Name = "Opis_Column";
            // 
            // Quantity_Column
            // 
            Quantity_Column.DataPropertyName = "Ilość";
            Quantity_Column.HeaderText = "Ilość";
            Quantity_Column.Name = "Quantity_Column";
            // 
            // Price_Column
            // 
            Price_Column.DataPropertyName = "Cena";
            Price_Column.HeaderText = "Cena";
            Price_Column.Name = "Price_Column";
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = Color.FromArgb(64, 64, 70);
            SearchTextBox.CausesValidation = false;
            SearchTextBox.Cursor = Cursors.IBeam;
            SearchTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            SearchTextBox.Location = new Point(8, 33);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(179, 30);
            SearchTextBox.TabIndex = 26;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 0;
            label1.Text = "Wyszukaj za słowami";
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.BackColor = Color.FromArgb(64, 64, 70);
            CategoryTextBox.CausesValidation = false;
            CategoryTextBox.Cursor = Cursors.IBeam;
            CategoryTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            CategoryTextBox.Location = new Point(17, 28);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(169, 30);
            CategoryTextBox.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 70);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(CategoryTextBox);
            panel1.Controls.Add(RemoveCategoryButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CategorylistBox);
            panel1.Controls.Add(UpdateCategoryList);
            panel1.Controls.Add(AddCategoryButton);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(6, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 380);
            panel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 70);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(SearchTextBox);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.DimGray;
            panel2.Location = new Point(6, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 83);
            panel2.TabIndex = 29;
            // 
            // UC_Warehouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(WarehouseView);
            Controls.Add(WarehouseAddButton);
            Name = "UC_Warehouse";
            Size = new Size(1007, 643);
            Load += UC_Warehouse_Load;
            ((System.ComponentModel.ISupportInitialize)WarehouseView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        public DataGridView WarehouseView;
        public ListBox CategorylistBox;
        private Label UpdateCategoryList;
        private Button WarehouseAddButton;

        private TextBox SearchTextBox;
        private Label label1;
        private TextBox CategoryTextBox;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewTextBoxColumn ID_Column_;
        private DataGridViewTextBoxColumn TypCzesci_Column;
        private DataGridViewTextBoxColumn NrCzęści_Column;
        private DataGridViewTextBoxColumn Nazwa_Column;
        private DataGridViewTextBoxColumn Opis_Column;
        private DataGridViewTextBoxColumn Quantity_Column;
        private DataGridViewTextBoxColumn Price_Column;
    }
}
