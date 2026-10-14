using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_Explorers.Models
{
    public class EvidencijaDolaska
    {
        public int Id_evidencija {  get; set; }
        public DateTime Datum {  get; set; }
        public string Prisutan {  get; set; }
        public string Razlog_izostanka { get; set; }
        public int Skupina_id { get; set; }
        public int Dijete_id { get; set; }
    }
}
