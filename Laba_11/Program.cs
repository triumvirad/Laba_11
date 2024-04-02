using ClassLibrary;
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;
using Laba_11;

namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Queue

            //Queue queue = new Queue();
            //Console.WriteLine($"В очереди {queue.Count} элементов");
            //for (int i = 0; i < 5; i++)
            //{
            //    MusicalInstrument mj = new MusicalInstrument();
            //    mj.RandomInit();
            //    queue.Enqueue(mj);
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Guitar mj = new Guitar();
            //    mj.RandomInit();
            //    queue.Enqueue(mj);
            //}
            //Console.WriteLine("QUEUE");
            //foreach (MusicalInstrument item in queue)
            //    Console.WriteLine(item);
            //Console.WriteLine($"В очереди {queue.Count} элементов");
            //MusicalInstrument mz = new MusicalInstrument();
            //mz.Init();
            //queue.Enqueue(mz);
            //Console.WriteLine("QUEUE");
            //foreach (MusicalInstrument item in queue)
            //    Console.WriteLine(item);
            //queue.Dequeue();
            //Console.WriteLine("QUEUE");
            //foreach (MusicalInstrument item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"В очереди {queue.Count} элементов");
            //int cnt1 = 0;
            //int srznach = 0;
            //foreach (MusicalInstrument item in queue)
            //{
            //    if (item is Guitar guitar)
            //    {
            //        cnt1++;
            //        Console.WriteLine(item);
            //        srznach += guitar.String_count1;
            //    }
            //}
            //int res = srznach / cnt1;
            //Console.WriteLine($"Количество гитар в коллекции: {cnt1}");
            //Console.WriteLine($"Среднее количество струн всех гитар: {res}");
            //Console.WriteLine("QUEUECLONE");
            //Queue cloneQueue = (Queue)queue.Clone();
            //foreach (MusicalInstrument item in cloneQueue)
            //{
            //    Console.WriteLine(item);
            //}
            //object[] temp = queue.ToArray();
            //queue.Clear();
            //Array.Sort(temp);
            //foreach (MusicalInstrument item in temp)
            //{
            //    queue.Enqueue(item);
            //}
            //Console.WriteLine("Массив отсортирован");
            //foreach (MusicalInstrument item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //MusicalInstrument n = new MusicalInstrument("Zuzaza", 13);
            //n.Init();
            //int index = Array.BinarySearch(temp, n);
            //Console.WriteLine(index);

            //#endregion Queue

            //#region Stack

            //Stack<MusicalInstrument> satck = new Stack<MusicalInstrument>();
            //Console.WriteLine($"В очереди {satck.Count} элементов");
            //for (int i = 0; i < 5; i++)
            //{
            //    MusicalInstrument mj = new MusicalInstrument();
            //    mj.RandomInit();
            //    satck.Push(mj);
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Guitar mj = new Guitar();
            //    mj.RandomInit();
            //    satck.Push(mj);
            //}
            //Console.WriteLine("Stack");
            //foreach (MusicalInstrument item in satck)
            //    Console.WriteLine(item);
            //Console.WriteLine($"В очереди {satck.Count} элементов");
            //MusicalInstrument mz = new MusicalInstrument();
            //mz.Init();
            //satck.Push(mz);
            //Console.WriteLine("Stack");
            //foreach (MusicalInstrument item in satck)
            //{
            //    Console.WriteLine(item);
            //}
            //satck.Pop();
            //Console.WriteLine("Stack");
            //foreach (MusicalInstrument item in satck)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"В очереди {satck.Count} элементов");
            //int cnt1 = 0;
            //int srznach = 0;
            //foreach (MusicalInstrument item in satck)
            //{
            //    if (item is Guitar guitar)
            //    {
            //        cnt1++;
            //        Console.WriteLine(item);
            //        srznach += guitar.String_count1;
            //    }
            //}
            //int res = srznach / cnt1;
            //Console.WriteLine($"Количество гитар в коллекции: {cnt1}");
            //Console.WriteLine($"Среднее количество струн всех гитар: {res}");
            //Console.WriteLine("StackCLONE");
            //Stack cloneStack = new Stack();
            //foreach (MusicalInstrument item in satck)
            //{
            //    cloneStack.Push(item);
            //}
            //foreach (MusicalInstrument item in cloneStack)
            //{
            //    Console.WriteLine(item);
            //}
            //object[] temp = satck.ToArray();
            //satck.Clear();
            //Array.Sort(temp);
            //foreach (MusicalInstrument item in temp)
            //{
            //    satck.Push(item);
            //}
            //Console.WriteLine("Массив отсортирован");
            //foreach (MusicalInstrument item in satck)
            //{
            //    Console.WriteLine(item);
            //}
            //MusicalInstrument n = new MusicalInstrument("Zuzaza", 13);
            //n.Init();
            //int index = Array.BinarySearch(temp, n);
            //Console.WriteLine(index);

            //#endregion Stack

            TestCollections st1 = new TestCollections(1000);
            st1.col1.Contains(st1.first);
            Stopwatch sw1 = new Stopwatch();
            MusicalInstrument m1 = new MusicalInstrument();
            m1.Init();
            sw1.Restart();
            bool okValue1 = st1.col1.Contains(m1);
            sw1.Stop();
            if (okValue1)
            {
                Console.WriteLine($"Найден за {sw1.ElapsedTicks}");
            }
            else
            {
                Console.WriteLine($"Не найден за {sw1.ElapsedTicks}");
            }

            //TestCollections st2 = new TestCollections(1000);
            //st2.col1.Contains(st2.midddle);
            //Stopwatch sw2 = new Stopwatch();
            //MusicalInstrument m2 = new MusicalInstrument();
            //m2.Init();
            //sw2.Restart();
            //bool okValue2 = st2.col1.Contains(m2);
            //sw2.Stop();
            //if (okValue2)
            //{
            //    Console.WriteLine($"Найден за {sw2.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw2.ElapsedTicks}");
            //}

            //TestCollections st3 = new TestCollections(1000);
            //st3.col1.Contains(st3.last);
            //Stopwatch sw3 = new Stopwatch();
            //MusicalInstrument m3 = new MusicalInstrument();
            //m3.Init();
            //sw3.Restart();
            //bool okValue3 = st3.col1.Contains(m3);
            //sw3.Stop();
            //if (okValue3)
            //{
            //    Console.WriteLine($"Найден за {sw3.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw3.ElapsedTicks}");
            //}

            //TestCollections st4 = new TestCollections(1000);
            //st4.col1.Contains(st4.noexist);
            //Stopwatch sw4 = new Stopwatch();
            //MusicalInstrument m4 = new MusicalInstrument();
            //m4.Init();
            //sw4.Restart();
            //bool okValue4 = st4.col1.Contains(m4);
            //sw4.Stop();
            //if (okValue4)
            //{
            //    Console.WriteLine($"Найден за {sw4.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw4.ElapsedTicks}");
            //}
        }
    }
}
