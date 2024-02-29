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
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
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
            label4.Location = new Point(351, 11);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 0;
            label4.Text = "Cena";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(351, 68);
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
            DescriptionTextBox.Location = new Point(12, 150);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(420, 30);
            DescriptionTextBox.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(12, 126);
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
            AddEditWarehouseButton.Location = new Point(12, 186);
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
            NameTextBox.Location = new Point(156, 94);
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
            NumberPartTextBox.Location = new Point(156, 35);
            NumberPartTextBox.Name = "NumberPartTextBox";
            NumberPartTextBox.PlaceholderText = "Numer części";
            NumberPartTextBox.Size = new Size(171, 30);
            NumberPartTextBox.TabIndex = 20;
            // 
            // QuantityNumericUpDown
            // 
            QuantityNumericUpDown.BackColor = Color.White;
            QuantityNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            QuantityNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            QuantityNumericUpDown.Location = new Point(351, 101);
            QuantityNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            QuantityNumericUpDown.Size = new Size(75, 23);
            QuantityNumericUpDown.TabIndex = 26;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.BackColor = Color.White;
            PriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            PriceNumericUpDown.Location = new Point(351, 42);
            PriceNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(75, 23);
            PriceNumericUpDown.TabIndex = 26;
            // 
            // WarehouseAddEdit
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(444, 227);
            Controls.Add(PriceNumericUpDown);
            Controls.Add(QuantityNumericUpDown);
            Controls.Add(AddEditWarehouseButton);
            Controls.Add(NumberPartTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(CategoryListBox);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            MaximizeBox = false;
            MaximumSize = new Size(460, 266);
            MinimizeBox = false;
            MinimumSize = new Size(460, 266);
            Name = "WarehouseAddEdit";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WarehouseAddEdit";
            Load += WarehouseAddEdit_Load;
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
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
    }
}