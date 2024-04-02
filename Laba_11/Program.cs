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
            // !!ЧАСТЬ 1!!

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

            // !!ЧАСТЬ 2!!

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

            // !!ЧАСТЬ 3!!

            //TestCollections st1 = new TestCollections(1000);
            //Stopwatch sw1 = new Stopwatch();
            //sw1.Restart();
            //bool okValue1 = st1.col1.Contains(st1.first);
            //sw1.Stop();
            //if (okValue1)
            //{
            //    Console.WriteLine($"Найден за {sw1.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw1.ElapsedTicks}");
            //}
            //sw1.Restart();
            //bool okValue2 = st1.col1.Contains(st1.middle);
            //sw1.Stop();
            //if (okValue2)
            //{
            //    Console.WriteLine($"Найден за {sw1.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw1.ElapsedTicks}");
            //}
            //sw1.Restart();
            //bool okValue3 = st1.col1.Contains(st1.last);
            //sw1.Stop();
            //if (okValue3)
            //{
            //    Console.WriteLine($"Найден за {sw1.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw1.ElapsedTicks}");
            //}
            //sw1.Restart();
            //bool okValue4 = st1.col1.Contains(st1.noexist);
            //sw1.Stop();
            //if (okValue4)
            //{
            //    Console.WriteLine($"Найден за {sw1.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw1.ElapsedTicks}");
            //}

            //TestCollections st2 = new TestCollections(1000);
            //Stopwatch sw2 = new Stopwatch();
            //sw2.Restart();
            //bool okValue1 = st2.col2.Contains(st2.first.ToString());
            //sw2.Stop();
            //if (okValue1)
            //{
            //    Console.WriteLine($"Найден за {sw2.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw2.ElapsedTicks}");
            //}
            //sw2.Restart();
            //bool okValue2 = st2.col2.Contains(st2.middle.ToString());
            //sw2.Stop();
            //if (okValue2)
            //{
            //    Console.WriteLine($"Найден за {sw2.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw2.ElapsedTicks}");
            //}
            //sw2.Restart();
            //bool okValue3 = st2.col2.Contains(st2.last.ToString());
            //sw2.Stop();
            //if (okValue3)
            //{
            //    Console.WriteLine($"Найден за {sw2.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw2.ElapsedTicks}");
            //}
            //sw2.Restart();
            //bool okValue4 = st2.col2.Contains(st2.noexist.ToString());
            //sw2.Stop();
            //if (okValue4)
            //{
            //    Console.WriteLine($"Найден за {sw2.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw2.ElapsedTicks}");
            //}

            //TestCollections st3 = new TestCollections(1000);
            //Stopwatch sw3 = new Stopwatch();
            //sw3.Restart();
            //bool okValue11 = st3.col3.ContainsKey(st3.first.GetBase());
            //sw3.Stop();
            //if (okValue11)
            //{
            //    Console.WriteLine($"Найден за {sw3.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw3.ElapsedTicks}");
            //}
            //sw3.Restart();
            //bool okValue12 = st3.col3.ContainsValue(st3.first);
            //sw3.Stop();
            //if (okValue12)
            //{
            //    Console.WriteLine($"Найден за {sw3.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw3.ElapsedTicks}");
            //}

            //sw3.Restart();
            //bool okValue21 = st3.col3.ContainsKey(st3.middle.GetBase());
            //sw3.Stop();
            //if (okValue11)
            //{
            //    Console.WriteLine($"Найден за {sw3.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw3.ElapsedTicks}");
            //}
            //sw3.Restart();
            //bool okValue22 = st3.col3.ContainsValue(st3.middle);
            //sw3.Stop();
            //if (okValue12)
            //{
            //    Console.WriteLine($"Найден за {sw3.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw3.ElapsedTicks}");
            //}

            //sw3.Restart();
            //bool okValue31 = st3.col3.ContainsKey(st3.last.GetBase());
            //sw3.Stop();
            //if (okValue11)
            //{
            //    Console.WriteLine($"Найден за {sw3.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw3.ElapsedTicks}");
            //}
            //sw3.Restart();
            //bool okValue32 = st3.col3.ContainsValue(st3.last);
            //sw3.Stop();
            //if (okValue12)
            //{
            //    Console.WriteLine($"Найден за {sw3.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw3.ElapsedTicks}");
            //}

            //sw3.Restart();
            //bool okValue41 = st3.col3.ContainsKey(st3.noexist.GetBase());
            //sw3.Stop();
            //if (okValue11)
            //{
            //    Console.WriteLine($"Найден за {sw3.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw3.ElapsedTicks}");
            //}
            //sw3.Restart();
            //bool okValue42 = st3.col3.ContainsValue(st3.noexist);
            //sw3.Stop();
            //if (okValue12)
            //{
            //    Console.WriteLine($"Найден за {sw3.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw3.ElapsedTicks}");
            //}

            //TestCollections st4 = new TestCollections(1000);
            //Stopwatch sw4 = new Stopwatch();
            //sw4.Restart();
            //bool okValue11 = st4.col4.ContainsKey(st4.first.GetBase().ToString());
            //sw4.Stop();
            //if (okValue11)
            //{
            //    Console.WriteLine($"Найден за {sw4.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw4.ElapsedTicks}");
            //}
            //sw4.Restart();
            //bool okValue12 = st4.col4.ContainsValue(st4.first);
            //sw4.Stop();
            //if (okValue12)
            //{
            //    Console.WriteLine($"Найден за {sw4.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw4.ElapsedTicks}");
            //}
            //sw4.Restart();
            //bool okValue21 = st4.col4.ContainsKey(st4.middle.GetBase().ToString());
            //sw4.Stop();
            //if (okValue11)
            //{
            //    Console.WriteLine($"Найден за {sw4.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw4.ElapsedTicks}");
            //}
            //sw4.Restart();
            //bool okValue22 = st4.col4.ContainsValue(st4.middle);
            //sw4.Stop();
            //if (okValue12)
            //{
            //    Console.WriteLine($"Найден за {sw4.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw4.ElapsedTicks}");
            //}
            //sw4.Restart();
            //bool okValue31 = st4.col4.ContainsKey(st4.last.GetBase().ToString());
            //sw4.Stop();
            //if (okValue11)
            //{
            //    Console.WriteLine($"Найден за {sw4.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw4.ElapsedTicks}");
            //}
            //sw4.Restart();
            //bool okValue32 = st4.col4.ContainsValue(st4.last);
            //sw4.Stop();
            //if (okValue12)
            //{
            //    Console.WriteLine($"Найден за {sw4.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw4.ElapsedTicks}");
            //}
            //sw4.Restart();
            //bool okValue41 = st4.col4.ContainsKey(st4.noexist.GetBase().ToString());
            //sw4.Stop();
            //if (okValue11)
            //{
            //    Console.WriteLine($"Найден за {sw4.ElapsedTicks}");
            //}
            //else
            //{
            //    Console.WriteLine($"Не найден за {sw4.ElapsedTicks}");
            //}
            //sw4.Restart();
            //bool okValue42 = st4.col4.ContainsValue(st4.noexist);
            //sw4.Stop();
            //if (okValue12)
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
