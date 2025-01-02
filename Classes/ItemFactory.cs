using System.Collections.Generic;

namespace SalesTaxProblem
{
    /// <summary>
    /// We're using factory design pattern to generate items with different properties
    /// </summary>
    public class ItemFactory
    {
        public static Item CreateItem(string name, ItemType type, bool isImported, float basePrice)
        {
            var item = new Item(name, type, isImported, basePrice);

            // Keeping track of all kind of strategies applicable on this item
            List<ITaxStrategy> taxStrategies = new List<ITaxStrategy>();

            if (type == ItemType.RegularItem)
            {
                ITaxStrategy basic = new BasicTaxStrategy();
                taxStrategies.Add(basic);
            }

            // Import tax always be there if item is imported. doesn't matter if it's regular item or special ones
            if (isImported)
            {
                ITaxStrategy import = new ImportTaxStrategy();
                taxStrategies.Add(import);
            }

            ITaxStrategy composite = new CompositeTaxStrategy(taxStrategies);
            item.SetTaxStrategy(composite);

            return item;
        }
    }
}
