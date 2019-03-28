﻿using System;
using System.Collections.Generic;
using System.Text;

namespace dot_net_motors.Classes
{
    // Concrete class
    class SubaruLegacy : StationWagon
    {
        public override decimal Price { get; set; } = 29000m;
        public override bool SunRoof { get; set; } = false;

        public override void Drive()
        {
            Console.WriteLine("Let's drive!");
        }

        public override string PlayRadio()
        {
            return "Subaru's got tunes";
        }
    }
}
