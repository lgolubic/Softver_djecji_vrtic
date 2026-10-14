using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_Explorers.Models
{
    public class Obavijest
    {
        public int Id_obavijest { get; set; }
        public string Naziv {  get; set; }
        public string Opis { get; set; }
        public DateTime Datum { get; set; }
        public string Primatelj { get; set; }
        public int Zaposlenik_id { get; set; }
        public int Roditelj_id { get; set; }

    }
}
