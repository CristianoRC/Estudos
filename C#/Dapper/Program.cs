using System;

namespace ExemplosDapper
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                #region Criação

                Console.WriteLine("Criação / Leitura de informações \n");
                var cia = new Companhia();

                cia.cNome = "Cristiano";
                cia.pais = "Brasil";
                cia.valoracao = 200;

                cia.Create();
                #endregion

                #region Leitura
                Console.WriteLine(cia.cNome);
                Console.WriteLine(cia.pais);
                Console.WriteLine(cia.valoracao);
                Console.WriteLine("\n======================\n\n");
                #endregion

                #region Edicao
                Console.WriteLine("Editando informações \n");

                cia.cNome = "Cristiano R. Cunha";
                cia.valoracao = 99999;
                cia.pais = "Rio Grande do Sul";
                cia.Update();

                Console.WriteLine(cia.cNome);
                Console.WriteLine(cia.pais);
                Console.WriteLine(cia.valoracao);
                Console.WriteLine("\n======================\n\n");
                #endregion

                #region Delete
                Console.WriteLine("Delete \n");
                Console.WriteLine($"Cia {cia.cNome} deletada com sucesso");
                //ciaBase.Delete();
                Console.WriteLine("\n======================\n\n");
                #endregion

                #region Listagem
                Console.WriteLine("Listagem\n");
                foreach (var item in Companhia.List())
                {
                    Console.WriteLine(item.cNome);
                    Console.WriteLine(item.pais);
                    Console.WriteLine(item.valoracao);
                    Console.WriteLine("--------------------\n");
                }
                Console.WriteLine("\n======================\n\n");
                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
