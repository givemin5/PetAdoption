using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using Newtonsoft.Json;
using PetAdoption.Web.Models;

namespace PetAdoption.Web.Daos
{
    public class PetDao
    {
        public List<PetJsonModel> GetAll()
        {
            const string url = "http://data.coa.gov.tw/Service/OpenData/AnimalOpenData.aspx";

            var webClient = new WebClient {Encoding = Encoding.UTF8};
            
            var response = webClient.DownloadString(url);

            var petJsons = JsonConvert.DeserializeObject<List<PetJsonModel>>(response);

            return petJsons;

        }
    }
}