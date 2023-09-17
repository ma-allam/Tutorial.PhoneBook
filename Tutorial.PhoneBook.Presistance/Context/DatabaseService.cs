using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Tutorial.PhoneBook.Application;
using Tutorial.PhoneBook.Application.Contracts;
using Tutorial.PhoneBook.Domain;
using Tutorial.PhoneBook.Domain.Entities;

namespace Tutorial.PhoneBook.Presistance.Context
{
    public partial class DatabaseService : DbContext, IDataBaseService
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }

        public DatabaseService()
        {
        }

        public DatabaseService(DbContextOptions<DatabaseService> options)
            : base(options)
        {
            Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=SQlDBPhoneBook;Integrated Security=true;TrustServerCertificate=True;");
        }
    }
}
