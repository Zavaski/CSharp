using ConsoleApplication3.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //futura view
            Curso curso = new Curso();
            CursoController cur = new CursoController();
            cur.cadastrarNovoCurso();
         
            Disciplina disciplina = new Disciplina();
            DisciplinaController dis = new DisciplinaController();
            dis.cadastrarNovaDisciplina();



            Console.ReadLine();
        }
    }
}
