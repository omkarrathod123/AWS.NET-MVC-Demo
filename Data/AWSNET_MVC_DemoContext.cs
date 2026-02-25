using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AWS.NET_MVC_Demo.Models;

namespace AWS.NET_MVC_Demo.Data
{
    public class AWSNET_MVC_DemoContext : DbContext
    {
        public AWSNET_MVC_DemoContext (DbContextOptions<AWSNET_MVC_DemoContext> options)
            : base(options)
        {
        }

        public DbSet<AWS.NET_MVC_Demo.Models.Product> Product { get; set; } = default!;
    }
}
