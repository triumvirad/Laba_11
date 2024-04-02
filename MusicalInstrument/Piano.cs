using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Piano : MusicalInstrument
    {
        public static int cnt_Piano;
        static string[] Key_layouts = { "октавная", "шкальная", "дигитальная" };
        protected string key_layout;
        public string Key_layout
        {
            get => key_layout;
            set
            {
                if (value != null)
                {
                    key_layout = value;
                }
                else
                {
                    key_layout = "неизвестная";
                }
            }
        }
        protected int key_count;
        public int Key_count
        {
            get => key_count;
            set
            {
                if (value != 0)
                {
                    key_count = value;
                }
                else
                {
                    key_count = 66;
                }
            }
        }
        public Piano() : base()
        {
            Key_layout = "неизвестная";
            Key_count = 66;
            cnt_Piano++;
        }
        public Piano(string title, string key_layout, int key_count, int id) : base(title, id)
        {
            Key_layout = key_layout;
            Key_count = key_count;
            cnt_Piano++;
        }
        public new void Show()
        {
            Console.WriteLine($"Раскладка клавиш: {Key_layout}, Количество клавиш: {Key_count}");
        }
        public override void VirtualShow()
        {
            Console.WriteLine($"ID: {id}, Фортепиано: Название инструмента: {Title}, Раскладка клавиш: {Key_layout}, Количество клавиш: {Key_count}");
        }
        //public override bool Equals(object obj)
        //{
        //    Piano s = obj as Piano;
        //    if (s != null)
        //    {
        //        return s.Key_layout == this.Key_layout && s.key_count == this.key_count && s.Title == this.Title;
        //    }
        //    else { return false; }
        //}
        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите количество клавиш фотепиано:");
            int kc;
            if (!int.TryParse(Console.ReadLine(), out kc))
            {
                Console.WriteLine("Число не распознано. Учтите, что число клавиш фортепиано может быть от 1 до 88. Повторите ввод: ");
                Init();                  
                return;
            }
            Key_count = kc;
            string k = " ";
            Console.WriteLine("Введите раскладку клавиш фортепиано: ");
            k = Console.ReadLine();
            if (k != null)
            {
                if (k == "октавная" | k == "шкальная" | k == "дигитальная")
                {
                    Key_layout = k;
                    return;
                }
                else
                {
                    Console.WriteLine("Раскладка не распознана. Учитите, что раскладка может быть только октавной, шкальной или дигитальной. Повторите ввод: ");
                    Init();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Раскладка не распознана. Учитите, что раскладка может быть только октавной, шкальной или дигитальной. Повторите ввод: ");
                Init();
                return;
            }
        }
        public override void RandomInit()
        {
            base.RandomInit();
            Key_layout = Key_layouts[rnd.Next(Key_layouts.Length)];
            Key_count = rnd.Next(1, 88);
        }
        public override string ToString()
        {
            return $"ID: {id}, Фортепиано: Название инструмента: {Title}, Раскладка клавиш: {Key_layout}, Количество клавиш: {Key_count}";
        }
    }
}
