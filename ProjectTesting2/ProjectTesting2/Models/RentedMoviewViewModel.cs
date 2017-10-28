using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTesting2.Models
{
    public class RentedMoviewViewModel
    {
        public Guid RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}