using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace CarApp
{
    class UsedCar : Car
    {
       //Serena Tindle--- Bonus #17 (Car Details)

        //variables(class memebers)
      
        private double mileage;

                
        //Properties
        public double Mileage
        {
            set { mileage = value; }
            get { return mileage; }
        }

        //Constructors
        public UsedCar() //default constructor
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
            Mileage = 0;
        }
        public UsedCar(string CarMake, string CarModel, int CarYear, double CarPrice, double CarMileage) //constructor w/parameters
        {
            Make = CarMake; // class member and parameters 
            Model = CarModel;
            Year = CarYear;
            Price = CarPrice;
            Mileage = CarMileage;
        }



    }
}
