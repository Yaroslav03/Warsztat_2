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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelDodatkowy = new Panel();
            label3 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelDodatkowy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panelDodatkowy
            // 
            panelDodatkowy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelDodatkowy.BackColor = Color.FromArgb(64, 64, 70);
            panelDodatkowy.BorderStyle = BorderStyle.FixedSingle;
            panelDodatkowy.Controls.Add(chart1);
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
            // chart1
            // 
            chart1.BackColor = Color.FromArgb(64, 64, 70);
            chart1.BorderlineColor = Color.Gray;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(-1, 84);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.Green;
            series1.Legend = "Legend1";
            series1.Name = "Zarobki";
            series1.YValuesPerPoint = 6;
            series2.ChartArea = "ChartArea1";
            series2.Color = Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Wydatki";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(493, 173);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
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
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            }

        #endregion

        private Panel panelDodatkowy;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        }
    }
