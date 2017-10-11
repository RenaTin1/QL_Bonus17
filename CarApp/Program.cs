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
                int NumOfCars;
                Car CarInfo = new Car();//create new object
                Console.WriteLine("Welcome to the Grand Circus Motors Admin Console"); //user prompt
                Console.WriteLine("How many cars are you entering?");
                NumOfCars = int.Parse(Console.ReadLine());
                ReadValidInt(); //convert user input
                
                Car[] GCMotors = new Car[NumOfCars]; //create an array using info provided by user

                for (int i = 0; i < GCMotors.Length; i++) //For Loop creates objects to fill in array based on user input length
                {
                    GCMotors[i] = new Car(); //creation of the new objects
                }

                for (int i = 0; i < GCMotors.Length; i++) //User fills in array objects with input(data)
                {
                    Console.WriteLine("Please enter the Make of the car:");
                    GCMotors[i].Make = Console.ReadLine();

                    Console.WriteLine("Please enter the Model of the car:");
                    GCMotors[i].Model = Console.ReadLine();

                    Console.WriteLine("Please enter the Year of the car:");
                    GCMotors[i].Year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter the Price of the car:");
                    GCMotors[i].Price = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("Current Inventory:");
                Console.WriteLine("Make \tModel \tYear \tPrice");
                foreach (Car CarEntry in GCMotors)
                {
                    Console.WriteLine($"{CarEntry.Make.PadRight(8, ' ')} \t{CarEntry.Model.PadRight(8, ' ')} \t{CarEntry.Year.ToString().PadRight(8, ' ')} \t{CarEntry.Price.ToString().PadRight(8, ' ')}"); //retrieving values 
                }

                string UserOption; //Continue program or exit?
                Console.WriteLine("Continue? (y/n)");
                UserOption = Console.ReadLine();

                if (UserOption == "N" || UserOption == "No" || UserOption == "no" || UserOption == "n" && UserOption != "yes" || UserOption != "y")
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
