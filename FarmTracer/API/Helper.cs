using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Text;

namespace FarmTracer.API
{
    internal class Helper
    {
        private readonly string _baseUrl = "https://localhost:7232/api/";
        private readonly HttpClient _client;

        public Helper()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(_baseUrl)
            };
        }

        public async Task<Admin> GetAdminByUsername(string username)
        {
            var response = await _client.GetAsync($"Admin/username/{username}");
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Admin>(jsonResult);
            }

            return null;
        }

        public async Task<List<Salarie>> GetAllSalaries()
        {
            var response = await _client.GetAsync("Salaries");
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Salarie>>(jsonResult);
            }
            return new List<Salarie>();
        }

        public bool IsPasswordValid(string enteredPassword, string storedPasswordHash, byte[] salt)
        {
            var hashedPassword = HashPassword(enteredPassword, salt);
            return hashedPassword == storedPasswordHash;
        }

        private string HashPassword(string password, byte[] salt)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
        }
        public class Admin
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string PasswordHash { get; set; }
            public byte[] Salt { get; set; }
        }

        public class Salarie
        {
            public int Id { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string TelephoneFixe { get; set; }
            public string TelephonePortable { get; set; }
            public string Email { get; set; }
            public string Service { get; set; }
            public string Site { get; set; }
        }
        public async Task AddSalarie(Salarie salarie)
        {
            var json = JsonConvert.SerializeObject(salarie);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("Salaries", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Erreur lors de l'ajout du salarié.");
            }
        }
        public async Task UpdateSalarie(Salarie salarie)
        {
            // Convertissez l'objet salarie en JSON
            var json = JsonConvert.SerializeObject(salarie);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Envoyez une requête PUT à l'API pour mettre à jour le salarie
            var response = await _client.PutAsync($"Salaries/{salarie.Id}", content);

            // Vérifiez si la requête a réussi
            if (!response.IsSuccessStatusCode)
            {
                // Récupérez le message d'erreur de l'API si la requête a échoué
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erreur lors de la mise à jour du salarié : {response.StatusCode}, Détails : {errorResponse}");
            }
        }
        public async Task DeleteSalarie(int id)
        {
            var response = await _client.DeleteAsync($"Salaries/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erreur lors de la suppression du salarié : {response.StatusCode}, Détails : {errorResponse}");
            }
        }


    }



}
