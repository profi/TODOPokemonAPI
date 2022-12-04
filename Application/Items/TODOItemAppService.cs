using Application.Items.Dto;
using Core.Constants;
using Flurl.Http;
using System;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.Items
{
    public class TODOItemAppService : ITODOItemAppService
    {

        public async Task<List<AllCharactersDto>> GetAllBreakingBadCharactersAsync()
        {
            string url = URLs.BASE_BREAKING_BAD_API_ENDPOINT + URLs.ALL_CHARACTERS_ENDPOINT;

            var allCharactersDtoList = await url.GetJsonAsync<List<AllCharactersDto>>();

            return allCharactersDtoList;
        }

        public Task<string> MapAllCharactersToDicAsync(List<AllCharactersDto> allCharactersDtoList)
        {
            int counter = 0;

            var allCharactersDic = allCharactersDtoList.Select(t => new { counter = counter + 1, t.Name }).ToList();

            var json = JsonSerializer.Serialize<object>(allCharactersDic, new JsonSerializerOptions { WriteIndented = true, });
           
            return Task.FromResult(json);
        }

        public async Task<RandomQuoteDto> GetRandomQuote()
        {
            string url = URLs.BASE_BREAKING_BAD_API_ENDPOINT + URLs.RANDOM_QUOTE_API_ENDPOINT;

            var randomQuote = await url.GetJsonAsync<RandomQuoteDto>();

            return randomQuote;
        }

        public Task<string> MapRandomQuote(RandomQuoteDto randomQuote)
        {
            var json = JsonSerializer.Serialize<object>(randomQuote, new JsonSerializerOptions { WriteIndented = true, });

            return Task.FromResult(json);
        }

    }
}
