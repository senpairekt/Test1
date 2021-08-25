using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Data
{
    public class DutchSeeder
    {
        private readonly DutchContext _ctx;
        private readonly IWebHostEnvironment _env;
        public DutchSeeder(DutchContext ctx, IWebHostEnvironment env)
        {
            _ctx = ctx;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();

            if (!_ctx.Products.Any())
            {
                // Need to create sample data
                var filePath = Path.Combine(_env.ContentRootPath, "Data/art.json");
                var json = File.ReadAllText(filePath);
            }
        }
    }
}
