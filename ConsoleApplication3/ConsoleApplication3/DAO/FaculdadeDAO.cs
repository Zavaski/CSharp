using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Dao
{
    class FaculdadeDAO
    {
        Faculdade faculdade;


        //################### SINGLETON #########################################
        private static FaculdadeDAO instance;
        private FaculdadeDAO() { }
        public static FaculdadeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FaculdadeDAO();
                }
                return instance;
            }
        }

       
        //################### SALVAR CURSO #########################################
        public void salvarCurso(Curso curso)
        {
            faculdade.Cursos.Add(curso);
      
        }
        //################### SALVAR PERIODO #########################################
        public void salvarPeriodo()
        {

        }

        //################### SALVAR DISCIPLINA ######################################
        public void salvarDisciplina()
        {

        }


        //################### BUSCAR CURSO #########################################
        public Curso buscarCurso(string nomeBusca)
        {
            foreach(Curso curso in faculdade.Cursos)
            {
                if (curso.Nome.Equals(nomeBusca))
                {
                     return curso;
                }
            }
            return null;
        }
        //################### BUSCAR PERIODO #########################################
        public Periodo buscarPeriodo(Curso curso, int numeroBusca)
        {
            foreach(Periodo periodo in curso.Periodos)
            {
                if (periodo.NumeroIdentificacao == numeroBusca)
                {
                    return periodo;
                }
            }
            return null;
        }

        //################### INSTANCIAR PERIODOS #########################################
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
