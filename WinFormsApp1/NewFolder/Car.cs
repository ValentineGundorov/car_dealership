using System;

namespace WinFormsApp1.NewFolder
{
    [Serializable]
    public abstract class Car
    {
        private double price;                     // price
        private int id;                           // ID of deal

        protected Car() : this(0,0) {}            // default constructor
        protected Car(double newPrice,int newId)  // Constructor
        {
            this.price = newPrice;
            this.id = newId;
        }

        public double getPrice()                  // Getter of price
        {
            return this.price;
        }
        public int getId()                        // Getter of deal's ID
        {
            return this.id;
        }
        public void setPrice(double newPrice)     // Setter of price
        {
            if (newPrice >= 0)
            {
                this.price = newPrice;
            }
        }
        public void setId(int newId)              // Setter of deal's ID
        {
            if (newId >= 0)                       // Cheking of inavild ID number
            {
                this.id = newId;
            }
        }
    }
}
