using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_Explorers.Models
{
    public class Zaposlenik
    {
        public int Id_zaposlenik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string Korisnicko_ime { get; set; }

        public string Lozinka { get; set; }

        public bool ProvjeriLozinku(string lozinka)
        {
            return Lozinka == lozinka;
        }
        public string Uloga { get; set; }

        public string Email { get; set; }

    }

}