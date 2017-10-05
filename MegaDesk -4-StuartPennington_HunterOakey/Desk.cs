﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //TODO:
        //CREATE CONSTRUCTOR
    }
}
