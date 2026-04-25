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
            label4 = new Label();
            label5 = new Label();
            DescriptionTextBox = new TextBox();
            AddEditWarehouseButton = new Button();
            NameTextBox = new TextBox();
            NumberPartTextBox = new TextBox();
            QuantityNumericUpDown = new NumericUpDown();
            PriceNumericUpDown = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            EarningNumericUpDown = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            label3 = new Label();
            CategoryComboBox = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            priceVAT = new Label();
            priceNetto = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label15 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            priceBRUTTO = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EarningNumericUpDown).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 33);
            label4.TabIndex = 0;
            label4.Text = "Cena zakupu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(318, 0);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 0;
            label5.Text = "Ilość";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BackColor = Color.FromArgb(48, 48, 54);
            DescriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
            DescriptionTextBox.CausesValidation = false;
            DescriptionTextBox.Cursor = Cursors.IBeam;
            DescriptionTextBox.Dock = DockStyle.Fill;
            DescriptionTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            DescriptionTextBox.Location = new Point(133, 129);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(474, 30);
            DescriptionTextBox.TabIndex = 20;
            // 
            // AddEditWarehouseButton
            // 
            AddEditWarehouseButton.BackColor = Color.FromArgb(94, 148, 255);
            AddEditWarehouseButton.Dock = DockStyle.Bottom;
            AddEditWarehouseButton.FlatAppearance.BorderSize = 0;
            AddEditWarehouseButton.FlatStyle = FlatStyle.Flat;
            AddEditWarehouseButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddEditWarehouseButton.ForeColor = Color.LightGray;
            AddEditWarehouseButton.Location = new Point(613, 243);
            AddEditWarehouseButton.Name = "AddEditWarehouseButton";
            AddEditWarehouseButton.Size = new Size(137, 30);
            AddEditWarehouseButton.TabIndex = 23;
            AddEditWarehouseButton.Text = "Zapisz";
            AddEditWarehouseButton.UseVisualStyleBackColor = false;
            AddEditWarehouseButton.Click += AddEditWarehouseButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.FromArgb(48, 48, 54);
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.CausesValidation = false;
            NameTextBox.Cursor = Cursors.IBeam;
            NameTextBox.Dock = DockStyle.Fill;
            NameTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NameTextBox.Location = new Point(133, 93);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(474, 30);
            NameTextBox.TabIndex = 20;
            // 
            // NumberPartTextBox
            // 
            NumberPartTextBox.BackColor = Color.FromArgb(48, 48, 54);
            NumberPartTextBox.BorderStyle = BorderStyle.FixedSingle;
            NumberPartTextBox.CausesValidation = false;
            NumberPartTextBox.Cursor = Cursors.IBeam;
            NumberPartTextBox.Dock = DockStyle.Fill;
            NumberPartTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NumberPartTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NumberPartTextBox.Location = new Point(133, 57);
            NumberPartTextBox.Name = "NumberPartTextBox";
            NumberPartTextBox.Size = new Size(474, 30);
            NumberPartTextBox.TabIndex = 20;
            // 
            // QuantityNumericUpDown
            // 
            QuantityNumericUpDown.BackColor = Color.FromArgb(48, 48, 54);
            QuantityNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            QuantityNumericUpDown.Dock = DockStyle.Fill;
            QuantityNumericUpDown.ForeColor = Color.FromArgb(224, 224, 224);
            QuantityNumericUpDown.Location = new Point(365, 3);
            QuantityNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            QuantityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            QuantityNumericUpDown.Size = new Size(106, 25);
            QuantityNumericUpDown.TabIndex = 26;
            QuantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            QuantityNumericUpDown.ValueChanged += QuantityNumericUpDown_ValueChanged;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.BackColor = Color.FromArgb(48, 48, 54);
            PriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PriceNumericUpDown.DecimalPlaces = 2;
            PriceNumericUpDown.Dock = DockStyle.Fill;
            PriceNumericUpDown.ForeColor = Color.FromArgb(224, 224, 224);
            PriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            PriceNumericUpDown.Location = new Point(108, 3);
            PriceNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(75, 25);
            PriceNumericUpDown.TabIndex = 26;
            PriceNumericUpDown.ValueChanged += PriceNumericUpDown_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(19, 201);
            label7.Name = "label7";
            label7.Size = new Size(108, 75);
            label7.TabIndex = 28;
            label7.Text = "Podgląd";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(189, 0);
            label8.Name = "label8";
            label8.Size = new Size(42, 21);
            label8.TabIndex = 29;
            label8.Text = "Zysk";
            // 
            // EarningNumericUpDown
            // 
            EarningNumericUpDown.BackColor = Color.FromArgb(48, 48, 54);
            EarningNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            EarningNumericUpDown.DecimalPlaces = 2;
            EarningNumericUpDown.Dock = DockStyle.Fill;
            EarningNumericUpDown.ForeColor = Color.FromArgb(224, 224, 224);
            EarningNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            EarningNumericUpDown.Location = new Point(237, 3);
            EarningNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            EarningNumericUpDown.Name = "EarningNumericUpDown";
            EarningNumericUpDown.Size = new Size(75, 25);
            EarningNumericUpDown.TabIndex = 30;
            EarningNumericUpDown.ValueChanged += EarningNumericUpDown_ValueChanged;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(19, 16);
            label9.Name = "label9";
            label9.Size = new Size(108, 38);
            label9.TabIndex = 31;
            label9.Text = "Kategoria:";
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(224, 224, 224);
            label10.Location = new Point(19, 90);
            label10.Name = "label10";
            label10.Size = new Size(108, 36);
            label10.TabIndex = 31;
            label10.Text = "Producent:";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(19, 126);
            label3.Name = "label3";
            label3.Size = new Size(108, 36);
            label3.TabIndex = 31;
            label3.Text = "Opis:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.BackColor = Color.FromArgb(48, 48, 54);
            CategoryComboBox.Dock = DockStyle.Fill;
            CategoryComboBox.FlatStyle = FlatStyle.Flat;
            CategoryComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryComboBox.ForeColor = Color.FromArgb(224, 224, 224);
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.ItemHeight = 21;
            CategoryComboBox.Location = new Point(133, 19);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(474, 29);
            CategoryComboBox.TabIndex = 32;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(224, 224, 224);
            label11.Location = new Point(19, 54);
            label11.Name = "label11";
            label11.Size = new Size(108, 36);
            label11.TabIndex = 31;
            label11.Text = "Numer części:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(224, 224, 224);
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(172, 21);
            label12.TabIndex = 28;
            label12.Text = "Cena sprzedaży NETTO:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(224, 224, 224);
            label14.Location = new Point(3, 21);
            label14.Name = "label14";
            label14.Size = new Size(172, 20);
            label14.TabIndex = 28;
            label14.Text = "VAT 23%:";
            // 
            // priceVAT
            // 
            priceVAT.AutoSize = true;
            priceVAT.Dock = DockStyle.Fill;
            priceVAT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceVAT.ForeColor = Color.FromArgb(224, 224, 224);
            priceVAT.Location = new Point(181, 21);
            priceVAT.Name = "priceVAT";
            priceVAT.Size = new Size(290, 20);
            priceVAT.TabIndex = 28;
            priceVAT.Text = "0 PLN";
            priceVAT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceNetto
            // 
            priceNetto.AutoSize = true;
            priceNetto.Dock = DockStyle.Fill;
            priceNetto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceNetto.ForeColor = Color.FromArgb(224, 224, 224);
            priceNetto.Location = new Point(181, 0);
            priceNetto.Name = "priceNetto";
            priceNetto.Size = new Size(290, 21);
            priceNetto.TabIndex = 28;
            priceNetto.Text = "0 PLN";
            priceNetto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label9, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(CategoryComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label10, 0, 2);
            tableLayoutPanel1.Controls.Add(label11, 0, 1);
            tableLayoutPanel1.Controls.Add(NumberPartTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(NameTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(DescriptionTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 4);
            tableLayoutPanel1.Controls.Add(label15, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 5);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(AddEditWarehouseButton, 2, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(16, 16, 16, 8);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(757, 277);
            tableLayoutPanel1.TabIndex = 33;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(label8, 3, 1);
            tableLayoutPanel2.Controls.Add(EarningNumericUpDown, 4, 1);
            tableLayoutPanel2.Controls.Add(label4, 1, 1);
            tableLayoutPanel2.Controls.Add(PriceNumericUpDown, 2, 1);
            tableLayoutPanel2.Controls.Add(label5, 5, 1);
            tableLayoutPanel2.Controls.Add(QuantityNumericUpDown, 6, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(133, 165);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(474, 33);
            tableLayoutPanel2.TabIndex = 33;
            // 
            // label15
            // 
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(224, 224, 224);
            label15.Location = new Point(19, 162);
            label15.Name = "label15";
            label15.Size = new Size(108, 39);
            label15.TabIndex = 31;
            label15.Text = "Cena:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(priceBRUTTO, 2, 3);
            tableLayoutPanel3.Controls.Add(label1, 1, 3);
            tableLayoutPanel3.Controls.Add(label12, 1, 1);
            tableLayoutPanel3.Controls.Add(priceVAT, 2, 2);
            tableLayoutPanel3.Controls.Add(label14, 1, 2);
            tableLayoutPanel3.Controls.Add(priceNetto, 2, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(133, 204);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(474, 69);
            tableLayoutPanel3.TabIndex = 34;
            // 
            // priceBRUTTO
            // 
            priceBRUTTO.AutoSize = true;
            priceBRUTTO.Dock = DockStyle.Fill;
            priceBRUTTO.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceBRUTTO.ForeColor = Color.FromArgb(224, 224, 224);
            priceBRUTTO.Location = new Point(181, 41);
            priceBRUTTO.Name = "priceBRUTTO";
            priceBRUTTO.Size = new Size(290, 28);
            priceBRUTTO.TabIndex = 36;
            priceBRUTTO.Text = "0 PLN";
            priceBRUTTO.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(3, 41);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 36;
            label1.Text = "Cena BRUTTO:";
            // 
            // WarehouseAddEdit
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 70);
            ClientSize = new Size(757, 277);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label label5;
        private TextBox DescriptionTextBox;
        private Button AddEditWarehouseButton;
        private TextBox NameTextBox;
        private TextBox NumberPartTextBox;
        private NumericUpDown QuantityNumericUpDown;
        private NumericUpDown PriceNumericUpDown;
        private Label label7;
        private Label label8;
        private NumericUpDown EarningNumericUpDown;
        private Label label9;
        private Label label10;
        private Label label3;
        private ComboBox CategoryComboBox;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label priceVAT;
        private Label priceNetto;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label15;
        private TableLayoutPanel tableLayoutPanel3;
        private Label priceBRUTTO;
        private Label label1;
        }
}