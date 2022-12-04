using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Constants
{
    public static class URLs
    {
        public static string BASE_BREAKING_BAD_API_ENDPOINT { get; set; } = "https://www.breakingbadapi.com/api/";
        public static string BREAKING_BAD_QUOTE_ENDPOINT { get; set; } = "quote";
        public static string ALL_CHARACTERS_ENDPOINT  { get; set; } = "characters";
        public static string RANDOM_QUOTE_API_ENDPOINT { get; set; } = "quote/random";
    }
}
