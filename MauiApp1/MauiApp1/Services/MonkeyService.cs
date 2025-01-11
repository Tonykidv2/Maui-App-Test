using MauiApp1.Shared.Model;
using MauiApp1.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    public class MonkeyService : IMonkeyService
    {
        HttpClient httpClient;
        public MonkeyService()
        {
            httpClient = new HttpClient();
        }

        List<Monkey> monkeyList = new();

        public async Task<List<Monkey>> GetMonkeys()
        {
            if (monkeyList.Count > 0)
                return monkeyList;
            var url = "https://montemagno.com/monkeys.json";
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
            }


            // Offline
            /*using var stream = await FileSystem.OpenAppPackageFileAsync("monkeydata.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            monkeyList = JsonSerializer.Deserialize(contents, MonkeyContext.Default.ListMonkey);*/
            return monkeyList;
        }
    }
}
