using System;

namespace OOPCat
{
    class Program
    {
        class Cat
        {
            public string name;
            public string color;
            public double hungryness;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungryness = 0;
                Console.WriteLine($"The cat {name} with {color} color scheme has been created.");
            }
            public string Name
            {
                get { return name; }
            }
            public string Color
            {
                get { return color; }
            }
            public void Sleeps()
            {
                Console.WriteLine("zz-zZ-ZZ");
                hungryness += 0.2;
            }
            public void Meows()
            {
                Console.WriteLine("meow - meow");

            }



        }
        static void Main(string[] args)
        {
            
            Cat myCat = new Cat("Kiisu", "green");
            while (myCat.hungryness != 1)
            {
                myCat.Sleeps();
            }
            myCat.Meows();
            Console.WriteLine($"Name of my cat: {myCat.Name}");
            Console.WriteLine($"Level of hungryness: {myCat.hungryness}");
            
        }
    }
}
