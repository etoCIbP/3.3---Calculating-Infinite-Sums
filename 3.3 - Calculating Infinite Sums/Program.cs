using System;

namespace _3._3___Calculating_Infinite_Sums
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 1;
            for (double i = Math.Pow(x, 3) / 3!, j = Math.Pow(x, 5) / 5!; ;)
            {
                Console.WriteLine($"i = {i}");
                Console.WriteLine($"j = {j}");
                i++; j++;
            }
                

        }
    }
}



//ДАЛЬШЕ Я ДЛЯ СЕБЯ ДЕЛАЛ ЭТО НЕ НУЖНО ПРОВЕРЯТЬ

//int i = 1;
//int x = 1;
//double O = 0;
//for (; ; )
//{
//    Console.WriteLine($"i = {i}");
//    i++;

//    for (; ; )
//    {
//       O = x - Math.Pow(x, 3) / 3! + Math.Pow(x, 5) / 5!
//            Console.WriteLine($"{i * x}");
//    }
//}

