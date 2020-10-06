using System;
using System.Collections.Generic;
namespace BureauV2
{
        class Item
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public Item(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        



    }
}