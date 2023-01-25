using System;
using System.Collections.Generic;
using System.Text;

namespace Class_constructor
{
    public class Animal
    {

        public string name;
        public string breed;
        public string color;
        public int age;


        public string GetDetails()
        {
            return $"{name} {breed} {age} ";
        }
    }
}
