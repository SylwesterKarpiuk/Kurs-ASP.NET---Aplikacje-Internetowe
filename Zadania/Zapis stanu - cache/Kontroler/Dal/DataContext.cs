using Kontroler.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kontroler.Dal
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DataConnectionString")
        {

        }
        public DbSet<Data> Dataa {get; set;}
    }
}