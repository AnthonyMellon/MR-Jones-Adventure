using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MrJonesAdventure
{
    public struct Stats
    {
        public int health;
        public string[] Inventory;
        public bool treasure;
    }    

    class Program
    {
        public static Stats playerInfo;

        static void MainMenu()
        {
            string[] menuOptions = { "New Game", "Load Game", "Quit" };
            bool menuLoop = true;
            ConsoleKeyInfo keyPressed;
            int selection = 0;
            while (menuLoop == true)
            {
                Console.WriteLine();
                Console.WriteLine("███╗   ███╗██████╗          ██╗ ██████╗ ███╗   ██╗███████╗███████╗     █████╗ ██████╗ ██╗   ██╗███████╗███╗   ██╗████████╗██╗   ██╗██████╗ ███████╗");
                Console.WriteLine("████╗ ████║██╔══██╗         ██║██╔═══██╗████╗  ██║██╔════╝██╔════╝    ██╔══██╗██╔══██╗██║   ██║██╔════╝████╗  ██║╚══██╔══╝██║   ██║██╔══██╗██╔════╝");
                Console.WriteLine("██╔████╔██║██████╔╝         ██║██║   ██║██╔██╗ ██║█████╗  ███████╗    ███████║██║  ██║██║   ██║█████╗  ██╔██╗ ██║   ██║   ██║   ██║██████╔╝█████╗  ");
                Console.WriteLine("██║╚██╔╝██║██╔══██╗    ██   ██║██║   ██║██║╚██╗██║██╔══╝  ╚════██║    ██╔══██║██║  ██║╚██╗ ██╔╝██╔══╝  ██║╚██╗██║   ██║   ██║   ██║██╔══██╗██╔══╝  ");
                Console.WriteLine("██║ ╚═╝ ██║██║  ██║    ╚█████╔╝╚██████╔╝██║ ╚████║███████╗███████║    ██║  ██║██████╔╝ ╚████╔╝ ███████╗██║ ╚████║   ██║   ╚██████╔╝██║  ██║███████╗");
                Console.WriteLine("╚═╝     ╚═╝╚═╝  ╚═╝     ╚════╝  ╚═════╝ ╚═╝  ╚═══╝╚══════╝╚══════╝    ╚═╝  ╚═╝╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚══════╝");
                Console.WriteLine("\n\n\n\n");
                for (int i = 0; i < menuOptions.Length; i++) //Write each menu option with the arrow pointer
                {
                    Console.Write("                                                                   ");
                    if (i == selection)
                    {
                        Console.Write("> ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine(menuOptions[i]);
                }
                keyPressed = Console.ReadKey();
                Console.Clear();
                if (keyPressed.Key == ConsoleKey.UpArrow)
                {
                    selection--;
                }
                else if (keyPressed.Key == ConsoleKey.DownArrow)
                {
                    selection++;
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    menuLoop = false;
                }

                selection = NumLoop(selection, 0, menuOptions.Length - 1);
            }
            if (selection == 0) //New Game
            {                
                Intro();
            }
            if (selection == 1) //Load Game
            {
                Intro();
            }
        }

        static void LoadPlayer(string loadFile)
        {
            StreamReader reader = new StreamReader(loadFile);   
        }
        static void PauseMenu()
        {
            Console.WriteLine("Your inventory currently contains the following items: ");
            for (int i = 0; i < playerInfo.Inventory.Length; i++)
            {
                Console.WriteLine($"1) {playerInfo.Inventory[i]}");
            }
            Console.WriteLine("Pause Menu");
        }

        static void InventoryMenu()
        {
            Console.WriteLine("Inventory Menu");
        }

        static void Player()
        {
            const int MAXHEALTH = 5;            
            playerInfo.health = MAXHEALTH;
            playerInfo.Inventory = new string[5];
            playerInfo.Inventory[0] = "Whip";
        }

        static void UI()
        {

        }

        static void Puzzle1()
        {

        }
        static void Puzzle2()
        {

        }

        static void Trap1()
        {

        }

        static void Trap2()
        {

        }

        static void StartRoom()
        {
            Console.WriteLine("There are two doors infront of you");
            Console.WriteLine("Which door do you want to take?");
            Console.WriteLine("North".PadRight(40) + "East");           
            bool loop = true;
            string temp;

            while (loop == true)
            {
                temp = Console.ReadLine().ToLower();
                if (temp == "north")
                {
                    Room1();
                    loop = false;
                }
                else if (temp == "east")
                {
                    Room2();
                    loop = false;
                }
                else
                {
                    Console.WriteLine("insert North or East");
                }
            }                   
        }

        static void Room1()
        {
            Console.WriteLine("You enter the room that has 1 door which is locked.");
            Console.WriteLine("To unlock the door you must complete the puzzle.");
            Puzzle1();
            





        }

        static void Room2()
        {
            Console.WriteLine("");
        }

        static void Room3()
        {
            Console.WriteLine("You enter the room and there are two more doors, one to the North and one to the East");
            Console.WriteLine("Which door would you like to take?");
            Console.WriteLine("North".PadRight(40) + "East".PadRight(40) + "South");
            string temp = Console.ReadLine().ToLower();
            bool loop = true;

            while (loop == true)
            {
                switch (temp)
                {
                    case "north":
                        Room5();
                        loop = false;
                        break;

                    case "east":
                        Room16();
                        loop = false;
                        break;

                    case "south":
                        Room1();
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("You didnt pick any of the doors");
                        break;
                }
            }


            


        }


        static void Room4()
        {

        }

        static void Room5()
        {

        }

        static void Room16()
        {

        }

        static void Intro()
        {
            Console.WriteLine("Welcome to Mr Jones Adventure");
            Console.WriteLine("This is a text based adventure game, you will be given options on screen to choose from such as solving puzzles or avoiding traps");
            Console.WriteLine("Your goal is to find treasure within the tomb and escape without dying");
            Console.WriteLine();
            Console.WriteLine("Are you ready to begin");
            Console.WriteLine("Yes".PadRight(20) + "No");
            bool loop = true;
            string temp;
            while (loop == true)
            {
                temp = Console.ReadLine().ToLower();
                if (temp == "yes")
                {
                    StartRoom();
                    loop = false;
                }
                else if (temp == "no")
                {
                    MainMenu();
                    loop = false;
                }
                else
                {
                    loop = true;
                    Console.WriteLine("I think you may have trouble with this game. Please enter Yes or No");

                }
            }
        }

        static int NumLoop(int input, int min, int max)
        {
            if (input > max)
            {
                input = min;
            }
            else if (input < min)
            {
                input = max;
            }
            return input;
        }


        static void Main()
        {
            //Console.SetWindowSize(172, 41);
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetWindowPosition(Console.WindowLeft, Console.WindowTop);
            Console.CursorVisible = false;            
            MainMenu();
        }
    }
}
