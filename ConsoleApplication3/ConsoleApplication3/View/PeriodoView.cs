using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.View
{
    class PeriodoView
    {
        Periodo periodo;

        //################### PEGAR DADOS TELA #########################################

        public Periodo pegarInformacoesConsole()
        {
            periodo = new Periodo();
            Console.WriteLine("Informe o numero do periodo");
            periodo.NumeroIdentificacao = Convert.ToInt16(Console.ReadLine());
            return periodo;
        }

    }
}
