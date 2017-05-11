using EsendexMessengerApp.Models;
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

            var dispatcherRequest = new DispatcherRequest();

            var restRequest = new RestRequest("/v1.0/messagedispatcher", Method.POST);
        }
    }
}