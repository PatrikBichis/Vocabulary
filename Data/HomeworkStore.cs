using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Vocabulary.Pages;
using Vocabulary.Shared;

namespace Vocabulary.Data
{
    public class HomeworkStore
    {
        private readonly HttpClient httpClient;
        private readonly IJSRuntime js;

        public HomeworkStore(HttpClient httpClient, IJSRuntime js)
        {
            this.httpClient = httpClient;
            this.js = js;
        }

        public ValueTask<Shared.Homework[]> GetAllHomeworksAsync()
        { 
            return js.InvokeAsync<Shared.Homework[]>("localHomeworkStore.getAll", "homeworks");
        }

        public async Task<Shared.Homework> GetHomeworkAsync(string id)
            => await GetAsync<Shared.Homework>("homeworks", id);

        public ValueTask SaveHomeworkAsync(Shared.Homework homework)
           => PutAsync("homeworks", null, homework);



        ValueTask<T> GetAsync<T>(string storeName, object key)
            => js.InvokeAsync<T>("localHomeworkStore.get", storeName, key);

        ValueTask PutAsync<T>(string storeName, object key, T value)
            => js.InvokeVoidAsync("localHomeworkStore.put", storeName, key, value);

        ValueTask DeleteAsync(string storeName, object key)
            => js.InvokeVoidAsync("localHomeworkStore.delete", storeName, key);
    }
}
