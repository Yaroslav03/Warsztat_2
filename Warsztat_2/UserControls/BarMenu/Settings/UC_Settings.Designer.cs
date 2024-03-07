namespace Warsztat_2._0.UserControls
{
    partial class UC_Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListBoxEmployer = new ListBox();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            NazwaFirmyTextBox = new TextBox();
            AdresFirmyTextBox = new TextBox();
            NIPTextBox = new TextBox();
            NrTelefonuTextBox = new TextBox();
            NumerBDOTextBox = new TextBox();
            KontoBankoweTextBox = new TextBox();
            MarzaTextBox = new TextBox();
            SaveDataButton = new Button();
            panel2 = new Panel();
            label2 = new Label();
            UpdateEmployerButton = new Button();
            ImiePracownikaTextBox = new TextBox();
            NumerTelefonuTextBox = new TextBox();
            RemoveEmployerButton = new Button();
            EmployerAddButton = new Button();
            StanowiskoSelect = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ListBoxEmployer
            // 
            ListBoxEmployer.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListBoxEmployer.FormattingEnabled = true;
            ListBoxEmployer.ItemHeight = 23;
            ListBoxEmployer.Location = new Point(16, 43);
            ListBoxEmployer.Name = "ListBoxEmployer";
            ListBoxEmployer.Size = new Size(324, 165);
            ListBoxEmployer.TabIndex = 6;
            ListBoxEmployer.SelectedIndexChanged += ListBoxEmployer_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(630, 30);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 15;
            label4.Text = "Stanowisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(393, 95);
            label1.Name = "label1";
            label1.Size = new Size(204, 21);
            label1.TabIndex = 15;
            label1.Text = "Numer telefonu pracownika";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 70);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(SaveDataButton);
            panel1.Controls.Add(MarzaTextBox);
            panel1.Controls.Add(NrTelefonuTextBox);
            panel1.Controls.Add(NIPTextBox);
            panel1.Controls.Add(AdresFirmyTextBox);
            panel1.Controls.Add(KontoBankoweTextBox);
            panel1.Controls.Add(NumerBDOTextBox);
            panel1.Controls.Add(NazwaFirmyTextBox);
            panel1.Controls.Add(label13);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 204);
            panel1.TabIndex = 29;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(396, 9);
            label13.Name = "label13";
            label13.Size = new Size(159, 28);
            label13.TabIndex = 0;
            label13.Text = "Dane Firmy";
            // 
            // NazwaFirmyTextBox
            // 
            NazwaFirmyTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NazwaFirmyTextBox.CausesValidation = false;
            NazwaFirmyTextBox.Cursor = Cursors.IBeam;
            NazwaFirmyTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NazwaFirmyTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NazwaFirmyTextBox.Location = new Point(16, 38);
            NazwaFirmyTextBox.Name = "NazwaFirmyTextBox";
            NazwaFirmyTextBox.PlaceholderText = "Nazwa";
            NazwaFirmyTextBox.Size = new Size(171, 30);
            NazwaFirmyTextBox.TabIndex = 21;
            // 
            // AdresFirmyTextBox
            // 
            AdresFirmyTextBox.BackColor = Color.FromArgb(64, 64, 70);
            AdresFirmyTextBox.CausesValidation = false;
            AdresFirmyTextBox.Cursor = Cursors.IBeam;
            AdresFirmyTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AdresFirmyTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            AdresFirmyTextBox.Location = new Point(229, 38);
            AdresFirmyTextBox.Name = "AdresFirmyTextBox";
            AdresFirmyTextBox.PlaceholderText = "Adres Firmy";
            AdresFirmyTextBox.Size = new Size(326, 30);
            AdresFirmyTextBox.TabIndex = 21;
            // 
            // NIPTextBox
            // 
            NIPTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NIPTextBox.CausesValidation = false;
            NIPTextBox.Cursor = Cursors.IBeam;
            NIPTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NIPTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NIPTextBox.Location = new Point(576, 38);
            NIPTextBox.Name = "NIPTextBox";
            NIPTextBox.PlaceholderText = "NIP";
            NIPTextBox.Size = new Size(201, 30);
            NIPTextBox.TabIndex = 21;
            // 
            // NrTelefonuTextBox
            // 
            NrTelefonuTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NrTelefonuTextBox.CausesValidation = false;
            NrTelefonuTextBox.Cursor = Cursors.IBeam;
            NrTelefonuTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NrTelefonuTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NrTelefonuTextBox.Location = new Point(802, 38);
            NrTelefonuTextBox.Name = "NrTelefonuTextBox";
            NrTelefonuTextBox.PlaceholderText = "Nr. Telefonu";
            NrTelefonuTextBox.Size = new Size(176, 30);
            NrTelefonuTextBox.TabIndex = 21;
            // 
            // NumerBDOTextBox
            // 
            NumerBDOTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NumerBDOTextBox.CausesValidation = false;
            NumerBDOTextBox.Cursor = Cursors.IBeam;
            NumerBDOTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NumerBDOTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NumerBDOTextBox.Location = new Point(16, 102);
            NumerBDOTextBox.Name = "NumerBDOTextBox";
            NumerBDOTextBox.PlaceholderText = "Numer BDO";
            NumerBDOTextBox.Size = new Size(307, 30);
            NumerBDOTextBox.TabIndex = 21;
            // 
            // KontoBankoweTextBox
            // 
            KontoBankoweTextBox.BackColor = Color.FromArgb(64, 64, 70);
            KontoBankoweTextBox.CausesValidation = false;
            KontoBankoweTextBox.Cursor = Cursors.IBeam;
            KontoBankoweTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            KontoBankoweTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            KontoBankoweTextBox.Location = new Point(395, 102);
            KontoBankoweTextBox.Name = "KontoBankoweTextBox";
            KontoBankoweTextBox.PlaceholderText = "Konto Bankowe";
            KontoBankoweTextBox.Size = new Size(326, 30);
            KontoBankoweTextBox.TabIndex = 21;
            // 
            // MarzaTextBox
            // 
            MarzaTextBox.BackColor = Color.FromArgb(64, 64, 70);
            MarzaTextBox.CausesValidation = false;
            MarzaTextBox.Cursor = Cursors.IBeam;
            MarzaTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MarzaTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            MarzaTextBox.Location = new Point(797, 102);
            MarzaTextBox.Name = "MarzaTextBox";
            MarzaTextBox.PlaceholderText = "Marża";
            MarzaTextBox.Size = new Size(181, 30);
            MarzaTextBox.TabIndex = 21;
            // 
            // SaveDataButton
            // 
            SaveDataButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SaveDataButton.BackColor = Color.FromArgb(94, 148, 255);
            SaveDataButton.FlatAppearance.BorderSize = 0;
            SaveDataButton.FlatStyle = FlatStyle.Flat;
            SaveDataButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDataButton.ForeColor = Color.LightGray;
            SaveDataButton.Location = new Point(830, 151);
            SaveDataButton.Name = "SaveDataButton";
            SaveDataButton.Size = new Size(125, 30);
            SaveDataButton.TabIndex = 24;
            SaveDataButton.Text = "Zapisz";
            SaveDataButton.UseVisualStyleBackColor = false;
            SaveDataButton.Click += this.SaveDataButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 70);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(StanowiskoSelect);
            panel2.Controls.Add(EmployerAddButton);
            panel2.Controls.Add(UpdateEmployerButton);
            panel2.Controls.Add(RemoveEmployerButton);
            panel2.Controls.Add(NumerTelefonuTextBox);
            panel2.Controls.Add(ListBoxEmployer);
            panel2.Controls.Add(ImiePracownikaTextBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.DimGray;
            panel2.Location = new Point(3, 263);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 255);
            panel2.TabIndex = 29;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(371, 6);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 0;
            label2.Text = "Pracownicy";
            // 
            // UpdateEmployerButton
            // 
            UpdateEmployerButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UpdateEmployerButton.BackColor = Color.FromArgb(94, 148, 255);
            UpdateEmployerButton.FlatAppearance.BorderSize = 0;
            UpdateEmployerButton.FlatStyle = FlatStyle.Flat;
            UpdateEmployerButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateEmployerButton.ForeColor = Color.LightGray;
            UpdateEmployerButton.Location = new Point(16, 6);
            UpdateEmployerButton.Name = "UpdateEmployerButton";
            UpdateEmployerButton.Size = new Size(324, 30);
            UpdateEmployerButton.TabIndex = 24;
            UpdateEmployerButton.Text = "Odśwież listę";
            UpdateEmployerButton.UseVisualStyleBackColor = false;
            UpdateEmployerButton.Click += this.UpdateEmployerButton_Click;
            // 
            // ImiePracownikaTextBox
            // 
            ImiePracownikaTextBox.BackColor = Color.FromArgb(64, 64, 70);
            ImiePracownikaTextBox.CausesValidation = false;
            ImiePracownikaTextBox.Cursor = Cursors.IBeam;
            ImiePracownikaTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ImiePracownikaTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            ImiePracownikaTextBox.Location = new Point(393, 55);
            ImiePracownikaTextBox.Name = "ImiePracownikaTextBox";
            ImiePracownikaTextBox.PlaceholderText = "Imię pracownika";
            ImiePracownikaTextBox.Size = new Size(181, 30);
            ImiePracownikaTextBox.TabIndex = 21;
            // 
            // NumerTelefonuTextBox
            // 
            NumerTelefonuTextBox.BackColor = Color.FromArgb(64, 64, 70);
            NumerTelefonuTextBox.CausesValidation = false;
            NumerTelefonuTextBox.Cursor = Cursors.IBeam;
            NumerTelefonuTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NumerTelefonuTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            NumerTelefonuTextBox.Location = new Point(393, 119);
            NumerTelefonuTextBox.Name = "NumerTelefonuTextBox";
            NumerTelefonuTextBox.PlaceholderText = "Nr. telefonu ";
            NumerTelefonuTextBox.Size = new Size(181, 30);
            NumerTelefonuTextBox.TabIndex = 21;
            NumerTelefonuTextBox.TextChanged += this.NumerTelefonuTextBox_TextChanged;
            // 
            // RemoveEmployerButton
            // 
            RemoveEmployerButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RemoveEmployerButton.BackColor = Color.FromArgb(94, 148, 255);
            RemoveEmployerButton.FlatAppearance.BorderSize = 0;
            RemoveEmployerButton.FlatStyle = FlatStyle.Flat;
            RemoveEmployerButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveEmployerButton.ForeColor = Color.LightGray;
            RemoveEmployerButton.Location = new Point(823, 85);
            RemoveEmployerButton.Name = "RemoveEmployerButton";
            RemoveEmployerButton.Size = new Size(139, 30);
            RemoveEmployerButton.TabIndex = 24;
            RemoveEmployerButton.Text = "Usuń Pracownika";
            RemoveEmployerButton.UseVisualStyleBackColor = false;
            RemoveEmployerButton.Click += this.RemoveEmployerButton_Click;
            // 
            // EmployerAddButton
            // 
            EmployerAddButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmployerAddButton.BackColor = Color.FromArgb(94, 148, 255);
            EmployerAddButton.FlatAppearance.BorderSize = 0;
            EmployerAddButton.FlatStyle = FlatStyle.Flat;
            EmployerAddButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EmployerAddButton.ForeColor = Color.LightGray;
            EmployerAddButton.Location = new Point(823, 49);
            EmployerAddButton.Name = "EmployerAddButton";
            EmployerAddButton.Size = new Size(139, 30);
            EmployerAddButton.TabIndex = 24;
            EmployerAddButton.Text = "Dodaj Pracownika";
            EmployerAddButton.UseVisualStyleBackColor = false;
            EmployerAddButton.Click += this.EmployerAddButton_Click;
            // 
            // StanowiskoSelect
            // 
            StanowiskoSelect.BackColor = Color.FromArgb(94, 148, 255);
            StanowiskoSelect.FlatStyle = FlatStyle.Flat;
            StanowiskoSelect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StanowiskoSelect.ForeColor = Color.FromArgb(68, 88, 112);
            StanowiskoSelect.FormattingEnabled = true;
            StanowiskoSelect.Items.AddRange(new object[] { "Elektronik", "Elektryk", "Mechanik", "Mechatronik", "Programista" });
            StanowiskoSelect.Location = new Point(620, 57);
            StanowiskoSelect.Name = "StanowiskoSelect";
            StanowiskoSelect.Size = new Size(171, 29);
            StanowiskoSelect.TabIndex = 25;
            // 
            // UC_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_Settings";
            Size = new Size(1019, 643);
            Load += UC_Settings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label8;
        private Label label11;
        private Label label17;
        private Label label3;
        private Label label7;
        private Label DiagnosticLabel2;
        private Label label18;
        private Label label16;
        private Label label19;
        private Label label4;
        private Label label1;
        private TextBox MarzaTextBox;
        private TextBox KontoBankoweTextBox;
        private TextBox NrTelefonuTextBox;
        private TextBox NIPTextBox;
        private TextBox AdresFirmyTextBox;
        private TextBox NazwaFirmyTextBox;
        private ListBox ListBoxEmployer;
        private Panel panel1;
        private Label label13;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox NumerBDOTextBox;
        private Button SaveDataButton;
        private Panel panel2;
        private Label label2;
        private Button UpdateEmployerButton;
        private Button EmployerAddButton;
        private Button RemoveEmployerButton;
        private TextBox NumerTelefonuTextBox;
        private TextBox ImiePracownikaTextBox;
        private ComboBox StanowiskoSelect;
    }
}
