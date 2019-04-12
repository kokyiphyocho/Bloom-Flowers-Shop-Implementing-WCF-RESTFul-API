using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloomWCFService.Models
{
    public class Bouquet
    {
        [Key]
        [MaxLength(10)]
        public String ItemID { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [MaxLength(100)]
        public string Tag { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
    }
}