using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiny_Explorers.Models
{
    public class Skupina
    {
        public int Id_skupina { get; set; }
        public string Naziv { get; set; }
        public string DobniRaspon { get; set; }
        public int MaxKapacitet { get; set; }
        public int BrojUpisanih { get; set; }

    }
}
