using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemploDotCEP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IEnumerable<DotCEP.Endereco> enderecos =
                                  DotCEP.Consultas.ObterListaDeEnderecos(DotCEP.UF.RS, "Pelotas", "Viana");

            var minhaRua = enderecos.
                                    Where(it => it.logradouro.Contains("Ferreira")).
                                    First();

            Console.WriteLine($"Rua lozalizada: {minhaRua.logradouro}");
        }
    }
}
