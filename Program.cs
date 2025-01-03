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
            Receipt receipt = new Receipt();

            ITaxStrategy strategy = TaxStrategyFactory.Create(ItemType.RegularItem, true);
            Item item = ItemFactory.CreateItem("Perfume", ItemType.RegularItem, true, 27.99f, strategy);
            receipt.Add(item);

            strategy = TaxStrategyFactory.Create(ItemType.RegularItem, false);
            item = ItemFactory.CreateItem("Perfume", ItemType.RegularItem, false, 18.99f, strategy);
            receipt.Add(item);

            strategy = TaxStrategyFactory.Create(ItemType.Medicines, false);
            item = ItemFactory.CreateItem("Headache Pills", ItemType.Medicines, false, 9.75f, strategy);
            receipt.Add(item);

            strategy = TaxStrategyFactory.Create(ItemType.Food, true);
            item = ItemFactory.CreateItem("Chocolates", ItemType.Food, true, 11.25f, strategy);
            receipt.Add(item);

            Console.WriteLine();
            Console.WriteLine("----------------------- RECEIPT -----------------------");
            Console.WriteLine();

            Printer printer = new Printer();
            printer.Print(receipt);

            Console.WriteLine();
            Console.WriteLine("----------------------- END ---------------------------");
        }

    }
}
