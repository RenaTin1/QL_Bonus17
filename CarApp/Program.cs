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

            bool ContinueProgram = true;
            while (ContinueProgram == true) 
            {
                int NumOfCars;
                Car CarInfo = new Car();
                Console.WriteLine("Welcome to the Grand Circus Motors Admin Console");
                Console.WriteLine("How many cars are you entering?");
                NumOfCars=int.Parse(Console.ReadLine());
                Car[] GCMotors = new Car[NumOfCars];

                for (int i = 0; i < GCMotors.Length; i++)
                {
                    GCMotors[i] = new Car(); //creates a new object 
                }
                for (int i = 0; i < GCMotors.Length; i++)
                {

                    Console.WriteLine("Please enter the Make of the car:");
                    GCMotors[i].Make =Console.ReadLine();

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
                    Console.WriteLine($"{CarEntry.Make} \t{CarEntry.Model} \t{CarEntry.Year} \t{CarEntry.Price}");
                }

                string UserOption; //Continue program or exit?
                Console.WriteLine("Continue? (y/n)");
                UserOption = Console.ReadLine();

                if (UserOption == "N" || UserOption == "No" || UserOption == "no" || UserOption == "n"&& UserOption!="yes" || UserOption!= "y")
                {
                    ContinueProgram = false;
                    Console.WriteLine("Thank you, Goodbye.");
                }
                Console.ReadKey();

            }







        }
    }
}
