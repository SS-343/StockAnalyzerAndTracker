using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace COP2513Project1
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        String period = null;/// Allows for period to be accessed anywhere in the class
        String fileToRetrive = null;/// Allows for file to accessed and set 
        FileInfo[] Files = null;
        public List<candlestick> dataFromForm = null;
        public string stockTickerName = null;
        
        public Form1()
        {
            instance = this;
            String fileName = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            String filepath = fileName + "/Stock Data/";
            DirectoryInfo d = new DirectoryInfo(filepath);
            Files = d.GetFiles("*.csv");
            InitializeComponent();///Initializes buttons and components
            

        }


        private void label1_Click(object sender, EventArgs e) ///Runs when label is clicked
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)/// Runs when text is changed
        {
           
            
        }

        public System.Windows.Forms.ComboBox.ObjectCollection Items { get; }

        private void button1_Click(object sender, EventArgs e)///Is called when Load Data is clicked
        {

            comboBoxForTicker.Items.Add("test");
            
            FormStockReader test = new FormStockReader(); /// Allows for methods to be used from the FormStockReader

            ///List<candlestick> dataFromForm= new List<candlestick>(test.findStockCSV("old ticker", fileToRetrive, dateTimePicker1.Value, dateTimePicker2.Value)); ///Populates new list from FormStockReader
            dataFromForm= (test.findStockCSV("old ticker", fileToRetrive, dateTimePicker1.Value, dateTimePicker2.Value));
            dataGridView1.DataSource = dataFromForm;
            decimal highNum = 0;
            decimal lowNum = 1000;
           
            foreach (candlestick item in dataFromForm) /// Finds minimum and maximum values to aid in scaling
            {
                if (highNum < item.open)
                { 
                    highNum = item.open;
                }

                if (lowNum > item.open)
                {
                    lowNum = item.open;
                }

            }

            chart1.DataSource = dataFromForm; ///Adds data to candlestick chart
            chart1.DataBind();


            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Decimal.ToDouble(highNum) + 2; ///Sets upper boundaries
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Decimal.ToDouble(lowNum) - 2; ///Sets lower boundaries

            chart1.Series["Series1"].XValueMember = "Date";
            chart1.Series["Series1"].YValueMembers = "high, low, open, close";
            chart1.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            chart1.Series["Series1"].CustomProperties = "PriceDownColor=Red,PriceUpColor=Green";
            chart1.Series["Series1"]["OpenCloseStyle"] = "Triangle";
            chart1.Series["Series1"]["ShowOpenClose"] = "Both";
            
            
            chart1.DataManipulator.IsStartFromFirst = true;

            
            
            button1.Click += new EventHandler(this.button1_Click);


            ChartDisplay f2 = new ChartDisplay();




            f2.ShowDialog();



        }

       

        private void button3_Click(object sender, EventArgs e)///Runs when button is clicked
        {
            


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)///Runs when date time value is changed
        {
            
        }

        private void weekly_CheckedChanged(object sender, EventArgs e)///Sets the period to week when radio button is clicked
        {
            period = "Week";
            comboBoxForTicker.Items.Clear();
            foreach (FileInfo file in Files)
            {
                if ((file.Name).Contains(period))
                {
                    comboBoxForTicker.Items.Add(file.Name);

                }
                //Console.WriteLine(file.Name);
            }

            Controls.Add(comboBoxForTicker);
            
        }

        private void daily_CheckedChanged(object sender, EventArgs e)///Sets the period to day when radio button is clicked
        {
            period = "Day";
            comboBoxForTicker.Items.Clear();
            foreach (FileInfo file in Files)
            {
                if ((file.Name).Contains(period))
                {
                    comboBoxForTicker.Items.Add(file.Name);

                }
                //Console.WriteLine(file.Name);
            }

            Controls.Add(comboBoxForTicker);

        }

        private void chart1_Click(object sender, EventArgs e)///Runs when datagridview chart is clicked
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)///Runs when chart is clicked
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileToRetrive = comboBoxForTicker.Text;
            if (period.Equals("Day")) {
                CurrentTicker.Text = comboBoxForTicker.Text.Substring(0, comboBoxForTicker.Text.Length - 8);
                stockTickerName = comboBoxForTicker.Text.Substring(0, comboBoxForTicker.Text.Length - 8);
                 }
            if (period.Equals("Week")) { 
                CurrentTicker.Text = comboBoxForTicker.Text.Substring(0, comboBoxForTicker.Text.Length - 9);
                stockTickerName = comboBoxForTicker.Text.Substring(0, comboBoxForTicker.Text.Length - 9);
            }
            if (period.Equals("Month")) {
                CurrentTicker.Text = comboBoxForTicker.Text.Substring(0, comboBoxForTicker.Text.Length - 10);
                stockTickerName = comboBoxForTicker.Text.Substring(0, comboBoxForTicker.Text.Length - 10);
            }
            //CurrentTicker.Text = comboBoxForTicker.Text.Substring(0, comboBoxForTicker.Text.Length - 4);
        }


        private void Monthly_CheckedChanged(object sender, EventArgs e)
        {
            period = "Month";
            
            comboBoxForTicker.Items.Clear();
            foreach(FileInfo file in Files)
            {
                if ((file.Name).Contains(period))
                {
                    comboBoxForTicker.Items.Add(file.Name);
                    
                }
                //Console.WriteLine(file.Name);
            }

            Controls.Add(comboBoxForTicker);
        }

        private void CurrentTicker_Click(object sender, EventArgs e)
        {

        }
    }
}
