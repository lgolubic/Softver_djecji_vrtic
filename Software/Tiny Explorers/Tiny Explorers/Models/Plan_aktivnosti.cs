using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_Explorers.Models
{
    public class Plan_aktivnosti
    {
        public int Id_plan { get; set; }
        public string Naziv { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
        public string Komentar { get; set; }
        public string Materijal { get; set; }
        public string Realizirano { get; set; }
        public int Skupina_id { get; set; }

        public string NazivSkupine { get; set; }

    }
}
