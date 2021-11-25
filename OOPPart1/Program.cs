using System;

namespace OOPPart1
{
    class Program
    {
        class Dog
        {
            public string name;
            public int spots;
            public double happiness;

            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} with {spots} spots has been created.");
            }
            public string Name
            {
                get { return name; }
            }
            public int Spots
            {
                get { return spots; }
            }

            public void Barks()
            {
                Console.WriteLine("woof - woof");
                happiness += 0.2;
            }
            public void Waggs()
            {
                Console.WriteLine("wiggle - wiggle");

            }

            public void Rename(string newName)
            {
                name = newName;
            }

        }
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Uudo", 15);
            //myDog.happiness = 10;
            //myDog.name = "Marko Moistt";
            while (myDog.happiness != 1)
            {
                myDog.Barks();
            }
            myDog.Waggs();
            Console.WriteLine("Rename your dog");
            string userInput = Console.ReadLine();
            myDog.Rename(userInput);

            Console.WriteLine($"Name: {myDog.Name}");
            Console.WriteLine($"Level of happiness: {myDog.happiness}");
        }

        

    }
}
