StockMarket stock = new StockMarket("TCS");

IObserver mobile = new MobileApp("Subramanyam");
IObserver web = new WebApp("Investor");

stock.RegisterObserver(mobile);
stock.RegisterObserver(web);

stock.SetPrice(3500);

stock.SetPrice(3650);