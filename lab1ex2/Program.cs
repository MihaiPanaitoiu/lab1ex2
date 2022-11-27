using System;

namespace lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura


            // Optiunea 1

            /*
            Console.WriteLine("Acest program va calcula media aritmetica a trei numere");

            Console.WriteLine("Introduceti primul numar:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti ap treilea numar:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Media aritmetica celor 3 numere este: " + (a + b + c) / 3);

            */


            //Optiunea 2

            /*
            static int Avg(int a, int b, int c)
            {
                return (a + b + c) / 3;
            }

            Console.WriteLine("Acest program va calcula media aritmetica a trei numere");

            Console.WriteLine("Introduceti primul numar:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti ap treilea numar:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Media aritmetica celor 3 numere este: " + Avg(a, b, c));
            */



            //Optiunea 3

            static int Aggr(int[] nums)
            {
                int total = 0;

                foreach (int num in nums)
                {
                    total += num;
                }
                return total;
            }


            static int Avg(int[] nums)
            {
                return Aggr(nums) / nums.Length;
            }



            Console.WriteLine("Acest program va calcula media aritmetica a trei numere");

            Console.WriteLine("Introduceti primul numar:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti ap treilea numar:");
            int c = int.Parse(Console.ReadLine());

            int[] nums = { a, b, c };

            Console.WriteLine("Media aritmetica celor 3 numere este: " + Avg(nums));
     
        }
    }
}
