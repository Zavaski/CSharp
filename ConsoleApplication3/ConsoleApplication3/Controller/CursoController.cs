using ConsoleApplication3.Dao;
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
        //################### SINGLETON #########################################
        private static CursoController instance;
        private CursoController() { }
        public static CursoController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CursoController();
                }
                return instance;
            }
        }
        Curso curso;

        //################### CADASTRO #########################################
        public void cadastrarNovoCurso()
        {
            CursoView cursoView = new CursoView();
          
            curso = cursoView.pegarInformacoesConsole();
            PeriodoController.Instance.instanciarPeriodos(curso);
            FaculdadeDAO.Instance.salvarCurso(curso);
            Console.Write("Curso criado com sucesso! ");
        }

        //################### BUSCA #########################################
        public Curso buscarCursoPorNome(String nomeCurso)
        {
           return FaculdadeDAO.Instance.buscarCurso(nomeCurso);
      
        }

        //################### CALCULO TOTAIS #########################################
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
