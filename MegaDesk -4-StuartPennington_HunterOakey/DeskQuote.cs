﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace MegaDesk__4_StuartPennington_HunterOakey
{
   class DeskQuote
   {
      //enums
      public enum ShippingSpeed
      {
         Three_day, // >1000 = 30, <1000> = 35, <2000 = 40
         Five_day, // >1000 = 40, <1000> = 50, <2000 = 60
         Seven_day, // >1000 = 60, <1000> = 70, <2000 = 80
         Fourteen_day //no charge
      }

      //values
      const string SaveFilePath = "savedQuotes.json";
      const string RushPricesPath = "rushOrderPrices.txt";   // Path to the config file

      //properties
      public Desk DeskStruct { get; set; } //pass desk struct to this class
      public string CustomerName { get; set; }
      public DateTime QuoteDate { get; set; } // get date from the system
      public decimal QuoteAmount { get; set; } // this is where the calculations for the full PRICE quote save
      public ShippingSpeed Shipping { get; set; }

      //multi-dimensional array for SHIPPING SPEED PRICES
      private int[,] shippingSpeedAssignment { get; set; }

      //TODO:
      //multidimensional Array for shipping amounts   // Mostly complete. The file has not been added.
      //Quote calculations       // COMPLETE
      //export to text file      // COMPLETE

      public DeskQuote()
      {
         DeskStruct = new Desk();
      }


      public decimal getDeskPrice(Desk desk, int desks, ShippingSpeed days)
      {
         // Make the desk structure
         DeskStruct = desk;
         // Get our prices
         shippingSpeedAssignment = initRushPrices(RushPricesPath);

         // Base price to add to
         decimal total = 200.0M;

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
         total += getRushPrice(desks, days);

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

      private int getRushPrice(int desks, ShippingSpeed rushDays)
      {
         switch (rushDays)
         {
            // 3 day rush
            case ShippingSpeed.Three_day:
               //Small number of desks
               if (desks < 1000)
                  return shippingSpeedAssignment[0,0];
               //Medium number of desks
               else if (desks < 2000)
                  return shippingSpeedAssignment[0, 1];
               // High number of desks
               else
                  return shippingSpeedAssignment[0, 2];
            // 5 day rush
            case ShippingSpeed.Five_day:
               if (desks < 1000)
                  return shippingSpeedAssignment[1, 0];
               else if (desks < 2000)
                  return shippingSpeedAssignment[1, 1];
               else
                  return shippingSpeedAssignment[1, 2];
            // 7 day rush
            case ShippingSpeed.Seven_day:
               if (desks < 1000)
                  return shippingSpeedAssignment[2, 0];
               else if (desks < 2000)
                  return shippingSpeedAssignment[2, 1];
               else
                  return shippingSpeedAssignment[2, 2];
            // No rush
            default:
               return 0;
         }
      }
        public void writetoFile(Desk desk, DeskQuote quote)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;

            StreamWriter writer;
            writer = new StreamWriter("quotes.txt", append: true);
            writer.WriteLine("{0},{1},{2},{3},{4},{5},{6},${7}",
                quote.CustomerName,
                date,
                desk.DeskWidth.ToString(),
                desk.DeskDepth.ToString(),
                desk.NumberOfDrawers.ToString(),
                desk.Material,
                quote.Shipping,
                quote.QuoteAmount
                );
            writer.Close();

        }

        private int[,] initRushPrices(string filePath)
      {
         // Immediately error out if the file path does not exist. 
         if (!File.Exists(filePath))
         {
            throw new Exception("ERROR: Rush days configuration file does not exist.");
         }

         // Read in all the price points
         string[] prices = File.ReadAllLines(filePath);

         // Initialize a 2-dimensional integer array
         // The NEW operator will populate this table of ints to 0
         int[,] priceMatrix = new int[2, 2];

         // Keep track of which prices we've used
         int pricesCount = 0;
         // Populate the array, row first then column
         for (int row = 0; row < 2; row++)
         {
            for (int col = 0; col < 2; col++)
            {
               // Add the price to our 2D array
               priceMatrix[row, col] = Int32.Parse(prices[pricesCount++]);
            }
         }

         return priceMatrix;
      }

      public static void Save(DeskQuote quote)
      {
         // Make a container for our saved desks
         List<DeskQuote> quotes = new List<DeskQuote>();

         // If a save file already exists, read from and append to it
         if (File.Exists(SaveFilePath))
         {
            // Load all saves
            string savedQuotes = File.ReadAllText(SaveFilePath);

            // Deserialize the saved list of desks
            quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(savedQuotes);
         }

         // Add the current desk to the (possibly empty) list of desks
         quotes.Add(quote);

         // JSONify
         string JSONDesks = JsonConvert.SerializeObject(quotes);

         // Save our JSON
         File.WriteAllText(SaveFilePath, JSONDesks);
      }
   }
}
