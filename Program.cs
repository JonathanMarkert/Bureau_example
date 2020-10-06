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

            while (true)
            {
                int drawerIndex = 0;
                int itemIndex = 0;

                System.Console.WriteLine("====================");
                System.Console.WriteLine("|_____Byrolåda_____|");
                System.Console.WriteLine("|__[L]ägg_I_sak____|");
                System.Console.WriteLine("|____[I]nnehåll____|");
                System.Console.WriteLine("|[T]a bort ur lådan|");
                System.Console.WriteLine("|_____[R]ensa______|");
                System.Console.WriteLine("|____[A]vsluta_____|");
                System.Console.WriteLine("|__________________|");
                System.Console.WriteLine(" |_|            |_| ");

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
                        return;

                    default:
                        Console.Clear();
                        System.Console.WriteLine("Ogiltligt val.");
                        break;
                }

            }
        }
    }
}