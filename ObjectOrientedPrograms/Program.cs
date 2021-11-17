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
                Console.WriteLine("Choose the Option : 1.JSON \n 2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        InventoryMain inv = new InventoryMain();
                        inv.DisplayData(@"C:\Users\navee\OneDrive\Documents\Bridgelabz practice\ObjectOrientedPrograms\ObjectOrientedPrograms\Files\Inventory.json");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}