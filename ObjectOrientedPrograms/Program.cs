using System;

namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Welcome to Object Oriented Programs");
                Console.WriteLine("Choose the Option : \n 1. JSON \n 2. Inventory Management \n 3. Stock List \n 4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        InventoryMain inv = new InventoryMain();
                        inv.DisplayData(@"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\ObjectOrientedPrograms\ObjectOrientedPrograms\Files\Inventory.json");
                        break;
                    case 2:
                        InventoryManagementMain inve = new InventoryManagementMain();
                        inve.ReadData(@"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\ObjectOrientedPrograms\ObjectOrientedPrograms\Files\InventoryList.json");
                        inve.DisplayData("Wheat");
                        break;
                    case 3:
                        StockMain stock = new StockMain();
                        Console.WriteLine("The Stock Report is : ");
                        stock.DisplayData(@"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\ObjectOrientedPrograms\ObjectOrientedPrograms\Files\Stock.json");
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}