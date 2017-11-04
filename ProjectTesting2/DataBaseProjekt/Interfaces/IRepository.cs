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
        //IRepository är ingen del av mvc egentligen men är ett interface som du skapar
        //det gör så att du kan decouple dina repositorys från riktig implementation
        //och decoupling är bra för att
        // din kod blir mbättre återanvänd och detta är bra
        // din kod kan använda invensions eller dependency injections
        //och detta är bra för att det håller koden separead och gör
        //det enklare för unit Testning
        //Din kod kan bli Unit testad, och detta är bra speciellt i stora projekt
        //med stora algoritmer och och ökar din förståelse av vad du gör.
        //och det är bra för att koden blir bygg i så kallas best practices, att följa 
        //vanliga mönster.
        void CreatePerson(PersonDTO dto);
        void CreateAccount(AccountDTO dto);
        void EditAccount(AccountDTO dto);
        void DeleteAccount(AccountDTO dto);
        void CreateMovie(MovieDTO dto);
        void EditMovie(MovieDTO dto);
        void DeleteMovie(MovieDTO dto);
    }
}
