using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_A_Farm
{
    class Dragon : Animals
    {
        //"default constructor" with WriteLine.
        public Dragon()
        {
            Console.WriteLine("\nAre you really trying to talk to a dragon?");
        }
        public Dragon(string name, int age, string job, string hobby)
        {
            this.name = name;
            this.age = age;
            this.job = job;
            this.hobby = hobby;
        }
        //Just messing around with DateTime
        public void Introduction()
        {
            var timeNow = DateTime.Now;
            Console.WriteLine($"\nSorry about that other guy. He's always grumpy on {timeNow}." +
                $"\nMy name is {name}. I'm {age} years old. I'm here to {job} but I'd rather {hobby}");
        }
        public static double AskForATemperature()
        {
            Console.WriteLine("\nEnter a number for the temperature");
            double temperature = double.Parse(Console.ReadLine());
            return temperature;
        }
        public static int CelsiusOrFahrenheit()
        {

            Console.WriteLine("If that number is  celsius enter 'c', if fahrenheit enter 'f':  ");
            string type = Console.ReadLine();
            int n = 0;
            if (type == "c" || type == "C")
            {
                return n = 0;
            }
            else if (type == "f" || type == "F")
            {
                return n = 1;
            }
            else return n = 2;
        }
        public static void TemperatureConversion()
        {
            double temperature = AskForATemperature();
            int type = CelsiusOrFahrenheit();
            if (type == 0)
            {
                double convertedTemperature = (temperature * (9 / 5)) + 32;
                Console.WriteLine($"{temperature} celsius converted to fahrenheit is {convertedTemperature}");
            }
            else if (type == 1)
            {
                double convertedTemperature = (temperature - 32) * (5 / 9);
                Console.WriteLine($"{temperature} fahrenheit converted to celsius is {convertedTemperature}");
            }
            else if (type == 2)
            {
                Console.WriteLine("We can try this again");
                TemperatureConversion();
            }
            //Omitting the "else" may be bad practice but there should be no reason for there to be an else.
            
        }
        public void DragonSpecialSkill()
        {
            Console.WriteLine("\nI have a special skill that most people don't know about." +
                "\nI can convert any number from celcius to fahrenheit and fahrenheit to celcius");
            TemperatureConversion();
            Console.WriteLine("Im still working on learning kelvins");
        }
        

        
    }
}
              

