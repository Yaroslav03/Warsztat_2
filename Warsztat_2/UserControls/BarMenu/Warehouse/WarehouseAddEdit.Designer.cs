namespace Warsztat_2._0.UserControls.BarMenu.Warehouse
{
    partial class WarehouseAddEdit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            CategoryListBox = new ListBox();
            label4 = new Label();
            label5 = new Label();
            DescriptionTextBox = new TextBox();
            label3 = new Label();
            AddEditWarehouseButton = new Button();
            NameTextBox = new TextBox();
            NumberPartTextBox = new TextBox();
            QuantityNumericUpDown = new NumericUpDown();
            PriceNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            EarningNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EarningNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // CategoryListBox
            // 
            CategoryListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryListBox.FormattingEnabled = true;
            CategoryListBox.ItemHeight = 21;
            CategoryListBox.Location = new Point(12, 10);
            CategoryListBox.Name = "CategoryListBox";
            CategoryListBox.Size = new Size(120, 109);
            CategoryListBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(12, 126);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 0;
            label4.Text = "Cena zakupu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(216, 126);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 0;
            label5.Text = "Ilość";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BackColor = Color.FromArgb(64, 64, 70);
            DescriptionTextBox.CausesValidation = false;
            DescriptionTextBox.Cursor = Cursors.IBeam;
            DescriptionTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            DescriptionTextBox.Location = new Point(12, 199);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(420, 30);
            DescriptionTextBox.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 0;
            label3.Text = "Opis";
            // 
            // AddEditWarehouseButton
            // 
            AddEditWarehouseButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddEditWarehouseButton.BackColor = Color.FromArgb(94, 148, 255);
            AddEditWarehouseButton.FlatAppearance.BorderSize = 0;
            AddEditWarehouseButton.FlatStyle = FlatStyle.Flat;
            AddEditWarehouseButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddEditWarehouseButton.ForeColor = Color.LightGray;
            AddEditWarehouseButton.Location = new Point(12, 235);
            AddEditWarehouseButton.Name = "AddEditWarehouseButton";
            AddEditWarehouseButton.Size = new Size(420, 30);
            AddEditWarehouseButton.TabIndex = 23;
            AddEditWarehouseButton.Text = "Zapisz";
            AddEditWarehouseButton.UseVisualStyleBackColor = false;
            AddEditWarehouseButton.Click += AddEditWarehouseButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NameTextBox.CausesValidation = false;
            NameTextBox.Cursor = Cursors.IBeam;
            NameTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NameTextBox.Location = new Point(147, 57);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Nazwa";
            NameTextBox.Size = new Size(171, 30);
            NameTextBox.TabIndex = 20;
            // 
            // NumberPartTextBox
            // 
            NumberPartTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NumberPartTextBox.CausesValidation = false;
            NumberPartTextBox.Cursor = Cursors.IBeam;
            NumberPartTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NumberPartTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NumberPartTextBox.Location = new Point(147, 10);
            NumberPartTextBox.Name = "NumberPartTextBox";
            NumberPartTextBox.PlaceholderText = "Numer części";
            NumberPartTextBox.Size = new Size(171, 30);
            NumberPartTextBox.TabIndex = 20;
            // 
            // QuantityNumericUpDown
            // 
            QuantityNumericUpDown.BackColor = Color.White;
            QuantityNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            QuantityNumericUpDown.Location = new Point(216, 149);
            QuantityNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            QuantityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            QuantityNumericUpDown.Size = new Size(75, 23);
            QuantityNumericUpDown.TabIndex = 26;
            QuantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            QuantityNumericUpDown.ValueChanged += QuantityNumericUpDown_ValueChanged;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.BackColor = Color.White;
            PriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PriceNumericUpDown.DecimalPlaces = 2;
            PriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            PriceNumericUpDown.Location = new Point(12, 149);
            PriceNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(75, 23);
            PriceNumericUpDown.TabIndex = 26;
            PriceNumericUpDown.ValueChanged += PriceNumericUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(324, 151);
            label1.Name = "label1";
            label1.Size = new Size(19, 21);
            label1.TabIndex = 0;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(297, 151);
            label2.Name = "label2";
            label2.Size = new Size(21, 21);
            label2.TabIndex = 0;
            label2.Text = "=";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(193, 149);
            label6.Name = "label6";
            label6.Size = new Size(17, 21);
            label6.TabIndex = 0;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(93, 149);
            label7.Name = "label7";
            label7.Size = new Size(21, 21);
            label7.TabIndex = 28;
            label7.Text = "+";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(124, 126);
            label8.Name = "label8";
            label8.Size = new Size(42, 21);
            label8.TabIndex = 29;
            label8.Text = "Zysk";
            // 
            // EarningNumericUpDown
            // 
            EarningNumericUpDown.BackColor = Color.White;
            EarningNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            EarningNumericUpDown.DecimalPlaces = 2;
            EarningNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            EarningNumericUpDown.Location = new Point(115, 149);
            EarningNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            EarningNumericUpDown.Name = "EarningNumericUpDown";
            EarningNumericUpDown.Size = new Size(75, 23);
            EarningNumericUpDown.TabIndex = 30;
            EarningNumericUpDown.ValueChanged += EarningNumericUpDown_ValueChanged;
            // 
            // WarehouseAddEdit
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(444, 277);
            Controls.Add(EarningNumericUpDown);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(PriceNumericUpDown);
            Controls.Add(QuantityNumericUpDown);
            Controls.Add(AddEditWarehouseButton);
            Controls.Add(NumberPartTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(CategoryListBox);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(460, 266);
            Name = "WarehouseAddEdit";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WarehouseAddEdit";
            Load += WarehouseAddEdit_Load;
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)EarningNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion
        private Label label4;
        private Label label5;
        public ListBox CategoryListBox;
        private TextBox DescriptionTextBox;
        private Label label3;
        private Button AddEditWarehouseButton;
        private TextBox NameTextBox;
        private TextBox NumberPartTextBox;
        private NumericUpDown QuantityNumericUpDown;
        private NumericUpDown PriceNumericUpDown;
        private Label label2;
        private Label label6;
        public Label label1;
        private Label label7;
        private Label label8;
        private NumericUpDown EarningNumericUpDown;
        }
}