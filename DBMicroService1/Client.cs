﻿using System.Net.Http;
using System.Threading.Tasks;

public class MicroserviceClient
{
    private readonly HttpClient _httpClient;

    public MicroserviceClient(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("ToinenMicroservice");
    }

    public async Task<string> HaeTiedotToiseltaMicroservicelta()
    {
        var response = await _httpClient.GetAsync("api/Electricity/GetSahko");
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
        else
        {
            return null;
        }
    }
}
