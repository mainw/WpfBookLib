using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
            await _httpClient.PostAsync("add/"+typeof(T).Name, content);
        }

        public async void Delete(T value)
        {
            StringContent content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("delete/" + typeof(T).Name, content);
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetValue(string name, object value)
        {
            StringContent content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            //return await _httpClient.PostAsync("delete/" + typeof(T).Name, content);
        }

        public async void Update(T value)
        {
            StringContent content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            await _httpClient.PostAsync("update/" + typeof(T).Name, content);
        }
    }
}
