namespace Factory
{
    public interface IHelloFactory
    {
        ISayHello Create(ELinguages linguage);
    }
}