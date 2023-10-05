using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp1.Data;
using WinFormsApp1.NewFolder;

namespace WinFormsApp1
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)    // EXIT TO START MENU
        {
            if(Storage.Cart.Count > 0)                             // If cart is not empty:
            {
                foreach (Car item in Storage.Cart)
                {
                    Storage.Stock.Add(item);
                }
            }

            Storage.Cart = new List<Car>();                        
            Close();                                               // Windows is closed
        }

        private void btn_Volvo_Click(object sender, EventArgs e)
        {
            bindComboBox(new Volvo());                             // new object Volvo
        }
        private void btn_Tesla_Click(object sender, EventArgs e)
        {
            bindComboBox(new Tesla());                             // new object Tesla
        }
        private void btn_Mercedes_Click(object sender, EventArgs e)
        {
            bindComboBox(new Mercedes());                          // new object Mercedes
        }
        private void btn_Charger_Click(object sender, EventArgs e)
        {
            bindComboBox(new Charger());                           // new object Charger
        }

        private void bindComboBox(Car type)                        // POLYMORPHISM
        {
            comboBoxItems.Items.Clear();                           //(collecrion object)

            foreach (Car item in Storage.Stock)
            {
                if (item.GetType() == type.GetType())
                {
                    comboBoxItems.Items.Add(item);
                }
            }

            if (comboBoxItems.Items.Count > 0)
            {
                comboBoxItems.Visible = true;      // Function of visible(true = yes, false = not)
                comboBoxItems.SelectedIndex = 0;   // Choice is vertical indexes
            }
            else comboBoxItems.Visible = false;
        }

        private void buttonAddItemToCart_Click(object sender, EventArgs e)
        {
            if (comboBoxItems.Visible == false) return;                 // Stock is empty of this car's type

            Storage.Cart.Add(comboBoxItems.SelectedItem as Car);        // Add object to cart
            Storage.Stock.Remove(comboBoxItems.SelectedItem as Car);    // Remove object from stock 
            comboBoxCart.Items.Add(comboBoxItems.SelectedItem as Car);

            textBoxItems.Text = "";

            foreach (Car item in Storage.Cart)
            {
                textBoxItems.Text += item.ToString() + "\r\n";
            }

            // Cheking of choice in comboBox:

            if (comboBoxItems.SelectedItem is Volvo)    
            {
                bindComboBox(new Volvo());
            }
            if (comboBoxItems.SelectedItem is Tesla)
            {
                bindComboBox(new Tesla());
            }
            if (comboBoxItems.SelectedItem is Mercedes)
            {
                bindComboBox(new Mercedes());
            }
            if (comboBoxItems.SelectedItem is Charger)
            {
                bindComboBox(new Charger());
            }

            labelPrice.Text = getTotalAmount().ToString();      // Label of final price
            labelItems.Text = Storage.Cart.Count.ToString();    // Label of final amount
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxCart.Text == "")                         // Cheking if comboBox is empty
            {
                return;
            }

            for(int i = 0; i < Storage.Cart.Count; i++)
            {
                if (Storage.Cart[i].getId() == (comboBoxCart.SelectedItem as Car).getId()) // Cheking of deal number that user wants to delete
                {
                    Storage.Stock.Add(Storage.Cart[i]);          // Return deleted object to stock from cart
                    comboBoxCart.Items.Remove(Storage.Cart[i]);  // Removing object from comboBox
                    comboBoxCart.Text = "";
                    Storage.Cart.Remove(Storage.Cart[i]);        // Removing object from cart
                    break;
                }
            }

            textBoxItems.Text = "";

            foreach (Car item in Storage.Cart)
            {
                textBoxItems.Text += item.ToString() + "\r\n";
            }

            labelPrice.Text = getTotalAmount().ToString();
            labelItems.Text = Storage.Cart.Count.ToString();
        }


        private double getTotalAmount()           // Calculate sum of prices of all items in cart
        {
            double sum = 0;

            foreach (Car item in Storage.Cart)    // Until cart is not empty, addition to sum
            {
                sum += item.getPrice();
            }
            return sum;
        }
        private void buttonBuy_Click(object sender, EventArgs e) 
        {
            if (Storage.Cart.Count != 0)          // If cart is not empty
            {
                Storage.Cart = new List<Car>();
                labelPrice.Text = "0";
                labelItems.Text = "0";
                comboBoxCart.Items.Clear();
                comboBoxCart.ResetText();
                textBoxItems.Text = "";
                MessageBox.Show("Thanks for buying!");
            }
            else
            {
                MessageBox.Show("Cart is empty");  // Cart is empty
            }
        }   
    }
}
