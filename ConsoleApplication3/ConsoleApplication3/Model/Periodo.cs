using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Periodo
    {
        private int numeroIdentificacao { get; set; }
        private int numeroAulasTeoricasPeriodo { get; set; }
        private int numeroAulasPraticasPeriodo { get; set; }
        private int numeroCreditosPeriodo { get; set; }
        private int totalHorasAulasPeriodo { get; set; }
        private int totalHorasRelogioPeriodo { get; set; }
        private List<Disciplina> disciplinas { get; set; }

        //################### CONSTRUCT #########################################
        public Periodo()
        {
            disciplinas = new List<Disciplina>();
           // this.calcularTotaisPeriodo();
        }

        //################### GET - SET #########################################
        public List<Disciplina> Disciplinas
        {
            get { return disciplinas; }
            set { disciplinas = value; }
        }

        public int TotalHorasRelogioPeriodo
        {
            get { return totalHorasRelogioPeriodo; }
            set { totalHorasRelogioPeriodo = value; }
        }

        public int TotalHorasAulasPeriodo
        {
            get { return totalHorasAulasPeriodo; }
            set { totalHorasAulasPeriodo = value; }
        }


        public int NumeroCreditosPeriodo
        {
            get { return numeroCreditosPeriodo; }
            set { numeroCreditosPeriodo = value; }
        }

        public int NumeroAulasPraticasPeriodo
        {
            get { return numeroAulasPraticasPeriodo; }
            set { numeroAulasPraticasPeriodo = value; }
        }

        public int NumeroAulasTeoricasPeriodo
        {
            get { return numeroAulasTeoricasPeriodo; }
            set { numeroAulasTeoricasPeriodo = value; }
        }

        public int NumeroIdentificacao
        {
            get { return numeroIdentificacao; }
            set { numeroIdentificacao = value; }
        }
  
    }
}
