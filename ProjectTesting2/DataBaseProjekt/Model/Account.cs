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
    class Account
    {
        [Key]
        public int AccountID {get;set;}
        public string Email { get; set; }
        public string Psw { get; set; }
        /*Account have many person */
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public virtual Person person { get; set; }
    }
}
