using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace COP2513Project1
{
    public partial class ChartDisplay : Form
    {
        public static ChartDisplay instance;
        public List<candlestick> candlestickData = Form1.instance.dataFromForm;

        public ChartDisplay()
        {
            InitializeComponent();
            instance = this;
            List<candlestick> candlestickData = Form1.instance.dataFromForm;
            String stockTick = Form1.instance.stockTickerName;



            PatternSelction.Items.Add("Common Doji");
            PatternSelction.Items.Add("Dragonfly Doji");
            PatternSelction.Items.Add("Gravestone Doji");
            PatternSelction.Items.Add("Long-Legged Doji");
            PatternSelction.Items.Add("White Marubozu");
            PatternSelction.Items.Add("Black Marubozu");
            PatternSelction.Items.Add("Hammer");
            PatternSelction.Items.Add("Inverted Hammer");
            PatternSelction.Items.Add("Spinning Top");
            PatternSelction.Items.Add("Hanging Man");
            PatternSelction.Items.Add("Shooting Star");
            PatternSelction.Items.Add("Bullish Engulfing");
            PatternSelction.Items.Add("Bearish Engulfing");





            decimal highNum = 0;
            decimal lowNum = 1000;

            foreach (candlestick item in candlestickData) /// Finds minimum and maximum values to aid in scaling
            {
                item.findAdvancedCandleStickData(item);
                if (highNum < item.open)
                {
                    highNum = item.open;
                }

                if (lowNum > item.open)
                {
                    lowNum = item.open;
                }

                if (item.isCommonDoji(item)) { Console.WriteLine("Common"); }
                if (item.isDragonFlyDoji(item)) { Console.WriteLine("DragonFly"); }
                if (item.isGravestoneDoji(item)) { Console.WriteLine("GraveStone"); }
                if (item.isLongLeggedDoji(item)) { Console.WriteLine("LongLeg"); }
                if (item.isBlackMarubozu(item)) { Console.WriteLine("Black Marubozu"); }


            }


            NewFormChart.DataSource = candlestickData; ///Adds data to candlestick chart
            NewFormChart.DataBind();


            NewFormChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            NewFormChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            NewFormChart.ChartAreas["ChartArea1"].AxisY.Maximum = Decimal.ToDouble(highNum) + 2; ///Sets upper boundaries
            NewFormChart.ChartAreas["ChartArea1"].AxisY.Minimum = Decimal.ToDouble(lowNum) - 2; ///Sets lower boundaries
            Color blue = Color.LightBlue;
            Color green = Color.LightGreen;
            Color red = Color.LightSalmon;
            Color black = Color.Black;
            Color orange = Color.Orange;
            Color violet = Color.Violet;
            Color darkBlue = Color.DarkBlue;
            Color yellow = Color.Yellow;
            Color darkGreen = Color.DarkGreen;
            NewFormChart.Legends["Legend1"].CustomItems.Add(blue, "Common Doji");
            NewFormChart.Legends["Legend1"].CustomItems.Add(green, "Gravestone Doji");
            NewFormChart.Legends["Legend1"].CustomItems.Add(red, "Dragonfly Doji");
            NewFormChart.Legends["Legend1"].CustomItems.Add(black, "Long-Legged Doji");
            NewFormChart.Legends["Legend1"].CustomItems.Add(orange, "Bullish Engulfing");
            NewFormChart.Legends["Legend1"].CustomItems.Add(violet, "Bearish Engulfing");
            NewFormChart.Legends["Legend1"].CustomItems.Add(darkBlue, "Shooting Star");
            NewFormChart.Legends["Legend1"].CustomItems.Add(yellow, "Spinning Top");
            NewFormChart.Legends["Legend1"].CustomItems.Add(darkGreen, "Hanging Man");
            NewFormChart.Legends["Legend1"].CustomItems.Add(Color.Beige, "Hammer");
            NewFormChart.Legends["Legend1"].CustomItems.Add(Color.DarkMagenta, "Inverted Hammer");
            NewFormChart.Legends["Legend1"].CustomItems.Add(Color.DeepPink, "White Marubozu");
            NewFormChart.Legends["Legend1"].CustomItems.Add(Color.Firebrick, "Black Marubozu");
            NewFormChart.Series["Series1"].LegendText = stockTick;
              


            NewFormChart.Series["Series1"].XValueMember = "Date";
            NewFormChart.Series["Series1"].YValueMembers = "high, low, open, close";
            NewFormChart.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            NewFormChart.Series["Series1"].CustomProperties = "PriceDownColor=Red,PriceUpColor=Green";
            NewFormChart.Series["Series1"]["OpenCloseStyle"] = "Triangle";
            NewFormChart.Series["Series1"]["ShowOpenClose"] = "Both";


            NewFormChart.DataManipulator.IsStartFromFirst = true;

            


        }

        private void PatternSelction_SelectedIndexChanged(object sender, EventArgs e)
        {

            Color blue = Color.LightBlue;
            Color green = Color.LightGreen;
            Color red = Color.LightSalmon;
            Color black = Color.Black;
            Color orange = Color.Orange;
            Color violet = Color.Violet;
            NewFormChart.Annotations.Clear();
            for (int i = 0; i < candlestickData.Count; i++)
            {
                if (candlestickData[i].isCommonDoji(candlestickData[i]) && PatternSelction.Text == "Common Doji")
                {
                    RectangleAnnotation commonRectanlge = new RectangleAnnotation();
                    commonRectanlge.Width = .5;
                    commonRectanlge.Height = 1;
                    commonRectanlge.BackColor = blue;
                    commonRectanlge.AxisX = NewFormChart.ChartAreas[0].AxisX;
                    commonRectanlge.AxisY = NewFormChart.ChartAreas[0].AxisY;
                    commonRectanlge.X = candlestickData[i].date.ToOADate();
                    // convert to double
                    commonRectanlge.Y = Convert.ToDouble(candlestickData[i].high);
                    commonRectanlge.AnchorX = candlestickData[i].date.ToOADate();
                    commonRectanlge.AnchorY = Convert.ToDouble(candlestickData[i].high);

                    NewFormChart.Annotations.Add(commonRectanlge);
                }

                if (candlestickData[i].isDragonFlyDoji(candlestickData[i]) && PatternSelction.Text == "Dragonfly Doji")
                {
                    RectangleAnnotation dragonFlyRectangle = new RectangleAnnotation();
                    dragonFlyRectangle.Width = .5;
                    dragonFlyRectangle.Height = 1;
                    dragonFlyRectangle.BackColor = red;
                    dragonFlyRectangle.AxisX = NewFormChart.ChartAreas[0].AxisX;
                    dragonFlyRectangle.AxisY = NewFormChart.ChartAreas[0].AxisY;
                    dragonFlyRectangle.X = candlestickData[i].date.ToOADate();
                    // convert to double
                    dragonFlyRectangle.Y = Convert.ToDouble(candlestickData[i].high);
                    dragonFlyRectangle.AnchorX = candlestickData[i].date.ToOADate();
                    dragonFlyRectangle.AnchorY = Convert.ToDouble(candlestickData[i].high);

                    NewFormChart.Annotations.Add(dragonFlyRectangle);
                }

                if (candlestickData[i].isGravestoneDoji(candlestickData[i]) && PatternSelction.Text =="Gravestone Doji")
                {
                    RectangleAnnotation gravestoneRectangle = new RectangleAnnotation();
                    gravestoneRectangle.Width = .5;
                    gravestoneRectangle.Height = 1;
                    gravestoneRectangle.BackColor = green;
                    gravestoneRectangle.AxisX = NewFormChart.ChartAreas[0].AxisX;
                    gravestoneRectangle.AxisY = NewFormChart.ChartAreas[0].AxisY;
                    gravestoneRectangle.X = candlestickData[i].date.ToOADate();
                    // convert to double
                    gravestoneRectangle.Y = Convert.ToDouble(candlestickData[i].high);
                    gravestoneRectangle.AnchorX = candlestickData[i].date.ToOADate();
                    gravestoneRectangle.AnchorY = Convert.ToDouble(candlestickData[i].high);

                    NewFormChart.Annotations.Add(gravestoneRectangle);
                }

                if (candlestickData[i].isLongLeggedDoji(candlestickData[i]) && PatternSelction.Text =="Long-Legged Doji")
                {
                    RectangleAnnotation lLRectangle = new RectangleAnnotation();
                    lLRectangle.Width = .5;
                    lLRectangle.Height = 1;
                    lLRectangle.BackColor = black;
                    lLRectangle.AxisX = NewFormChart.ChartAreas[0].AxisX;
                    lLRectangle.AxisY = NewFormChart.ChartAreas[0].AxisY;
                    lLRectangle.X = candlestickData[i].date.ToOADate();
                    // convert to double
                    lLRectangle.Y = Convert.ToDouble(candlestickData[i].high);
                    lLRectangle.AnchorX = candlestickData[i].date.ToOADate();
                    lLRectangle.AnchorY = Convert.ToDouble(candlestickData[i].high);
                    NewFormChart.Annotations.Add(lLRectangle);
                }

                if (candlestickData[i].isShootingStar(candlestickData[i]) && PatternSelction.Text == "Shooting Star")//Shooting star
                {
                    RectangleAnnotation sSRectangle = new RectangleAnnotation();
                    sSRectangle.Width = .5;
                    sSRectangle.Height = 1;
                    sSRectangle.BackColor = Color.DarkBlue;
                    sSRectangle.AxisX = NewFormChart.ChartAreas[0].AxisX;
                    sSRectangle.AxisY = NewFormChart.ChartAreas[0].AxisY;
                    sSRectangle.X = candlestickData[i].date.ToOADate();
                    // convert to double
                    sSRectangle.Y = Convert.ToDouble(candlestickData[i].high);
                    sSRectangle.AnchorX = candlestickData[i].date.ToOADate();
                    sSRectangle.AnchorY = Convert.ToDouble(candlestickData[i].high);
                    NewFormChart.Annotations.Add(sSRectangle);
                }

                if (candlestickData[i].isSpinningTop(candlestickData[i]) && PatternSelction.Text == "Spinning Top")//spinning top
                {
                    RectangleAnnotation sTRectangle = new RectangleAnnotation();
                    sTRectangle.Width = .5;
                    sTRectangle.Height = 1;
                    sTRectangle.BackColor = Color.Yellow;
                    sTRectangle.AxisX = NewFormChart.ChartAreas[0].AxisX;
                    sTRectangle.AxisY = NewFormChart.ChartAreas[0].AxisY;
                    sTRectangle.X = candlestickData[i].date.ToOADate();
                    // convert to double
                    sTRectangle.Y = Convert.ToDouble(candlestickData[i].high);
                    sTRectangle.AnchorX = candlestickData[i].date.ToOADate();
                    sTRectangle.AnchorY = Convert.ToDouble(candlestickData[i].high);
                    NewFormChart.Annotations.Add(sTRectangle);
                }

                if (candlestickData[i].isHangingMan(candlestickData[i]) && PatternSelction.Text == "Hanging Man")//hanging man
                {
                    RectangleAnnotation hMRectangle = new RectangleAnnotation();
                    hMRectangle.Width = .5;
                    hMRectangle.Height = 1;
                    hMRectangle.BackColor = Color.DarkGreen;
                    hMRectangle.AxisX = NewFormChart.ChartAreas[0].AxisX;
                    hMRectangle.AxisY = NewFormChart.ChartAreas[0].AxisY;
                    hMRectangle.X = candlestickData[i].date.ToOADate();
                    // convert to double
                    hMRectangle.Y = Convert.ToDouble(candlestickData[i].high);
                    hMRectangle.AnchorX = candlestickData[i].date.ToOADate();
                    hMRectangle.AnchorY = Convert.ToDouble(candlestickData[i].high);
                    NewFormChart.Annotations.Add(hMRectangle);
                }

                if (candlestickData[i].isHammer(candlestickData[i]) && PatternSelction.Text == "Hammer")//Hammer
                {
                    RectangleAnnotation hRectangle = new RectangleAnnotation();
                    hRectangle.Width = .5;
                    hRectangle.Height = 1;
                    hRectangle.BackColor = Color.Beige;
                    hRectangle.AxisX = NewFormChart.ChartAreas[0].AxisX;
                    hRectangle.AxisY = NewFormChart.ChartAreas[0].AxisY;
                    hRectangle.X = candlestickData[i].date.ToOADate();
                    // convert to double
                    hRectangle.Y = Convert.ToDouble(candlestickData[i].high);
                    hRectangle.AnchorX = candlestickData[i].date.ToOADate();
                    hRectangle.AnchorY = Convert.ToDouble(candlestickData[i].high);
                    NewFormChart.Annotations.Add(hRectangle);
                }

                if (candlestickData[i].isInvertedHammer(candlestickData[i]) && PatternSelction.Text == "Inverted Hammer")//Inverted Hammer
                {
                    RectangleAnnotation iHrectangle = new RectangleAnnotation();
                    iHrectangle.Width = .5;
                    iHrectangle.Height = 1;
                    iHrectangle.BackColor = Color.DarkMagenta;
                    iHrectangle.AxisX = NewFormChart.ChartAreas[0].AxisX;
                    iHrectangle.AxisY = NewFormChart.ChartAreas[0].AxisY;
                    iHrectangle.X = candlestickData[i].date.ToOADate();
                    // convert to double
                    iHrectangle.Y = Convert.ToDouble(candlestickData[i].high);
                    iHrectangle.AnchorX = candlestickData[i].date.ToOADate();
                    iHrectangle.AnchorY = Convert.ToDouble(candlestickData[i].high);
                    NewFormChart.Annotations.Add(iHrectangle);
                }

                if (candlestickData[i].isWhiteMarubozu(candlestickData[i]) && PatternSelction.Text == "White Marubozu")//White Marubozu
                {
                    RectangleAnnotation wMRectangle = new RectangleAnnotation();
                    wMRectangle.Width = .5;
                    wMRectangle.Height = 1;
                    wMRectangle.BackColor = Color.DeepPink;
                    wMRectangle.AxisX = NewFormChart.ChartAreas[0].AxisX;
                    wMRectangle.AxisY = NewFormChart.ChartAreas[0].AxisY;
                    wMRectangle.X = candlestickData[i].date.ToOADate();
                    // convert to double
                    wMRectangle.Y = Convert.ToDouble(candlestickData[i].high);
                    wMRectangle.AnchorX = candlestickData[i].date.ToOADate();
                    wMRectangle.AnchorY = Convert.ToDouble(candlestickData[i].high);
                    NewFormChart.Annotations.Add(wMRectangle);
                }

                if (candlestickData[i].isBlackMarubozu(candlestickData[i]) && PatternSelction.Text == "Black Marubozu")//Black Marubozu
                {
                    RectangleAnnotation bMRectanle = new RectangleAnnotation();
                    bMRectanle.Width = .5;
                    bMRectanle.Height = 1;
                    bMRectanle.BackColor = Color.Firebrick;
                    bMRectanle.AxisX = NewFormChart.ChartAreas[0].AxisX;
                    bMRectanle.AxisY = NewFormChart.ChartAreas[0].AxisY;
                    bMRectanle.X = candlestickData[i].date.ToOADate();
                    // convert to double
                    bMRectanle.Y = Convert.ToDouble(candlestickData[i].high);
                    bMRectanle.AnchorX = candlestickData[i].date.ToOADate();
                    bMRectanle.AnchorY = Convert.ToDouble(candlestickData[i].high);
                    NewFormChart.Annotations.Add(bMRectanle);
                }

                try
                {
                    if (candlestickData[i].close < candlestickData[i].open && candlestickData[i + 1].close > candlestickData[i + 1].open && candlestickData[i + 1].open <= candlestickData[i].close && candlestickData[i + 1].close >= candlestickData[i].open && candlestickData[i + 1].body > candlestickData[i].body && PatternSelction.Text == "Bullish Engulfing")
                    {
                        RectangleAnnotation bullEngulfRectangle = new RectangleAnnotation();
                        bullEngulfRectangle.Width = .5;
                        bullEngulfRectangle.Height = 1;
                        bullEngulfRectangle.BackColor = orange;
                        bullEngulfRectangle.AxisX = NewFormChart.ChartAreas[0].AxisX;
                        bullEngulfRectangle.AxisY = NewFormChart.ChartAreas[0].AxisY;
                        bullEngulfRectangle.X = candlestickData[i].date.ToOADate();
                        // convert to double
                        bullEngulfRectangle.Y = Convert.ToDouble(candlestickData[i].high);
                        bullEngulfRectangle.AnchorX = candlestickData[i].date.ToOADate();
                        bullEngulfRectangle.AnchorY = Convert.ToDouble(candlestickData[i].high);
                        NewFormChart.Annotations.Add(bullEngulfRectangle);
                        Console.WriteLine("Bullish");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:", ex.Message);
                }

                try
                {
                    if ((candlestickData[i].close > candlestickData[i].open && candlestickData[i + 1].close < candlestickData[i + 1].open && candlestickData[i + 1].open >= candlestickData[i].close && candlestickData[i + 1].close <= candlestickData[i].open && candlestickData[i + 1].body > candlestickData[i].body) && PatternSelction.Text == "Bearish Engulfing")
                    {
                        RectangleAnnotation bearEngulfRectangle = new RectangleAnnotation();
                        bearEngulfRectangle.Width = .5;
                        bearEngulfRectangle.Height = 1;
                        bearEngulfRectangle.BackColor = violet;
                        bearEngulfRectangle.AxisX = NewFormChart.ChartAreas[0].AxisX;
                        bearEngulfRectangle.AxisY = NewFormChart.ChartAreas[0].AxisY;
                        bearEngulfRectangle.X = candlestickData[i].date.ToOADate();
                        // convert to double
                        bearEngulfRectangle.Y = Convert.ToDouble(candlestickData[i].high);
                        bearEngulfRectangle.AnchorX = candlestickData[i].date.ToOADate();
                        bearEngulfRectangle.AnchorY = Convert.ToDouble(candlestickData[i].high);
                        NewFormChart.Annotations.Add(bearEngulfRectangle);
                        Console.WriteLine("Bearish");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:", ex.Message);
                }


               
            }
        }



    }
}
