using DataBaseProjekt.Model;
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
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<RentedMovie> RentedMovies { get; set; }
        public DbSet<Person> Persons { get; set; }

        public MovieStoreApplicationContext() : base("MovieStoreContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MovieStoreApplicationContext>());

        }
    }
}
