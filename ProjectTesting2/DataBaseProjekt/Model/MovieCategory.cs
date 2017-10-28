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
    class MovieCategory
    {
        public Guid CategoryID { get; set; }
        public string CategoryName { get; set; }
        [ForeignKey("Movie")]
        public Guid MovieId { get; set; }
        public Movie Movies { get; set; }


    }
}
