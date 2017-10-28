using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreData
{
    class MovieStoreApplicationContext : DbContext
    {
        public MovieStoreApplicationContext() : base("MovieStoreContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MovieStoreApplicationContext>());
        }
    }
}
