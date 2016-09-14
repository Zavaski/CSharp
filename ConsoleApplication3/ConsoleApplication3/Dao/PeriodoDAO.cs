using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Dao
{
    class PeriodoDAO
    {
        public void salvarPeriodos(Curso curso)
        {

            if (curso.NumeroPeriodos > 0)
            {

                for (int i = 0; i <= curso.NumeroPeriodos; i++)
                {
                    Periodo periodo = new Periodo();
                    periodo.NumeroIdentificacao = i;

                    curso.Periodos.Add(periodo);
                    //Console.WriteLine(i);
                }
            }
        }
    }
}
