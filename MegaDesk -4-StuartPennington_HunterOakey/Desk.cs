using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//test

namespace MegaDesk__4_StuartPennington_HunterOakey
{
  
       /* //properties 
        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DeskMaterial Material { get; set; }

      /*public Desk(int width, int depth,
       int nDrawers, Desk.DeskMaterial mat)
      {
         this.DeskWidth = width;
         this.DeskDepth = depth;
         this.NumberOfDrawers = nDrawers;
         this.Material = mat;
      }*/

        struct Desk
        {

        //enums'
        public enum DeskMaterial
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }
        private int _width;
            private int _depth;
            private int _numberOfDrawers;
            private string _purchaserName;
            private string _orderType;
            private string _price;
            private DateTime _date;
            private DeskMaterial _surfaceMaterial;

            public int DeskWidth
            {
                get { return _width; }
                set { _width = value; }
            }

            public int DeskDepth
            {
                get { return _depth; }
                set { _depth = value; }
            }

            public int NumberOfDrawers
            {
                get { return _numberOfDrawers; }
                set { _numberOfDrawers = value; }
            }

            public string CustomerName
            {
                get { return _purchaserName; }
                set { _purchaserName = value; }
            }

            public string orderType
            {
                get { return _orderType; }
                set { _orderType = value; }
            }

            public string Shipping
            {
                get { return _price; }
                set { _price = value; }
            }

            public DateTime date
            {
                get { return _date; }
                set { _date = value; }
            }

            public DeskMaterial Material
            {
                get { return _surfaceMaterial; }
                set { _surfaceMaterial = value; }
            }
        }
    }

