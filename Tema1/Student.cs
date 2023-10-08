using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    internal class Student
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Id { get; set; }
        public DateTime DataNasterii { get; set; }
        public List<Materie> Materii { get; set; }

        public Student()
        {

        }
    }
}
