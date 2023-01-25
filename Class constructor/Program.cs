using System;

namespace Class_constructor
{
    class Pet
    {
        static void Main(string[] args)
        {
            //var Animal1 = new Animal();
            //Animal1.name = "Giraffe";
            //Animal1.breed = "male";
            //Animal1.color = "standart Giraffe color";
            //Animal1.age = 12;
            //Console.WriteLine(Animal1.GetDetails());

            //var Animal2 = new Animal();
            //Animal2.name = "Dog";
            //Animal2.breed = "male";
            //Animal2.color = "white";
            //Animal2.age = 2;
            //Console.WriteLine(Animal2.GetDetails());







            var Building1 = new Building("Trump",155,450);
            
            Console.WriteLine(Building1.GetVolume());




            var Building2 = new Building("Messenat",50,40);
            
            Console.WriteLine(Building2.GetVolume());















        }
    }
}
