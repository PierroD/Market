using System.Text.Json.Serialization;

namespace Lindra_Market_v3.Tools.Bo3LanguageSelector.Models
{
    public class Bo3Language
    {
        [JsonPropertyName("key")]
        public string Key { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        public override string ToString() => Name;
    }
}
