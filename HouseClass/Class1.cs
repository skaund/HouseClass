using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseClass
{
    class House
    {
        public double price { get; set; }
        public int age { get; set; }
        public string place { get; set; }
        public string name { get; set; }

        public void GetHouseInfo()
        {
            Console.WriteLine($"Адрес: {name}| |Возраст: {age}| |Место: {place}|");
        }
    }


    class House1 : House
    {
        public string type { get; set; }

        public virtual void GetHouse1Info()
        {
            Console.WriteLine($"Адрес: {name}| |Возраст: {age}| |Место: {place}| |Цена дома: {price}| |Тип: {type}");
        }
    }
}