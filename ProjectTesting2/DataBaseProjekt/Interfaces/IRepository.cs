using DataBaseProjekt.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProjekt.Interfaces
{
    public interface IRepository
    {
        void CreatePerson(PersonDTO dto);
    }
}
