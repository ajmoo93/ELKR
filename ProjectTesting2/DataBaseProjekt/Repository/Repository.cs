using DataBaseProjekt.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseProjekt.DTO;
using DataBaseProjekt.Model;
using MovieStoreData;

namespace DataBaseProjekt.Repository
{
    public class Repository : IRepository
    {
        public void CreateAccount(AccountDTO dto)
        {
            throw new NotImplementedException();
        }

        public void CreateMovie(MovieDTO dto)
        {
            var newMovie = new Movie
            {

                MovieId = Guid.NewGuid(),
                MovieTitle = dto.MovieTitle,
                MovieRating = dto.MovieRating,
            };
            using(var context = new MovieStoreApplicationContext())
            {
                context.Movies.Add(newMovie);
                context.SaveChanges();
            }
        }

        public void CreatePerson(PersonDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(AccountDTO AccountId)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(MovieDTO MovieId)
        {
            throw new NotImplementedException();
        }

        public void EditAccount(AccountDTO dto)
        {
            throw new NotImplementedException();
        }

        public void EditMovie(MovieDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
