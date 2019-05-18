using System.Collections.Generic;
using WebCoreProjekt.Models;

namespace WebCoreProjekt.ViewModels
{
    public class HomeVM
    {
        public string Tytul { get; set; }
        public List<Samochod> Samochody { get; set; }
    }
}
