﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.View
{
    class CursoView
    {
        Curso curso;
        //################### PEGAR DADOS TELA #########################################
        public Curso pegarInformacoesConsole()
        {
           
            curso = new Curso();
            Console.Write("Informe o nome do curso \n");
            curso.Nome = Console.ReadLine();
            Console.Write("Informe o número de períodos \n");
            curso.NumeroPeriodos = Convert.ToInt16(Console.ReadLine());
            return curso;
        }


    }
}
