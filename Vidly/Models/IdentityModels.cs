﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("ApplicationDbContext")
        {
        }

        public DbSet<Movie> Movies{ get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }

}