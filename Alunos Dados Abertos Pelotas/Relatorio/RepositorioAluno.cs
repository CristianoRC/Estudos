using MongoDB.Bson;
using MongoDB.Driver;

namespace Relatorio
{
    public class RepositorioAluno
    {

        public RepositorioAluno()
        {
            var cliente = new MongoClient(@"mongodb://AlunosPelotas:Pelotas20*18@ds016298.mlab.com:16298/estudos");
            var dataBase = cliente.GetDatabase("estudos");
            alunos = dataBase.GetCollection<Aluno>("AlunosPelotas");
        }

        private IMongoCollection<Aluno> alunos { get; set; }

        public Aluno Buscar(int matricula)
        {
            return alunos.Find(x => x.Matricula.Equals(matricula)).FirstOrDefault();
        }

        public long ObterNumeroDeAlunosSexo(ESexo sexo)
        {
            if (sexo.Equals(ESexo.Feminino))
            {
                return alunos.Find(aluno => aluno.Sexo.Equals(ESexo.Feminino)).Count();
            }
            else if (sexo.Equals(ESexo.Masculino))
            {
                return alunos.Find(aluno => aluno.Sexo.Equals(ESexo.Masculino)).Count();
            }

            return alunos.Find(aluno => aluno.Sexo != ESexo.Masculino.ToString() && aluno.Sexo != ESexo.Feminino.ToString()).Count();
        }


        public long ObterNumeroDeAlunosBairro(string bairro)
        {
            return alunos.Find(aluno => aluno.Bairro.Equals(bairro.ToUpper())).Count();
        }

        public long ObterNumeroDeAlunosEscola(string escola)
        {
            return alunos.Find(aluno => aluno.Escola.Equals(escola.ToUpper())).Count();
        }

        public long ObterNumeroDeAlunosComNecessidades()
        {
            return alunos.Find(aluno => aluno.NecessidadesEducacionaisEspeciais != "SEM NECESSIDADES ESPECIAIS").Count();
        }

        public long ObterNumeroDeAlunos()
        {
            return alunos.Find(x => true).Count();
        }

        public long ObterNumeroDeAlunosFormandos()
        {
            return alunos.Find(aluno => aluno.Serie.Contains("8ª") || aluno.Serie.Contains("9º")).Count();
        }
    }
}
