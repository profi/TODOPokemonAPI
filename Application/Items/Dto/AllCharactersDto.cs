// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Application.Items.Dto;
//
//    var allCharactersDto = AllCharactersDto.FromJson(jsonString);

namespace Application.Items.Dto
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Text.Json.Serialization;

    public partial class AllCharactersDto
    {
        [JsonPropertyName("char_id")]
        public long CharId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }

        [JsonPropertyName("occupation")]
        public List<string> Occupation { get; set; }

        [JsonPropertyName("img")]
        public Uri Img { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        [JsonPropertyName("appearance")]
        public List<long> Appearance { get; set; }

        [JsonPropertyName("portrayed")]
        public string Portrayed { get; set; }

        [JsonPropertyName("category")]
        public string? Category { get; set; }

        [JsonPropertyName("better_call_saul_appearance")]
        public List<long> BetterCallSaulAppearance { get; set; }
    }
}


    
