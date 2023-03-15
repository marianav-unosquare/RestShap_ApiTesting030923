//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using RestAPI_NUnitCsharp090323.Features.HealthcareGov.NewFolder;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RestAPI_NUnitCsharp090323.Core
//{
//    internal class ReadJson
//    {

//        public JObject ReadJson(string fileName)
//        {
//            //string completePath = @":\Users\mariana.vives\source\repos\RestSharp_ApiTesting_070323\RestSharp_ApiTesting_070323\Requests\HealthcareGov\Gets\HealthGovJsonFIleGet.json";

//            string completePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName + ".json");

//            try
//            {
//                if (File.Exists(completePath))
//                {
//                    string jsonText = File.ReadAllText(completePath);

//                    var data = JsonConvert.DeserializeObject<Articles>(jsonText);

//                    return data;

//                }

//                return null;
//            }

//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.ToString());
//            }

//        }


//    }

//}
