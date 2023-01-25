using System;
using System.Collections.Generic;
using System.Text;

namespace Class_constructor
{
    public class Building
    {
        public string name;
        public int height;
        public int area;
        public string address;


        public string GetVolume()
        {
            return $" {height*area} ";
        }

    }
}
