using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_Explorers.Models
{
    public class Raspored
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string Smjena { get; set; }
        public string Zamjena { get; set; }
        public int ZaposlenikId { get; set; }
    }

}
