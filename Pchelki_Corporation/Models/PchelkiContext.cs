using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Pchelki_Corporation.Models.Entityes
{
    public class PchelkiContext : DbContext
    {
        #region DbSet
        public DbSet<Bee_Garden> Bee_Gardens { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Healing> Healings { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Sign> Signs { get; set; }
        public DbSet<Type_of_Work> Types_of_Work { get; set; }
        public DbSet<Type_of_Bees> Types_of_Bees { get; set; }
        public DbSet<Type_of_Beehives> Types_of_Beehives { get; set; }
        public DbSet<Tabel> Tabels { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Employee_by_Post> Employees_by_Posts { get; set; }
        public DbSet<Healing_of_Disease> Healings_of_Diseases { get; set; }
        public DbSet<Product_Sold> Product_Solds { get; set; }
        public DbSet<Sick> Sicks { get; set; }
        public DbSet<Sign_of_Disease> Signs_of_Diseases { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local)\SQLEXPRESS;Database=Pchelki_Corporation;Trusted_Connection=True;");
        }

        public PchelkiContext()
        {
            Database.EnsureCreated();
        }
    }
}
