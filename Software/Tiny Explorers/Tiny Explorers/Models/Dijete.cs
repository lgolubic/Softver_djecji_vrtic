using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiny_Explorers.Repositories;

namespace Tiny_Explorers.Models
{
    public class Dijete
    {
        public int Id_dijete { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Oib { get; set; }
        public DateTime Datum_rodenja { get; set; }
        public string Alergije { get; set; }    
        public string Dijete_s_teskocama { get;set; }
        public string Napomena { get; set; }
        public int Roditelj_id { get; set; }
        public int Skupina_id {  get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

        
        public string ImeRoditelja { get; set; }
        public string NazivSkupine { get; set; }
        public string EmailRoditelja { get; set; }
        public string TelefonRoditelja { get; set; }

    }
}
