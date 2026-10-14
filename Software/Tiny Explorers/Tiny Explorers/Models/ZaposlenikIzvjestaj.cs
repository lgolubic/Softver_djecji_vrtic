using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_Explorers.Models
{
    public class ZaposlenikIzvjestaj
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string Korisnicko_ime { get; set; }

        public string Uloga { get; set; }

        public string Email { get; set; }

        public ZaposlenikIzvjestaj(Zaposlenik zaposlenik)
        {
            Ime = zaposlenik.Ime;
            Prezime = zaposlenik.Prezime;
            Korisnicko_ime = zaposlenik.Korisnicko_ime;
            Uloga = zaposlenik.Uloga;
            Email = zaposlenik.Email;
        }
    }
}
