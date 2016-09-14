using ConsoleApplication3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Controller
{
    class CursoController
    {
      
        Curso curso;
        PeriodoController periodoController;

        public void cadastrarNovoCurso()
        {
            CursoView cursoView = new CursoView();
            periodoController = new PeriodoController();
            curso = cursoView.pegarInformacoesConsole();
            periodoController.salvarPeriodos(curso);

        }
        public void calcularTotaisCurso(Curso curso)
        {
            if (this.curso.NumeroPeriodos > 0)
            {
                foreach (Periodo per in curso.Periodos)
                {
                    curso.NumeroAulasTeoricasCurso += per.NumeroAulasTeoricasPeriodo;
                    curso.NumeroAulasPraticasCurso += per.NumeroAulasPraticasPeriodo;
                    curso.NumeroCreditosCurso += per.NumeroCreditosPeriodo;
                    curso.TotalHorasAulasCurso += per.TotalHorasAulasPeriodo;
                    curso.TotalHorasRelogioCurso += per.TotalHorasRelogioPeriodo;
                }
            }
        }


    }
}
