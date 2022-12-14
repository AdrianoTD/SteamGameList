using Azure;
using System.Net;
using System.Net.Http;
using System.Reflection.Metadata;

namespace TrabalhoServico.Controllers
{
    public class SteamController
    {
        private string SteamGames { get; set; }
        private static HttpClient httpClient = new()
        {
            BaseAddress = new Uri("http://api.steampowered.com/"),
        };
        /*public async void GetSteamGames()
        {
            HttpResponseMessage response = await httpClient.GetAsync("ISteamApps/GetAppList/v0002/?key=5B546BDC738461025113E04C3D004A6C&format=json");

            var jsonResponse = await response.Content.ReadAsStringAsync();
        }*/

        public string GetSteamGames()
        {
            var url = "http://api.steampowered.com/ISteamApps/GetAppList/v0002/?key=5B546BDC738461025113E04C3D004A6C&format=json";//Paste ur url here  

            WebRequest request = HttpWebRequest.Create(url);

            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string responseText = reader.ReadToEnd();
            SteamGames = responseText;
            
            return SteamGames;
        }  
    }
}
