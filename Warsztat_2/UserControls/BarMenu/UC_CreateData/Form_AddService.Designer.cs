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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            ServiceHistoryView = new DataGridView();
            ID_Column = new DataGridViewTextBoxColumn();
            RemoveBtn = new DataGridViewButtonColumn();
            ServiceName_Column = new DataGridViewTextBoxColumn();
            Price_Column = new DataGridViewTextBoxColumn();
            ServiceView = new DataGridView();
            ID_Column_ = new DataGridViewTextBoxColumn();
            BtnDelete_ = new DataGridViewButtonColumn();
            SelectBtn = new DataGridViewButtonColumn();
            ServiceName_Column_ = new DataGridViewTextBoxColumn();
            Price_Column_ = new DataGridViewTextBoxColumn();
            ServiceTextBox = new TextBox();
            label12 = new Label();
            panelKontaktowy = new Panel();
            AddButton = new Button();
            PriceNumericUpDown = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ServiceHistoryView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServiceView).BeginInit();
            panelKontaktowy.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ServiceHistoryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ServiceHistoryView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceHistoryView.Columns.AddRange(new DataGridViewColumn[] { ID_Column, RemoveBtn, ServiceName_Column, Price_Column });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ServiceHistoryView.DefaultCellStyle = dataGridViewCellStyle2;
            ServiceHistoryView.EnableHeadersVisualStyles = false;
            ServiceHistoryView.Location = new Point(12, 60);
            ServiceHistoryView.Name = "ServiceHistoryView";
            ServiceHistoryView.RowTemplate.Height = 25;
            ServiceHistoryView.Size = new Size(687, 251);
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
            RemoveBtn.FillWeight = 20F;
            RemoveBtn.HeaderText = "Usuń";
            RemoveBtn.Name = "RemoveBtn";
            // 
            // ServiceName_Column
            // 
            ServiceName_Column.DataPropertyName = "ServiceName";
            ServiceName_Column.HeaderText = "Usługa";
            ServiceName_Column.Name = "ServiceName_Column";
            // 
            // Price_Column
            // 
            Price_Column.DataPropertyName = "Price";
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ServiceView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ServiceView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceView.Columns.AddRange(new DataGridViewColumn[] { ID_Column_, BtnDelete_, SelectBtn, ServiceName_Column_, Price_Column_ });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            ServiceView.DefaultCellStyle = dataGridViewCellStyle4;
            ServiceView.EnableHeadersVisualStyles = false;
            ServiceView.Location = new Point(12, 323);
            ServiceView.Name = "ServiceView";
            ServiceView.RowTemplate.Height = 25;
            ServiceView.Size = new Size(687, 251);
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
            // ServiceTextBox
            // 
            ServiceTextBox.BackColor = Color.FromArgb(64, 64, 70);
            ServiceTextBox.BorderStyle = BorderStyle.None;
            ServiceTextBox.CausesValidation = false;
            ServiceTextBox.Cursor = Cursors.IBeam;
            ServiceTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ServiceTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            ServiceTextBox.Location = new Point(60, 7);
            ServiceTextBox.Margin = new Padding(3, 4, 3, 4);
            ServiceTextBox.Name = "ServiceTextBox";
            ServiceTextBox.PlaceholderText = "Nazwa usługi";
            ServiceTextBox.Size = new Size(281, 23);
            ServiceTextBox.TabIndex = 63;
            // 
            // label12
            // 
            label12.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(224, 224, 224);
            label12.Location = new Point(3, 6);
            label12.Name = "label12";
            label12.Size = new Size(66, 29);
            label12.TabIndex = 62;
            label12.Text = "Usługa:";
            // 
            // panelKontaktowy
            // 
            panelKontaktowy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelKontaktowy.BackColor = Color.FromArgb(64, 64, 70);
            panelKontaktowy.BorderStyle = BorderStyle.FixedSingle;
            panelKontaktowy.Controls.Add(AddButton);
            panelKontaktowy.Controls.Add(PriceNumericUpDown);
            panelKontaktowy.Controls.Add(ServiceTextBox);
            panelKontaktowy.Controls.Add(label1);
            panelKontaktowy.Controls.Add(label12);
            panelKontaktowy.ForeColor = Color.DimGray;
            panelKontaktowy.Location = new Point(12, 2);
            panelKontaktowy.Name = "panelKontaktowy";
            panelKontaktowy.Size = new Size(687, 52);
            panelKontaktowy.TabIndex = 64;
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
            AddButton.Location = new Point(489, 12);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(193, 35);
            AddButton.TabIndex = 65;
            AddButton.Text = "Dodaj";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.BackColor = Color.FromArgb(64, 64, 70);
            PriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PriceNumericUpDown.Location = new Point(390, 3);
            PriceNumericUpDown.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            PriceNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(70, 23);
            PriceNumericUpDown.TabIndex = 64;
            PriceNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(347, 1);
            label1.Name = "label1";
            label1.Size = new Size(66, 29);
            label1.TabIndex = 62;
            label1.Text = "Cena";
            // 
            // Form_AddService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(711, 627);
            Controls.Add(panelKontaktowy);
            Controls.Add(ServiceView);
            Controls.Add(ServiceHistoryView);
            MaximizeBox = false;
            MaximumSize = new Size(727, 666);
            MinimumSize = new Size(727, 666);
            Name = "Form_AddService";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usługi";
            Load += Form_AddService_Load;
            ((System.ComponentModel.ISupportInitialize)ServiceHistoryView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServiceView).EndInit();
            panelKontaktowy.ResumeLayout(false);
            panelKontaktowy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            ResumeLayout(false);
            }

        #endregion
        private DataGridView ServiceHistoryView;
        private DataGridView ServiceView;
        public TextBox ServiceTextBox;
        private Label label12;
        private Panel panelKontaktowy;
        public NumericUpDown PriceNumericUpDown;
        private Label label1;
        private Button AddButton;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewButtonColumn RemoveBtn;
        private DataGridViewTextBoxColumn ServiceName_Column;
        private DataGridViewTextBoxColumn Price_Column;
        private DataGridViewTextBoxColumn ID_Column_;
        private DataGridViewButtonColumn BtnDelete_;
        private DataGridViewButtonColumn SelectBtn;
        private DataGridViewTextBoxColumn ServiceName_Column_;
        private DataGridViewTextBoxColumn Price_Column_;
        }
    }