using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medical.Models;
using Microsoft.EntityFrameworkCore;

namespace Medical.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Users> users { get; set; }
        public DbSet<patientRecords> patientRecords { get; set; }
    }
}
