using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.NewFolder
{
    abstract class ElectricCars : Car
    {
        private int horsePower;         // HP of car
        private string color;           // Color of car
        private int year;               // Year of car's issue

        protected ElectricCars(double price, int id, int horsePower, string color, int newYear) : base(price, id) // Constructor
        {
            setHorsePower(horsePower);
            setColor(color);
            setYear(newYear);
        }
        protected ElectricCars(int horsePower = 0, string color = "Black", int year = 2022) // Constructor
        {
            setHorsePower(horsePower);
            setColor(color);
            setYear(year);
        }
        public int getHorsePower()      // Getter of HP
        {
            return this.horsePower;
        }
        public string getColor()        // Getter of car's color
        {
            return this.color;
        }
        public int getYear()            // Getter of car's issue
        {
            return this.year;
        }
        public void setHorsePower(int newHorsePower)
        {
            if (newHorsePower > 0)      // Cheking invalid value
            {
                this.horsePower = newHorsePower;
            }
        }
        public void setColor(string newColor)
        {
            if (!string.IsNullOrWhiteSpace(newColor)) // Cheking invalid string
            {
                this.color = newColor;
            }
        }
        public void setYear(int newYear)
        { 
            if (newYear > 2015 && newYear < 2023)     // Cheking invalid year 
            {
                this.year = newYear;
            }
        }

        public override string ToString()             // Function from (C#) for converting to string 
        {                                             // Override because we have our realization
            return "ElectricCar";
        }

    }
}
