using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using my_api.Models;

namespace my_api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }
        public DbSet<Stock> Stock{get; set;} =null!;//null! indique au compilateur d'ignorer l'analyse de nullabilité, car vous savez que ces propriétés seront correctement configurées par le framework.
        public DbSet<Comments> Comments{get;set;}= null!;
    }
}