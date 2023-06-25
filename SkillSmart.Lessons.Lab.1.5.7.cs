using System;
using System.Security.Policy;

///  1. singletone (те же фабрики) для экземпляров биржы
public class Exchange
{
    private Exchange(string exchange) { }

    public static readonly Exchange Binance = new Exchange("Binance");
    public static readonly Exchange Deribit = new Exchange("Deribit");
    public static readonly Exchange Moex = new Exchange("Moex");
}

public class Market
{
    private Market(Exchange exchange, string type) { }

    public class Binance
    {
        public static readonly Market Spot = new Market(Exchange.Binance, "Spot");
        public static readonly Market Futures = new Market(Exchange.Binance, "Futures");
        public static readonly Market FutCoins = new Market(Exchange.Binance, "FutCoins");
    }

    public class Deribit
    {
        public static readonly Market Options = new Market(Exchange.Deribit, "Options");
    }

    public class readonly Moex
    {
        public static readonly Market Securities = new Market(Exchange.Moex, "Securities");
        public static readonly Market Derivatives = new Market(Exchange.Moex, "Derivatives");
    }
}



///  2. Абстрактная фабрика для создания экземпляра клиента для Binace по типу рынка

interface IBinanceMarket : IMarketData {}

public class BinanceSpotMarket : IBinanceMarket {}

public class BinanceFuturesMarket : IBinanceMarket {}

public class BinanceFutCoinsMarket : IBinanceMarket {}

public class BinanceMarketFactory
{
    IBinanceMarket Create(Market market) => throw new NotImplementedException();
}

public class DeribitMarketFactory
{
    IDeribiMarket Crate(Market market) => throw new NotImplementedException();
}

public class MoexMarketFactory
{
    IMoexMarket Crate(Market market) => throw new NotImplementedException();   
}

/// аналогично для deribit, moex


/// 3. Абстрактаня фабрика по создания клиента по типу биржы

interface IMarketData { }

public class MarketDataFactory
{
    private static readonly BinanceMarketFactory binanceFactory = new BinanceMarketFactory();
    private static readonly DeribitMarketFactory deribitFactory = new DeribitMarketFactory();
    private static readonly MoexMarketFactory moexFactory = new MoexMarketFactory();

    IMarketData Create(Market market) => throw new NotImplementedException();
}