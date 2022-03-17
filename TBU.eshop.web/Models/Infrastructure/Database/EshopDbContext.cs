using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBU.eshop.web.Models.Entities;

namespace TBU.eshop.web.Models.Infrastructure.Database
{
    public class EshopDbContext : DbContext
    {
        public DbSet<CarouselItem> CarouselItems { get; set; }

        public EshopDbContext(DbContextOptions option) : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DatabaseInit init = new DatabaseInit();
            modelBuilder.Entity<CarouselItem>().HasData(init.GenerateCarouselItems());
        }

    }
}
