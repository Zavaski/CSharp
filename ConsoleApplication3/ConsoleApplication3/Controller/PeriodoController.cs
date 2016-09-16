using ConsoleApplication3.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication3.Controller
{
    class PeriodoController
    {
        //################### SINGLETON #########################################
        private static PeriodoController instance;
        private PeriodoController() { }
        public static PeriodoController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PeriodoController();
                }
                return instance;
            }
        }
        //################### INSTANCIAR PERIODOS #########################################

        public void instanciarPeriodos(Curso curso)
        {
            FaculdadeDAO.Instance.salvarPeriodos(curso);
           
            //faculdadeDAO.salvarPeriodos(curso);
          
        }

        //################### SINGLETON #########################################
        public Periodo buscarPeriodoPorNumero(Curso curso, int numeroPeriodo)
        {
            
            return FaculdadeDAO.Instance.buscarPeriodo(curso, numeroPeriodo);

        }

        //################### CALCULO TOTAIS #########################################
        public void calcularTotaisPeriodo(Periodo periodo)
        {

            foreach (Disciplina dis in periodo.Disciplinas)
            {
                periodo.NumeroAulasTeoricasPeriodo += dis.NumeroTotalAulasTeoricas;
                periodo.NumeroAulasPraticasPeriodo += dis.NumeroAulasPraticas;
                periodo.NumeroCreditosPeriodo += dis.NumeroDeCreditos;
                periodo.TotalHorasAulasPeriodo += dis.TotalHorasAulas;
                periodo.TotalHorasRelogioPeriodo+= dis.TotalHorasRelogio;
            }

        }

    }
}
