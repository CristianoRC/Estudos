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

    }
}