using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Mono.Data.Sqlite;

namespace ExemplosDapper
{
    public class Companhia : ICRUD<Companhia>
    {
        #region construtor
        public Companhia(string Nome)
        {
            Companhia ciaTemp = Read(Nome);

            this.cNome = ciaTemp.cNome;
            this.pais = ciaTemp.pais;
            this.valoracao = ciaTemp.valoracao;
        }

        public Companhia()
        {

        }

        #endregion

        #region Propriedades

        public string cNome { get; set; }
        public string pais { get; set; }
        public int valoracao { get; set; }
        #endregion

        #region CRUD padrão

        public void Create()
        {
            var sql = "insert into companhia values(@cnome, @valoracao, @pais)";
            var parametros = new DynamicParameters();

            parametros.Add("@cnome", this.cNome, DbType.String);
            parametros.Add("@valoracao", this.valoracao, DbType.Int32);
            parametros.Add("@pais", this.pais, DbType.String);


            using (var conn = new SqliteConnection(Properties.Resources.StrConn))
            {
                conn.Execute(sql, parametros);
            }
        }

        public Companhia Read(string nome)
        {
            var sql = "select t.* from companhia t where cnome = @cnome";
            var parametros = new DynamicParameters();

            parametros.Add("@cnome", nome, DbType.String, ParameterDirection.Input);

            using (var conn = new SqliteConnection(Properties.Resources.StrConn))
            {
                conn.Open();

                return conn.QuerySingle<Companhia>(sql, parametros);
            }
        }

        public void Update()
        {
            var sql = "update companhia set cNome = @cnome, " +
                "pais = @pais, valoracao = @valoracao " +
                "where cnome = 'Cristiano'";
            //Coloquei um nome aleatorio no Where, pois a tabela não tem um ID;

            var parametros = new DynamicParameters();

            parametros.Add("@cnome", this.cNome, DbType.String);
            parametros.Add("@pais", this.pais, DbType.String);
            parametros.Add("@valoracao", this.valoracao, DbType.Int32);

            using (var conn = new SqliteConnection(Properties.Resources.StrConn))
            {
                conn.Execute(sql, parametros);
            }
        }

        public void Delete()
        {
            var sql = "delete from companhia where cnome = @cnome";
            var parametros = new DynamicParameters();

            parametros.Add("@cnome", this.cNome, DbType.String, ParameterDirection.Input);

            using (var conn = new SqliteConnection(Properties.Resources.StrConn))
            {
                conn.Execute(sql, parametros);
            }
        }

        public static IEnumerable<Companhia> List()
        {
            var sql = "select t.* from companhia t";

            using (var conn = new SqliteConnection(Properties.Resources.StrConn))
            {
                conn.Open();

                var cias = conn.Query<Companhia>(sql);

                conn.Close();

                return cias;
            }
        }

        #endregion
    }
}
