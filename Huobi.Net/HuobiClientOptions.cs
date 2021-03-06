﻿using CryptoExchange.Net.Objects;
using System;

namespace Huobi.Net
{
    public class HuobiClientOptions: ClientOptions
    {
        public HuobiClientOptions()
        {
            BaseAddress = "https://api.huobi.pro";
        }
    }

    public class HuobiSocketClientOptions : SocketClientOptions
    {
        /// <summary>
        /// The base address for the authenticated websocket
        /// </summary>
        public string BaseAddressAuthenticated { get; set; } = "wss://api.huobi.pro/ws/v1";

        public HuobiSocketClientOptions()
        {
            BaseAddress = "wss://api.huobi.pro/ws";
            SocketSubscriptionsCombineTarget = 10;
        }

        public HuobiSocketClientOptions Copy()
        {
            var copy = Copy<HuobiSocketClientOptions>();
            copy.BaseAddressAuthenticated = BaseAddressAuthenticated;
            return copy;
        }
    }
}
