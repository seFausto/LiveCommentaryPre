using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Raven.Client.Document;

namespace LiveCommentaryServiceModel
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var documentStore = new DocumentStore
            {
                Url = "http:\\localhost:8080",
                DefaultDatabase= "LiveCommentary"
            };

            documentStore.Initialize();

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
