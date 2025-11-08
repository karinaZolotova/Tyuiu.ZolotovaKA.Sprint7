namespace Tyuiu.ZolotovaKA.Sprint7.Project.V3
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxData_ZKA = new GroupBox();
            labelExpAvg_ZKA = new Label();
            labelAvgAge_ZKA = new Label();
            labelMinAge_ZKA = new Label();
            labelMaxAge_ZKA = new Label();
            labelCount_ZKA = new Label();
            chartExpAge_ZKA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxData_ZKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartExpAge_ZKA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxData_ZKA
            // 
            groupBoxData_ZKA.Controls.Add(labelExpAvg_ZKA);
            groupBoxData_ZKA.Controls.Add(labelAvgAge_ZKA);
            groupBoxData_ZKA.Controls.Add(labelMinAge_ZKA);
            groupBoxData_ZKA.Controls.Add(labelMaxAge_ZKA);
            groupBoxData_ZKA.Controls.Add(labelCount_ZKA);
            groupBoxData_ZKA.Location = new Point(12, 12);
            groupBoxData_ZKA.Name = "groupBoxData_ZKA";
            groupBoxData_ZKA.Size = new Size(201, 367);
            groupBoxData_ZKA.TabIndex = 0;
            groupBoxData_ZKA.TabStop = false;
            groupBoxData_ZKA.Text = "Данные";
            // 
            // labelExpAvg_ZKA
            // 
            labelExpAvg_ZKA.AutoSize = true;
            labelExpAvg_ZKA.Location = new Point(6, 111);
            labelExpAvg_ZKA.Name = "labelExpAvg_ZKA";
            labelExpAvg_ZKA.Size = new Size(90, 15);
            labelExpAvg_ZKA.TabIndex = 0;
            labelExpAvg_ZKA.Text = "Средний стаж: ";
            // 
            // labelAvgAge_ZKA
            // 
            labelAvgAge_ZKA.AutoSize = true;
            labelAvgAge_ZKA.Location = new Point(6, 96);
            labelAvgAge_ZKA.Name = "labelAvgAge_ZKA";
            labelAvgAge_ZKA.Size = new Size(106, 15);
            labelAvgAge_ZKA.TabIndex = 0;
            labelAvgAge_ZKA.Text = "Средний возраст: ";
            // 
            // labelMinAge_ZKA
            // 
            labelMinAge_ZKA.AutoSize = true;
            labelMinAge_ZKA.Location = new Point(6, 65);
            labelMinAge_ZKA.Name = "labelMinAge_ZKA";
            labelMinAge_ZKA.Size = new Size(141, 15);
            labelMinAge_ZKA.TabIndex = 0;
            labelMinAge_ZKA.Text = "Минимальный возраст: ";
            // 
            // labelMaxAge_ZKA
            // 
            labelMaxAge_ZKA.AutoSize = true;
            labelMaxAge_ZKA.Location = new Point(6, 50);
            labelMaxAge_ZKA.Name = "labelMaxAge_ZKA";
            labelMaxAge_ZKA.Size = new Size(145, 15);
            labelMaxAge_ZKA.TabIndex = 0;
            labelMaxAge_ZKA.Text = "Максимальный возраст: ";
            // 
            // labelCount_ZKA
            // 
            labelCount_ZKA.AutoSize = true;
            labelCount_ZKA.Location = new Point(6, 19);
            labelCount_ZKA.Name = "labelCount_ZKA";
            labelCount_ZKA.Size = new Size(170, 15);
            labelCount_ZKA.TabIndex = 0;
            labelCount_ZKA.Text = "Количество преподавателей: ";
            // 
            // chartExpAge_ZKA
            // 
            chartArea1.Name = "ChartArea1";
            chartExpAge_ZKA.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartExpAge_ZKA.Legends.Add(legend1);
            chartExpAge_ZKA.Location = new Point(219, 12);
            chartExpAge_ZKA.Name = "chartExpAge_ZKA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartExpAge_ZKA.Series.Add(series1);
            chartExpAge_ZKA.Size = new Size(353, 367);
            chartExpAge_ZKA.TabIndex = 1;
            chartExpAge_ZKA.Text = "Зависимость стажа от возраста";
            chartExpAge_ZKA.Click += chartExpAge_ZKA_Click;
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 391);
            Controls.Add(chartExpAge_ZKA);
            Controls.Add(groupBoxData_ZKA);
            MaximizeBox = false;
            MaximumSize = new Size(600, 430);
            MinimumSize = new Size(600, 430);
            Name = "FormStatistics";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Статистика";
            Load += FormStatistics_Load;
            groupBoxData_ZKA.ResumeLayout(false);
            groupBoxData_ZKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartExpAge_ZKA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxData_ZKA;
        private Label labelExpAvg_ZKA;
        private Label labelAvgAge_ZKA;
        private Label labelMinAge_ZKA;
        private Label labelMaxAge_ZKA;
        private Label labelCount_ZKA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpAge_ZKA;
    }
}
