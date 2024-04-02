using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace Laba_11
{
    public class TestCollections
    {
        public Queue<Guitar> col1 = new Queue<Guitar>();
        public Queue<string> col2 = new Queue<string>();
        public Dictionary<MusicalInstrument, Guitar> col3 = new Dictionary<MusicalInstrument, Guitar>();
        public Dictionary<string, Guitar> col4 = new Dictionary<string, Guitar>();
        public Guitar? first, midddle, last, noexist;
        public TestCollections(int length)
        {
            for (int i = 0; i < length; i++)
            {
                try
                {
                    Guitar guitar = new Guitar();
                    guitar.RandomInit();
                    col1.Enqueue(guitar);
                    col2.Enqueue(guitar.ToString());
                    col3.Add(new MusicalInstrument(guitar.Title, guitar.id.number1), guitar);
                    col4.Add((new MusicalInstrument(guitar.Title, guitar.id.number1)).ToString(), guitar);
                    if (i == 0)
                    {
                        first = new Guitar(guitar.Title, guitar.String_count1, guitar.id.number1);
                    }
                    if (i == length / 2)
                    {
                        midddle = new Guitar(guitar.Title, guitar.String_count1, guitar.id.number1);
                    }
                    if (i == length - 1)
                    {
                        last = new Guitar(guitar.Title, guitar.String_count1, guitar.id.number1);
                    }
                }
                catch
                {
                    i--;
                }
            }
            noexist = new Guitar();
            noexist.RandomInit();
        }
    }
}