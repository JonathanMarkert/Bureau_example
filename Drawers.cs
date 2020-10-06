using System;
using System.Collections.Generic;
namespace BureauV2
{
    class Drawer
    {
        private List<Item> listOfItems = new List<Item>();
        public int id { get; set; }
        // public Drawer() // konstruktorn
        // {

        // }

        public void DrawerMetoden(string itemName, double itemWeight)
        {
            Item items = new Item(itemName, itemWeight);
            listOfItems.Add(items);
        }

        public void ListItems()
        {
            int i = 0;
            foreach (Item item in listOfItems)
            {

                System.Console.WriteLine($"Contains: {item.Name}, index#: {i}");
                i++;

            }
        }

        public void RemoveItem(int itemIndex)
        {
            listOfItems.RemoveAt(itemIndex);
        }

        public void RemoveAllItems()
        {
            listOfItems.Clear();
        }

    }
}