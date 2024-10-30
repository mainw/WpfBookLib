using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.ModelGenericCommunications
{
    public interface IModelT<T>
    {
        void Add(T value);
        void Delete(T value);
        void Update(T value);

        T GetValue(string name);
    }
}
