using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_Explorers.Models
{
    public class DijeteIzvjestaj
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Oib { get; set; }
        public DateTime Datum_rodenja { get; set; }
        public string Alergije { get; set; }
        public string Dijete_s_teskocama { get; set; }
        public string Napomena { get; set; }

        public DijeteIzvjestaj(Dijete dijete)
        {
            Ime = dijete.Ime;
            Prezime = dijete.Prezime;
            Oib = dijete.Oib;
            Datum_rodenja = dijete.Datum_rodenja;
            Alergije = dijete.Alergije;
            Dijete_s_teskocama = dijete.Dijete_s_teskocama;
            Napomena = dijete.Napomena;
        }
    }
}
