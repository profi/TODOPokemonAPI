using Application.Items;
using Microsoft.AspNetCore.Mvc;

namespace TODOPokemonAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BreakingBadController : ControllerBase
    {
        private readonly ITODOItemAppService _toDoItemAppService;
        public BreakingBadController(ITODOItemAppService toDoItemAppService)
        {
            _toDoItemAppService = toDoItemAppService;
        }

        public async Task<string> GetProfilesByTenantIdSelectList()
        {
            try
            {
                var brekingBadCharacters = await _toDoItemAppService.GetAllBreakingBadCharactersAsync();

                var brekingBadCharactersJson = await _toDoItemAppService.MapAllCharactersToDicAsync(brekingBadCharacters);

                return await Task.FromResult(brekingBadCharactersJson);
            }
            catch (Exception ex)
            {
                throw;
                //submit to exeptionless or log
            }
        }

        public async Task<string> GetRandomQuoteByName(string name)
        {
            try
            {
                var randonQuote = await _toDoItemAppService.GetRandomQuote();

                //Just for show separation of concerns altow randonQuote and serializedRandomQuote are the same

                var serializedRandomQuote = await _toDoItemAppService.MapRandomQuote(randonQuote);

                return await Task.FromResult(serializedRandomQuote);
            }
            catch (Exception ex)
            {
                //submit to exeptionless or log
                throw;
            }
        }       

    }
}
