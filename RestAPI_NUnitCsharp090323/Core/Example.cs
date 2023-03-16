//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RestAPI_NUnitCsharp090323.Core
//{
//    public class Example
//    {
//        public void Serialize()
//        {
//            int idBody = ReadFromJsonFile("DataToPutInTheBody.Json", "id"); //As a suggestion, send the file name and the parameter you are looking for
//            string firtBody = ReadFromJsonFile("DataToPutInTheBody.Json", "name");
//            string lastBody = ReadFromJsonFile("DataToPutInTheBody.Json", "lastName");

//            body = new ClassToSerialize
//            {
//                id = idBody,
//                name = firtBody,
//                lastName = lastBody
//            };

//            restCore = new RestCore("www.dummyURL.com/doSomething");
//            restRequest = restCore.CreateRequestWithHeaders(Method);
//            serviceResponse = restCore.AddRequestBody(restRequest, body);
//        }

//    }
//}
