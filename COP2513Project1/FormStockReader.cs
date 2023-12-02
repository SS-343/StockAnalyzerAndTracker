using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace COP2513Project1
{
    public class FormStockReader ///Reads data from file and creates a list of candlestick objects from a csv file
    {
        public String ticker;
        public String period;
        public DateTime startDate;
        public DateTime endDate;
        public String fileName;

        const string dataFolder = "Stock Data";/// location of stock data
        public List<candlestick> listOfCandlesticks = null;

        public List<candlestick> findStockCSV(String ticker, String filename, DateTime startDate, DateTime endDate) {///Finds csv file depending on user input
        string filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            ///String fileName = filePath +"/Stock Data/"+ ticker + "-" + period + ".csv"; ///Locates csv files in the debug folder < old filename 
        fileName = filePath + "/Stock Data/" + filename;
            

            return readInCandlesticks(fileName,startDate, endDate);///returns candlestick list to Form1

        }


        public FormStockReader()///Default constuctor that limits number of candlesticks
        { 
            listOfCandlesticks = new List<candlestick>(256);
        }

        
        public List<candlestick> readInCandlesticks(String filename, DateTime startDate, DateTime endDate) ///Read data and output to list via candlestick notation
        {
            char[] seperators = new char[] { '-', ',', '"' };
            String[] lines = System.IO.File.ReadAllLines(filename);

            String header = lines[0];
            Console.WriteLine(header);
            if (header == "Date,Open,High,Low,Close,Adj Close,Volume")
            {
                //"Date,Open,High,Low,Close,Adj Close,Volume" - "\"Date\",\"Open\",\"High\",\"Low\",\"Close\",\"Adj Close\",\"Volume\""
                Console.WriteLine("File is here");
                listOfCandlesticks = new List<candlestick>(lines.Length - 1);
                
                for (int l = 1; l < lines.Length; ++l)///Skips header when reading line by line
                {
                    String line = lines[l].Trim();
                    String[] subStrings = line.Split(seperators, StringSplitOptions.RemoveEmptyEntries); /// split it base on ,-"

                    int year = int.Parse(subStrings[0]);
                    int month = int.Parse(subStrings[1]);
                    int day = int.Parse(subStrings[2]);
                    
                    DateTime date = new DateTime(year, month, day);///Builds a date object from parsed csv data


                    if (date.CompareTo(startDate) >= 0 && date.CompareTo(endDate) <= 0)///Only retrives data if in range
                    {
                        Decimal open = Decimal.Parse(subStrings[3]);
                        Decimal high = Decimal.Parse(subStrings[4]);
                        Decimal low = Decimal.Parse(subStrings[5]);
                        Decimal close = Decimal.Parse(subStrings[6]);
                        long volume = long.Parse(subStrings[8]);
                        
                        /// Rounds to 2 decimal places 
                        open = Math.Round(open, 2);
                        high = Math.Round(high, 2);
                        low = Math.Round(low, 2);
                        close = Math.Round(close, 2);
                        
                        candlestick candleSticky = new candlestick(date, open, close, high, low, volume);///Creates candlestick object for each iteration
                        listOfCandlesticks.Add(candleSticky);///Adds new object to list
                    }
                }
            }

            
            return listOfCandlesticks;///returns list of candlestick objects to findStockCSV method return statemenet
        }
        
    }
}
