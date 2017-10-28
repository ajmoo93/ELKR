using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProjekt.Model
{
    class Movies
    {
        public Guid MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string Director { get; set; }
        public int RentalDuration { get; set; }
        public int MovieRating { get; set; }
        

        public MovieCategory MovieCategory { get; set; }

    }
}
