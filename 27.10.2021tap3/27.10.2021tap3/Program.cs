using System;

namespace _27._10._2021tap3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, result = 0;
            Console.Write("Sayini daxil edin : ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                result += (number % 10);
                number = number / 10;
            }
            Console.WriteLine("Sayinin Reqemlerin Cemi : " + result);
            Console.ReadKey();
        }
    }
}
