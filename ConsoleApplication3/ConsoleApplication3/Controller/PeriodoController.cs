using ConsoleApplication3.Dao;
using ConsoleApplication3.View;
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
        //################### CADASTRO #########################################
        public void cadastrarPeriodo()
        {
             PeriodoView periodoView = new PeriodoView();
             Console.Write("Informe o Curso que deseja cadastrar o periodo \n");
             string nomeCurso = Console.ReadLine();
             Curso curso = CursoController.Instance.buscarCursoPorNome(nomeCurso);

             Periodo periodo = periodoView.pegarInformacoesConsole();
               
             FaculdadeDAO.Instance.salvarPeriodo(curso, periodo);

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
