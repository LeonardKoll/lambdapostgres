using System;
using System.Collections.Generic;
using System.Text;

namespace lambdamail
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.IO;
    using Microsoft.EntityFrameworkCore;

    namespace ConsoleApp.PostgreSQL
    {
        public class TryoutContext : DbContext
        {
            string details = File.ReadAllText(@".connection");
            public DbSet<Calcs> Calcs { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseNpgsql(details);
        }

        [Table("calcs")]
        public class Calcs
        {
            [Key]
            public int id { get; set; }

            public string term { get; set; }
            public double result { get; set; }
        }

    }
}
