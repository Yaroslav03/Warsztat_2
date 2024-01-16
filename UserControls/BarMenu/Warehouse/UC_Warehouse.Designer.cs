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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            WarehouseView = new Guna.UI2.WinForms.Guna2DataGridView();
            BtnDelete = new DataGridViewButtonColumn();
            ID_Column = new DataGridViewTextBoxColumn();
            TypCzesci_Column_Main = new DataGridViewTextBoxColumn();
            NrCzesci_Column_Main = new DataGridViewTextBoxColumn();
            Nazwa_Column_Main = new DataGridViewTextBoxColumn();
            Opis_Column_Main = new DataGridViewTextBoxColumn();
            Quantity_Column = new DataGridViewTextBoxColumn();
            Price_Column = new DataGridViewTextBoxColumn();
            CategorylistBox = new ListBox();
            label4 = new Label();
            SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            CategoryTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            UpdateCategoryList = new Label();
            WarehouseAddButton = new Guna.UI2.WinForms.Guna2Button();
            AddCategoryButton = new Button();
            RemoveCategoryButton = new Button();
            ((System.ComponentModel.ISupportInitialize)WarehouseView).BeginInit();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // AddCategoryButton
            // 
            AddCategoryButton.BackColor = Color.FromArgb(94, 148, 255);
            AddCategoryButton.BackgroundImageLayout = ImageLayout.None;
            AddCategoryButton.FlatStyle = FlatStyle.Flat;
            AddCategoryButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddCategoryButton.ForeColor = Color.LightGray;
            AddCategoryButton.Location = new Point(15, 77);
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
            RemoveCategoryButton.Location = new Point(13, 116);
            RemoveCategoryButton.Name = "RemoveCategoryButton";
            RemoveCategoryButton.Size = new Size(169, 26);
            RemoveCategoryButton.TabIndex = 15;
            RemoveCategoryButton.Text = "-";
            RemoveCategoryButton.TextAlign = ContentAlignment.TopCenter;
            RemoveCategoryButton.UseVisualStyleBackColor = false;
            RemoveCategoryButton.Click += RemoveCategoryButton_Click;
            // 
            // WarehouseView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            WarehouseView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            WarehouseView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            WarehouseView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            WarehouseView.ColumnHeadersHeight = 17;
            WarehouseView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            WarehouseView.Columns.AddRange(new DataGridViewColumn[] { BtnDelete, ID_Column, TypCzesci_Column_Main, NrCzesci_Column_Main, Nazwa_Column_Main, Opis_Column_Main, Quantity_Column, Price_Column });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            WarehouseView.DefaultCellStyle = dataGridViewCellStyle4;
            WarehouseView.GridColor = Color.FromArgb(231, 229, 255);
            WarehouseView.Location = new Point(234, 0);
            WarehouseView.Name = "WarehouseView";
            WarehouseView.RowHeadersVisible = false;
            WarehouseView.RowTemplate.Height = 25;
            WarehouseView.Size = new Size(773, 643);
            WarehouseView.TabIndex = 10;
            WarehouseView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            WarehouseView.ThemeStyle.AlternatingRowsStyle.Font = null;
            WarehouseView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            WarehouseView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            WarehouseView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            WarehouseView.ThemeStyle.BackColor = Color.White;
            WarehouseView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            WarehouseView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            WarehouseView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            WarehouseView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            WarehouseView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            WarehouseView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            WarehouseView.ThemeStyle.HeaderStyle.Height = 17;
            WarehouseView.ThemeStyle.ReadOnly = false;
            WarehouseView.ThemeStyle.RowsStyle.BackColor = Color.White;
            WarehouseView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            WarehouseView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            WarehouseView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            WarehouseView.ThemeStyle.RowsStyle.Height = 25;
            WarehouseView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            WarehouseView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            WarehouseView.CellContentClick += WarehouseView_CellContentClick;
            WarehouseView.DoubleClick += WarehouseView_DoubleClick;
            // 
            // BtnDelete
            // 
            BtnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(94, 148, 255);
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            BtnDelete.DefaultCellStyle = dataGridViewCellStyle3;
            BtnDelete.FillWeight = 20.22091F;
            BtnDelete.FlatStyle = FlatStyle.Popup;
            BtnDelete.HeaderText = "Usuń";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Usuń";
            BtnDelete.Width = 50;
            // 
            // ID_Column
            // 
            ID_Column.DataPropertyName = "Id";
            ID_Column.HeaderText = "ID";
            ID_Column.Name = "ID_Column";
            ID_Column.Visible = false;
            // 
            // TypCzesci_Column_Main
            // 
            TypCzesci_Column_Main.DataPropertyName = "Typ";
            TypCzesci_Column_Main.FillWeight = 49.01244F;
            TypCzesci_Column_Main.HeaderText = "typ części";
            TypCzesci_Column_Main.Name = "TypCzesci_Column_Main";
            // 
            // NrCzesci_Column_Main
            // 
            NrCzesci_Column_Main.DataPropertyName = "NumerCzęści";
            NrCzesci_Column_Main.FillWeight = 72.88495F;
            NrCzesci_Column_Main.HeaderText = "Numer części";
            NrCzesci_Column_Main.Name = "NrCzesci_Column_Main";
            // 
            // Nazwa_Column_Main
            // 
            Nazwa_Column_Main.DataPropertyName = "Nazwa";
            Nazwa_Column_Main.FillWeight = 61.18229F;
            Nazwa_Column_Main.HeaderText = "Nazwa";
            Nazwa_Column_Main.Name = "Nazwa_Column_Main";
            // 
            // Opis_Column_Main
            // 
            Opis_Column_Main.DataPropertyName = "Opis";
            Opis_Column_Main.FillWeight = 160.9702F;
            Opis_Column_Main.HeaderText = "Opis";
            Opis_Column_Main.Name = "Opis_Column_Main";
            // 
            // Quantity_Column
            // 
            Quantity_Column.DataPropertyName = "Ilość";
            Quantity_Column.FillWeight = 28.6948547F;
            Quantity_Column.HeaderText = "Ilość";
            Quantity_Column.Name = "Quantity_Column";
            // 
            // Price_Column
            // 
            Price_Column.DataPropertyName = "Cena";
            Price_Column.FillWeight = 42.357357F;
            Price_Column.HeaderText = "Cena [zł]";
            Price_Column.Name = "Price_Column";
            // 
            // CategorylistBox
            // 
            CategorylistBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CategorylistBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CategorylistBox.FormattingEnabled = true;
            CategorylistBox.ItemHeight = 21;
            CategorylistBox.Location = new Point(15, 170);
            CategorylistBox.Name = "CategorylistBox";
            CategorylistBox.Size = new Size(167, 235);
            CategorylistBox.TabIndex = 14;
            CategorylistBox.MouseClick += CategorylistBox_MouseClick;
            CategorylistBox.MouseDoubleClick += CategorylistBox_MouseDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(5, 145);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 0;
            label4.Text = "Filtruj części:";
            // 
            // SearchTextBox
            // 
            SearchTextBox.BorderColor = Color.White;
            SearchTextBox.BorderRadius = 5;
            SearchTextBox.Cursor = Cursors.IBeam;
            SearchTextBox.CustomizableEdges = customizableEdges1;
            SearchTextBox.DefaultText = "";
            SearchTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchTextBox.FillColor = Color.DimGray;
            SearchTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTextBox.ForeColor = Color.FromArgb(94, 148, 255);
            SearchTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchTextBox.Location = new Point(5, 36);
            SearchTextBox.Margin = new Padding(3, 4, 3, 4);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PasswordChar = '\0';
            SearchTextBox.PlaceholderText = "";
            SearchTextBox.SelectedText = "";
            SearchTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SearchTextBox.Size = new Size(177, 30);
            SearchTextBox.TabIndex = 12;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(5, 11);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 0;
            label1.Text = "Wyszukaj za słowami";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(64, 64, 68);
            guna2Panel1.BorderColor = Color.DarkGray;
            guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(SearchTextBox);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(6, 39);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(192, 79);
            guna2Panel1.TabIndex = 14;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Panel2.BackColor = Color.FromArgb(64, 64, 68);
            guna2Panel2.BorderColor = Color.DarkGray;
            guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel2.BorderThickness = 1;
            guna2Panel2.Controls.Add(RemoveCategoryButton);
            guna2Panel2.Controls.Add(CategoryTextBox);
            guna2Panel2.Controls.Add(CategorylistBox);
            guna2Panel2.Controls.Add(AddCategoryButton);
            guna2Panel2.Controls.Add(UpdateCategoryList);
            guna2Panel2.Controls.Add(label4);
            guna2Panel2.CustomizableEdges = customizableEdges7;
            guna2Panel2.Location = new Point(6, 145);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel2.Size = new Size(192, 424);
            guna2Panel2.TabIndex = 14;
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.BorderColor = Color.White;
            CategoryTextBox.BorderRadius = 5;
            CategoryTextBox.Cursor = Cursors.IBeam;
            CategoryTextBox.CustomizableEdges = customizableEdges5;
            CategoryTextBox.DefaultText = "";
            CategoryTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            CategoryTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            CategoryTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            CategoryTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            CategoryTextBox.FillColor = Color.DimGray;
            CategoryTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            CategoryTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryTextBox.ForeColor = Color.FromArgb(94, 148, 255);
            CategoryTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            CategoryTextBox.Location = new Point(13, 37);
            CategoryTextBox.Margin = new Padding(3, 4, 3, 4);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.PasswordChar = '\0';
            CategoryTextBox.PlaceholderText = "";
            CategoryTextBox.SelectedText = "";
            CategoryTextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            CategoryTextBox.Size = new Size(167, 30);
            CategoryTextBox.TabIndex = 12;
            // 
            // UpdateCategoryList
            // 
            UpdateCategoryList.AutoSize = true;
            UpdateCategoryList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateCategoryList.ForeColor = Color.FromArgb(224, 224, 224);
            UpdateCategoryList.Location = new Point(13, 9);
            UpdateCategoryList.Name = "UpdateCategoryList";
            UpdateCategoryList.Size = new Size(69, 21);
            UpdateCategoryList.TabIndex = 0;
            UpdateCategoryList.Text = "Odśwież";
            UpdateCategoryList.Click += UpdateCategoryList_Click;
            // 
            // WarehouseAddButton
            // 
            WarehouseAddButton.BorderRadius = 5;
            WarehouseAddButton.Cursor = Cursors.Hand;
            WarehouseAddButton.CustomizableEdges = customizableEdges9;
            WarehouseAddButton.DisabledState.BorderColor = Color.DarkGray;
            WarehouseAddButton.DisabledState.CustomBorderColor = Color.DarkGray;
            WarehouseAddButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            WarehouseAddButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            WarehouseAddButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            WarehouseAddButton.ForeColor = Color.LightGray;
            WarehouseAddButton.Location = new Point(6, 5);
            WarehouseAddButton.Name = "WarehouseAddButton";
            WarehouseAddButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            WarehouseAddButton.Size = new Size(192, 28);
            WarehouseAddButton.TabIndex = 15;
            WarehouseAddButton.Text = "Dodaj";
            WarehouseAddButton.Click += WarehouseAddButton_Click;
            // 
            // UC_Warehouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            Controls.Add(WarehouseAddButton);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Panel2);
            Controls.Add(WarehouseView);
            Name = "UC_Warehouse";
            Size = new Size(1007, 643);
            Load += UC_Warehouse_Load;
            ((System.ComponentModel.ISupportInitialize)WarehouseView).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Label label4;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        public Guna.UI2.WinForms.Guna2Button WarehouseAddButton;
        public Guna.UI2.WinForms.Guna2DataGridView WarehouseView;
        public Guna.UI2.WinForms.Guna2TextBox CategoryTextBox;
        public ListBox CategorylistBox;
        private Label UpdateCategoryList;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewTextBoxColumn TypCzesci_Column_Main;
        private DataGridViewTextBoxColumn NrCzesci_Column_Main;
        private DataGridViewTextBoxColumn Nazwa_Column_Main;
        private DataGridViewTextBoxColumn Opis_Column_Main;
        private DataGridViewTextBoxColumn Quantity_Column;
        private DataGridViewTextBoxColumn Price_Column;
    }
}
