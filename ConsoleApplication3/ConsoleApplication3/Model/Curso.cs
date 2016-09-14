using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Curso
    {

        private string nome { set; get; }
        private List<Periodo> periodos { get; set; }
        private int numeroAulasTeoricasCurso { get; set; }
        private int numeroAulasPraticasCurso { get; set; }
        private int numeroCreditosCurso { get; set; }
        private int totalHorasAulasCurso { get; set; }
        private int totalHorasRelogioCurso { get; set; }
        private int numeroPeriodos;

        public Curso()
        {
            periodos = new List<Periodo>();
        //    this.calcularTotaisCurso();
         //   this.criarPeriodos();
        }

     
        public int NumeroPeriodos
        {
            get { return numeroPeriodos; }
            set { numeroPeriodos = value; }
        }

        public int TotalHorasRelogioCurso
        {
            get { return totalHorasRelogioCurso; }
            set { totalHorasRelogioCurso = value; }
        }


        public int TotalHorasAulasCurso
        {
            get { return totalHorasAulasCurso; }
            set { totalHorasAulasCurso = value; }
        }


        public int NumeroCreditosCurso
        {
            get { return numeroCreditosCurso; }
            set { numeroCreditosCurso = value; }
        }


        public int NumeroAulasPraticasCurso
        {
            get { return numeroAulasPraticasCurso; }
            set { numeroAulasPraticasCurso = value; }
        }


        public int NumeroAulasTeoricasCurso
        {
            get { return numeroAulasTeoricasCurso; }
            set { numeroAulasTeoricasCurso = value; }
        }


        public List<Periodo> Periodos
        {
            get { return periodos; }
            set { periodos = value; }
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}
