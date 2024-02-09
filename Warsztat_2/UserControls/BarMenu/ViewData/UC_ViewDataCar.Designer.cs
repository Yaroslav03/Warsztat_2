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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            label1 = new Label();
            DataGridViewCar = new Guna.UI2.WinForms.Guna2DataGridView();
            BtnDelete = new DataGridViewButtonColumn();
            BtnRead = new DataGridViewButtonColumn();
            StatusZlecenia_Column_Main = new DataGridViewTextBoxColumn();
            DataPrzyjecia_Column_Main = new DataGridViewTextBoxColumn();
            DataWydania_Column_Main = new DataGridViewTextBoxColumn();
            Marka_Column_Main = new DataGridViewTextBoxColumn();
            Model_Column_Main = new DataGridViewTextBoxColumn();
            NumerRejestracji_Column_Main = new DataGridViewTextBoxColumn();
            Imie_Column_Main = new DataGridViewTextBoxColumn();
            Nazwisko_Column_Main = new DataGridViewTextBoxColumn();
            Telefon_Column_Main = new DataGridViewTextBoxColumn();
            KosztKoncowy_Column_Main = new DataGridViewTextBoxColumn();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCar).BeginInit();
            SuspendLayout();
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
            // DataGridViewCar
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewCar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewCar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewCar.ColumnHeadersHeight = 17;
            DataGridViewCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridViewCar.Columns.AddRange(new DataGridViewColumn[] { BtnDelete, BtnRead, StatusZlecenia_Column_Main, DataPrzyjecia_Column_Main, DataWydania_Column_Main, Marka_Column_Main, Model_Column_Main, NumerRejestracji_Column_Main, Imie_Column_Main, Nazwisko_Column_Main, Telefon_Column_Main, KosztKoncowy_Column_Main });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewCar.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewCar.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewCar.Location = new Point(0, 67);
            DataGridViewCar.Name = "DataGridViewCar";
            DataGridViewCar.RowHeadersVisible = false;
            DataGridViewCar.RowTemplate.Height = 25;
            DataGridViewCar.Size = new Size(1043, 548);
            DataGridViewCar.TabIndex = 4;
            DataGridViewCar.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridViewCar.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridViewCar.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridViewCar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridViewCar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridViewCar.ThemeStyle.BackColor = Color.White;
            DataGridViewCar.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewCar.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridViewCar.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCar.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewCar.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridViewCar.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridViewCar.ThemeStyle.HeaderStyle.Height = 17;
            DataGridViewCar.ThemeStyle.ReadOnly = false;
            DataGridViewCar.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridViewCar.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewCar.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewCar.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewCar.ThemeStyle.RowsStyle.Height = 25;
            DataGridViewCar.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridViewCar.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // BtnDelete
            // 
            BtnDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            BtnDelete.FillWeight = 20.22091F;
            BtnDelete.HeaderText = "Usuń";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Usuń";
            BtnDelete.Width = 60;
            // 
            // BtnRead
            // 
            BtnRead.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            BtnRead.FillWeight = 178.955F;
            BtnRead.HeaderText = "Przeczytaj";
            BtnRead.Name = "BtnRead";
            BtnRead.Width = 60;
            // 
            // StatusZlecenia_Column_Main
            // 
            StatusZlecenia_Column_Main.HeaderText = "Status Zlecenia";
            StatusZlecenia_Column_Main.Name = "StatusZlecenia_Column_Main";
            // 
            // DataPrzyjecia_Column_Main
            // 
            DataPrzyjecia_Column_Main.HeaderText = "Data Przyjęcia";
            DataPrzyjecia_Column_Main.Name = "DataPrzyjecia_Column_Main";
            // 
            // DataWydania_Column_Main
            // 
            DataWydania_Column_Main.HeaderText = "Data Wydania";
            DataWydania_Column_Main.Name = "DataWydania_Column_Main";
            // 
            // Marka_Column_Main
            // 
            Marka_Column_Main.HeaderText = "Marka";
            Marka_Column_Main.Name = "Marka_Column_Main";
            // 
            // Model_Column_Main
            // 
            Model_Column_Main.HeaderText = "Model";
            Model_Column_Main.Name = "Model_Column_Main";
            // 
            // NumerRejestracji_Column_Main
            // 
            NumerRejestracji_Column_Main.HeaderText = "Numer Rejestracji";
            NumerRejestracji_Column_Main.Name = "NumerRejestracji_Column_Main";
            // 
            // Imie_Column_Main
            // 
            Imie_Column_Main.HeaderText = "Imię";
            Imie_Column_Main.Name = "Imie_Column_Main";
            // 
            // Nazwisko_Column_Main
            // 
            Nazwisko_Column_Main.HeaderText = "Nazwisko";
            Nazwisko_Column_Main.Name = "Nazwisko_Column_Main";
            // 
            // Telefon_Column_Main
            // 
            Telefon_Column_Main.HeaderText = "Telefon";
            Telefon_Column_Main.Name = "Telefon_Column_Main";
            // 
            // KosztKoncowy_Column_Main
            // 
            KosztKoncowy_Column_Main.HeaderText = "Koszt Końcowy";
            KosztKoncowy_Column_Main.Name = "KosztKoncowy_Column_Main";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderColor = Color.White;
            guna2TextBox1.BorderRadius = 5;
            guna2TextBox1.Cursor = Cursors.IBeam;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = Color.DimGray;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.ForeColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(3, 29);
            guna2TextBox1.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(184, 31);
            guna2TextBox1.TabIndex = 14;
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
            // UC_ViewDataCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(guna2TextBox1);
            Controls.Add(DataGridViewCar);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "UC_ViewDataCar";
            Size = new Size(1043, 615);
            ((System.ComponentModel.ISupportInitialize)DataGridViewCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewCar;
        private DataGridViewButtonColumn BtnDelete;
        private DataGridViewButtonColumn BtnRead;
        private DataGridViewTextBoxColumn StatusZlecenia_Column_Main;
        private DataGridViewTextBoxColumn DataPrzyjecia_Column_Main;
        private DataGridViewTextBoxColumn DataWydania_Column_Main;
        private DataGridViewTextBoxColumn Marka_Column_Main;
        private DataGridViewTextBoxColumn Model_Column_Main;
        private DataGridViewTextBoxColumn NumerRejestracji_Column_Main;
        private DataGridViewTextBoxColumn Imie_Column_Main;
        private DataGridViewTextBoxColumn Nazwisko_Column_Main;
        private DataGridViewTextBoxColumn Telefon_Column_Main;
        private DataGridViewTextBoxColumn KosztKoncowy_Column_Main;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
    }
