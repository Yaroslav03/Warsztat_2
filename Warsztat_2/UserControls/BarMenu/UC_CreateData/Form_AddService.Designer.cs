namespace Warsztat_2.UserControls.BarMenu.UC_CreateData {
    partial class Form_AddService {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            ServiceHistoryView = new DataGridView();
            ID_Column = new DataGridViewTextBoxColumn();
            RemoveBtn = new DataGridViewButtonColumn();
            SelectBtn_ = new DataGridViewButtonColumn();
            ServiceName_Column = new DataGridViewTextBoxColumn();
            Price_Column = new DataGridViewTextBoxColumn();
            ServiceView = new DataGridView();
            ID_Column_ = new DataGridViewTextBoxColumn();
            BtnDelete_ = new DataGridViewButtonColumn();
            SelectBtn = new DataGridViewButtonColumn();
            ServiceName_Column_ = new DataGridViewTextBoxColumn();
            Price_Column_ = new DataGridViewTextBoxColumn();
            AddButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            PriceNumericUpDown = new NumericUpDown();
            ServiceTextBox = new TextBox();
            label9 = new Label();
            label22 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)ServiceHistoryView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServiceView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // ServiceHistoryView
            // 
            ServiceHistoryView.AllowUserToAddRows = false;
            ServiceHistoryView.AllowUserToDeleteRows = false;
            ServiceHistoryView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ServiceHistoryView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ServiceHistoryView.BorderStyle = BorderStyle.None;
            ServiceHistoryView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ServiceHistoryView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.LightGray;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ServiceHistoryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ServiceHistoryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceHistoryView.Columns.AddRange(new DataGridViewColumn[] { ID_Column, RemoveBtn, SelectBtn_, ServiceName_Column, Price_Column });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ServiceHistoryView.DefaultCellStyle = dataGridViewCellStyle6;
            ServiceHistoryView.EnableHeadersVisualStyles = false;
            ServiceHistoryView.Location = new Point(4, 150);
            ServiceHistoryView.Name = "ServiceHistoryView";
            ServiceHistoryView.RowTemplate.Height = 25;
            ServiceHistoryView.Size = new Size(835, 197);
            ServiceHistoryView.TabIndex = 60;
            ServiceHistoryView.CellContentClick += ServiceHistoryView_CellContentClick;
            // 
            // ID_Column
            // 
            ID_Column.DataPropertyName = "Id";
            ID_Column.HeaderText = "ID";
            ID_Column.Name = "ID_Column";
            ID_Column.Visible = false;
            // 
            // RemoveBtn
            // 
            RemoveBtn.FillWeight = 23.1841259F;
            RemoveBtn.HeaderText = "Usuń";
            RemoveBtn.Name = "RemoveBtn";
            // 
            // SelectBtn_
            // 
            SelectBtn_.FillWeight = 23.18412F;
            SelectBtn_.HeaderText = "Wybierz";
            SelectBtn_.Name = "SelectBtn_";
            // 
            // ServiceName_Column
            // 
            ServiceName_Column.DataPropertyName = "ServiceName";
            ServiceName_Column.FillWeight = 115.920631F;
            ServiceName_Column.HeaderText = "Usługa";
            ServiceName_Column.Name = "ServiceName_Column";
            // 
            // Price_Column
            // 
            Price_Column.DataPropertyName = "Price";
            Price_Column.FillWeight = 115.920631F;
            Price_Column.HeaderText = "Cena";
            Price_Column.Name = "Price_Column";
            // 
            // ServiceView
            // 
            ServiceView.AllowUserToAddRows = false;
            ServiceView.AllowUserToDeleteRows = false;
            ServiceView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ServiceView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ServiceView.BorderStyle = BorderStyle.None;
            ServiceView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ServiceView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.LightGray;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            ServiceView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            ServiceView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceView.Columns.AddRange(new DataGridViewColumn[] { ID_Column_, BtnDelete_, SelectBtn, ServiceName_Column_, Price_Column_ });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            ServiceView.DefaultCellStyle = dataGridViewCellStyle8;
            ServiceView.EnableHeadersVisualStyles = false;
            ServiceView.Location = new Point(4, 398);
            ServiceView.Name = "ServiceView";
            ServiceView.RowTemplate.Height = 25;
            ServiceView.Size = new Size(835, 225);
            ServiceView.TabIndex = 61;
            ServiceView.CellContentClick += ServiceView_CellContentClick;
            // 
            // ID_Column_
            // 
            ID_Column_.DataPropertyName = "Id";
            ID_Column_.HeaderText = "ID";
            ID_Column_.Name = "ID_Column_";
            ID_Column_.Visible = false;
            // 
            // BtnDelete_
            // 
            BtnDelete_.FillWeight = 20F;
            BtnDelete_.HeaderText = "Usuń";
            BtnDelete_.Name = "BtnDelete_";
            // 
            // SelectBtn
            // 
            SelectBtn.FillWeight = 20F;
            SelectBtn.HeaderText = "Wybierz";
            SelectBtn.Name = "SelectBtn";
            // 
            // ServiceName_Column_
            // 
            ServiceName_Column_.DataPropertyName = "ServiceName";
            ServiceName_Column_.FillWeight = 58.6390762F;
            ServiceName_Column_.HeaderText = "Usługa";
            ServiceName_Column_.Name = "ServiceName_Column_";
            // 
            // Price_Column_
            // 
            Price_Column_.DataPropertyName = "Price";
            Price_Column_.FillWeight = 58.6390762F;
            Price_Column_.HeaderText = "Cena";
            Price_Column_.Name = "Price_Column_";
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.BackColor = Color.FromArgb(94, 148, 255);
            AddButton.Cursor = Cursors.Hand;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.ForeColor = Color.LightGray;
            AddButton.Location = new Point(582, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(249, 35);
            AddButton.TabIndex = 65;
            AddButton.Text = "Dodaj";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(64, 64, 70);
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.03998F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(ServiceView, 0, 5);
            tableLayoutPanel1.Controls.Add(label2, 0, 4);
            tableLayoutPanel1.Controls.Add(ServiceHistoryView, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.46729F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.53271F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 203F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 230F));
            tableLayoutPanel1.Size = new Size(843, 627);
            tableLayoutPanel1.TabIndex = 65;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(64, 64, 70);
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0692043F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.038063F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.1899824F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.65285F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 252F));
            tableLayoutPanel2.Controls.Add(PriceNumericUpDown, 3, 0);
            tableLayoutPanel2.Controls.Add(AddButton, 4, 0);
            tableLayoutPanel2.Controls.Add(ServiceTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(label9, 2, 0);
            tableLayoutPanel2.Controls.Add(label22, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 58);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 51.1904755F));
            tableLayoutPanel2.Size = new Size(835, 46);
            tableLayoutPanel2.TabIndex = 68;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.BackColor = Color.FromArgb(48, 48, 54);
            PriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PriceNumericUpDown.DecimalPlaces = 2;
            PriceNumericUpDown.Dock = DockStyle.Fill;
            PriceNumericUpDown.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PriceNumericUpDown.ForeColor = Color.FromArgb(224, 224, 224);
            PriceNumericUpDown.Location = new Point(474, 4);
            PriceNumericUpDown.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(101, 31);
            PriceNumericUpDown.TabIndex = 66;
            // 
            // ServiceTextBox
            // 
            ServiceTextBox.BackColor = Color.FromArgb(48, 48, 54);
            ServiceTextBox.BorderStyle = BorderStyle.FixedSingle;
            ServiceTextBox.CausesValidation = false;
            ServiceTextBox.Cursor = Cursors.IBeam;
            ServiceTextBox.Dock = DockStyle.Fill;
            ServiceTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ServiceTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            ServiceTextBox.Location = new Point(120, 4);
            ServiceTextBox.Name = "ServiceTextBox";
            ServiceTextBox.Size = new Size(288, 30);
            ServiceTextBox.TabIndex = 43;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(415, 1);
            label9.Name = "label9";
            label9.Size = new Size(52, 44);
            label9.TabIndex = 33;
            label9.Text = "Cena";
            // 
            // label22
            // 
            label22.Dock = DockStyle.Fill;
            label22.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.FromArgb(224, 224, 224);
            label22.Location = new Point(4, 1);
            label22.Name = "label22";
            label22.Size = new Size(109, 44);
            label22.TabIndex = 32;
            label22.Text = "Nazwa usługi";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(4, 351);
            label2.Name = "label2";
            label2.Size = new Size(835, 43);
            label2.TabIndex = 66;
            label2.Text = "Katalog usług warsztatowych";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(4, 108);
            label3.Name = "label3";
            label3.Size = new Size(835, 38);
            label3.TabIndex = 67;
            label3.Text = "Usługi przypisane do zlecenia";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(4, 1);
            label4.Name = "label4";
            label4.Size = new Size(835, 53);
            label4.TabIndex = 67;
            label4.Text = "Dodaj własną usługę";
            // 
            // Form_AddService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(843, 627);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimumSize = new Size(727, 666);
            Name = "Form_AddService";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usługi";
            Load += Form_AddService_Load;
            ((System.ComponentModel.ISupportInitialize)ServiceHistoryView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServiceView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView ServiceHistoryView;
        private DataGridView ServiceView;
        private Button AddButton;
        private DataGridViewTextBoxColumn ID_Column_;
        private DataGridViewButtonColumn BtnDelete_;
        private DataGridViewButtonColumn SelectBtn;
        private DataGridViewTextBoxColumn ServiceName_Column_;
        private DataGridViewTextBoxColumn Price_Column_;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewButtonColumn RemoveBtn;
        private DataGridViewButtonColumn SelectBtn_;
        private DataGridViewTextBoxColumn ServiceName_Column;
        private DataGridViewTextBoxColumn Price_Column;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox ServiceTextBox;
        private Label label9;
        private Label label22;
        private NumericUpDown PriceNumericUpDown;
    }
    }