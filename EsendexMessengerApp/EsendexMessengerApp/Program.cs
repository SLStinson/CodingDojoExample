using System;
using EsendexMessengerApp.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace EsendexMessengerApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            const string username = "";
            const string password = "";

            var client = new RestClient("https://api.esendex.com")
                         {
                             Authenticator = new HttpBasicAuthenticator(username, password)
                         };

            var dispatcherRequest = new DispatcherRequest
            {
                AccountReference = "",
                Messages = new[] {new DispatcherMessage
                {
                    Body = "",
                    Recipient = ""
                } }
            };

            var jsonString = JsonConvert.SerializeObject(dispatcherRequest);

            var restRequest = new RestRequest("/v1.0/messagedispatcher", Method.POST);
            restRequest.AddParameter("application/json", jsonString, ParameterType.RequestBody);

            var response = client.Execute<DispatcherResponse>(restRequest);

            Console.WriteLine(response.StatusCode);
            Console.ReadLine();
        }
    }
}