using BloomWCFService.Data;
using BloomWCFService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BloomWCFService
{
    public class DataService : IDataService
    {
        public async Task<Tuple<List<Bouquet>, Pagination>> GetData(String category, string pagesize, string pageno)
        {
            List<Bouquet> bouquetList;
            Pagination pagination;

            using (BouquetDbContext bouquetDbContext = new BouquetDbContext())
            {
                pagination = new Pagination();
                pagination.PageSize = pagesize.ParseInt(pagination.PageSize);
                pagination.PageNo = pageno.ParseInt(1);

                var query = bouquetDbContext.Bouquets.AsNoTracking().Where(b => category.ToLower() == "all" ? true : b.Tag.ToString().Contains(category)).OrderBy(b => b.ItemID);
                pagination.TotalCount = await query.CountAsync().ConfigureAwait(false);

                bouquetList = await query.Skip((pagination.PageNo - 1) * pagination.PageSize).Take(pagination.PageSize).ToListAsync().ConfigureAwait(false);
            }

            return (new Tuple<List<Bouquet>, Pagination>(bouquetList, pagination));
        }

    }
}
