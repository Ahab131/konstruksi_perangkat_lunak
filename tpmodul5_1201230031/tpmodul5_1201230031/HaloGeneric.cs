using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1201230031
{
    class HaloGeneric<T>
    {
        public void SapaUser(T nama)
        {
            Console.WriteLine("Halo user " + nama);
        }
    }
}
