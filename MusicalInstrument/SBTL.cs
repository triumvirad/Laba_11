using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SBTL : IComparer
    {
        public int Compare(object? x, object? y)
        {
            MusicalInstrument m1 = x as MusicalInstrument;
            MusicalInstrument m2 = y as MusicalInstrument;
            int comp = String.Compare(m1.Title, m2.Title);
            if (comp == 1 || comp == -1)
            {
                return comp;
            }
            if (m1.id.number1 < m2.id.number1)
            {
                return -1;
            }
            if (m1.id.number1 > m2.id.number1)
            {
                return 1;
            }
            return 0;
        }
    }
}
