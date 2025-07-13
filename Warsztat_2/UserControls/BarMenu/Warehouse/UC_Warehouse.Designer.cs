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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            CategorylistBox = new ListBox();
            label4 = new Label();
            UpdateCategoryList = new Label();
            WarehouseAddButton = new Button();
            SearchTextBox = new TextBox();
            label1 = new Label();
            CategoryTextBox = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            WarehouseView = new DataGridView();
            BtnDelete_ = new DataGridViewButtonColumn();
            ID_Column = new DataGridViewTextBoxColumn();
            Typ_column = new DataGridViewTextBoxColumn();
            NumerCzęści_column = new DataGridViewTextBoxColumn();
            Nazwa_column_ = new DataGridViewTextBoxColumn();
            Opis_column_ = new DataGridViewTextBoxColumn();
            Cena_column = new DataGridViewTextBoxColumn();
            Ilość_column = new DataGridViewTextBoxColumn();
            EarningParts_Column = new DataGridViewTextBoxColumn();
            Suma_Column = new DataGridViewTextBoxColumn();
            AddCategoryButton = new Button();
            RemoveCategoryButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WarehouseView).BeginInit();
            SuspendLayout();
            // 
            // AddCategoryButton
            // 
            AddCategoryButton.BackColor = Color.FromArgb(94, 148, 255);
            AddCategoryButton.BackgroundImageLayout = ImageLayout.None;
            AddCategoryButton.FlatStyle = FlatStyle.Flat;
            AddCategoryButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddCategoryButton.ForeColor = Color.LightGray;
            AddCategoryButton.Location = new Point(8, 79);
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
            RemoveCategoryButton.Location = new Point(8, 111);
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
            WarehouseAddButton.BackColor = Color.FromArgb(94, 148, 255);
            WarehouseAddButton.FlatAppearance.BorderSize = 0;
            WarehouseAddButton.FlatStyle = FlatStyle.Flat;
            WarehouseAddButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WarehouseAddButton.ForeColor = Color.LightGray;
            WarehouseAddButton.Location = new Point(6, 3);
            WarehouseAddButton.Name = "WarehouseAddButton";
            WarehouseAddButton.Size = new Size(192, 30);
            WarehouseAddButton.TabIndex = 24;
            WarehouseAddButton.Text = "Dodaj część";
            WarehouseAddButton.UseVisualStyleBackColor = false;
            WarehouseAddButton.Click += WarehouseAddButton_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = Color.FromArgb(64, 64, 70);
            SearchTextBox.CausesValidation = false;
            SearchTextBox.Cursor = Cursors.IBeam;
            SearchTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            SearchTextBox.Location = new Point(5, 33);
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
            CategoryTextBox.Location = new Point(8, 28);
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
            // WarehouseView
            // 
            WarehouseView.AllowUserToAddRows = false;
            WarehouseView.AllowUserToDeleteRows = false;
            WarehouseView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WarehouseView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WarehouseView.BorderStyle = BorderStyle.None;
            WarehouseView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            WarehouseView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            WarehouseView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WarehouseView.Columns.AddRange(new DataGridViewColumn[] { BtnDelete_, ID_Column, Typ_column, NumerCzęści_column, Nazwa_column_, Opis_column_, Cena_column, Ilość_column, EarningParts_Column, Suma_Column });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            WarehouseView.DefaultCellStyle = dataGridViewCellStyle4;
            WarehouseView.EnableHeadersVisualStyles = false;
            WarehouseView.Location = new Point(216, 39);
            WarehouseView.Name = "WarehouseView";
            WarehouseView.RowTemplate.Height = 25;
            WarehouseView.Size = new Size(788, 604);
            WarehouseView.TabIndex = 37;
            WarehouseView.CellContentClick += WarehouseView_CellContentClick;
            WarehouseView.DoubleClick += WarehouseView_DoubleClick;
            // 
            // BtnDelete_
            // 
            BtnDelete_.HeaderText = "Usuń";
            BtnDelete_.Name = "BtnDelete_";
            // 
            // ID_Column
            // 
            ID_Column.DataPropertyName = "ID";
            ID_Column.HeaderText = "ID";
            ID_Column.Name = "ID_Column";
            ID_Column.Visible = false;
            // 
            // Typ_column
            // 
            Typ_column.DataPropertyName = "Typ";
            Typ_column.HeaderText = "Typ";
            Typ_column.Name = "Typ_column";
            // 
            // NumerCzęści_column
            // 
            NumerCzęści_column.DataPropertyName = "NumerCzęści";
            NumerCzęści_column.HeaderText = "Numer Części";
            NumerCzęści_column.Name = "NumerCzęści_column";
            // 
            // Nazwa_column_
            // 
            Nazwa_column_.DataPropertyName = "Nazwa";
            Nazwa_column_.HeaderText = "Nazwa";
            Nazwa_column_.Name = "Nazwa_column_";
            // 
            // Opis_column_
            // 
            Opis_column_.DataPropertyName = "Opis";
            Opis_column_.HeaderText = "Opis";
            Opis_column_.Name = "Opis_column_";
            // 
            // Cena_column
            // 
            Cena_column.DataPropertyName = "Cena";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            Cena_column.DefaultCellStyle = dataGridViewCellStyle2;
            Cena_column.HeaderText = "Cena";
            Cena_column.Name = "Cena_column";
            // 
            // Ilość_column
            // 
            Ilość_column.DataPropertyName = "Ilość";
            Ilość_column.HeaderText = "Ilość";
            Ilość_column.Name = "Ilość_column";
            // 
            // EarningParts_Column
            // 
            EarningParts_Column.DataPropertyName = "ZarobekCzęści";
            EarningParts_Column.HeaderText = "Dochód z części";
            EarningParts_Column.Name = "EarningParts_Column";
            EarningParts_Column.Visible = false;
            // 
            // Suma_Column
            // 
            Suma_Column.DataPropertyName = "Suma";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            Suma_Column.DefaultCellStyle = dataGridViewCellStyle3;
            Suma_Column.HeaderText = "Suma";
            Suma_Column.Name = "Suma_Column";
            // 
            // UC_Warehouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(WarehouseView);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(WarehouseAddButton);
            Name = "UC_Warehouse";
            Size = new Size(1007, 643);
            Load += UC_Warehouse_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WarehouseView).EndInit();
            ResumeLayout(false);
            }

        #endregion
        private Label label4;
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
        private DataGridViewTextBoxColumn Sum_Column;
        private DataGridView WarehouseView;
        private DataGridViewButtonColumn BtnDelete_;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewTextBoxColumn Typ_column;
        private DataGridViewTextBoxColumn NumerCzęści_column;
        private DataGridViewTextBoxColumn Nazwa_column_;
        private DataGridViewTextBoxColumn Opis_column_;
        private DataGridViewTextBoxColumn Cena_column;
        private DataGridViewTextBoxColumn Ilość_column;
        private DataGridViewTextBoxColumn EarningParts_Column;
        private DataGridViewTextBoxColumn Suma_Column;
        }
}
