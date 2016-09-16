using ConsoleApplication3.View;
using ConsoleApplication3.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Controller
{
    class DisciplinaController
    {

        //################### SINGLETON #########################################
        private static DisciplinaController instance;
        private DisciplinaController() { }
        public static DisciplinaController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DisciplinaController();
                }
                return instance;
            }
        }
        //################### CADASTRO #########################################

        public void cadastrarNovaDisciplina()
        {
            
            DisciplinaView disciplinaView = new DisciplinaView();
            Console.Write("Informe o curso que deseja cadastrar a disciplina");
            String nomeCurso = Console.ReadLine();
            Curso curso = CursoController.Instance.buscarCursoPorNome(nomeCurso); 

            Console.Write("Informe o periodo que deseja cadastrar a disciplina");
            int numeroPeriodo = Convert.ToInt16(Console.ReadLine());

            Periodo periodo = PeriodoController.Instance.buscarPeriodoPorNumero(curso, numeroPeriodo);
            Disciplina disciplina = new Disciplina();

            disciplina = disciplinaView.pegarInformacoesConsole();
            FaculdadeDAO.Instance.salvarDisciplina(curso, periodo, disciplina);
            Console.Write("Disciplina cadastrada com sucesso! \n");
       
        }
    }
}
