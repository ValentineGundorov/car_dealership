using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.NewFolder
{
    class Tesla:ElectricCars
    {
        private double weight; // Weight


        public Tesla(string color = "Black", int year = 2022 ,double newWeight = 2100.5) : base((newWeight * 100), 200 + (int)newWeight, (int)(newWeight / 10), color, year) // Constructor
        {
            setWeight(newWeight);

            switch(color)      // Setting of deal's ID:
            {
                case "Black":
                    setId(200 + (int)newWeight + 1);
                    break;

                case "White":

                    setId(200 + (int)newWeight + 2);
                    break;

                case "Grey":
                    setId(200 + (int)newWeight + 3);
                    break;
                default:
                    break;
            }
        }

        public double getWeight()                 // Getter of weight
        {
            return this.weight;
        }
        public void setWeight(double newWeight)   // Setter of weight
        {
            if (newWeight >= 0)                   // Cheking invalid value
            {
                this.weight = newWeight;
            }
        }
        public override string ToString()         // function from (C#) for converting to string
        {
            return "Tesla" + " price: " + getPrice() + " id: " + getId() + " color: " + getColor() + " hp: " + getHorsePower() + " year: " + getYear() + " weight: " + getWeight();
            //"Tesla" + " Price: " + getPrice() + " Id: " + getId() + " Color: " + getColor() + " Hp: " + getHorsePower() + " Year: " + getYear() + " Weight: " + getWeight();
        }
    }
}
