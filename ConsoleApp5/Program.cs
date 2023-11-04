

using ConsoleApp5.FactoryMethod.Singleton;

var logger = new Logger();
Logger.Instance.LogInfo("info");
Logger.Instance.LogError("error");
Logger.Instance.LogWarning("warning");
