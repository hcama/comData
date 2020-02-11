using comData.core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace comData.data
{
    class AplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}
