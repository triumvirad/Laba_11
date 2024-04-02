using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ICM : IComparer
    {
        public int Compare(object? x, object? y) 
        {
            Guitar m1 = x as Guitar;
            Guitar m2 = y as Guitar;
            if (m1.String_count1 < m2.String_count1)
            {
                return -1;
            }
            if (m1.String_count1 == m2.String_count1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
