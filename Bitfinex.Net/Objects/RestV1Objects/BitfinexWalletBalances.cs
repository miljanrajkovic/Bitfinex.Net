using Newtonsoft.Json;

namespace Bitfinex.Net.Objects.RestV1Objects
{
    public class BitfinexWalletBalances
    {
        [JsonProperty("type")]
        string Type { get; set; }
        [JsonProperty("currency")]
        string Currency { get; set; }
        [JsonProperty("amount")]
        decimal Amount { get; set; }
        [JsonProperty("available")]
        decimal Available { get; set; }

        public BitfinexWalletBalances()
        {
        }
    }
}
