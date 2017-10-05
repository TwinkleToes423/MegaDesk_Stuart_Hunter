using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk__4_StuartPennington_HunterOakey
{
    struct Desk
    {
        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }
        public DeskMaterial Material { get; set; }
        public enum DeskMaterial
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }
    }
}
