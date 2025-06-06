using System.Text.Json.Serialization;
using CryptoExchange.Net.Converters.SystemTextJson;
using CryptoExchange.Net.Attributes;

namespace Bitget.Net.Enums.V2
{
    /// <summary>
    /// Self trade prevention mode
    /// </summary>
    [JsonConverter(typeof(EnumConverter<SelfTradePreventionMode>))]
    public enum SelfTradePreventionMode
    {
        /// <summary>
        /// None
        /// </summary>
        [Map("none")]
        None,
        /// <summary>
        /// Cancel taker order
        /// </summary>
        [Map("cancel_taker")]
        CancelTaker,
        /// <summary>
        /// Cancel maker order
        /// </summary>
        [Map("cancel_maker")]
        CancelMaker,
        /// <summary>
        /// Cancel both 
        /// </summary>
        [Map("cancel_both")]
        CancelBoth
    }
}
