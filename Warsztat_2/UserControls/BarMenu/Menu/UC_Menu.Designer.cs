namespace Warsztat_2.UserControls.BarMenu.Menu {
    partial class UC_Menu {
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
            // 
            // panelDodatkowy
            // 
            panelDodatkowy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelDodatkowy.BackColor = Color.FromArgb(64, 64, 70);
            panelDodatkowy.BorderStyle = BorderStyle.FixedSingle;
            panelDodatkowy.Controls.Add(label3);
            panelDodatkowy.ForeColor = Color.DimGray;
            panelDodatkowy.Location = new Point(0, 0);
            panelDodatkowy.Name = "panelDodatkowy";
            panelDodatkowy.Size = new Size(1040, 258);
            panelDodatkowy.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(370, -1);
            label3.Name = "label3";
            label3.Size = new Size(179, 28);
            label3.TabIndex = 0;
            label3.Text = "Grafik Zarobków";
            // 
            // UC_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panelDodatkowy);
            Name = "UC_Menu";
            Size = new Size(1040, 580);
            panelDodatkowy.ResumeLayout(false);
            ResumeLayout(false);
            }

        #endregion

        private Panel panelDodatkowy;
        private Label label3;
        }
    }
