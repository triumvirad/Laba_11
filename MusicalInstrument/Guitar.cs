using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace ClassLibrary
{
    public class Guitar : MusicalInstrument
    {
        public static int cnt_Guitar;
        protected int string_count1;
        public int String_count1
        {
            get => string_count1;
            set
            {
                if(value != 0)
                {
                    string_count1 = value;
                }
                else
                {
                    string_count1 = 6;
                }
            }
        }
        public Guitar() : base()
        {
            String_count1 = 6;
            cnt_Guitar++;
        }
        public Guitar(string title, int string_count, int id) : base(title, id)
        {
            String_count1 = string_count;
            cnt_Guitar++;
        }
        public new void Show()
        {
            Console.WriteLine($"Количество струн гитары: {String_count1}");
        }
        public override void VirtualShow()
        {
            Console.WriteLine($"ID: {id}, Гитара: Название инструмента: {Title}, Количество струн: {String_count1}");
        }
        public override bool Equals(object obj)
        {
            Guitar s = obj as Guitar;
            if (s != null)
            {
                return s.string_count1 == this.string_count1 && s.Title == this.Title && s.id.number1 == this.id.number1;
            }
            else { return false; }
        }
        public override void Init()
        {
            base.Init();            
            Console.WriteLine("Введите количество струн гитары:");
            int sc;
            if (!int.TryParse(Console.ReadLine(), out sc))
            {
                if (4 <= sc && sc <= 12)
                {
                    String_count1 = sc;
                    return;
                }
                else
                {
                    Console.WriteLine("Число не распознано. Учтите, что число струн гитары может быть от 4 до 12. Повторите ввод: ");
                    Init();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Число не распознано. Учтите, что число струн гитары может быть от 4 до 12. Повторите ввод: ");
                Init();
                return;
            }
        }
        public override void RandomInit()
        {
            base.RandomInit();
            String_count1 = rnd.Next(4, 13);
        }
        public override string ToString()
        {
            return $"ID: {id}, Гитара: Название инструмента: {Title}, Количество струн: {String_count1}";
        }
        public MusicalInstrument GetBase()
        {
            return new MusicalInstrument(Title, id.number1);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode() * 23 + (string_count1.GetHashCode());
        }
    }
}