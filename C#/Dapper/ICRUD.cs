using System.Collections.Generic;

namespace ExemplosDapper
{
    public interface ICRUD<T>
    {
        void Create();
        void Update();
        void Delete();
        T Read(string key);

    }
}
