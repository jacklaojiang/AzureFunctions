using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using RealEstateManagement;
using Serilog;

[assembly: FunctionsStartup(typeof(Startup))]
namespace RealEstateManagement
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            Log.Logger = new LoggerConfiguration()
               .Enrich.FromLogContext()
               .WriteTo.Console()
               .CreateLogger();

            Log.Information("Starting Startup");
            
        }
    }
}
