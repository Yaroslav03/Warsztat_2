namespace Warsztat_2._0.UserControls
{
    partial class UC_AddData
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
            OrderManagementButton = new Button();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            CustommerButton = new Button();
            CarButton = new Button();
            CommisionRepairButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // OrderManagementButton
            // 
            OrderManagementButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OrderManagementButton.BackColor = Color.FromArgb(94, 148, 255);
            OrderManagementButton.FlatAppearance.BorderSize = 0;
            OrderManagementButton.FlatStyle = FlatStyle.Flat;
            OrderManagementButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            OrderManagementButton.ForeColor = Color.LightGray;
            OrderManagementButton.Location = new Point(741, 14);
            OrderManagementButton.Name = "OrderManagementButton";
            OrderManagementButton.Size = new Size(230, 30);
            OrderManagementButton.TabIndex = 16;
            OrderManagementButton.Text = "Zarządzanie Zleceniami";
            OrderManagementButton.UseVisualStyleBackColor = false;
            OrderManagementButton.Click += OrderManagementButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(64, 64, 68);
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Zoom;
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.ForeColor = Color.IndianRed;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(64, 64, 68);
            splitContainer1.Size = new Size(1019, 643);
            splitContainer1.SplitterDistance = 43;
            splitContainer1.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(CustommerButton);
            panel1.Controls.Add(CarButton);
            panel1.Controls.Add(OrderManagementButton);
            panel1.Controls.Add(CommisionRepairButton);
            panel1.ForeColor = Color.Black;
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(3, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 51);
            panel1.TabIndex = 0;
            // 
            // CustommerButton
            // 
            CustommerButton.BackColor = Color.FromArgb(94, 148, 255);
            CustommerButton.FlatAppearance.BorderSize = 0;
            CustommerButton.FlatStyle = FlatStyle.Flat;
            CustommerButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CustommerButton.ForeColor = Color.LightGray;
            CustommerButton.Location = new Point(30, 14);
            CustommerButton.Name = "CustommerButton";
            CustommerButton.Size = new Size(200, 30);
            CustommerButton.TabIndex = 16;
            CustommerButton.Text = "Klient";
            CustommerButton.UseVisualStyleBackColor = false;
            CustommerButton.Click += CustommerButton_Click;
            // 
            // CarButton
            // 
            CarButton.BackColor = Color.FromArgb(94, 148, 255);
            CarButton.FlatAppearance.BorderSize = 0;
            CarButton.FlatStyle = FlatStyle.Flat;
            CarButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CarButton.ForeColor = Color.LightGray;
            CarButton.Location = new Point(277, 14);
            CarButton.Name = "CarButton";
            CarButton.Size = new Size(199, 30);
            CarButton.TabIndex = 16;
            CarButton.Text = "Samochód";
            CarButton.UseVisualStyleBackColor = false;
            CarButton.Click += CarButton_Click;
            // 
            // CommisionRepairButton
            // 
            CommisionRepairButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CommisionRepairButton.BackColor = Color.FromArgb(94, 148, 255);
            CommisionRepairButton.FlatAppearance.BorderSize = 0;
            CommisionRepairButton.FlatStyle = FlatStyle.Flat;
            CommisionRepairButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CommisionRepairButton.ForeColor = Color.LightGray;
            CommisionRepairButton.Location = new Point(516, 14);
            CommisionRepairButton.Name = "CommisionRepairButton";
            CommisionRepairButton.Size = new Size(199, 30);
            CommisionRepairButton.TabIndex = 16;
            CommisionRepairButton.Text = "Zlecenie i Naprawa";
            CommisionRepairButton.UseVisualStyleBackColor = false;
            CommisionRepairButton.Click += CommisionRepairButton_Click;
            // 
            // UC_AddData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(splitContainer1);
            ForeColor = Color.Silver;
            Name = "UC_AddData";
            Size = new Size(1019, 643);
            Load += UC_AddClient_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button OrderManagementButton;
        private SplitContainer splitContainer1;
        private Button CarButton;
        private Button CommisionRepairButton;
        private Button CustommerButton;
        private Panel panel1;
    }
}
