using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ElectricGuitar : MusicalInstrument
    {
        public static int cnt_ElectricGuitar;
        protected int string_count2;
        public int String_count2
        {
            get => string_count2;
            set
            {
                if (value != 0)
                {
                    string_count2 = value;
                }
                else
                {
                    string_count2 = 6;
                }
            }
        }
        static string[] Power_supplies = { "батарейки", "аккумуляторы", "ФИП", "USB" };
        protected string power_supply;
        public string Power_supply
        {
            get => power_supply;
            set
            {
                if (value != null)
                {
                    power_supply = value;
                }
                else
                {
                    power_supply = "не определён";
                }
            }
        }
        public ElectricGuitar() : base()
        {
            Power_supply = "не определён";
            cnt_ElectricGuitar++;
        }
        public ElectricGuitar(string title, string power_supply, int string_count2, int id) : base(title, id)
        {
            Power_supply = power_supply;
            String_count2 = string_count2;
            cnt_ElectricGuitar++;
        }
        public new void Show()
        {
            Console.WriteLine($"Источник питания: {Power_supply}, Количество струн: {String_count2}");
        }
        public override void VirtualShow()
        {
            Console.WriteLine($"ID: {id}, Электрогитара: Название инструмента: {Title}, Источник питания: {Power_supply}, Количество струн: {String_count2}");
        }
        //public override bool Equals(object obj)
        //{
        //    ElectricGuitar s = obj as ElectricGuitar;
        //    if (s != null)
        //    {
        //        return s.power_supply == this.power_supply && s.Title == this.Title;
        //    }
        //    else { return false; }
        //}
        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите количество струн электрогитары:");
            int ks;
            if (!int.TryParse(Console.ReadLine(), out ks))
            {
                Console.WriteLine("Число не распознано. Учтите, что число струн электрогитары может быть от 4 до 12. Повторите ввод: ");
                Init();
                return;
            }
            String_count2 = ks;
            string k = " ";
            Console.WriteLine("Введите источник питания инструмента: ");
            k = Console.ReadLine();
            if (k != null)
            {
                if (k == "батарейки" | k == "аккумуляторы" | k == "ФИП" | k == "USB")
                {
                    Power_supply = k;
                    return;
                }
                else
                {
                    Console.WriteLine("Источник питания не распознан. Повторите ввод: ");
                    Init();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Источник питания не распознан. Повторите ввод: ");
                Init();
                return;
            }
        }
        public override void RandomInit()
        {
            base.RandomInit();
            Power_supply = Power_supplies[rnd.Next(Power_supplies.Length)];
            String_count2 = rnd.Next(4, 13);
        }
        public override string ToString()
        {
            return $"ID: {id}, Электрогитара: Название инструмента: {Title}, Источник питания: {Power_supply}, Количество струн: {String_count2}";
        }
    }
}