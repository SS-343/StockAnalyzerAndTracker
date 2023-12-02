namespace COP2513Project1
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxForTicker = new System.Windows.Forms.ComboBox();
            this.daily = new System.Windows.Forms.RadioButton();
            this.Weekly = new System.Windows.Forms.RadioButton();
            this.Monthly = new System.Windows.Forms.RadioButton();
            this.CurrentTicker = new System.Windows.Forms.Label();
            this.TickerSelectLabel = new System.Windows.Forms.Label();
            this.candlestickBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candlestickBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.candlestickBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.candlestickBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.candlestickBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formStockReaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formStockReaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(135, 127);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ticker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "End Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Load Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.openDataGridViewTextBoxColumn,
            this.closeDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.candlestickBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(350, 262);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(553, 201);
            this.dataGridView1.TabIndex = 14;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.candlestickBindingSource1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(350, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Lime, LabelValueType=Open";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(553, 236);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // comboBoxForTicker
            // 
            this.comboBoxForTicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForTicker.FormattingEnabled = true;
            this.comboBoxForTicker.Location = new System.Drawing.Point(135, 262);
            this.comboBoxForTicker.Name = "comboBoxForTicker";
            this.comboBoxForTicker.Size = new System.Drawing.Size(121, 21);
            this.comboBoxForTicker.TabIndex = 16;
            this.comboBoxForTicker.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // daily
            // 
            this.daily.AutoSize = true;
            this.daily.Location = new System.Drawing.Point(135, 180);
            this.daily.Name = "daily";
            this.daily.Size = new System.Drawing.Size(48, 17);
            this.daily.TabIndex = 0;
            this.daily.TabStop = true;
            this.daily.Text = "Daily";
            this.daily.UseVisualStyleBackColor = true;
            this.daily.CheckedChanged += new System.EventHandler(this.daily_CheckedChanged);
            // 
            // Weekly
            // 
            this.Weekly.AutoSize = true;
            this.Weekly.Location = new System.Drawing.Point(135, 203);
            this.Weekly.Name = "Weekly";
            this.Weekly.Size = new System.Drawing.Size(61, 17);
            this.Weekly.TabIndex = 1;
            this.Weekly.TabStop = true;
            this.Weekly.Text = "Weekly";
            this.Weekly.UseVisualStyleBackColor = true;
            this.Weekly.CheckedChanged += new System.EventHandler(this.weekly_CheckedChanged);
            // 
            // Monthly
            // 
            this.Monthly.AutoSize = true;
            this.Monthly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Monthly.Location = new System.Drawing.Point(135, 227);
            this.Monthly.Name = "Monthly";
            this.Monthly.Size = new System.Drawing.Size(62, 17);
            this.Monthly.TabIndex = 18;
            this.Monthly.TabStop = true;
            this.Monthly.Text = "Monthly";
            this.Monthly.UseVisualStyleBackColor = true;
            this.Monthly.CheckedChanged += new System.EventHandler(this.Monthly_CheckedChanged);
            // 
            // CurrentTicker
            // 
            this.CurrentTicker.AutoSize = true;
            this.CurrentTicker.Location = new System.Drawing.Point(135, 48);
            this.CurrentTicker.Name = "CurrentTicker";
            this.CurrentTicker.Size = new System.Drawing.Size(105, 13);
            this.CurrentTicker.TabIndex = 19;
            this.CurrentTicker.Text = "TickerSelectedLabel";
            this.CurrentTicker.Click += new System.EventHandler(this.CurrentTicker_Click);
            // 
            // TickerSelectLabel
            // 
            this.TickerSelectLabel.AutoSize = true;
            this.TickerSelectLabel.Location = new System.Drawing.Point(47, 262);
            this.TickerSelectLabel.Name = "TickerSelectLabel";
            this.TickerSelectLabel.Size = new System.Drawing.Size(70, 13);
            this.TickerSelectLabel.TabIndex = 20;
            this.TickerSelectLabel.Text = "Select Ticker";
            // 
            // candlestickBindingSource1
            // 
            this.candlestickBindingSource1.DataSource = typeof(COP2513Project1.candlestick);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // openDataGridViewTextBoxColumn
            // 
            this.openDataGridViewTextBoxColumn.DataPropertyName = "open";
            this.openDataGridViewTextBoxColumn.HeaderText = "open";
            this.openDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.openDataGridViewTextBoxColumn.Name = "openDataGridViewTextBoxColumn";
            this.openDataGridViewTextBoxColumn.Width = 150;
            // 
            // closeDataGridViewTextBoxColumn
            // 
            this.closeDataGridViewTextBoxColumn.DataPropertyName = "close";
            this.closeDataGridViewTextBoxColumn.HeaderText = "close";
            this.closeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.closeDataGridViewTextBoxColumn.Name = "closeDataGridViewTextBoxColumn";
            this.closeDataGridViewTextBoxColumn.Width = 150;
            // 
            // highDataGridViewTextBoxColumn
            // 
            this.highDataGridViewTextBoxColumn.DataPropertyName = "high";
            this.highDataGridViewTextBoxColumn.HeaderText = "high";
            this.highDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            this.highDataGridViewTextBoxColumn.Width = 150;
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "low";
            this.lowDataGridViewTextBoxColumn.HeaderText = "low";
            this.lowDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            this.lowDataGridViewTextBoxColumn.Width = 150;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "volume";
            this.volumeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.Width = 150;
            // 
            // candlestickBindingSource3
            // 
            this.candlestickBindingSource3.DataSource = typeof(COP2513Project1.candlestick);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(COP2513Project1.Form1);
            // 
            // candlestickBindingSource5
            // 
            this.candlestickBindingSource5.DataSource = typeof(COP2513Project1.candlestick);
            // 
            // candlestickBindingSource4
            // 
            this.candlestickBindingSource4.DataSource = typeof(COP2513Project1.candlestick);
            // 
            // candlestickBindingSource2
            // 
            this.candlestickBindingSource2.DataSource = typeof(COP2513Project1.candlestick);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(COP2513Project1.Form1);
            // 
            // formStockReaderBindingSource
            // 
            this.formStockReaderBindingSource.DataSource = typeof(COP2513Project1.FormStockReader);
            // 
            // candlestickBindingSource
            // 
            this.candlestickBindingSource.DataSource = typeof(COP2513Project1.candlestick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COP2513Project1.Properties.Resources.MU11063;
            this.ClientSize = new System.Drawing.Size(924, 474);
            this.Controls.Add(this.TickerSelectLabel);
            this.Controls.Add(this.CurrentTicker);
            this.Controls.Add(this.Monthly);
            this.Controls.Add(this.comboBoxForTicker);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Weekly);
            this.Controls.Add(this.daily);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formStockReaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candlestickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource formStockReaderBindingSource;
        private System.Windows.Forms.BindingSource candlestickBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource candlestickBindingSource1;
        //private Database database;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource candlestickBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource candlestickBindingSource3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource candlestickBindingSource4;
        private System.Windows.Forms.BindingSource candlestickBindingSource5;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.RadioButton daily;
        private System.Windows.Forms.RadioButton Weekly;
        private System.Windows.Forms.RadioButton Monthly;
        private System.Windows.Forms.Label CurrentTicker;
        private System.Windows.Forms.Label TickerSelectLabel;
        private System.Windows.Forms.ComboBox comboBoxForTicker;
        // private DatabaseTableAdapters.StocksTableAdapter stocksTableAdapter;
    }
}

