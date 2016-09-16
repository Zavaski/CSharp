using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Disciplina
    {
        private int id { get;  }
        private string nome { get; set; }
        private int numeroAulasPraticas { get; set; }
        private int numeroAulasTeoricas { get; set; }
        private int numeroDeCreditos { get; set; }
        private int totalHorasAulas { get; set; }
        private int totalHorasRelogio { get; set; }
        private List<Disciplina> disciplinasRequisitos { get; set; }

        //################### CONSTRUCT #########################################
        public Disciplina()
        {
            disciplinasRequisitos = new List<Disciplina>();
        }

        //################### GET - SET #########################################

        public int Id
        {
            get { return id; }
   
        }

        public int NumeroTotalAulasTeoricas
        {
            get { return numeroAulasTeoricas; }
            set { numeroAulasTeoricas = value; }
        }

        public int TotalHorasRelogio
        {
            get { return totalHorasRelogio; }
            set { totalHorasRelogio = value; }
        }

        public int TotalHorasAulas
        {
            get { return totalHorasAulas; }
            set { totalHorasAulas = value; }
        }

        public int NumeroDeCreditos
        {
            get { return numeroDeCreditos; }
            set { numeroDeCreditos = value; }
        }


        public int NumeroAulasPraticas
        {
            get { return numeroAulasPraticas; }
            set { numeroAulasPraticas = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public List<Disciplina> DisciplinasRequisitos
        {
            get { return disciplinasRequisitos; }
            set { disciplinasRequisitos = value; }
        }

    }
}
