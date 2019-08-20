using System;
using GroceryStoreRewards.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GroceryStoreRewards.Areas.Identity.IdentityHostingStartup))]
namespace GroceryStoreRewards.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
<<<<<<< HEAD


=======
>>>>>>> da6537fc5b46cfc1f9d8324d191149831ddf8724
}