using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem_C
{
    public class BankSystemDbContext : DbContext
    {

        public BankSystemDbContext() : base("Server=A-104-04;Database=BankSystem;Trusted_Connection=true;")
        {
       Database.CreateIfNotExists();
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
