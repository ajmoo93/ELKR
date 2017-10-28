using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProjekt.Model
{
    class MovieCategory
    {
        public Guid CategoryID { get; set; }
        public string CategoryName { get; set; }
        public Guid MovieId { get; set; }

        
    }
}
