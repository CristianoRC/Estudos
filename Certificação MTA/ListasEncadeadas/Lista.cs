namespace ListasEncadeadas
{
    public class Lista
    {
        public No PrimeiroNo { get; private set; }

        public No UltimoNo { get; private set; }

        public Lista()
        {
            PrimeiroNo = null;
        }

        public void Adicionar(string valor)
        {
            var novoNo = new No(valor, null);

            if (PrimeiroNo == null)
            {
                PrimeiroNo = novoNo;
            }
            else
            {
                UltimoNo.ProximoNo = novoNo;
            }

            UltimoNo = novoNo;
        }


        public string[] ObterValores()
        {
            string[] auxiliar = new string[0]; ;
            string[] valores = new string[0];
            No noAuxiliar = PrimeiroNo;

            do
            {
                auxiliar = new string[valores.Length + 1];
                //Cria um novo arra com o tamnho das informações obtidas até agora, e mais campo para a nova;

                auxiliar[valores.Length] = noAuxiliar.Valor;
                //Passa o novo valor para a ultima casa do array auxiliar;

                for (int i = 0; i < valores.Length; i++)
                {
                    auxiliar[i] = valores[i];
                    //Passa os antigos valores para a auxiliar
                }


                valores = auxiliar; //Passa os valores atualizados para o array de retorno.

                noAuxiliar = noAuxiliar.ProximoNo; // Pula para o próximo nó.
            }
            while (noAuxiliar != null); // Verifica se o nó é nulo(o último nó é semprenulo).

            return valores;
        }

        public void Deletar(string valor)
        {
            
        }
    }
}