using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_A_Farm
{
    public class Dog : Animals
    {
        static Random R = new Random();
        double tailWagsPerSecond;
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine($"\nI'm {name} and I'm {age} years old.");
        }
        public Dog(string name, int age,string job)
        {
            this.name = name;
            this.age = age;
            this.job = job;
        }
        public void Introduction()
        {
            Console.WriteLine($"\nHello, I am {name}. I am {age} years old and I {job}" +
                "\nEveryone loves me!");
        }
        public double TailWags(double maxTailWags)
        {
            double tailwagsPerSecond = maxTailWags / 86400;
            return tailwagsPerSecond;
        }
        public void DogHobby()
        {
            Console.WriteLine("\nI like to wag my tail because I'm always happy");
            double tailWagsPerSecond = TailWags(R.Next(70000));
            double wagsADay = tailWagsPerSecond * 86400;
            Console.WriteLine($"\nIf I wag my tail {wagsADay} times a day that means I wagged my tail " +
                $"\n{tailWagsPerSecond} times per second.");

        }
        public void GoodBye()
        {
            Console.WriteLine("Thanks for visitng");
        }
    }
}
