using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serena Tindle--- Bonus #17 (Car Details)

            bool ContinueProgram = true;
            while (ContinueProgram == true)
            {
                Car Car1 = new Car("Ford", "Taurus", "2017", "30000");
                Car Car2 = new Car("Chevy", "Cruze", "2017", "20000");
                Car Car3 = new Car("Kia", "Optima", "2017", "40000");
                UsedCar Used1 = new UsedCar("Toyota", "Camry", "1999", "3000(used)", "50,700");
                UsedCar Used2 = new UsedCar("Ford", "Focus", "2001", "4200(used)", "44,800");
                UsedCar Used3 = new UsedCar("Pontiac", "Sunfire", "1996", "1200(used)", "90,960");

                Car[] CarInventory = new Car[6];
                CarInventory[0] = Car1;
                CarInventory[1] = Car2;
                CarInventory[2] = Car2;
                CarInventory[3] = Used1;
                CarInventory[4] = Used1;
                CarInventory[5] = Used1;

                for (int i = 0; i < CarInventory.Length; i++)
                {
                    CarInventory[i].PrintInfo();        
                }

                Console.WriteLine("Which car would you like?");
                int.Parse(Console.ReadLine());
                

                string UserOption; //Continue program or exit?
                Console.WriteLine("Continue? (y/n)");
                UserOption = Console.ReadLine();

                if (UserOption == "N" || UserOption == "No" || UserOption == "no" || UserOption == "n" && UserOption != "yes" || UserOption != "y+")
                {
                    ContinueProgram = false;
                    Console.WriteLine("Thank you, Goodbye.");
                }


                Console.ReadKey();
            }

        }


        public static double ReadValidDouble() //method for validation 
        {
            double.Parse(Console.ReadLine());
            double input = 0;

            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter valid data");
            }
            return input;


        }

        public static int ReadValidInt() //method for validation 
        {
            int.Parse(Console.ReadLine());
            int input = 0;

            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter valid data");
            }
            return input;


        }
    }
}
