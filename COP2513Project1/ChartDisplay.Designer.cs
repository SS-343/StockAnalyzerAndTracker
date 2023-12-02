namespace COP2513Project1
{
    partial class ChartDisplay
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.NewFormChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.candlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PatternSelction = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NewFormChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NewFormChart
            // 
            chartArea1.Name = "ChartArea1";
            this.NewFormChart.ChartAreas.Add(chartArea1);
            this.NewFormChart.DataSource = this.candlestickBindingSource;
            legend1.Name = "Legend1";
            this.NewFormChart.Legends.Add(legend1);
            this.NewFormChart.Location = new System.Drawing.Point(248, 12);
            this.NewFormChart.Name = "NewFormChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Lime";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.NewFormChart.Series.Add(series1);
            this.NewFormChart.Size = new System.Drawing.Size(830, 612);
            this.NewFormChart.TabIndex = 0;
            this.NewFormChart.Text = "chart1";
            // 
            // candlestickBindingSource
            // 
            this.candlestickBindingSource.DataSource = typeof(COP2513Project1.candlestick);
            // 
            // PatternSelction
            // 
            this.PatternSelction.FormattingEnabled = true;
            this.PatternSelction.Location = new System.Drawing.Point(36, 441);
            this.PatternSelction.Name = "PatternSelction";
            this.PatternSelction.Size = new System.Drawing.Size(121, 21);
            this.PatternSelction.TabIndex = 1;
            this.PatternSelction.SelectedIndexChanged += new System.EventHandler(this.PatternSelction_SelectedIndexChanged);
            // 
            // ChartDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 667);
            this.Controls.Add(this.PatternSelction);
            this.Controls.Add(this.NewFormChart);
            this.Name = "ChartDisplay";
            this.Text = "ChartDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.NewFormChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart NewFormChart;
        private System.Windows.Forms.BindingSource candlestickBindingSource;
        private System.Windows.Forms.ComboBox PatternSelction;
    }
}