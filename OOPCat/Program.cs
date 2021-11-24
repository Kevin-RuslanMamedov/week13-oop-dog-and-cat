using System;

namespace OOPCat
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hungriness;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungriness = 0;
                Console.WriteLine($"The cat {name} has been created");

            }
            public string Name
            {
                get { return name; }
            }
            public string Color
            {
                get { return color; }
            }
            public double Hungriness
            {
                get { return hungriness; }
            }
            public void Sleep()
            {
                Console.WriteLine("*Sleeps*");
                Console.WriteLine("Hunger has been increased by 0,2");
                hungriness += 0.2;
            }
            public void Meows()
            {
                Console.WriteLine("Meoooooow");
            }

            static void Main(string[] args)
            {
                Cat myCat = new Cat("Kiisu", "Black");
               

                while (myCat.Hungriness != 1)
                {
                    myCat.Sleep();
                }
                myCat.Meows();
            }









        }
    }
}
