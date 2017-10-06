using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk__4_StuartPennington_HunterOakey
{
   public partial class AddQuote : Form
   {   //saves instance of previous form
      private Form _mainMenu;

      public AddQuote(Form mainMenu)
      {
         InitializeComponent();
         _mainMenu = mainMenu;
      }

      private void AddQuote_Load(object sender, EventArgs e)
      {

      }

      private void goBackFromAddQuote_Click(object sender, EventArgs e)
      {
         _mainMenu.Show();
         this.Close();
      }


      private void generateDeskQuoteButton_Click(object sender, EventArgs e)
      {
         Desk desk = new Desk();

         desk.DeskWidth = Convert.ToInt32(widthInputBox.Text);
         desk.DeskDepth = Convert.ToInt32(depthInputBox.Text);
         desk.NumberOfDrawers = Convert.ToInt32(drawerNumberInputForm.Text);

         switch (materialInputBox.Text)
         {
            case "Pine":
               desk.Material = Desk.DeskMaterial.Pine;
               break;
            case "Rosewood":
               desk.Material = Desk.DeskMaterial.Rosewood;
               break;
            case "Oak":
               desk.Material = Desk.DeskMaterial.Oak;
               break;
            case "Laminate":
               desk.Material = Desk.DeskMaterial.Laminate;
               break;
            case "Veneer":
               desk.Material = Desk.DeskMaterial.Veneer;
               break;
         }

         DeskQuote quote = new DeskQuote();

         quote.CustomerName = customerNameBox.Text;
         quote.QuoteDate = DateTime.Today;
         quote.QuoteAmount = 0.0m; //DeskQuoteOutput();//result of calculations //TODO: Make this function
         quote.DeskStruct = desk;

         switch (shippingInputBox.SelectedValue.ToString())
         {
            case "Three Day":
               quote.Shipping = DeskQuote.ShippingSpeed.Three_day;
               break;
            case "Five Day":
               quote.Shipping = DeskQuote.ShippingSpeed.Five_day;
               break;
            case "Seven Day":
               quote.Shipping = DeskQuote.ShippingSpeed.Seven_day;
               break;
            default:
               quote.Shipping = DeskQuote.ShippingSpeed.Fourteen_day;
               break;
         }
         //calculations done here. 
         int calculateDeskArea = desk.DeskWidth * desk.DeskDepth;

      }
      //calls instance of saved form in variable above. 
      private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
      {
         _mainMenu.Show();
      }
   }
}
