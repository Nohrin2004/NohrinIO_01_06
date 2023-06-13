using Block1Variant6.Classes;
using System;

namespace Block1Variant6
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Вывод переменной Q");
            BaseClass class1 = new BaseClass("Apple", 10, 5);
            ChildClass class2 = new ChildClass("Xiaomi", 15, 3, 2018);
            class1.PrintInfo(); //вывод информации
            class2.PrintInfo();
        }
    }
}
