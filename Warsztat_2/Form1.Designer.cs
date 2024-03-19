namespace Warsztat_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            SettingsButton = new Button();
            button1 = new Button();
            AddButton = new Button();
            ArchiveButton = new Button();
            ViewAllCar = new Button();
            WarehouseButton = new Button();
            ScheduleCarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(64, 64, 68);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(64, 64, 68);
            splitContainer1.Size = new Size(1285, 641);
            splitContainer1.SplitterDistance = 256;
            splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(3, 361);
            panel3.Name = "panel3";
            panel3.Size = new Size(249, 277);
            panel3.TabIndex = 0;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(35, 237);
            label9.Name = "label9";
            label9.Size = new Size(77, 17);
            label9.TabIndex = 1;
            label9.Text = "Brakuje:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(8, 209);
            label8.Name = "label8";
            label8.Size = new Size(165, 17);
            label8.TabIndex = 1;
            label8.Text = "Wydatki za miesiąc:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(8, 181);
            label7.Name = "label7";
            label7.Size = new Size(165, 17);
            label7.TabIndex = 1;
            label7.Text = "zarobki za miesiąc:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(25, 133);
            label5.Name = "label5";
            label5.Size = new Size(189, 17);
            label5.TabIndex = 1;
            label5.Text = "Zaplanowane samochody:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(25, 105);
            label4.Name = "label4";
            label4.Size = new Size(165, 17);
            label4.TabIndex = 1;
            label4.Text = "Obecnie samochodów:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(8, 77);
            label2.Name = "label2";
            label2.Size = new Size(149, 17);
            label2.TabIndex = 1;
            label2.Text = "Ilość samochodów:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(8, 49);
            label1.Name = "label1";
            label1.Size = new Size(133, 17);
            label1.TabIndex = 1;
            label1.Text = "Ilość klientów:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(8, 10);
            label6.Name = "label6";
            label6.Size = new Size(149, 17);
            label6.TabIndex = 1;
            label6.Text = "Krótka informacja";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SettingsButton);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(ArchiveButton);
            panel1.Controls.Add(ViewAllCar);
            panel1.Controls.Add(WarehouseButton);
            panel1.Controls.Add(ScheduleCarButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 353);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("AR DESTINE", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(10, 4);
            label3.Name = "label3";
            label3.Size = new Size(235, 39);
            label3.TabIndex = 1;
            label3.Text = "ALEKSAUTO";
            // 
            // SettingsButton
            // 
            SettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SettingsButton.BackColor = Color.FromArgb(94, 148, 255);
            SettingsButton.FlatAppearance.BorderSize = 0;
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsButton.ForeColor = Color.LightGray;
            SettingsButton.Location = new Point(-1, 90);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(249, 37);
            SettingsButton.TabIndex = 0;
            SettingsButton.Text = "Ustawienia";
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(94, 148, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(-1, 47);
            button1.Name = "button1";
            button1.Size = new Size(249, 37);
            button1.TabIndex = 0;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.BackColor = Color.FromArgb(94, 148, 255);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.ForeColor = Color.LightGray;
            AddButton.Location = new Point(0, 262);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(249, 37);
            AddButton.TabIndex = 0;
            AddButton.Text = "Dodaj";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // ArchiveButton
            // 
            ArchiveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ArchiveButton.BackColor = Color.FromArgb(94, 148, 255);
            ArchiveButton.FlatAppearance.BorderSize = 0;
            ArchiveButton.FlatStyle = FlatStyle.Flat;
            ArchiveButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ArchiveButton.ForeColor = Color.LightGray;
            ArchiveButton.Location = new Point(0, 176);
            ArchiveButton.Name = "ArchiveButton";
            ArchiveButton.Size = new Size(248, 37);
            ArchiveButton.TabIndex = 0;
            ArchiveButton.Text = "Zobacz archiwum";
            ArchiveButton.UseVisualStyleBackColor = false;
            ArchiveButton.Click += ArchiveButton_Click;
            // 
            // ViewAllCar
            // 
            ViewAllCar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ViewAllCar.BackColor = Color.FromArgb(94, 148, 255);
            ViewAllCar.FlatAppearance.BorderSize = 0;
            ViewAllCar.FlatStyle = FlatStyle.Flat;
            ViewAllCar.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ViewAllCar.ForeColor = Color.LightGray;
            ViewAllCar.Location = new Point(0, 133);
            ViewAllCar.Name = "ViewAllCar";
            ViewAllCar.Size = new Size(248, 37);
            ViewAllCar.TabIndex = 0;
            ViewAllCar.Text = "Przegłąd samochodów";
            ViewAllCar.UseVisualStyleBackColor = false;
            ViewAllCar.Click += ViewAllCar_Click;
            // 
            // WarehouseButton
            // 
            WarehouseButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WarehouseButton.BackColor = Color.FromArgb(94, 148, 255);
            WarehouseButton.FlatAppearance.BorderSize = 0;
            WarehouseButton.FlatStyle = FlatStyle.Flat;
            WarehouseButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            WarehouseButton.ForeColor = Color.LightGray;
            WarehouseButton.Location = new Point(0, 305);
            WarehouseButton.Name = "WarehouseButton";
            WarehouseButton.Size = new Size(249, 37);
            WarehouseButton.TabIndex = 0;
            WarehouseButton.Text = "Magazyn";
            WarehouseButton.UseVisualStyleBackColor = false;
            WarehouseButton.Click += WarehouseButton_Click;
            // 
            // ScheduleCarButton
            // 
            ScheduleCarButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ScheduleCarButton.BackColor = Color.FromArgb(94, 148, 255);
            ScheduleCarButton.FlatAppearance.BorderSize = 0;
            ScheduleCarButton.FlatStyle = FlatStyle.Flat;
            ScheduleCarButton.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ScheduleCarButton.ForeColor = Color.LightGray;
            ScheduleCarButton.Location = new Point(0, 219);
            ScheduleCarButton.Name = "ScheduleCarButton";
            ScheduleCarButton.Size = new Size(249, 37);
            ScheduleCarButton.TabIndex = 0;
            ScheduleCarButton.Text = "Zaplanowane";
            ScheduleCarButton.UseVisualStyleBackColor = false;
            ScheduleCarButton.Click += ScheduleCarButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 68);
            ClientSize = new Size(1285, 641);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button1;
        private Button SettingsButton;
        private Button AddButton;
        private Button WarehouseButton;
        private Button ScheduleCarButton;
        private Button ViewAllCar;
        private Panel panel1;
        private Panel panel3;
        private Label label6;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button ArchiveButton;
    }
}
