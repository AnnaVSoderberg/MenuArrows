using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuArrows
{
    internal class MenuArrows
    {

        public static void menu()
        {
            //Function that crates Main menu for customer/user to choose from 
            string[] mainMenu = new string[] { "\tKonto", "\tÖverföring", "\tUttag", "\tAvsluta" };
            int menuSelected = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Gör ditt val med piltangenterna och tryck Enter för att välja\n");


                if (menuSelected == 0)
                {
                    Console.WriteLine("-->" + mainMenu[0]);
                    Console.WriteLine(mainMenu[1]);
                    Console.WriteLine(mainMenu[2]);
                    Console.WriteLine(mainMenu[3]);
                }
                else if (menuSelected == 1)
                {
                    Console.WriteLine(mainMenu[0]);
                    Console.WriteLine("-->" + mainMenu[1]);
                    Console.WriteLine(mainMenu[2]);
                    Console.WriteLine(mainMenu[3]);
                }
                else if (menuSelected == 2)
                {
                    Console.WriteLine(mainMenu[0]);
                    Console.WriteLine(mainMenu[1]);
                    Console.WriteLine("-->" + mainMenu[2]);
                    Console.WriteLine(mainMenu[3]);
                }
                else if (menuSelected == 3)
                {
                    Console.WriteLine(mainMenu[0]);
                    Console.WriteLine(mainMenu[1]);
                    Console.WriteLine(mainMenu[2]);
                    Console.WriteLine("-->" + mainMenu[3]);
                }

                var keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelected != mainMenu.Length - 1)
                {
                    menuSelected++;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelected >= 1)
                {
                    menuSelected--;
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    switch (menuSelected)
                    {
                        case 0:
                            Console.WriteLine("CASE 0");
                            break;

                        case 1:
                            Console.WriteLine("CASE 1");
                            break;

                        case 2:
                            Console.WriteLine("CASE 2");
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                    }
                    Console.ReadLine();
                }

            }
        }
    }
}
