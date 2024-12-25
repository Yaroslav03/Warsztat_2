namespace Warsztat_2._0.UserControls
{
    partial class UC_AddCar
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
            PojemnośćSilnikaSearch = new TextBox();
            MarkaSearch = new TextBox();
            ModelSearch = new TextBox();
            RokProdukcjiListBox = new ListBox();
            ModelListBox = new ListBox();
            EngineListBox = new ListBox();
            MarkaListBox = new ListBox();
            panelDodatkowy = new Panel();
            label6 = new Label();
            RokProdukcjitextBox = new TextBox();
            VINTextBox = new TextBox();
            panel2 = new Panel();
            ClientsList = new ListBox();
            label2 = new Label();
            NumLenghtNadwoziaLabel = new Label();
            panel3 = new Panel();
            label1 = new Label();
            ButtoCarSave = new Button();
            panelDodatkowy.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // PojemnośćSilnikaSearch
            // 
            PojemnośćSilnikaSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PojemnośćSilnikaSearch.Location = new Point(384, 36);
            PojemnośćSilnikaSearch.Name = "PojemnośćSilnikaSearch";
            PojemnośćSilnikaSearch.Size = new Size(169, 23);
            PojemnośćSilnikaSearch.TabIndex = 5;
            // 
            // MarkaSearch
            // 
            MarkaSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MarkaSearch.Location = new Point(34, 36);
            MarkaSearch.Name = "MarkaSearch";
            MarkaSearch.Size = new Size(169, 23);
            MarkaSearch.TabIndex = 5;
            // 
            // ModelSearch
            // 
            ModelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ModelSearch.Location = new Point(208, 36);
            ModelSearch.Name = "ModelSearch";
            ModelSearch.Size = new Size(169, 23);
            ModelSearch.TabIndex = 5;
            // 
            // RokProdukcjiListBox
            // 
            RokProdukcjiListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RokProdukcjiListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RokProdukcjiListBox.FormattingEnabled = true;
            RokProdukcjiListBox.ItemHeight = 21;
            RokProdukcjiListBox.Items.AddRange(new object[] { "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020" });
            RokProdukcjiListBox.Location = new Point(559, 57);
            RokProdukcjiListBox.Name = "RokProdukcjiListBox";
            RokProdukcjiListBox.Size = new Size(169, 361);
            RokProdukcjiListBox.TabIndex = 4;
            // 
            // ModelListBox
            // 
            ModelListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ModelListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModelListBox.FormattingEnabled = true;
            ModelListBox.ItemHeight = 21;
            ModelListBox.Location = new Point(209, 57);
            ModelListBox.Name = "ModelListBox";
            ModelListBox.Size = new Size(169, 361);
            ModelListBox.TabIndex = 4;
            ModelListBox.SelectedIndexChanged += ModelListBox_SelectedIndexChanged;
            // 
            // EngineListBox
            // 
            EngineListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            EngineListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EngineListBox.FormattingEnabled = true;
            EngineListBox.ItemHeight = 21;
            EngineListBox.Location = new Point(384, 57);
            EngineListBox.Name = "EngineListBox";
            EngineListBox.Size = new Size(169, 361);
            EngineListBox.TabIndex = 4;
            // 
            // MarkaListBox
            // 
            MarkaListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MarkaListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MarkaListBox.ItemHeight = 21;
            MarkaListBox.Location = new Point(34, 57);
            MarkaListBox.Name = "MarkaListBox";
            MarkaListBox.Size = new Size(169, 361);
            MarkaListBox.TabIndex = 4;
            MarkaListBox.SelectedIndexChanged += MarkaListBox_SelectedIndexChanged;
            MarkaListBox.MouseUp += MarkaListBox_MouseUp;
            // 
            // panelDodatkowy
            // 
            panelDodatkowy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelDodatkowy.BackColor = Color.FromArgb(64, 64, 70);
            panelDodatkowy.BorderStyle = BorderStyle.FixedSingle;
            panelDodatkowy.Controls.Add(label6);
            panelDodatkowy.Controls.Add(RokProdukcjitextBox);
            panelDodatkowy.Controls.Add(PojemnośćSilnikaSearch);
            panelDodatkowy.Controls.Add(MarkaListBox);
            panelDodatkowy.Controls.Add(MarkaSearch);
            panelDodatkowy.Controls.Add(EngineListBox);
            panelDodatkowy.Controls.Add(ModelSearch);
            panelDodatkowy.Controls.Add(ModelListBox);
            panelDodatkowy.Controls.Add(RokProdukcjiListBox);
            panelDodatkowy.ForeColor = Color.DimGray;
            panelDodatkowy.Location = new Point(3, 39);
            panelDodatkowy.Name = "panelDodatkowy";
            panelDodatkowy.Size = new Size(744, 534);
            panelDodatkowy.TabIndex = 28;
            // 
            // label6
            // 
            label6.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(596, 5);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 20;
            label6.Text = "Dane Techniczne";
            // 
            // RokProdukcjitextBox
            // 
            RokProdukcjitextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            RokProdukcjitextBox.Location = new Point(559, 36);
            RokProdukcjitextBox.Name = "RokProdukcjitextBox";
            RokProdukcjitextBox.Size = new Size(169, 23);
            RokProdukcjitextBox.TabIndex = 5;
            // 
            // VINTextBox
            // 
            VINTextBox.BackColor = Color.FromArgb(64, 64, 70);
            VINTextBox.BorderStyle = BorderStyle.None;
            VINTextBox.CausesValidation = false;
            VINTextBox.CharacterCasing = CharacterCasing.Upper;
            VINTextBox.Cursor = Cursors.IBeam;
            VINTextBox.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            VINTextBox.ForeColor = Color.FromArgb(224, 224, 224);
            VINTextBox.Location = new Point(8, 36);
            VINTextBox.Name = "VINTextBox";
            VINTextBox.PlaceholderText = "VIN";
            VINTextBox.Size = new Size(243, 23);
            VINTextBox.TabIndex = 17;
            VINTextBox.TextChanged += VINTextBox_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GrayText;
            panel2.Location = new Point(8, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 10);
            panel2.TabIndex = 18;
            // 
            // ClientsList
            // 
            ClientsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ClientsList.FormattingEnabled = true;
            ClientsList.ItemHeight = 15;
            ClientsList.Location = new Point(5, 78);
            ClientsList.Name = "ClientsList";
            ClientsList.Size = new Size(258, 349);
            ClientsList.TabIndex = 12;
            ClientsList.DoubleClick += ClientsList_DoubleClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(5, 12);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 10;
            label2.Text = "VIN:";
            // 
            // NumLenghtNadwoziaLabel
            // 
            NumLenghtNadwoziaLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NumLenghtNadwoziaLabel.ForeColor = Color.Silver;
            NumLenghtNadwoziaLabel.Location = new Point(41, 17);
            NumLenghtNadwoziaLabel.Name = "NumLenghtNadwoziaLabel";
            NumLenghtNadwoziaLabel.Size = new Size(34, 16);
            NumLenghtNadwoziaLabel.TabIndex = 0;
            NumLenghtNadwoziaLabel.Text = "0";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(64, 64, 70);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(NumLenghtNadwoziaLabel);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(VINTextBox);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(ClientsList);
            panel3.ForeColor = Color.DimGray;
            panel3.Location = new Point(745, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 534);
            panel3.TabIndex = 29;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(8, 433);
            label1.Name = "label1";
            label1.Size = new Size(255, 90);
            label1.TabIndex = 10;
            label1.Text = "Proszę kliknąć 2 razy po wybranym kliencie, wtedy samochód automatycznie zostanie przypisany do klienta.\r\n";
            // 
            // ButtoCarSave
            // 
            ButtoCarSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtoCarSave.BackColor = Color.FromArgb(94, 148, 255);
            ButtoCarSave.Cursor = Cursors.Hand;
            ButtoCarSave.FlatAppearance.BorderSize = 0;
            ButtoCarSave.FlatStyle = FlatStyle.Flat;
            ButtoCarSave.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtoCarSave.ForeColor = Color.LightGray;
            ButtoCarSave.Location = new Point(0, 3);
            ButtoCarSave.Name = "ButtoCarSave";
            ButtoCarSave.Size = new Size(1012, 35);
            ButtoCarSave.TabIndex = 19;
            ButtoCarSave.Text = "Zapisz";
            ButtoCarSave.UseVisualStyleBackColor = false;
            ButtoCarSave.Click += ButtoCarSave_Click;
            // 
            // UC_AddCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 70);
            Controls.Add(panelDodatkowy);
            Controls.Add(ButtoCarSave);
            Controls.Add(panel3);
            MinimumSize = new Size(1019, 580);
            Name = "UC_AddCar";
            Size = new Size(1019, 580);
            Load += UC_AddCar_Load;
            panelDodatkowy.ResumeLayout(false);
            panelDodatkowy.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            }

        #endregion
        public ListBox CategoryListBox;
        public ListBox RokProdukcjiListBox;
        public ListBox ModelListBox;
        private ListBox MarkaListBox;
        private TextBox PojemnośćSilnikaSearch;
        private TextBox MarkaSearch;
        private TextBox ModelSearch;
        public ListBox EngineListBox;
        private Panel panelDodatkowy;
        private Label label6;
        private TextBox VINTextBox;
        private Panel panel2;
        private ListBox ClientsList;
        private Label label2;
        public Label NumLenghtNadwoziaLabel;
        private Panel panel3;
        private TextBox RokProdukcjitextBox;
        private Button ButtoCarSave;
        private Label label1;
        }
}
