using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.NewFolder
{
    class Charger : Car
    {
        private int cable;                     // Cable
        //private static int powerStation = 0;   // Count of power stations for one car

        public Charger(int newCable = 2)       // Constructor
        {
            setCable(newCable);
            setPrice(newCable * 1000);         // Cable's count * 1000 = price
            setId(500 + newCable);

            //powerStation++;
        }

        /*public static int PowerStation         // Getter of power station
        {
            get
            {
                return powerStation;
            }
        }*/

        public int getCable()                  // Getter of cable
        {
            return this.cable;
        }
        public void setCable(int newCable)     // Setter of cable
        {
            if (newCable > 0)
            {
                this.cable = newCable;
            }
        }
        public override string ToString() // function from (C#) for converting to string
        {
            return "Charger" + " price: " + getPrice() + " id: " + getId() + " amount: " + getCable();
            //"Charger" + " Price: " + getPrice() + " Id: " + getId() + " Cable: " + getCable();

        }
    }
}
