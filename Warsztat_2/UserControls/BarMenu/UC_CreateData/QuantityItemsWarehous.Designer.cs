namespace Warsztat_2.UserControls.BarMenu.UC_CreateData
{
    partial class QuantityItemsWarehous
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
            QuantityNumericUpDown = new NumericUpDown();
            UpdateCategoryList = new Label();
            CancelButton = new Button();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // QuantityNumericUpDown
            // 
            QuantityNumericUpDown.BackColor = Color.White;
            QuantityNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            QuantityNumericUpDown.Location = new Point(136, 12);
            QuantityNumericUpDown.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            QuantityNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            QuantityNumericUpDown.Size = new Size(72, 23);
            QuantityNumericUpDown.TabIndex = 27;
            QuantityNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            QuantityNumericUpDown.ValueChanged += QuantityNumericUpDown_ValueChanged;
            // 
            // UpdateCategoryList
            // 
            UpdateCategoryList.AutoSize = true;
            UpdateCategoryList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateCategoryList.ForeColor = Color.FromArgb(224, 224, 224);
            UpdateCategoryList.Location = new Point(86, 12);
            UpdateCategoryList.Name = "UpdateCategoryList";
            UpdateCategoryList.Size = new Size(44, 21);
            UpdateCategoryList.TabIndex = 28;
            UpdateCategoryList.Text = "Ilość:";
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CancelButton.BackColor = Color.FromArgb(94, 148, 255);
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.LightGray;
            CancelButton.Location = new Point(172, 45);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(125, 30);
            CancelButton.TabIndex = 29;
            CancelButton.Text = "Anuluj";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SaveButton.BackColor = Color.FromArgb(94, 148, 255);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.LightGray;
            SaveButton.Location = new Point(12, 45);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(125, 30);
            SaveButton.TabIndex = 29;
            SaveButton.Text = "Zapisz";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // QuantityItemsWarehous
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(309, 81);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(UpdateCategoryList);
            Controls.Add(QuantityNumericUpDown);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "QuantityItemsWarehous";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuantityItemsWarehous";
            Load += QuantityItemsWarehous_Load;
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion

        private NumericUpDown QuantityNumericUpDown;
        private Label UpdateCategoryList;
        private Button CancelButton;
        private Button SaveButton;
    }
}