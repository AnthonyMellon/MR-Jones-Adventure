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
            string[] MenuOptions = { "", "", "", ""};
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

        static void StartRoom()
        {
            Console.WriteLine("There are two doors infront of you");
            Console.WriteLine("Which door do you want to take?");
            Console.WriteLine("Left".PadRight(40) + "Right");
            Console.ReadLine();


        }

        static void Room1()
        {





        }

        static void Room2()
        {

        }


        static void Main()
        {
            MainMenu();
        }
    }
}
