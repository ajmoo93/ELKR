using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProjekt.Model
{
    class RentedMovies
    {
        public Guid RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Guid MovieId { get; set; }
        public Guid PersonId { get; set; }

        public Person Person { get; set; }
        public Movies Movies { get; set; }
    }
}
