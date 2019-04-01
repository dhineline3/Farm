using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Farm
    {

        public static void Main()
        {
            Cat myCat = new Cat();
            Rabbit myRabbit = new Rabbit();
            Duck myDuck = new Duck();
            Horse myHorse = new Horse();
            Pig myPig = new Pig();

            string name = "";
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("Which animal would you like to select?\n" +
                    "1. Cats\n" +
                    "2. Rabbits\n" +
                    "3. Ducks\n" +
                    "4. Horses\n" +
                    "5. Pigs\n" +
                    "6. Quit\n");
                Console.Write("My option is: ");
                name = Console.ReadLine();
                

                switch (name)
                {
                    case "1":
                        Console.Clear();
                        myCat.Speak();
                        myCat.Eat();
                        myCat.Product();
                        myCat.Famous();
                        check = false;
                        break;

                    case "2":
                        Console.Clear();
                        myRabbit.Speak();
                        myRabbit.Eat();
                        myRabbit.Product();
                        myRabbit.Famous();
                        check = false;
                        break;

                    case "3":
                        Console.Clear();
                        myDuck.Speak();
                        myDuck.Eat();
                        myDuck.Product();
                        myDuck.Famous();
                        check = false;
                        break;

                    case "4":
                        Console.Clear();
                        myHorse.Speak();
                        myHorse.Eat();
                        myHorse.Product();
                        myHorse.Famous();
                        check = false;
                        break;

                    case "5":
                        Console.Clear();
                        myPig.Speak();
                        myPig.Eat();
                        myPig.Product();
                        myPig.Famous();
                        check = false;
                        break;

                    case "6":
                        Console.WriteLine("Thanks for playing.");
                        Console.ReadLine();
                        check = true;
                        break;

                    default:
                        Console.WriteLine("Please choose a valid option.");
                        check = false;
                        break;
                  

                }
            }
        }
    }
    public class Cat
    {
        public void Speak()
        {
            Console.WriteLine("Hello, my name is Hobbes and I am a cat. I say meow.");
        }
        public void Eat()
        {
            Console.WriteLine("Hello, my name is Hobbes and I am a cat. I eat tuna.");
        }
        public void Product()
        {
            Console.WriteLine("Hello, my name is Hobbes and I am a cat. I kill mice.");
        }
        public void Famous()
        {
            Console.WriteLine("Hello, my name is Hobbes and I am a cat. I am named after the famous character in the comic book Calvin and Hobbes!\n");
        }
    }
    public class Rabbit
    {
        public void Speak()
        {
            Console.WriteLine("Hello, my name is Bugs Bunny and I am a rabbit. I say 'What's up doc?'");
        }
        public void Eat()
        {
            Console.WriteLine("Hello, my name is Bugs Bunny and I am a rabbit. I eat carrots.");
        }
        public void Product()
        {
            Console.WriteLine("Hello, my name is Bugs Bunny and I am a rabbit. I dig holes and pick on ducks.");
        }
        public void Famous()
        {
            Console.WriteLine("Hello, my name is Bugs Bunny and I am a rabbit. I am named after the famous Bugs Bunny from Looney Tunes!\n");
        }
    }
    public class Duck
    {
        public void Speak()
        {
            Console.WriteLine("Hello, my name is Daffy and I am a duck. I say quack.");
        }
        public void Eat()
        {
            Console.WriteLine("Hello, my name is Daffy and I am a duck. I eat grass.");
        }
        public void Product()
        {
            Console.WriteLine("Hello, my name is Daffy and I am a duck. I hate Bugs Bunny and I hunt aliens in my spare time");
        }
        public void Famous()
        {
            Console.WriteLine("Hello, my name is Daffy and I am a duck. I am named after the famous duck in Looney Tunes!\n");
        }
    }
    public class Horse
    {
        public void Speak()
        {
            Console.WriteLine("Hello, my name is Bucephalus and I am a horse. I say neigh.");
        }
        public void Eat()
        {
            Console.WriteLine("Hello, my name is Bucephalus and I am a horse. I eat hay.");
        }
        public void Product()
        {
            Console.WriteLine("Hello, my name is Bucephalus and I am a horse. I provide transportation for one of the greatest leaders of all time!");
        }
        public void Famous()
        {
            Console.WriteLine("Hello, my name is Bucephalus and I am a horse. I am named after the steed of Alexander the Great\n");
        }
    }
    public class Pig
    {
        public void Speak()
        {
            Console.WriteLine("Hello, my name is Porky and I am a pig. I say oink.");
        }
        public void Eat()
        {
            Console.WriteLine("Hello, my name is Porky and I am a pig. I eat anything honestly.");
        }
        public void Product()
        {
            Console.WriteLine("Hello, my name is Porky and I am a pig. I end every episode in Looney Tunes!");
        }
        public void Famous()
        {
            Console.WriteLine("Hello, my name is Porky and I am a pig. I am named after the famous pig in Looney Tunes!\n");
        }
    }

}
