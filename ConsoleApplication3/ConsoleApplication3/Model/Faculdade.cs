using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Faculdade
    {
        private String nomeEmpresarial = "PUCPR";
        private List<Curso> cursos { get; set; }


        public List<Curso> Cursos
        {
            get { return cursos; }
            set { cursos = value; }
        }

    }
}
