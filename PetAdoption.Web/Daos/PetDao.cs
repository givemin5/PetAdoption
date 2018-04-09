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
            string url = "http://data.coa.gov.tw/Service/OpenData/AnimalOpenData.aspx";

            HttpWebRequest req = WebRequest.Create(new Uri(url)) as HttpWebRequest;
            req.Method = "GET";

            WebResponse rs = req.GetResponse();

            using (Stream stream = rs.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                String responseString = reader.ReadToEnd();

                var petJsons = JsonConvert.DeserializeObject<List<PetJsonModel>>(responseString);

                return petJsons;
            }
        }
    }
}