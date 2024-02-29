namespace Warsztat_2._0.UserControls {
    partial class UC_ViewDataCar {
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ViewActualData = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            BtnDelete = new DataGridViewButtonColumn();
            BtnFinish = new DataGridViewButtonColumn();
            Przyjęty_Column = new DataGridViewCheckBoxColumn();
            OczekujeNaOdbiór_Column = new DataGridViewCheckBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Imię_Column = new DataGridViewTextBoxColumn();
            Nazwisko_Column = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Marka_Column = new DataGridViewTextBoxColumn();
            Model_Column = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ViewActualData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(770, 20);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Plik PDF";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(902, 20);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 3;
            label3.Text = "Stwórz PDF";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(94, 148, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(757, 38);
            button1.Name = "button1";
            button1.Size = new Size(84, 22);
            button1.TabIndex = 15;
            button1.Text = "Lokalizacja";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(94, 148, 255);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.LightGray;
            button2.Location = new Point(847, 38);
            button2.Name = "button2";
            button2.Size = new Size(84, 22);
            button2.TabIndex = 15;
            button2.Text = "Zlecenie";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(94, 148, 255);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.LightGray;
            button3.Location = new Point(937, 39);
            button3.Name = "button3";
            button3.Size = new Size(84, 22);
            button3.TabIndex = 15;
            button3.Text = "Faktura";
            button3.UseVisualStyleBackColor = false;
            // 
            // ViewActualData
            // 
            ViewActualData.AllowUserToAddRows = false;
            ViewActualData.AllowUserToDeleteRows = false;
            ViewActualData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewActualData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewActualData.BorderStyle = BorderStyle.None;
            ViewActualData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewActualData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewActualData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewActualData.Columns.AddRange(new DataGridViewColumn[] { ID, BtnDelete, BtnFinish, Przyjęty_Column, OczekujeNaOdbiór_Column, Column1, Imię_Column, Nazwisko_Column, Column4, Marka_Column, Model_Column, Column7, Column8 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ViewActualData.DefaultCellStyle = dataGridViewCellStyle2;
            ViewActualData.EnableHeadersVisualStyles = false;
            ViewActualData.Location = new Point(3, 67);
            ViewActualData.Name = "ViewActualData";
            ViewActualData.RowTemplate.Height = 25;
            ViewActualData.Size = new Size(1040, 548);
            ViewActualData.TabIndex = 30;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Usuń zgłoszenie";
            BtnDelete.Name = "BtnDelete";
            // 
            // BtnFinish
            // 
            BtnFinish.HeaderText = "Wykonane";
            BtnFinish.Name = "BtnFinish";
            // 
            // Przyjęty_Column
            // 
            Przyjęty_Column.DataPropertyName = "Przyjęty";
            Przyjęty_Column.FalseValue = "0";
            Przyjęty_Column.HeaderText = "Przyjęty";
            Przyjęty_Column.Name = "Przyjęty_Column";
            Przyjęty_Column.Resizable = DataGridViewTriState.True;
            Przyjęty_Column.SortMode = DataGridViewColumnSortMode.Automatic;
            Przyjęty_Column.TrueValue = "1";
            // 
            // OczekujeNaOdbiór_Column
            // 
            OczekujeNaOdbiór_Column.DataPropertyName = "OczekujeNaOdbiór";
            OczekujeNaOdbiór_Column.FalseValue = "0";
            OczekujeNaOdbiór_Column.HeaderText = "Oczekuje na odbiór";
            OczekujeNaOdbiór_Column.Name = "OczekujeNaOdbiór_Column";
            OczekujeNaOdbiór_Column.Resizable = DataGridViewTriState.True;
            OczekujeNaOdbiór_Column.SortMode = DataGridViewColumnSortMode.Automatic;
            OczekujeNaOdbiór_Column.TrueValue = "1";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "DataPrzyjęcie";
            Column1.HeaderText = "DataPrzyjęcia";
            Column1.Name = "Column1";
            // 
            // Imię_Column
            // 
            Imię_Column.DataPropertyName = "Imię";
            Imię_Column.HeaderText = "Imię Klienta";
            Imię_Column.Name = "Imię_Column";
            // 
            // Nazwisko_Column
            // 
            Nazwisko_Column.DataPropertyName = "Nazwisko";
            Nazwisko_Column.HeaderText = "Nazwisko Klienta";
            Nazwisko_Column.Name = "Nazwisko_Column";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Telefon";
            Column4.HeaderText = "Nr. telefonu";
            Column4.Name = "Column4";
            // 
            // Marka_Column
            // 
            Marka_Column.DataPropertyName = "Marka";
            Marka_Column.HeaderText = "Marka";
            Marka_Column.Name = "Marka_Column";
            // 
            // Model_Column
            // 
            Model_Column.DataPropertyName = "Model";
            Model_Column.HeaderText = "Model";
            Model_Column.Name = "Model_Column";
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Zlecenie";
            Column7.HeaderText = "Zlecenie";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.DataPropertyName = "KosztZMarżą";
            Column8.HeaderText = "Koszt naprawy";
            Column8.Name = "Column8";
            // 
            // UC_ViewDataCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(ViewActualData);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "UC_ViewDataCar";
            Size = new Size(1043, 615);
            Load += UC_ViewDataCar_Load;
            ((System.ComponentModel.ISupportInitialize)ViewActualData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView ViewActualData;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewButtonColumn BtnFinish;
        private DataGridViewCheckBoxColumn Przyjęty_Column;
        private DataGridViewCheckBoxColumn OczekujeNaOdbiór_Column;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Imię_Column;
        private DataGridViewTextBoxColumn Nazwisko_Column;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Marka_Column;
        private DataGridViewTextBoxColumn Model_Column;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
    }
