

using ConsoleApp5.FactoryMethod.Singleton;

Computer compuhter = new Computer();
compuhter.Launch("Pentium");
Console.WriteLine(compuhter.OS.Name);

compuhter.OS = OS.GetInstance("Windows 11");
Console.WriteLine(compuhter.OS.Name);

var comp2 = new Computer();
comp2.Launch("Windows xp");
Console.WriteLine(comp2.OS.Name);

OS os = new OS("sdfsfds");
