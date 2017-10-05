using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk__4_StuartPennington_HunterOakey
{
    class DeskQuote
    {
        //enums'
        public enum ShippingSpeed
        {
            Three_day, // >1000 = 30, <1000> = 35, <2000 = 40
            Five_day, // >1000 = 40, <1000> = 50, <2000 = 60
            Seven_day, // >1000 = 60, <1000> = 70, <2000 = 80
            Fourteen_day //no charge
        }

        //properties
         public Desk DeskStruct { get; set; } //pass desk struct to this class
         public string CustomerName { get; set; } 
         public DateTime QuoteDate { get; set; } // get date from the system
         public decimal QuoteAmount { get; set; } // this is where the calculations for the full PRICE quote save
         public ShippingSpeed Shipping { get; set; }

        //multi-dimensional array for SHIPPING SPEED PRICES
        int[,] shippingSpeedAssignment = new int[,]
            { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };

        //TODO:
        //multidimensional Array for shipping amounts
        //Quote calculations
        //export to text file
    }
}
