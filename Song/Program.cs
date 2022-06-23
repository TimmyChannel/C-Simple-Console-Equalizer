using System;
using System.Threading;

namespace Song
{
    class Program
    {
        delegate void method();
        static void Main(string[] args)
        {
            string[] items = {
                "MissionImpossible",
                "Fur Elise -- Beethoven",
                "Grasshoper", 
                "Happy Birthday", 
                "Jingle Bells", 
                "Mary Christmas", 
                "Star Wars Theme", 
                "Super Mario Classic Theme", 
                "Tannenbaum", 
                "Exit" };
            method[] methods = new method[] { 
                Songs.PlayMissionImpossible, 
                Songs.PlayBeethoven,
                Songs.PlayGrasshoper, 
                Songs.PlayHappyBirthday, 
                Songs.PlayJingle, 
                Songs.PlayMary, 
                Songs.PlayStarWars, 
                Songs.PlaySuperMario, 
                Songs.PlayTannenbaum, 
                Exit 
            };
            ConsoleMenu menu = new ConsoleMenu(items);
            int menuResult;
            do
            {
                menuResult = menu.PrintMenu();
                methods[menuResult]();
                Console.WriteLine("Press Any Key to Return");
                Console.ReadKey();
            } while (menuResult != items.Length - 1);
            
        }
        static void Exit()
        {
            Environment.Exit(0);
        }
    }
}

