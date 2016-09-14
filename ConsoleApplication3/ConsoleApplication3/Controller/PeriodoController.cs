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
        PeriodoDAO periodoDAO;
      
        public void salvarPeriodos(Curso curso)
        {
            periodoDAO = new PeriodoDAO();
            periodoDAO.salvarPeriodos(curso);
          
        }

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
