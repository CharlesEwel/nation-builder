using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationBuilder.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<EventNation>()
                .HasOne(it => it.Event)
                .WithMany(t => t.NationEvents);
            builder.Entity<EventNation>()
                .HasOne(it => it.Nation)
                .WithMany(i => i.NationEvents);
        }
        public virtual DbSet<nation> Nations { get; set; }
        public virtual DbSet<Event> Events { get; set; }

        public virtual DbSet<EventNation> NationEvents {get; set;}
    }
}

