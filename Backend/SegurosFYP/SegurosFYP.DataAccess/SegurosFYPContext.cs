using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SegurosFYP.DataAccess.Context;
using System;

namespace SegurosFYP.DataAccess
{
    public class SegurosFYPContext : DbsegurosfypContext
    {
        public static string ConnectionString { get; set; }

        public SegurosFYPContext()
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        public static void BuildConnectionString(string connection)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder { ConnectionString = connection };
            ConnectionString = connectionStringBuilder.ConnectionString;
        }
    }
}
