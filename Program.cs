using System;
using System.Collections.Generic;
namespace BureauV2
{


    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDrawers = 0;

            System.Console.WriteLine("Hur många lådor har du i din byrå?");

            try
            {
                numberOfDrawers = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

            Bureau bureau = new Bureau(numberOfDrawers);
            bool inMenu = true;

            while (inMenu)
            {
                int drawerIndex = 0;
                int itemIndex = 0;
                bureau.PrintBureauMenu();
                string menuInput = Console.ReadLine().ToUpper();

                switch (menuInput)
                {
                    case "L":
                        Console.Clear();
                        System.Console.WriteLine("Vad vill du lägga i lådan?");
                        string itemName = Console.ReadLine();

                        System.Console.WriteLine("Hur mycket väger det?");
                        double itemWeight;
                        int index;
                        itemWeight = Convert.ToDouble(Console.ReadLine());

                        System.Console.WriteLine("I vilken låda vill du lägga det?");

                        index = Convert.ToInt32(Console.ReadLine());

                        bureau.AddToDrawer(index, itemName, itemWeight);

                        break;

                    case "I":
                        Console.Clear();
                        System.Console.WriteLine("Byrån innehåller:");
                        bureau.ListContent();
                        Console.ReadLine();
                        break;

                    case "T":
                        Console.Clear();
                        bureau.ListDrawers();
                        System.Console.WriteLine("Vilken låda?");
                        drawerIndex = Convert.ToInt32(Console.ReadLine());
                        bureau.ListContentInChosenDrawer(drawerIndex);
                        itemIndex = Convert.ToInt32(Console.ReadLine());
                        bureau.RemoveItemFromDrawer(drawerIndex, itemIndex);
                        break;

                    case "R":
                        bureau.ListDrawers();
                        System.Console.WriteLine("Vilken låda tömma");
                        drawerIndex = Convert.ToInt32(Console.ReadLine());
                        bureau.EmptyDrawer(drawerIndex);
                        break;

                    case "A":
                        Console.Clear();
                        System.Console.WriteLine("Stänger lådan och tänder eld på byrån. Hej då.");
                        Console.ReadLine();
                        inMenu = false;
                        break;

                    default:
                        Console.Clear();
                        System.Console.WriteLine("Ogiltligt val.");
                        break;
                }

            }
        }
    }
}