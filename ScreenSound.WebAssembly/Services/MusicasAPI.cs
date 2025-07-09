﻿using ScreenSound.Shared.Modelos.Response;
using System.Net.Http.Json;

namespace ScreenSound.WebAssembly.Services
{
    public class MusicasAPI
    {
        private readonly HttpClient _httpClient;

        public MusicasAPI(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("API");
        }

        public async Task<ICollection<MusicaResponse>> GetMusicasAsync()
        {
            return await _httpClient.GetFromJsonAsync<ICollection<MusicaResponse>>("musicas");
        }
    }
}
