using System.Text.Json.Serialization;

namespace goblinAPI.models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GoblinJob
    {
        

        Banker,
        Beggar,
        CoinPolisher,
    }
}