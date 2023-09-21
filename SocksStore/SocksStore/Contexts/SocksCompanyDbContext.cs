using SocksStore.DBModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocksStore.Contexts
{
    public class SocksCompanyDbContext : DbContext
    {
        public SocksCompanyDbContext() : base("SocksDataBase")
        {

        }
        public DbSet<SocksTable> Socks { get; set; }
        public DbSet<CompanyTable> Companys { get; set; }
    }
}
