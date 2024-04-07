using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dame.Utils
{
    public static class Utils
    {
        /// <summary>
        /// Verifies if the row/column valeus are in the right interval [0-8)
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public static bool IsOutOfBounds(int row, int col)
        {
            return row < 0 || col < 0 || row >= 8 || col >= 8;
        }
    }
}
