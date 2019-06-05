using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static void MainMenu()
        {
            string[] menuOptions = { "Play", "Settings", "Quit"};
            bool menuLoop = true;
            ConsoleKeyInfo keyPressed;
            int selection = 0;
            while (menuLoop == true)
            {
                Console.Clear();
                for (int i = 0; i < menuOptions.Length; i++) //Write each menu option with the arrow pointer
                {
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
                if (selection == 0)
                {
                    StartRoom();
                }
                else if (selection == 1)
                {
                    Settings();
                }
            }
        }
        static void Settings()
        {

        }

        static void PauseMenu()
        {

        }

        static void InventoryMenu()
        {

        }

        static void Player()
        {
            const int MAXHEALTH = 5;
            Stats playerInfo;
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

        static void Room1()
        {

        }

        static void Room2()
        {

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
            MainMenu();
        }
    }
}
