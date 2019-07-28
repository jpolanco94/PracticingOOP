using System;

namespace Creating_A_Farm
{
    class Program
    {
        static void DiningWithThePigs()
        {
            Console.WriteLine("\nPigs");
            Pig tooBusyEating = new Pig();
            Pig friendlypig = new Pig("Sloppy Joe", "Ranch Dressing");
            friendlypig.JoinUs();
            Pig johnny = new Pig("Johnny", "eat", "sleep");
            Pig dontae = new Pig("Johnny", "eat", "eat");
            dontae.Introduction();
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
            Dragon jasmine = new Dragon("Jasmine", 12, "protect gold", "fight the hero of a story");
            jasmine.Introduction();
            jasmine.DragonSpecialSkill();
        }
        static void BringingInTheCows()
        {
            Console.WriteLine("\nCows");
            Cow steve = new Cow("Steve", 34, "provide milk", "sleep and eat");
            steve.Introduction();
            steve.GallonsOfMilk();
            steve.GrammarCow();
            Cow melissa = new Cow("Melissa", 1);
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
