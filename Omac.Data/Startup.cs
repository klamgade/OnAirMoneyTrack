using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Omack.Data
{
    public class Startup
    {
        public static IConfigurationRoot Configuration { get; set; }
        public static void Main(string[] args = null)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), @"..\.."))
                .AddJsonFile("config.json");
            Configuration = builder.Build();
        }
    }
}
