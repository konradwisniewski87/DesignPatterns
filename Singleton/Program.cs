
using Singleton.Configuration;

Console.WriteLine("-------------------------------------------------------------------");

//var cfg2 = new ConfigurationSingleton(); //error, constructor is private
var cfg = ConfigurationSingleton.GetInstance();
var cfg2 = ConfigurationSingleton.GetInstance();

if(ReferenceEquals(cfg, cfg2))
{
	Console.WriteLine("Reference are equels");
}

Console.WriteLine("-------------------------------------------------------------------");