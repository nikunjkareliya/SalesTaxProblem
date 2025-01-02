using System;

namespace SalesTaxProblem
{
    class Program
    {
        /// <summary>        
        /// Input 3:
        /// 1 imported bottle of perfume at 27.99
        /// 1 bottle of perfume at 18.99
        /// 1 packet of headache pills at 9.75
        /// 1 box of imported chocolates at 11.25
        /// </summary>        
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------- RECEIPT -----------------------");
            Console.WriteLine();

            Receipt receipt = new Receipt();

            Item item = ItemFactory.CreateItem("Perfume", ItemType.RegularItem, true, 27.99f);
            receipt.Add(item);
            item = ItemFactory.CreateItem("Perfume", ItemType.RegularItem, false, 18.99f);
            receipt.Add(item);
            item = ItemFactory.CreateItem("Headache Pills", ItemType.Medicines, false, 9.75f);
            receipt.Add(item);
            item = ItemFactory.CreateItem("Chocolates", ItemType.Food, true, 11.25f);
            receipt.Add(item);

            receipt.Print();

            Console.WriteLine();
            Console.WriteLine("----------------------- END ---------------------------");
        }

    }
}
