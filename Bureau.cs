using System;
using System.Collections.Generic;
namespace BureauV2
{
    class Bureau
    {
        private List<Drawer> listOfDrawers = new List<Drawer>();
        Drawer drawers = new Drawer();
        public Bureau(int amountOfDrawers)
        {
            for (int i = 0; i < amountOfDrawers; i++)
            {
                Drawer drawers = new Drawer();
                listOfDrawers.Add(drawers);
            }
        }

        public void AddToDrawer(int index, string itemName, double itemWeight)
        {
            listOfDrawers[index].DrawerMetoden(itemName, itemWeight);
        }

        public void ListContent()
        {
            for (int i = 0; i < listOfDrawers.Count; i++)
            {
                System.Console.WriteLine($"Drawer: {i}");
                listOfDrawers[i].ListItems();
            }
        }

        public void ListDrawers()
        {
            for (int i = 0; i < listOfDrawers.Count; i++)
            {
                System.Console.WriteLine($"Låda #{i}");
            }
        }

        public void EmptyDrawer(int drawerIndex)
        {
            listOfDrawers[drawerIndex].RemoveAllItems();
        }

        public void RemoveItemFromDrawer(int drawerIndex, int itemIndex)
        {
            listOfDrawers[drawerIndex].RemoveItem(itemIndex);
        }

        public void ListContentInChosenDrawer(int drawerIndex)
        {
            listOfDrawers[drawerIndex].ListItems();
        }
        public void BureauMenu()
        {
                System.Console.WriteLine("==========================");
                System.Console.WriteLine("|__________Byrå__________|");
                System.Console.WriteLine("|                        |");
                System.Console.WriteLine("|________[L]ägg_I________|");
                System.Console.WriteLine("|                        |");
                System.Console.WriteLine("|_______[I]nnehåll_______|");
                System.Console.WriteLine("|                        |");
                System.Console.WriteLine("|___[T]a bort ur lådan___|");
                System.Console.WriteLine("|                        |");
                System.Console.WriteLine("|________[R]ensa_________|");
                System.Console.WriteLine("|                        |");
                System.Console.WriteLine("|_______[A]vsluta________|");
                System.Console.WriteLine("|                        |");
                System.Console.WriteLine("|________________________|");
                System.Console.WriteLine(" |_|                  |_| ");
        }


    }
}