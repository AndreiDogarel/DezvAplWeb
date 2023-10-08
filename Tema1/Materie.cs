using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    internal class Materie
    {
        public string Nume { get; set; }
        public int Durata { get; set; }
        public string FormaExaminare { get; set; }
        public DateTime DataExaminarii { get; set; }
        public Materie(string Nume, int Durata, string FormaExaminare, DateTime DataExaminare)
        {
            this.Nume = Nume;
            this.Durata = Durata;
            this.FormaExaminare = FormaExaminare;
            this.DataExaminarii = DataExaminare;
        }
    }
}
