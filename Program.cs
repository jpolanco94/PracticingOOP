using System;

namespace Creating_A_Farm
{
    class Program
    {
        static void DiningWithThePigs()
        {
            Console.WriteLine("\nPigs");
            Pig friendlypig = new Pig();
            friendlypig.food1 = "slop";
            friendlypig.food2 = "filet mignon";
            Pig johnny = new Pig();
            Pig dontae = new Pig();
            friendlypig.JoinUs();
            dontae.Introduction();
            johnny.name = "Johnny";
            johnny.job = "eat";
            johnny.LeaderIntro();
            friendlypig.Eating();
            friendlypig.Drinking();
        }
        static void LettingOutTheDogs()
        {
            Console.WriteLine("\nDogs");
            Dog amanda = new Dog("Amanda", 7);
            amanda.DogHobby();
            amanda.GoodBye();
            Dog joseph = new Dog("Joseph", 13, "run");
            joseph.Introduction();
            joseph.DogHobby();
            joseph.GoodBye();
        }
        static void VisitingTheDragons()
        {
            Console.WriteLine("\nDragons");
            Dragon sandy = new Dragon();
            sandy.AnnoyedDragon();
            Dragon jasmine = new Dragon();
            jasmine.name = "Jasmine";
            jasmine.age = 12;
            jasmine.job = "provide heat";
            jasmine.hobby = "battle the hero of a story";
            jasmine.Introduction();
            jasmine.DragonSpecialSkill();
        }
        static void BringingInTheCows()
        {
            Console.WriteLine("\nCows");
            Cow steve = new Cow();
            steve.name = "Steve";
            steve.age = 34;
            steve.job = "provide milk";
            steve.hobby = "play a mean drum solo";
            steve.Introduction();
            steve.GallonsOfMilk();
            steve.GrammarCow();
            Cow melissa = new Cow();
            melissa.name = "Melissa";
            melissa.age = 1;
            melissa.Introduction();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Creating_A_Farm.Program.Main()");
            BringingInTheCows();
            VisitingTheDragons();
            LettingOutTheDogs();
            DiningWithThePigs();

        }
    }
}
