using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_泛型
{
    class Test1<T> : IBaid
    {
        public string Name => throw new NotImplementedException();

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
