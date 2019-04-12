using BloomWCFService.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloomWCFService.Data
{
    public class BouquetDbContext :  DbContext
    {
        public BouquetDbContext() : base("DefaultConnection") { }

        public DbSet<Bouquet> Bouquets { get; set; }
    }
}


