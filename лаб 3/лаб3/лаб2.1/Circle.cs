﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Circle : Figure
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Radius * Radius * 3.14;
        }
    }
}
