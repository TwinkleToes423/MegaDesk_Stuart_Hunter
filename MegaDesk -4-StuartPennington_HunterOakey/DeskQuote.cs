using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk__4_StuartPennington_HunterOakey
{
    class DeskQuote
    {
         public Desk DeskStruct { get; set; }
         public string CustomerName { get; set; }
         public DateTime QuoteDate { get; set; }
         public decimal QuoteAmount { get; set; }
         public DeskDrawers Drawers { get; set; }
         public enum DeskDrawers
        {
            Three_day, // >1000 = 30, <1000> = 35, <2000 = 40
            Five_day, // >1000 = 40, <1000> = 50, <2000 = 60
            Seven_day, // >1000 = 60, <1000> = 70, <2000 = 80
            Fourteen_day //no charge
        }

        //TODO:
        //multidimensional Array for shipping amounts
        //Quote calculations
        //export to text file
        //
    }
}
