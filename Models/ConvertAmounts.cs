using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreRewards.Models
{
    public class ConvertAmounts
    {
        [Key]
        public string type { get; set; }
        public int sourceAmount { get; set; }
        public string sourceUnit { get; set; }
        public int targetAmount { get; set; }
        public string targetUnit { get; set; }
        public string answer { get; set; }
     

    }
}
