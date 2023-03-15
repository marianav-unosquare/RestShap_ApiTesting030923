using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI_NUnitCsharp090323.Core
{
    public class ClientSetup
    {
        protected RestClient client;
        protected RestRequest request;
        protected RestResponse response;

        private string healthCareUrl = "https://www.healthcare.gov/";
        private string NasaUrl = "https://api.nasa.gov/";
        private string APINasaToken = "5ZpzNnl9vn4lC5f5xAXmvXWE2fzXETV4SdRfrpp6";

        protected void ExecuteGenericRequestNasa(string url, Method method, object body = null)
        {
            response = new RestResponse();
            client = new RestClient(NasaUrl);
            request = new RestRequest(url + APINasaToken, method);


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

        protected void ExecuteGenericRequestHealthCare(string url, Method method, object body = null)
        {
            response = new RestResponse();
            client = new RestClient(healthCareUrl);
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
