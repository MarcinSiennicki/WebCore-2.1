using System.Collections.Generic;

namespace WebCoreProjekt.Models
{
    public interface ISamochodRepository
    {
        IEnumerable<Samochod> PobierzWszystkieSamochody();
        Samochod PobierzSamochodId(int samochodId);
    }
}
