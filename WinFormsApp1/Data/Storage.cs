using System.Collections.Generic;
using System.IO;  // library for class File
using WinFormsApp1.NewFolder;

namespace WinFormsApp1.Data
{
    public static class Storage                     // מחלקה אחראית על כל המידע
    {
        public static List<Car> Stock { get; set; }  // מלאי
        public static List<Car> Cart { get; set; }   // עגלת קניות שלנו
        static Storage()                             // Constructor
        {
            Stock = LoadData();
            Cart = new List<Car>();                  // יוצרים עצם חדש   
        }

        public static void SaveData()                // שומרים כל המידע
        {
            if (File.Exists("Temp_FILE.txt"))
            {
                File.Delete("Temp_FILE.txt");
            }

            foreach (Car item in Stock)              // הוספת אובייקט לטקסט עד שהוא קיים במלאי
            {
                File.AppendAllText("Temp_FILE.txt", item.ToString() + "\r\n");
            }
        }
        public static List<Car> LoadData()           // מעלים כל המידע שנשמרה אחרי יציאה  
        {
            Stock = new List<Car>();                 // new object with type Car

            if (File.Exists("Temp_FILE.txt"))
            {
                string[] lines = File.ReadAllLines("Temp_FILE.txt"); // Contain all strings of file

                foreach (string line in lines)
                {
                    string[] sublines = line.Split(" ");

                    if (line.Contains("Volvo"))
                    {
                        Stock.Add(new NewFolder.Volvo(sublines[6], int.Parse(sublines[10]), int.Parse(sublines[12]), int.Parse(sublines[14])));
                    }
                    else if (line.Contains("Tesla"))
                    {
                        Stock.Add(new NewFolder.Tesla(sublines[6], int.Parse(sublines[10]), double.Parse(sublines[12])));
                    }
                    else if (line.Contains("Merc"))
                    {
                        Stock.Add(new NewFolder.Mercedes(sublines[6], int.Parse(sublines[10]), int.Parse(sublines[12]), int.Parse(sublines[14])));
                    }
                    else if (line.Contains("Charge"))
                    {
                        Stock.Add(new NewFolder.Charger(int.Parse(sublines[6])));
                    }
                }
            }

            return Stock;  // מחזירים כל המלאי  
        }
    }
}
