using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; 

namespace SuperLig_Codefirst.Entity
{
    class Context:DbContext
    {

        public Context()
        {
            Database.Connection.ConnectionString = @"Data Source=LAPTOP-38BN7A9V;Initial Catalog=SuperLig2;Integrated Security=true;"; 
        }

        public DbSet <Takim> Teams { get; set; }
        public DbSet  <Player> Players { get; set; }
        public DbSet<Antrenor> Trainers { get; set; }

    }
}
