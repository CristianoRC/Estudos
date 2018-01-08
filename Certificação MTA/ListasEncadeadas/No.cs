namespace ListasEncadeadas
{
    public class No
    {
        public No(string valor, No proximoNo)
        {
            Valor = valor;
            ProximoNo = proximoNo;
        }

        public string Valor { get; set; }

        public No ProximoNo { get; set; }
    }
}