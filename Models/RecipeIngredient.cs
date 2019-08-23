﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreRewards.Models
{
    public class RecipeIngredient
    {
        [Key]
        public string ingredient { get; set; }
        public int count { get; set; }
        public string measurementType { get; set; }



    }
}
