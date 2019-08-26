﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreRewards.Models
{

    public class Metric
    {
        public double value { get; set; }
        public string unit { get; set; }
    }

    public class Us
    {
        public double value { get; set; }
        public string unit { get; set; }
    }

    public class Amount
    {
        public Metric metric { get; set; }
        public Us us { get; set; }
    }

    public class Ingredient
    {
        public string name { get; set; }
        public string image { get; set; }
        public Amount amount { get; set; }
    }

    public class SpoonacularRecipeIngredients
    {
        public List<Ingredient> ingredients { get; set; }
    }
}
