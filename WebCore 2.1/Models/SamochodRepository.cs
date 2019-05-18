using System.Collections.Generic;
using System.Linq;

namespace WebCoreProjekt.Models
{
    public class SamochodRepository : ISamochodRepository
    {
        private readonly AppDbContext _appDbContext;

        public SamochodRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Samochod PobierzSamochodId(int samochodId)
        {
            return _appDbContext.Samochody.FirstOrDefault(s => s.Id == samochodId);
        }

        public IEnumerable<Samochod> PobierzWszystkieSamochody()
        {
            return _appDbContext.Samochody;
        }
    }
}
