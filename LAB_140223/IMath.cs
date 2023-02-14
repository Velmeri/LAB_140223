using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_140223.N2
{
    internal interface IMath
    {
        int Max();
        int Min();
        double Avg();
        bool Search(int valueToSearch);
    }
}
