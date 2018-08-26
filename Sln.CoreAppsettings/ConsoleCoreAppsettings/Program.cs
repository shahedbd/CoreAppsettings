using Microsoft.Extensions.Configuration;
using System;
using System.IO;


namespace ConsoleCoreAppsettings
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            Console.WriteLine(configuration.GetConnectionString("MSSQLConn"));
            Console.ReadKey();
        }
    }
}
