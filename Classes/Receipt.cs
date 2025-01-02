using System;
using System.Collections.Generic;

namespace SalesTaxProblem
{
    /// <summary>
    /// Used to track all items and print the details
    /// </summary>
    public class Receipt
    {
        private List<Item> _items;

        public Receipt()
        {
            _items = new List<Item>();
        }

        public void Add(Item item)
        {
            _items.Add(item);
        }

        public float GetTotalPriceToBePaid()
        {
            float totalPrice = 0f;

            for (int i = 0; i < _items.Count; i++)
            {
                totalPrice += _items[i].GetPriceWithTax();
            }

            return totalPrice;
        }

        public float GetTotalTaxToBePaid()
        {
            float totalTax = 0f;

            for (int i = 0; i < _items.Count; i++)
            {
                totalTax += _items[i].GetTax();
            }

            return totalTax;
        }

        public void Print()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_items[i].Name} | Type: {_items[i].Type} | Is imported? {_items[i].IsImported} | Price with tax: {_items[i].GetPriceWithTax()}");
            }

            Console.WriteLine();
            Console.WriteLine($"Tax to be paid: {GetTotalTaxToBePaid()}");
            Console.WriteLine($"Total: {GetTotalPriceToBePaid()}");
        }

    }
}
