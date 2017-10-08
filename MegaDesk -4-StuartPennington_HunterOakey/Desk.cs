using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//test

namespace MegaDesk__4_StuartPennington_HunterOakey
{
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

        //properties 
        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DeskMaterial Material { get; set; }

      public Desk(int width, int depth,
       int nDrawers, Desk.DeskMaterial mat)
      {
         this.DeskWidth = width;
         this.DeskDepth = depth;
         this.NumberOfDrawers = nDrawers;
         this.Material = mat;
      }
   }
}
