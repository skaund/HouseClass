using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseClass
{
    class Program
    {
        static void Main(string[] args)
        {

            House house = new House();
            house.name = "Шотландская вислоухая";
            house.price = 6000;
            house.age = 2;
            house.place = "Китай";

            house.GetHouseInfo();

            House1 house1 = new House1();
            house1.type = "Семейство кошачих";
            house1.name = "Русская голубая";
            house1.place = "Россия";
            house1.price = 100;
            house1.age = 5;


            house1.GetHouse1Info();

            Console.ReadLine();
        }
    }
}
