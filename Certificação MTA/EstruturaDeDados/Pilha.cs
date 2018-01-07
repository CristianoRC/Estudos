namespace EstruturaDeDados
{
    public sealed class Pilha
    {

        private Funcionario[] pilhaFuncionarios;
        public int Tamanho => pilhaFuncionarios.Length;
        public Funcionario ValorNoTopo
        {
            get
            {
                if (pilhaFuncionarios.Length != 0)
                {
                    return pilhaFuncionarios[pilhaFuncionarios.Length - 1];
                }
                throw new System.Exception("Não há funcionários na pilha");
            }
        }

        public void Empilhar(Funcionario funcionario)
        {
            var pilhaTemporaria = new Funcionario[pilhaFuncionarios.Length + 1];

            for (int i = 0; i < pilhaFuncionarios.Length; i++)
            {
                pilhaTemporaria[i] = pilhaFuncionarios[i];
            }

            pilhaTemporaria[pilhaTemporaria.Length - 1] = funcionario;

            pilhaFuncionarios = pilhaTemporaria;
        }

        public void Desempilhar()
        {
            if (pilhaFuncionarios.Length != 0)
            {
                var pilhaTemporaria = new Funcionario[pilhaFuncionarios.Length - 1];

                for (int i = 0; i < pilhaFuncionarios.Length - 1; i++)
                {
                    pilhaTemporaria[i] = pilhaFuncionarios[i];
                }

                pilhaFuncionarios = pilhaTemporaria;
            }
        }

        public decimal SomarSalarios()
        {
            decimal montante = 0;

            foreach (var item in pilhaFuncionarios)
            {
                montante += item.Salario;
            }

            return montante;
        }

        public Funcionario[] Listar()
        {
            return pilhaFuncionarios;
        }

        #region Construtores
        public Pilha()
        {
            pilhaFuncionarios = new Funcionario[0];
        }

        public Pilha(Funcionario[] funcionarios)
        {
            pilhaFuncionarios = funcionarios;
        }
        #endregion
    }
}