﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Square : Figure
    {
        public double Width { get; set; }

        public override double GetArea()
        {
            return Width * Width;
        }
    }
}
