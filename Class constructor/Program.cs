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







            var Building1 = new Building();
            Building1.name = "Trump";
            Building1.height = 155;
            Building1.area = 450;
            Building1.address = "city Baku";
            Console.WriteLine(Building1.GetVolume());




            var Building2 = new Building();
            Building2.name = "Messenat";
            Building2.height = 50;
            Building2.area = 40;
            Building2.address = "city Baku";
            Console.WriteLine(Building2.GetVolume());















        }
    }
}
