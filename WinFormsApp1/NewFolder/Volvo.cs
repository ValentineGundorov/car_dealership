using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.NewFolder
{
    class Volvo : ElectricCars
    {
        private int weight; // Weight
        private int doors;  // Count of Doors in the car

        public Volvo(string color = "Black", int year = 2022, int newWeight = 2300, int door = 2,  int horsePower = 180) : base(newWeight * 100, 2000 + newWeight + door*10, newWeight/10, color, year)
        {
            setDoors(door);
            setWeight(newWeight);

            switch (color)  // Setting of deal's ID:
            {
                case "Black":
                    setId(2000 + newWeight + door * 10 + 1);
                    break;

                case "White":
                    setId(2000 + newWeight + door * 10 + 2);
                    break;

                case "Grey":
                    setId(2000 + newWeight + door * 10 + 3);
                    break;

                default:
                    break;
            }
        }

        public int getWeight()               // Getter of weight
        {
            return this.weight;
        }
        public void setWeight(int newWeight) // Setter of weight
        {
            if (newWeight > 0)
            {
                this.weight = newWeight;
            }
        }
        public int getDoors()                // Getter of count's doors
        {
            return this.doors;
        }
        public void setDoors(int newDoor)    // Setter of count's doors
        {
            if (newDoor > 0)
            {
                this.doors = newDoor;
            }
        }
        public override string ToString()    // function from (C#) for converting to string
        {
            return "Volvo" + " price: " + getPrice() + " id: " + getId() + " color: " + getColor() + " hp: " + getHorsePower() + " year: " + getYear() + " weight: " + getWeight() + " doors: " + getDoors();
            //"Volvo" + " Price: " + getPrice() + " Id: " + getId() + " Color: " + getColor() + " HP: " + getHorsePower() + " Year: " + getYear() + " Weight: " + getWeight() + " Doors: " + getDoors();
        }
    }
}
