using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseExt
{
    public class SocksCompanyContext : DbContext
    {
        public DbSet<SockElement> Socks { get; set; }
        public DbSet<CompanyElement> Company { get; set; }
    }
}
