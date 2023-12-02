using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace COP2513Project1
{
    public class candlestick///Creates and provides methods for candlestick objects
    {
        /// <summary>
        /// Below contains setters and getters for each attribute of a candlestick object
        /// </summary>
        public DateTime date { get; set; }/// Creates getter and setter for date. Also initializes variable
        public decimal open { get; set; }/// Creates getter and setter for open. Also initializes variable
        public decimal close { get; set; }/// Creates getter and setter for close. Also initializes variable
        public decimal high { get; set; }/// Creates getter and setter for high. Also initializes variable
        public decimal low { get; set; }/// Creates getter and setter for low. Also initializes variable
        public long volume { get; set; }/// Creates getter and setter for volume. Also initializes variable
        public decimal upperTail { get; set; }
        public decimal lowerTail { get; set; }
        public decimal range { get; set; }
        public decimal body { get; set; }
        public decimal upperShadow { get; set; }
        public decimal lowerShadow { get; set; }
        public decimal shadowLength { get; set; }




        public candlestick(DateTime date, decimal open, decimal close, decimal high, decimal low, long volume)///Candlestick object constructor 
        {
            this.date = date;
            this.open = open;
            this.close = close;
            this.high = high;
            this.low = low;
            this.volume = volume;
        }

        public void findAdvancedCandleStickData(candlestick candle)
        {
            upperTail = candle.high - Math.Max(candle.open, candle.close);
            lowerTail = Math.Min(candle.open, candle.close) - candle.low;
            body = Math.Abs(candle.open - candle.close);
            range = candle.high - candle.low;
            upperShadow = candle.high - Math.Max(candle.open, candle.close);
            lowerShadow = Math.Min(candle.open, candle.close) - candle.low;
            shadowLength = Math.Max(candle.high - candle.close, candle.open - candle.low);
        }

        public bool isCommonDoji(candlestick candle)//rewrite
        {
           
            if (body < shadowLength * 0.1m && shadowLength > body)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool isDragonFlyDoji(candlestick candle)
        {
            
            return (body <= 0.1m * (candle.high - candle.low)) && (upperShadow <= 0.1m * (candle.high - candle.low)) && (lowerShadow >= 2m * body);
        }
        
        public bool isGravestoneDoji(candlestick candle)
        {
            return (body <= 0.1m * (candle.high - candle.low)) && (lowerShadow <= 0.1m * (candle.high - candle.low)) && (upperShadow >= 2 * body);
        }
    

        public bool isLongLeggedDoji(candlestick candle)
        {
            return (body <= 0.1m * (high - low)) && (upperShadow >= 0.1m * (high - low)) && (lowerShadow >= 0.1m * (high - low));
        }

        public bool isWhiteMarubozu(candlestick candle)
        {
            return (close > open && upperShadow < 0.05m * (high - low) && lowerShadow < 0.05m * (high - low));
        }

        public bool isBlackMarubozu(candlestick candle)
        {
            return ((open > close && upperShadow < 0.05m * (high - low) && lowerShadow < 0.05m * (high - low)));
        }

        public bool isHammer(candlestick candle)
        {
            return (close > open && upperShadow >= 2m * body && lowerShadow <= 0.2m * body);
        }

        public bool isInvertedHammer(candlestick candle)
        {
            return (close < open && upperShadow >= 2m * body && lowerShadow <= 0.2m * body);
        }

        public bool isShootingStar(candlestick candle)
        { 
            return (open > close && upperShadow >= 2 * body && lowerShadow <= body / 2m);
        }

        public bool isSpinningTop(candlestick candle)
        {
            return (body <= shadowLength && body < 0.05m * (high - low));
        }

        public bool isHangingMan(candlestick candle)
        {
            return (open > close && lowerShadow >= 2 * body && upperShadow <= body / 2);
        }
    }
}