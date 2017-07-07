using System;
using System.Runtime.Serialization;

namespace Execoes
{
    [Serializable]
    public class ExecoesExemplo : Exception
    {
        public ExecoesExemplo()
        {

        }

        public ExecoesExemplo(string message) : base(message)
        {
        }

        public ExecoesExemplo(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExecoesExemplo(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
