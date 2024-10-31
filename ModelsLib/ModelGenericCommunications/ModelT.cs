using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ModelsLib.ModelGenericCommunications
{
    public class ModelT<T> : IModelT<T>
    {
        private readonly HttpClient _httpClient;
        public ModelT()
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri(ConfigValues.HostAddress) };
        }
        public ModelT(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async void Add(T value)
        {
            StringContent content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("add/" + typeof(T).Name, content);
        }

        public async void Delete(T value)
        {
            StringContent content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            await _httpClient.DeleteAsync($"{typeof(T).Name}/{content}");
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            HttpResponseMessage responce = await _httpClient.PostAsync("getall/" + typeof(T).Name, null);
            if (responce.IsSuccessStatusCode)
            {
                string responseContent = await responce.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<IEnumerable<T>>(responseContent);
            }
            throw new Exception("");
        }

        public async Task<T> GetValue(string name, object value)
        {
            var obj = new { name, value };
            StringContent content = new StringContent(JsonSerializer.Serialize(obj), Encoding.UTF8, "application/json");
            HttpResponseMessage responce = await _httpClient.GetAsync($"get/{typeof(T).Name}/{content}");
            if (responce.IsSuccessStatusCode)
            {
                string responseContent = await responce.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<T>(responseContent);
            }
            throw new Exception("");
        }

        public async void Update(T value)
        {
            StringContent content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("update/" + typeof(T).Name, content);
        }
    }
}
