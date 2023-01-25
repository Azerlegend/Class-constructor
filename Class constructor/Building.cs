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
          

        public Building(string name,int height,int area)
        {
            this.name = name;
            this.height = height;
            this.area = area;
        }


        public string GetVolume()
        {
            return $" {height*area} ";
        }

    }
}
