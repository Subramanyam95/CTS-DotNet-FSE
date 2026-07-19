Logger logger1 = Logger.GetInstance();
Logger logger2 = Logger.GetInstance();

logger1.Log("First Message");
logger2.Log("Second Message");

Console.WriteLine(logger1 == logger2);
