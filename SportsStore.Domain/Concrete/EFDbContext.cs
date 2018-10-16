using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Entities;
using System.Data.Entity;
using System.Data.SqlClient;

namespace SportsStore.Domain.Concrete
{
    class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }


        public string TestConnection()
        {
            try
            {
                this.Database.Connection.Open();
                this.Database.Connection.Close();
            }
            catch (SqlException)
            {
                return "connection error";
            }
            return "connection success";
        }

    }
}
