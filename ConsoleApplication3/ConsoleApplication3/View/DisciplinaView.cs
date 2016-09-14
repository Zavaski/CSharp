using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.View
{
    class DisciplinaView
    {
        Disciplina disciplina;
        public Disciplina pegarInformacoesConsole()
        {
            disciplina = new Disciplina();
            Console.WriteLine("Informe o nome da disciplina \n");
            disciplina.Nome = Console.ReadLine();
            Console.Write("Informe o numero de Aulas Praticas da disciplina \n");
            disciplina.NumeroAulasPraticas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Informe o numero de Aulas Teoricas da disciplina \n");
            disciplina.NumeroTotalAulasTeoricas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Informe o numero de Creditos \n");
            disciplina.NumeroDeCreditos = Convert.ToInt16(Console.ReadLine());
            Console.Write("Informe o total de Horas Aulas \n");
            disciplina.TotalHorasAulas = Convert.ToInt16(Console.ReadLine());
            Console.Write("Informe o total de Horas Relogio \n");
            disciplina.TotalHorasRelogio = Convert.ToInt16(Console.ReadLine());
            return disciplina;
        }

    }
}
