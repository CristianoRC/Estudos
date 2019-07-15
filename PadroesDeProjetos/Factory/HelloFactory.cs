using Factory.SayHalloLinguages;
using System;

namespace Factory
{
    public class HelloFactory : IHelloFactory
    {
        public ISayHello Create(ELinguages linguage)
        {
            ISayHello linguageText;

            switch (linguage)
            {
                case ELinguages.English:
                    linguageText = new SayHelloEnglish();
                    break;
                case ELinguages.Portugues:
                    linguageText = new SayHelloPortuguese();
                    break;
                case ELinguages.Spanish:
                    linguageText = new SayHelloSpanish();
                    break;
                case ELinguages.Germany:
                    linguageText = new SayHelloGermany();
                    break;
                default:
                    throw new ArgumentException("Informed language does not exist");
            }

            return linguageText;
        }
    }
}