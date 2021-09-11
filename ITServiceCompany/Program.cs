namespace ITServiceCompany
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;

    using static EmailSender.Example;
    public class Program
    {
        public static void Main(string[] args)
        {
            //Execute().Wait();
            CreateHostBuilder(args).Build().Run();
  
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
