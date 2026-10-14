using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_Explorers.Models
{
    public class Biljeska
    {
        public int Id { get; set; }  // id_biljeska
        public string Naziv { get; set; }  // dropdown
        public DateTime Datum { get; set; }
        public string OpisBiljeske { get; set; }
        public string DodatneNapomene { get; set; }

        public int DijeteId { get; set; }  // FK
        public int ZaposlenikId { get; set; }  // FK
    }
}