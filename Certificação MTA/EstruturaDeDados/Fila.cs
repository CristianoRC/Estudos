namespace EstruturaDeDados
{
    public class Fila
    {
        private Funcionario[] filaFuncionarios;

        public int Tamanho => filaFuncionarios.Length;
        public Funcionario Primeiro
        {
            get
            {
                if (filaFuncionarios.Length != 0)
                {
                    return filaFuncionarios[0];
                }
                throw new System.Exception("Não há funcionários na fila");
            }
        }

        public void Enfileirar(Funcionario funcionario)
        {
            var filaTemporaria = new Funcionario[filaFuncionarios.Length + 1];

            for (int i = 0; i < filaFuncionarios.Length; i++)
            {
                filaTemporaria[i] = filaFuncionarios[i];
            }

            filaTemporaria[filaTemporaria.Length - 1] = funcionario;

            filaFuncionarios = filaTemporaria;
        }

        public void Desenfileirar()
        {
            if (filaFuncionarios.Length > 0)
            {
                var filaTemporaria = new Funcionario[filaFuncionarios.Length - 1];

                for (int i = 1; i < filaFuncionarios.Length; i++)
                {
                    filaTemporaria[(i - 1)] = filaFuncionarios[i];
                }

                filaFuncionarios = filaTemporaria;
            }

        }

        public Funcionario[] Listar()
        {
            return filaFuncionarios;
        }

        #region Construtores
        public Fila()
        {
            filaFuncionarios = new Funcionario[0];

        }

        public Fila(Funcionario[] funcionarios)
        {
            filaFuncionarios = funcionarios;

        }

        #endregion
    }
}