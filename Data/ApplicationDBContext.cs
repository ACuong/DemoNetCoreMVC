using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoDotNetMVC.Models;

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<DemoDotNetMVC.Models.Employee> Employee { get; set; }


        public DbSet<DemoDotNetMVC.Models.Product> Product { get; set; }

        public DbSet<DemoDotNetMVC.Models.Person> Person { get; set; }

        public DbSet<DemoDotNetMVC.Models.Student> Student { get; set; }

        public DbSet<DemoDotNetMVC.Models.Teacher> Teacher { get; set; }

        public DbSet<DemoDotNetMVC.Models.Category> Category { get; set; }
        
        public DbSet<DemoDotNetMVC.Models.Khoa> Khoa { get; set; } 
        public DbSet<DemoDotNetMVC.Models.ChuyenNganh> ChuyenNganh { get; set; }
        
        public DbSet<DemoDotNetMVC.Models.Animal> Animal { get; set; }
        public DbSet<DemoDotNetMVC.Models.Cat> Cat { get; set; } 
        public DbSet<DemoDotNetMVC.Models.Movies> Movies { get; set; }

    }
