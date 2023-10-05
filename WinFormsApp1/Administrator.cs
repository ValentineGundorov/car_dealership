using System;
using System.Windows.Forms;
using WinFormsApp1.Data;
using WinFormsApp1.NewFolder;
using System.Collections.Generic;
using System.IO;

namespace WinFormsApp1
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();

        }
        private void refreshForItem()        // Function of visible's comboBoxes
        {
            labelWeight.Visible = false;
            labelDoor.Visible = false;
            labelColor.Visible = false;
            labelYear.Visible = false;
            labelMaxSpeed.Visible = false;
            labelCables.Visible = false;

            comboBoxWeight.Visible = false;
            comboBoxDoors.Visible = false;
            comboBoxColors.Visible = false;
            comboBoxYear.Visible = false;
            comboBoxMaxSpeed.Visible = false;
            comboBoxCables.Visible = false;

            comboBoxWeight.Items.Clear();
        }

        private void visibleTesla()           // Function of visible's comboBoxes of Tesla
        {
            labelWeight.Visible = true;
            labelColor.Visible = true;
            labelYear.Visible = true;
            comboBoxWeight.Visible = true;
            comboBoxColors.Visible = true;
            comboBoxYear.Visible = true;

            comboBoxWeight.Items.Add("2350.4");
            comboBoxWeight.Items.Add("1950.5");
        }
        private void visibleMercedes()        // Function of visible's comboBoxes of Mercedes
        {
            labelWeight.Visible = true;
            labelColor.Visible = true;
            labelYear.Visible = true;
            labelMaxSpeed.Visible = true;

            comboBoxWeight.Visible = true;
            comboBoxColors.Visible = true;
            comboBoxYear.Visible = true;
            comboBoxMaxSpeed.Visible = true;

            comboBoxWeight.Items.Add("2100");
            comboBoxWeight.Items.Add("1800");
        }
        private void visibleCharger()        // Function of visible's comboBoxes of Chargers
        {
            labelCables.Visible = true;
            comboBoxCables.Visible = true;
        }
        private void visibleVolvo()          // Function of visible's comboBoxes of Volvo
        {
            labelWeight.Visible = true;
            labelDoor.Visible = true;
            labelColor.Visible = true;
            labelYear.Visible = true;

            comboBoxWeight.Visible = true;
            comboBoxDoors.Visible = true;
            comboBoxColors.Visible = true;
            comboBoxYear.Visible = true;

            comboBoxWeight.Items.Add("2000");
            comboBoxWeight.Items.Add("2100");
            comboBoxWeight.Items.Add("2200");
            comboBoxWeight.Items.Add("2300");
        }

        private void refresh_comboBox()      // Refreshing of all comboBoxes
        {
            comboBoxColors.Text = "select";
            comboBoxYear.Text = "select";
            comboBoxDoors.Text = "select";
            comboBoxWeight.Text = "select";
            comboBoxMaxSpeed.Text = "select";
            comboBoxCables.Text = "select";
        }

        private void btn_return_Click(object sender, EventArgs e)  // Return to menu
        {
            Close();
        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshForItem();

            switch (comboBoxItems.SelectedItem.ToString()) // Convert data in comboBox to string
            {
                case "Tesla":
                    visibleTesla();                        // If you choice Tesla, all Tesla's comboBoxes are visible 
                    break;

                case "Mercedes":
                    visibleMercedes();                     // If you choice Mercedes, all Mercedes's comboBoxes are visible
                    break;

                case "Charger":
                    visibleCharger();                      // If you choice Charger, all Charger's comboBoxes are visible
                    break;

                case "Volvo":
                    visibleVolvo();                        // If you choice Volvo, all Volvo's comboBoxes are visible
                    break;

                default:
                    break;
            }

            refresh_comboBox();                            // Refreshing of all comboBoxes
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool flag = false;

            switch (comboBoxItems.SelectedIndex)
            {
                case 2: // for Tesla
                    if (comboBoxColors.Text.Contains("select") || comboBoxYear.Text.Contains("select") || comboBoxWeight.Text.Contains("select"))
                    {
                        MessageBox.Show("Please finish fill the form");
                    }
                    else
                    {
                        Storage.Stock.Add(new Tesla(comboBoxColors.SelectedItem.ToString(),Convert.ToInt32(comboBoxYear.SelectedItem),Convert.ToDouble(comboBoxWeight.SelectedItem)));
                        flag = true;
                    }
                    break;
                case 1: // for Mercedes
                    if (comboBoxColors.Text.Contains("select") || comboBoxYear.Text.Contains("select") || comboBoxWeight.Text.Contains("select") || comboBoxMaxSpeed.Text.Contains("select"))
                        MessageBox.Show("Please finish fill the form");
                    else
                    {
                        Storage.Stock.Add(new Mercedes(comboBoxColors.SelectedItem.ToString(),Convert.ToInt32(comboBoxYear.SelectedItem),Convert.ToInt32(comboBoxWeight.SelectedItem), Convert.ToInt32(comboBoxMaxSpeed.SelectedItem)));
                        flag = true;
                    }
                    break;
                case 0: // for Charger
                    if (comboBoxCables.Text.Contains("select"))
                        MessageBox.Show("Please finish fill the form");
                    else
                    {
                        Storage.Stock.Add(new Charger(Convert.ToInt32(comboBoxCables.SelectedItem)));
                        flag = true;
                    }
                    break;
                case 3:  //for Volvo
                    if (comboBoxColors.Text.Contains("select") || comboBoxYear.Text.Contains("select") || comboBoxWeight.Text.Contains("select") || comboBoxDoors.Text.Contains("select"))
                    {
                        MessageBox.Show("Please finish fill the form");
                    }
                    else
                    {
                        Storage.Stock.Add(new Volvo(comboBoxColors.SelectedItem.ToString(),Convert.ToInt32(comboBoxYear.SelectedItem),Convert.ToInt32(comboBoxWeight.SelectedItem), Convert.ToInt32(comboBoxDoors.SelectedItem)));
                        flag = true;
                    }
                    break;
            }
            if (flag)
            {
                showData();
                refresh_comboBox();
                Storage.SaveData();
                tb_return_id_TextChanged(sender, e);
                tb_return_price_TextChanged(sender, e);
            }
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            refreshForItem();
            showData();
        }
        private void showData()               // Function that show data in Stock
        {
            textBoxData.Text = "";

            if(Storage.Stock != null)
            {
                foreach (Car item in Storage.Stock)
                {
                    textBoxData.Text += item.ToString() + "\r\n";
                }
            }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Car item;

            switch (comboBoxItems.SelectedIndex)
            {
                case 2: // for Tesla
                    if (comboBoxColors.Text.Contains("select") || comboBoxYear.Text.Contains("select") || comboBoxWeight.Text.Contains("select"))
                    {
                        MessageBox.Show("Please finish fill the form");
                    }
                    else
                    {
                        item = new Tesla(comboBoxColors.SelectedItem.ToString(),Convert.ToInt32(comboBoxYear.SelectedItem),Convert.ToDouble(comboBoxWeight.SelectedItem));
                        
                        foreach (Car item2 in Storage.Stock)
                        {
                            if (item.getId() == item2.getId())
                            {
                                Storage.Stock.Remove(item2);
                                flag = true;
                                tb_return_id.Text = item.getId().ToString();
                                tb_return_price.Text = item.getPrice().ToString();
                                break;
                            }

                        }

                        if (flag)
                        {
                            MessageBox.Show("The item deleted");
                        }
                        else
                        {
                            MessageBox.Show("Not exict this item in a stock");
                        }
                    }
                    break;
                case 1: // for Mercedes
                    if (comboBoxColors.Text.Contains("select") || comboBoxYear.Text.Contains("select") || comboBoxWeight.Text.Contains("select") || comboBoxMaxSpeed.Text.Contains("select"))
                    {
                        MessageBox.Show("Please finish fill the form");
                    }
                    else
                    {
                        item = new Mercedes(comboBoxColors.SelectedItem.ToString(),Convert.ToInt32(comboBoxYear.SelectedItem),Convert.ToInt32(comboBoxWeight.SelectedItem), Convert.ToInt32(comboBoxMaxSpeed.SelectedItem));
                        
                        foreach (Car item2 in Storage.Stock)
                        {
                            if (item.getId() == item2.getId())
                            {
                                Storage.Stock.Remove(item2);
                                flag = true;
                                tb_return_id.Text = item.getId().ToString();
                                tb_return_price.Text = item.getPrice().ToString();
                                break;
                            }
                        }

                        if (flag)
                        {
                            MessageBox.Show("The item deleted");
                        }
                        else
                        {
                            MessageBox.Show("Not exict this item in a stock");
                        }
                    }
                    break;
                case 0: // for Charger
                    if (comboBoxCables.Text.Contains("select"))
                    {
                        MessageBox.Show("Please finish fill the form");
                    }
                    else
                    {
                        item = new Charger(Convert.ToInt32(comboBoxCables.SelectedItem));
                        
                        foreach (Car item2 in Storage.Stock)
                        {
                            if (item.getId() == item2.getId())
                            {
                                Storage.Stock.Remove(item2);
                                flag = true;
                                tb_return_id.Text = item.getId().ToString();
                                tb_return_price.Text = item.getPrice().ToString();
                                break;
                            }
                        }

                        if (flag)
                        {
                            MessageBox.Show("The item deleted");
                        }
                        else
                            MessageBox.Show("Not exict this item in a stock");
                    }
                    break;
                case 3:  // for Volvo
                    if (comboBoxColors.Text.Contains("select") || comboBoxYear.Text.Contains("select") || comboBoxWeight.Text.Contains("select") || comboBoxDoors.Text.Contains("select"))
                    {
                        MessageBox.Show("Please finish fill the form");
                    }
                    else
                    {
                        item = new Volvo(comboBoxColors.SelectedItem.ToString(),Convert.ToInt32(comboBoxYear.SelectedItem),Convert.ToInt32(comboBoxWeight.SelectedItem), Convert.ToInt32(comboBoxDoors.SelectedItem));
                        
                        foreach (Car item2 in Storage.Stock)
                        {
                            if (item.getId() == item2.getId())
                            {
                                Storage.Stock.Remove(item2);
                                flag = true;
                                tb_return_id.Text = item.getId().ToString();
                                tb_return_price.Text = item.getPrice().ToString();
                                break;
                            }
                        }

                        if (flag)
                        {
                            MessageBox.Show("The item deleted");
                        }
                        else
                        {
                            MessageBox.Show("Not exict this item in a stock");
                        }
                    }
                    break;
            }

            if (flag)   // Item was deleted(flag = true)
            {
                showData();
                refresh_comboBox();
                Storage.SaveData();
            }
        }

        private void tb_return_id_TextChanged(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Temp_FILE.txt");

            if (lines != null)
            {
                int count = lines.Length - 1;
                string[] sublines = lines[count].Split(' ');
                tb_return_id.Text = sublines[4];
            }
        }

        private void tb_return_price_TextChanged(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Temp_FILE.txt");

            if (lines != null)
            {
                int count = lines.Length - 1;
                string[] sublines = lines[count].Split(" ");
                tb_return_price.Text = sublines[2];
            }
        }
    }
}