using ConsoleApplication3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Controller
{
    class DisciplinaController
    {
        Disciplina disciplina;

        public void cadastrarNovaDisciplina()
        {
            //Console.Write("Selecione o período que deseja cadastrar a disciplina");
            DisciplinaView disciplinaView = new DisciplinaView();
            disciplina = disciplinaView.pegarInformacoesConsole();

       
        }
    }
}
