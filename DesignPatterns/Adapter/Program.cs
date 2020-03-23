using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationDTO config = null;
            AppConfiguration appConfiguration = null;

            appConfiguration = new ConfigurationAdapter();
            config = appConfiguration.ParseConfiguration("appsettings.json");

            Console.WriteLine($"Id:{config.Id}{Environment.NewLine}Name: {config.Name}{Environment.NewLine}CnnString: {config.ConnectionString}");

            // Console.Write($"{Environment.NewLine}Press any key to continue...");
            // Console.ReadKey();
        }
    }
}
