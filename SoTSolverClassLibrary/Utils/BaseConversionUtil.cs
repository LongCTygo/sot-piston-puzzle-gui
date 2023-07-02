using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoTSolverClassLibrary.Utils
{
    public class BaseConversionUtil
    {
        public static int[] ToBinaryArray(int x)
        {
            int[] array = new int[32];
            for (int i = 31; i >= 0; i--)
            {
                int mask = 1 << i;
                array[31 - i] = (x & mask) != 0 ? 1 : 0;
            }
            return array;
        }
    }
}
