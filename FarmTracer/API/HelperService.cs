using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;

namespace FarmTracer.API
{
    internal class HelperService
    {
        private readonly string _baseUrl = "https://localhost:7232/api/";
        private readonly HttpClient _client;

        public HelperService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(_baseUrl)
            };
        }

        public async Task<List<Service>> GetAllServices()
        {
            var response = await _client.GetAsync("Services");
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Service>>(jsonResult);
            }
            return new List<Service>();
        }

        public async Task AddService(Service service)
        {
            var json = JsonConvert.SerializeObject(service);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("Services", content);
            if (!response.IsSuccessStatusCode)
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erreur lors de l'ajout du service : {response.StatusCode}, Détails : {errorResponse}");
            }
        }

        public async Task UpdateService(Service service)
        {
            var json = JsonConvert.SerializeObject(service);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"Services/{service.Id}", content);
            if (!response.IsSuccessStatusCode)
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erreur lors de la mise à jour du service : {response.StatusCode}, Détails : {errorResponse}");
            }
        }

        public async Task DeleteService(int id)
        {
            var response = await _client.DeleteAsync($"Services/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erreur lors de la suppression du service : {response.StatusCode}, Détails : {errorResponse}");
            }
        }

        
        public class Service
        {
            public int Id { get; set; }
            public string Nom { get; set; }
           
        }
    }
}
