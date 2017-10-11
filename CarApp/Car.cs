using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Car
    {
        //Serena Tindle--- Bonus #17 (Car Details)

        //variables(class memebers)
        private string make;
        private string model;
        private int year;
        private double price;

        //Method  (not included in the main)
       public void CarDetails()
        {
            Console.WriteLine("Please enter the Make of the car:");
            Console.ReadLine();
            Console.WriteLine("Please enter the Model of the car:");
            Console.ReadLine();
            Console.WriteLine("Please enter the Year of the car:");
            int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Price of the car:");
            double.Parse(Console.ReadLine());
        }
        
       //Properties
       public string Make
        {
            set { make = value; }
            get { return make; }
        }

       public string Model
        {
            set { model = value; }
            get { return model; }
        }
        
       public int Year
        {
            set { year = value; }
            get { return year; }
        }

       public double Price
        {
            set { price = value; }
            get { return price; }
        }

       //Constructors
       public Car() //default constructor
        {
            make = "";
            model = "";
            year = 0;
            price = 0;
        }
       public Car(string CarMake, string CarModel, int CarYear, double CarPrice) //constructor w/parameters
        {
            make = CarMake; // class member and parameters 

            model = CarModel;
            year = CarYear;
            price = CarPrice;
        }





    }
}
