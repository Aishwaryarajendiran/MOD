using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mentor_On_Demand.Data
{
    public class MODContext:IdentityDbContext
    {
        public MODContext([NotNullAttribute] DbContextOptions options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>(r => r.HasData(new IdentityRole
            {
                Id = "1",
                Name = "Admin"
            },
            new IdentityRole

            {
                Id = "2",
                Name = "Mentor"
            },
            new IdentityRole

            {
                Id = "3",
                Name = "Student"
            }

            ));
            base.OnModelCreating(builder);
        }
    }
}

