namespace Warsztat_2.UserControls.BarMenu.Settings {
    partial class UC_CompanyExpenses {
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel3 = new Panel();
            DateOfDeductionCalendar = new DateTimePicker();
            label7 = new Label();
            ViewDataOfDeduction = new DataGridView();
            ID_Column = new DataGridViewTextBoxColumn();
            BtnDelete = new DataGridViewButtonColumn();
            NazwaWydatku_Column = new DataGridViewTextBoxColumn();
            CenaWydatku_Column = new DataGridViewTextBoxColumn();
            DataPotrącenia_Column = new DataGridViewTextBoxColumn();
            ExpenseNameTextBox = new TextBox();
            PriceNumericUpDown = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            BtnSaveDateOfDeduction = new Button();
            label3 = new Label();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            SaveButton = new Button();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            ID_Column_ = new DataGridViewTextBoxColumn();
            BtnDelete_ = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewDataOfDeduction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(64, 64, 70);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(DateOfDeductionCalendar);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(ViewDataOfDeduction);
            panel3.Controls.Add(ExpenseNameTextBox);
            panel3.Controls.Add(PriceNumericUpDown);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(BtnSaveDateOfDeduction);
            panel3.Controls.Add(label3);
            panel3.ForeColor = Color.DimGray;
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1019, 222);
            panel3.TabIndex = 30;
            // 
            // DateOfDeductionCalendar
            // 
            DateOfDeductionCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateOfDeductionCalendar.Format = DateTimePickerFormat.Short;
            DateOfDeductionCalendar.Location = new Point(544, 68);
            DateOfDeductionCalendar.Name = "DateOfDeductionCalendar";
            DateOfDeductionCalendar.Size = new Size(200, 23);
            DateOfDeductionCalendar.TabIndex = 38;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(544, 44);
            label7.Name = "label7";
            label7.Size = new Size(119, 21);
            label7.TabIndex = 36;
            label7.Text = "Data potrącenia";
            // 
            // ViewDataOfDeduction
            // 
            ViewDataOfDeduction.AllowUserToAddRows = false;
            ViewDataOfDeduction.AllowUserToDeleteRows = false;
            ViewDataOfDeduction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ViewDataOfDeduction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewDataOfDeduction.BorderStyle = BorderStyle.None;
            ViewDataOfDeduction.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewDataOfDeduction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewDataOfDeduction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewDataOfDeduction.Columns.AddRange(new DataGridViewColumn[] { ID_Column, BtnDelete, NazwaWydatku_Column, CenaWydatku_Column, DataPotrącenia_Column });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ViewDataOfDeduction.DefaultCellStyle = dataGridViewCellStyle3;
            ViewDataOfDeduction.EnableHeadersVisualStyles = false;
            ViewDataOfDeduction.Location = new Point(13, 31);
            ViewDataOfDeduction.Name = "ViewDataOfDeduction";
            ViewDataOfDeduction.RowTemplate.Height = 25;
            ViewDataOfDeduction.Size = new Size(525, 174);
            ViewDataOfDeduction.TabIndex = 34;
            ViewDataOfDeduction.CellContentClick += ViewDataOfDeduction_CellContentClick;
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
            BtnDelete.HeaderText = "Usuń";
            BtnDelete.Name = "BtnDelete";
            // 
            // NazwaWydatku_Column
            // 
            NazwaWydatku_Column.DataPropertyName = "NazwaWydatku";
            NazwaWydatku_Column.HeaderText = "Nazwa Wydatku";
            NazwaWydatku_Column.Name = "NazwaWydatku_Column";
            // 
            // CenaWydatku_Column
            // 
            CenaWydatku_Column.DataPropertyName = "CenaWydatku";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            CenaWydatku_Column.DefaultCellStyle = dataGridViewCellStyle2;
            CenaWydatku_Column.HeaderText = "Stała kwota potręcenia";
            CenaWydatku_Column.Name = "CenaWydatku_Column";
            // 
            // DataPotrącenia_Column
            // 
            DataPotrącenia_Column.DataPropertyName = "DataPotrącenia";
            DataPotrącenia_Column.HeaderText = "Data";
            DataPotrącenia_Column.Name = "DataPotrącenia_Column";
            // 
            // ExpenseNameTextBox
            // 
            ExpenseNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExpenseNameTextBox.BackColor = Color.FromArgb(64, 64, 70);
            ExpenseNameTextBox.CausesValidation = false;
            ExpenseNameTextBox.Cursor = Cursors.IBeam;
            ExpenseNameTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ExpenseNameTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            ExpenseNameTextBox.Location = new Point(768, 61);
            ExpenseNameTextBox.Name = "ExpenseNameTextBox";
            ExpenseNameTextBox.Size = new Size(181, 30);
            ExpenseNameTextBox.TabIndex = 33;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriceNumericUpDown.BackColor = Color.White;
            PriceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            PriceNumericUpDown.DecimalPlaces = 2;
            PriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            PriceNumericUpDown.Location = new Point(768, 127);
            PriceNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(98, 23);
            PriceNumericUpDown.TabIndex = 32;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(768, 103);
            label6.Name = "label6";
            label6.Size = new Size(183, 21);
            label6.TabIndex = 31;
            label6.Text = "Stały wydatek za miesiąc:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(768, 31);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 31;
            label5.Text = "Nazwa wydatku:";
            // 
            // BtnSaveDateOfDeduction
            // 
            BtnSaveDateOfDeduction.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSaveDateOfDeduction.BackColor = Color.FromArgb(94, 148, 255);
            BtnSaveDateOfDeduction.FlatAppearance.BorderSize = 0;
            BtnSaveDateOfDeduction.FlatStyle = FlatStyle.Flat;
            BtnSaveDateOfDeduction.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSaveDateOfDeduction.ForeColor = Color.LightGray;
            BtnSaveDateOfDeduction.Location = new Point(896, 175);
            BtnSaveDateOfDeduction.Name = "BtnSaveDateOfDeduction";
            BtnSaveDateOfDeduction.Size = new Size(122, 30);
            BtnSaveDateOfDeduction.TabIndex = 7;
            BtnSaveDateOfDeduction.Text = "Zapisz";
            BtnSaveDateOfDeduction.UseVisualStyleBackColor = false;
            BtnSaveDateOfDeduction.Click += BtnSaveDateOfDeduction_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(335, -1);
            label3.Name = "label3";
            label3.Size = new Size(192, 28);
            label3.TabIndex = 0;
            label3.Text = "Wydatki stałe firmy";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(64, 64, 70);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label8);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(0, 341);
            panel1.Name = "panel1";
            panel1.Size = new Size(1019, 299);
            panel1.TabIndex = 31;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(164, 19);
            checkBox1.TabIndex = 46;
            checkBox1.Text = "Pokaż za cały czas wydatki";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(554, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 45;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(554, 54);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 44;
            label1.Text = "Data potrącenia";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(64, 64, 70);
            textBox1.CausesValidation = false;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(224, 224, 224);
            textBox1.Location = new Point(768, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 30);
            textBox1.TabIndex = 43;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown1.BackColor = Color.White;
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Location = new Point(768, 137);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(98, 23);
            numericUpDown1.TabIndex = 42;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(768, 113);
            label2.Name = "label2";
            label2.Size = new Size(146, 21);
            label2.TabIndex = 40;
            label2.Text = "wydatek za miesiąc:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(768, 41);
            label4.Name = "label4";
            label4.Size = new Size(123, 21);
            label4.TabIndex = 41;
            label4.Text = "Nazwa wydatku:";
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveButton.BackColor = Color.FromArgb(94, 148, 255);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.LightGray;
            SaveButton.Location = new Point(896, 185);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(122, 30);
            SaveButton.TabIndex = 39;
            SaveButton.Text = "Zapisz";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_Column_, BtnDelete_, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(2, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(546, 240);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(335, -1);
            label8.Name = "label8";
            label8.Size = new Size(230, 28);
            label8.TabIndex = 0;
            label8.Text = "Wydaki w tym miesiącu";
            // 
            // ID_Column_
            // 
            ID_Column_.DataPropertyName = "ID";
            ID_Column_.HeaderText = "ID";
            ID_Column_.Name = "ID_Column_";
            ID_Column_.Visible = false;
            // 
            // BtnDelete_
            // 
            BtnDelete_.HeaderText = "Usuń";
            BtnDelete_.Name = "BtnDelete_";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "NazwaWydatku";
            dataGridViewTextBoxColumn2.HeaderText = "Nazwa Wydatku";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "CenaWydatku";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTextBoxColumn3.HeaderText = "Stała kwota potręcenia";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "DataPotrącenia";
            dataGridViewTextBoxColumn4.HeaderText = "Data";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // UC_CompanyExpenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "UC_CompanyExpenses";
            Size = new Size(1019, 643);
            Load += UC_CompanyExpenses_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewDataOfDeduction).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            }

        #endregion

        private Panel panel3;
        private DateTimePicker DateOfDeductionCalendar;
        private Label label7;
        private DataGridView ViewDataOfDeduction;
        private DataGridViewTextBoxColumn ID_Column;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewTextBoxColumn NazwaWydatku_Column;
        private DataGridViewTextBoxColumn CenaWydatku_Column;
        private DataGridViewTextBoxColumn DataPotrącenia_Column;
        private TextBox ExpenseNameTextBox;
        private NumericUpDown PriceNumericUpDown;
        private Label label6;
        private Label label5;
        private Button BtnSaveDateOfDeduction;
        private Label label3;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label4;
        private Button SaveButton;
        private DataGridView dataGridView1;
        private Label label8;
        private CheckBox checkBox1;
        private DataGridViewTextBoxColumn ID_Column_;
        private DataGridViewButtonColumn BtnDelete_;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        }
    }
