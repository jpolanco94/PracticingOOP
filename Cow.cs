using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_A_Farm
{
    class Cow : Animals
    {
        //First constructor for Cow
        public Cow(string name, int age, string job, string hobby)
        {
            this.name = name;
            this.age = age;
            this.job = job;
            this.hobby = hobby;
        }
        //Second constructor for Cow
        public Cow(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //Introduction method that gives you proper grammer dependendant on age
        public void Introduction()
        {
            if (age > 1)
            {
                Console.WriteLine($"\nHello, my name is {name}, and I am {age} years old." +
                $"\nI {job} on the farm but I'd rather {hobby} all day.");
            }
            else
            {
                Console.WriteLine($"\nHello, my name is {name}, and I am {age} year old." +
                $"\nI'm too young to do anything. I shouldn't even be talking.");
            }
        }
        //Just some basic practice with writing enumerations
        public void GallonsOfMilk ()
        {
            Console.WriteLine($"\nOn Friday I provided {(int)WeekDays.Friday} gallons of milk");
            Console.WriteLine($"\nOn Saturday I provided {(int)WeekDays.Saturday} gallons of milk" +
                $"\nThat means I drank them instead.");
        }
        public static string AskAQuestion()
        {
            Console.Write("Whats your name:  ");
            string r = Console.ReadLine();
            return r;
            
        }
        static void FirstLetterUpper()
        {
            string yourName = AskAQuestion();
            //char firstLetter = yourName[0];
            if (char.IsLower(yourName[0]))
            {
                string properName = Char.ToUpper(yourName[0]) + yourName.Substring(1);
                Console.WriteLine("You really should capitlize the first letter of your own name" +
                    "\nGuess I'll do it for you");
                Console.WriteLine(properName);
            }
            else Console.WriteLine("Thank you for writing your name properly");
        }
        public void GrammarCow()
        {
            //AskAQuestion();
            FirstLetterUpper();
            Console.WriteLine("Thanks for visitng us");
        }
    }
}

