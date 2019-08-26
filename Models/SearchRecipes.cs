using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreRewards.Models
{
    public class SearchRecipes
    {
        [Key]
        public int id { get; set; }
        public int MyProperty { get; set; }
        public string results { get; set; }
        public string baseUri { get; set; }
        public int offset { get; set; }
        public int number { get; set; }
        public int totalRequests { get; set; }
        public int processingTimeMs { get; set; }
        public int expires { get; set; }
        public bool isStale  { get; set; }
    }
}
