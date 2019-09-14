using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_A_Farm
{
    class Pig : Animals
    {
        static Random W = new Random();
        public string food1 {get; set;}
        public string food2 { get; set; }

        public void JoinUs()
        {
            Console.WriteLine($"\nGrab some {food1} and {food2} and come join us");
        }
        public void Introduction()
        {
            Console.WriteLine("Whats up");
        }
            
        public void LeaderIntro()
        {
            Console.WriteLine($"\nHey, Im {name} and Im the leader of the pigs. All we do is \n{job} until " +
                "we're all big and then we dissapear somewhere. Sweet gig");
        }
        public int Eating()
        {
            int meals = W.Next(5, 15);
            int numberBurritos = 0;
            int  numberTacos = 0;
            int ouncesFiletMignon = 0;
            for(int i = 0; i < meals; i++ )
            {
                numberBurritos++;
                numberTacos++;
                ouncesFiletMignon += 10;
            }
            Console.WriteLine($"\nToday I had {numberBurritos} burritos, {numberTacos} tacos, and " +
                $"{ouncesFiletMignon} ounces of Filet Mignon.");
            return meals;
        }
        public int NumberWaterDrank(int meals)
        {

            int gallonsOfWater;
            return (meals >= 10) ? gallonsOfWater = 10 : gallonsOfWater = 5; 
        }
        public void Drinking()
        {
            int water = NumberWaterDrank(Eating());
            Console.WriteLine($"\nToday I drank {water} gallons of water.");
        }
        
    }
    
}
