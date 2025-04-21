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
            button1 = new Button();
            ViewRepair = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            RemoveBtn = new DataGridViewButtonColumn();
            ServiceName_Column = new DataGridViewTextBoxColumn();
            Price_Column = new DataGridViewTextBoxColumn();
            ServiceView = new DataGridView();
            ServiceTextBox = new TextBox();
            label12 = new Label();
            panelKontaktowy = new Panel();
            AddButton = new Button();
            PriceNumericUpDown = new NumericUpDown();
            label1 = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            SelectBtn = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ViewRepair).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServiceView).BeginInit();
            panelKontaktowy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(94, 148, 255);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(12, 580);
            button1.Name = "button1";
            button1.Size = new Size(687, 35);
            button1.TabIndex = 59;
            button1.Text = "Anuluj";
            button1.UseVisualStyleBackColor = false;
            // 
            // ViewRepair
            // 
            ViewRepair.AllowUserToAddRows = false;
            ViewRepair.AllowUserToDeleteRows = false;
            ViewRepair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewRepair.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewRepair.BorderStyle = BorderStyle.None;
            ViewRepair.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ViewRepair.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.LightGray;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ViewRepair.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ViewRepair.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewRepair.Columns.AddRange(new DataGridViewColumn[] { ID, RemoveBtn, ServiceName_Column, Price_Column });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ViewRepair.DefaultCellStyle = dataGridViewCellStyle6;
            ViewRepair.EnableHeadersVisualStyles = false;
            ViewRepair.Location = new Point(12, 60);
            ViewRepair.Name = "ViewRepair";
            ViewRepair.RowTemplate.Height = 25;
            ViewRepair.Size = new Size(687, 251);
            ViewRepair.TabIndex = 60;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.LightGray;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            ServiceView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            ServiceView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn1, SelectBtn, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            ServiceView.DefaultCellStyle = dataGridViewCellStyle8;
            ServiceView.EnableHeadersVisualStyles = false;
            ServiceView.Location = new Point(12, 323);
            ServiceView.Name = "ServiceView";
            ServiceView.RowTemplate.Height = 25;
            ServiceView.Size = new Size(687, 251);
            ServiceView.TabIndex = 61;
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.FillWeight = 20F;
            dataGridViewButtonColumn1.HeaderText = "Usuń";
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // SelectBtn
            // 
            SelectBtn.FillWeight = 20F;
            SelectBtn.HeaderText = "Wybierz";
            SelectBtn.Name = "SelectBtn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "ServiceName";
            dataGridViewTextBoxColumn2.FillWeight = 58.6390762F;
            dataGridViewTextBoxColumn2.HeaderText = "Usługa";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            dataGridViewTextBoxColumn3.FillWeight = 58.6390762F;
            dataGridViewTextBoxColumn3.HeaderText = "Cena";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form_AddService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(711, 627);
            Controls.Add(panelKontaktowy);
            Controls.Add(ServiceView);
            Controls.Add(ViewRepair);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(727, 666);
            MinimumSize = new Size(727, 666);
            Name = "Form_AddService";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usługi";
            Load += Form_AddService_Load;
            ((System.ComponentModel.ISupportInitialize)ViewRepair).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServiceView).EndInit();
            panelKontaktowy.ResumeLayout(false);
            panelKontaktowy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            ResumeLayout(false);
            }

        #endregion
        private Button button1;
        private DataGridView ViewRepair;
        private DataGridView ServiceView;
        public TextBox ServiceTextBox;
        private Label label12;
        private Panel panelKontaktowy;
        public NumericUpDown PriceNumericUpDown;
        private Label label1;
        private Button AddButton;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewButtonColumn RemoveBtn;
        private DataGridViewTextBoxColumn ServiceName_Column;
        private DataGridViewTextBoxColumn Price_Column;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn SelectBtn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        }
    }