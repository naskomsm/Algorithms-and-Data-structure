﻿namespace Algorithms_and_data_structure.DynamicProgramming.TheKnapsack
{
    public class Item
    {
        public Item(string name, int weight, int price)
        {
            this.Name = name;
            this.Weight = weight;
            this.Price = price;
        }

        public string Name { get; private set; }

        public int Weight { get; private set; }

        public int Price { get; private set; }
    }
}
