﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;

namespace FarmTracer.API
{
    internal class HelperSite
    {
        private readonly string _baseUrl = "https://localhost:7232/api/";
        private readonly HttpClient _client;

        public HelperSite()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(_baseUrl)
            };
        }

        public async Task<List<Site>> GetAllSites()
        {
            var response = await _client.GetAsync("Site");
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Site>>(jsonResult);
            }
            else
            {
                
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erreur lors de la récupération des sites : {response.StatusCode}, Détails : {errorResponse}");
            }
        }

        public async Task AddSite(Site site)
        {
            var json = JsonConvert.SerializeObject(site);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("Site", content);
            if (!response.IsSuccessStatusCode)
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erreur lors de l'ajout du site : {response.StatusCode}, Détails : {errorResponse}");
            }
        }

        public async Task UpdateSite(Site site)
        {
            var json = JsonConvert.SerializeObject(site);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"Site/{site.Id}", content);
            if (!response.IsSuccessStatusCode)
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erreur lors de la mise à jour du site : {response.StatusCode}, Détails : {errorResponse}");
            }
        }

        public async Task DeleteSite(int id)
        {
            var response = await _client.DeleteAsync($"Site/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erreur lors de la suppression du site : {response.StatusCode}, Détails : {errorResponse}");
            }
        }

        
        public class Site
        {
            public int Id { get; set; }
            public string Nom { get; set; }
        }
    }
}
