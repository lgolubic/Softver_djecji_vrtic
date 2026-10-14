using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers.Models
{
    public class EvidencijaDolaskaIzvjestaj
    {
        public DateTime Datum {  get; set; }
        public string Prisutan {  get; set; }
        public string Razlog_izostanka { get; set; }
        public string Skupina { get; set; }

        public EvidencijaDolaskaIzvjestaj(EvidencijaDolaska evidencija)
        {
            Datum = evidencija.Datum;
            Prisutan = evidencija.Prisutan;
            Razlog_izostanka = evidencija.Razlog_izostanka;

            SkupineRepository repo = new SkupineRepository();
            var skupina = repo.GetSkupina(evidencija.Skupina_id);
            Skupina = skupina?.Naziv ?? "Nepoznato";

        }
    }
}
