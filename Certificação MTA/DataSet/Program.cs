using System;
using System.Data;
using Mono.Data.Sqlite;

namespace DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Data.DataSet dataSet = new System.Data.DataSet("Compras");

            DataTable tabela = new DataTable("Funcionários");
            object[] Nome = { "Cristiano", "João", "Cristian", "William" };

            tabela.Columns.Add("Nome");

            foreach (var item in Nome)
            {
                tabela.Rows.Add(item);
            }

            dataSet.Tables.Add(tabela);

            Console.WriteLine($"XML do DataSET:\n\n{dataSet.GetXml()}\n\nTabelas:\n{dataSet.Tables[0].TableName}");
        }
    }
}
