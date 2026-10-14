using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_Explorers.Models
{
    public class Racun
    {
        public int Id_racun { get; set; }
        public string Mjesec { get; set; }
        public string Skupina { get; set; }
        public int Izostanci { get; set; }
        public int Sati_boravka { get; set; }
        public int Roditelj_id { get; set; }
        public string Dijete_s_teskocama { get; set; }
        public decimal Osnovna_cijena { get; set; }
        public decimal Izostanci_cijena { get; set; }
        public decimal Ukupna_cijena { get; set; }
        public int Dijete_id { get; set; }

        public string ImePrezimeRoditelja { get; set; }
        public string ImePrezimeDjeteta { get; set; }



    }
}
