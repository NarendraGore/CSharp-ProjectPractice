using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP
{
    internal class PropertyExample
    {
        private int width;

        public int Width { 
            get { return width; } 
            set { width = value; }
        }
    }
}
