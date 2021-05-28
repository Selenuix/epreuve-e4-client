//using System.Text.Json;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace JO2012
{
    class ApiService
    {
        public void getVins()
        {
            // Create HttpClient
            RestClient client = new RestClient("http://localhost/cave/");

            // Request wines
            RestRequest request = new RestRequest("vins");

            // Get the response
            IRestResponse response = client.Execute(request);

            // Check the status code returned
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // Get the JSON response content
                string rawResponse = response.Content;

                //Console.WriteLine(rawResponse);

                // deserialize the response into a Vin object
                /*string jsonString =
                @"{
                    ""Id"": 1,
                    ""Nom"": ""CHATEAU DE SAINT COSME"",
                    ""Annee"": 2009,
                    ""Cepage"": ""Grenache"",
                    ""Pays"": ""France"",
                    ""Region"": ""Gigondas / Côtes du Rhône sud"",
                    ""Description"": ""The aromas of fruit and spice give one a hint of the light drinkability of this lovely wine, which makes an excellent complement to fish dishes.""
                }"; */

                //Vin vin = JsonSerializer.Deserialize<Vin>(jsonString);

                List<Vin> vins = JsonConvert.DeserializeObject<List<Vin>>(rawResponse);

                foreach (var vin in vins)
                {
                    Console.WriteLine("{0} {1} {2} {3}\n", vin.Id, vin.Nom, vin.Annee, vin.Cepage, vin.Pays, vin.Region, vin.Description);
                }

                //dynamic json = JsonConvert.Text.Json

                /*foreach (var leVin in rawResponse)
                {
                    Vin v = JsonSerializer.Deserialize<Vin>(rawResponse);
                    //lesVins.Add(leVin);

                    Console.WriteLine($"id: {leVin.Id}");
                    Console.WriteLine($"nom: {leVin.Nom}");
                    Console.WriteLine($"annee: {leVin.Annee}");
                } */

                /* Console.WriteLine($"Id: {vin.Id}");
                 Console.WriteLine($"Nom: {vin.Nom}"); 
                 Console.WriteLine($"Annee: {vin.Annee}"); */
            }
        }
    }
}
