using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI_NUnitCsharp090323
{
    public class ClientRestSetUp
    {
        protected RestClient client;
        protected RestRequest request;
        protected RestResponse response;

        private string mainUrl = "http://api.zippopotam.us";
        private string mainUrlPost = "https://api.nasa.gov/";

        protected void ValidateStatusCode()
        {

        }


        protected void ExecuteGenericRequest(string url, Method method, object body = null)
        {
            response = null;
            client = new RestClient(mainUrlPost);
            request = new RestRequest(url, method);

            if (body == null)
            {
                response = client.Execute(request);
            }
            else
            {
                request = request.AddBody(body);
                response = client.Execute(request);
            }
        }

    }
}
