using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_Explorers.Models
{
    public class SkupinaIzvjestaj
    {
        public string Naziv { get; set; }
        public string DobniRaspon { get; set; }
        public int MaxKapacitet { get; set; }
        public int BrojUpisanih { get; set; }

        public SkupinaIzvjestaj(Skupina skupina)
        {
            Naziv = skupina.Naziv;
            DobniRaspon = skupina.DobniRaspon;
            MaxKapacitet = skupina.MaxKapacitet;
            BrojUpisanih = skupina.BrojUpisanih;
        }
    }
}
