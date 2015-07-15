using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsExperiment1.Models
{
    public class ComicDBContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
    }
}
