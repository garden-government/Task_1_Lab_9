namespace Task_1_Lab_9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SimpleNumberFirst = new System.Windows.Forms.Button();
            this.SimpleNumberSecond = new System.Windows.Forms.Button();
            this.Fractal = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // SimpleNumberFirst
            // 
            this.SimpleNumberFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SimpleNumberFirst.Location = new System.Drawing.Point(12, 538);
            this.SimpleNumberFirst.Name = "SimpleNumberFirst";
            this.SimpleNumberFirst.Size = new System.Drawing.Size(337, 80);
            this.SimpleNumberFirst.TabIndex = 0;
            this.SimpleNumberFirst.Text = "Simple number points 10.000";
            this.SimpleNumberFirst.UseVisualStyleBackColor = true;
            this.SimpleNumberFirst.Click += new System.EventHandler(this.SimpleNumberFirst_Click);
            // 
            // SimpleNumberSecond
            // 
            this.SimpleNumberSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SimpleNumberSecond.Location = new System.Drawing.Point(355, 537);
            this.SimpleNumberSecond.Name = "SimpleNumberSecond";
            this.SimpleNumberSecond.Size = new System.Drawing.Size(337, 81);
            this.SimpleNumberSecond.TabIndex = 1;
            this.SimpleNumberSecond.Text = "Simple number points 150.000";
            this.SimpleNumberSecond.UseVisualStyleBackColor = true;
            this.SimpleNumberSecond.Click += new System.EventHandler(this.SimpleNumberSecond_Click);
            // 
            // Fractal
            // 
            this.Fractal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fractal.Location = new System.Drawing.Point(698, 537);
            this.Fractal.Name = "Fractal";
            this.Fractal.Size = new System.Drawing.Size(285, 80);
            this.Fractal.TabIndex = 2;
            this.Fractal.Text = "Fractal";
            this.Fractal.UseVisualStyleBackColor = true;
            this.Fractal.Click += new System.EventHandler(this.Fractal_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Black;
            series1.MarkerSize = 2;
            series1.Name = "ZIZI";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(971, 520);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 630);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Fractal);
            this.Controls.Add(this.SimpleNumberSecond);
            this.Controls.Add(this.SimpleNumberFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SimpleNumberFirst;
        private System.Windows.Forms.Button SimpleNumberSecond;
        private System.Windows.Forms.Button Fractal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

