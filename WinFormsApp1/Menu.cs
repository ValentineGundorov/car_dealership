using System;
using System.Windows.Forms;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_administrator_Click(object sender, EventArgs e)    // ADMINISTRATOR
        {
            Administrator formManager = new Administrator();
            Hide();
            formManager.ShowDialog();
            Show();
        }

        private void btn_Shop_Click(object sender, EventArgs e)     // SHOP
        {
            Shop formCustomer = new Shop();
            Hide();
            formCustomer.ShowDialog();
            Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)     // EXIT
        {
            Storage.SaveData();
            Close();
        }

    }
}

