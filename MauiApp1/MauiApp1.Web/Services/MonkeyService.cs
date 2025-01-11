using MauiApp1.Shared.Model;
using MauiApp1.Shared.Services;

namespace MauiApp1.Web.Services
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

            return monkeyList;
        }
    }
}
