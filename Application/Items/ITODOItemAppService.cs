using Application.Items.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Items
{
    public interface ITODOItemAppService
    {
        Task<List<AllCharactersDto>> GetAllBreakingBadCharactersAsync();
        Task<string> MapAllCharactersToDicAsync(List<AllCharactersDto> allCharactersDtoList);
        Task<RandomQuoteDto> GetRandomQuote();
        Task<string> MapRandomQuote(RandomQuoteDto randomQuote);
    }
}
