using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
      int[,] shippingSpeedAssignment;

      //TODO:
      //multidimensional Array for shipping amounts
      //Quote calculations
      //export to text file

      public DeskQuote()
      {
         DeskStruct = new Desk();
      }


      private double getDeskPrice(int width, int depth,
         int nDrawers, Desk.DeskMaterial mat, int desks)
      {
         //Make the desk structure
         DeskStruct = new Desk(width, depth, nDrawers, mat);

         // Base price to add to
         double total = 200.0;

         //Add large-size cost
         // Desktop Surface Area > 1000 in(2) $1 per in(2)
         int area = DeskStruct.DeskWidth * DeskStruct.DeskDepth;
         if (area > 1000)
            total += area - 1000;

         // Add cost of surface material
         total += getSurfacePrice();

         // Add drawers cost
         total += DeskStruct.NumberOfDrawers * 50;

         // Add rush cost
         total += getRushPrice(desks, /*TODO: FIX ME */ 3 /* TODO: Get rid of this hardcode value. It's just here to compile */);

         // Calculate for number of desks
         total *= desks;

         return total;
      }

      private int getSurfacePrice()
      {
         switch (DeskStruct.Material)
         {
            case Desk.DeskMaterial.Laminate:
               return 100;
            case Desk.DeskMaterial.Oak:
               return 200;
            case Desk.DeskMaterial.Rosewood:
               return 300;
            case Desk.DeskMaterial.Veneer:
               return 125;
            case Desk.DeskMaterial.Pine:
               return 50;
            default:
               return 0;
         }
      }

      private int getRushPrice(int desks, int rushDays)
      {
         switch (rushDays)
         {
            // 3 day rush
            case 3:
               //Small number of desks
               if (desks < 1000)
                  return 60;
               //Medium number of desks
               else if (desks < 2000)
                  return 70;
               // High number of desks
               else
                  return 80;
            // 5 day rush
            case 5:
               if (desks < 1000)
                  return 40;
               else if (desks < 2000)
                  return 50;
               else
                  return 60;
            // 7 day rush
            case 7:
               if (desks < 1000)
                  return 30;
               else if (desks < 2000)
                  return 35;
               else
                  return 40;
            // No rush
            default:
               return 0;
         }
      }

      private void getRushPrice(string filePath)
      {
         // Immediately error out if the 
         if (!File.Exists(filePath))
         {
            throw new Exception("ERROR: Rush days configuration file does not exist.");
         }

         // Read in all the price points
         string[] prices = File.ReadAllLines(filePath);

         // Discover the size that should be used for our array
         // It is square root of 
         //int dimension = Math.Sqrt(prices.Length) - 1;

         // Initialize a 2-dimensional integer array
         // The NEW operator will populate this table of ints to 0
         int[,] shippingSpeedAssignment = new int[2,2];

         //for ()
      }
   }
}
