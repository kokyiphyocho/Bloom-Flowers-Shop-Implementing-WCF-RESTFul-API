using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using BloomWCFService.Models;

namespace BloomWCFService
{    
    [ServiceContract]
    public interface IDataService
    {
        [OperationContract]
        [WebGet(UriTemplate = "api/getlist/{category}/{pagesize}/{pageno}", ResponseFormat = WebMessageFormat.Json)]
        Task<Tuple<List<Bouquet>, Pagination>> GetData(String category, string pagesize, string pageno);
    }
}

