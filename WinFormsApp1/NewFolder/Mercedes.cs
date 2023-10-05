using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.NewFolder
{
    class Mercedes:ElectricCars
    {
        private int weight;    // Weight of car
        private int maxSpeed;  // Max speed of car

        public Mercedes(string color = "Black", int year = 2022 , int newWeight = 2000, int newMaxSpeed = 320):  // Constructor
            base(newWeight * newMaxSpeed, 100 + newWeight, 440, color, year)
        {
            setMaxSpeed(newMaxSpeed);
            setWeight(newWeight);

            switch (color)     // Setting of deal's ID:
            {
                case "Black":
                    setId(100 + newMaxSpeed + 1);
                    break;
                case "White":
                    setId(100 + newMaxSpeed + 2);
                    break;
                case "Grey":
                    setId(100 + newMaxSpeed + 3);
                    break;
                default:
                    break;
            }
        }

        public int getWeight()                // Getter of Weight
        {
            return this.weight;
        }
        public void setWeight(int newWeight)  // Setter of Weight
        {
            if (newWeight > 0)                // Checking invalid value
            {
                this.weight = newWeight;
            }
        }
        public int getMaxSpeed()              // Getter of max speed
        {
            return this.maxSpeed;
        }
        public void setMaxSpeed(int newMaxSpeed) // Setter of Weight
        {
            if (newMaxSpeed > 0)                 // Cheking invalid value
            {
                this.maxSpeed = newMaxSpeed;
            }
        }

        public override string ToString()        // function from (C#) for converting to string
        {
            return "Merc" + " price: " + getPrice() + " id: " + getId() + " color: " + getColor() + " hp: " + getHorsePower() + " year: " + getYear() + " weight: " + getWeight() + " maxSpeed: " + getMaxSpeed();
            //"Merc" + " Price: " + getPrice() + " Id: " + getId() + " Color: " + getColor() + " Hp: " + getHorsePower() + " Year: " + getYear() + " Weight: " + getWeight() + " MaxSpeed: " + getMaxSpeed();
        }
    }
}
