using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseProjekt.Model
{
    class RentedMovies
    {
        public Guid RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        [ForeignKey("Movie")]
        public Guid MovieId { get; set; }
        [ForeignKey("Person")]
        public Guid PersonId { get; set; }

        public Person Person { get; set; }
        public Movies Movies { get; set; }
    }
}
