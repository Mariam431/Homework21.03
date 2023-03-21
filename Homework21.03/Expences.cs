using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework21._03
{
    delegate void ExDelegat(int a);
    internal class Expences
    {
        public decimal mnacord = 0;
        public Expences()
        {
            Console.WriteLine("Enter money");
        }
        public decimal k = decimal.Parse(Console.ReadLine());
        public void komunal(int a)
        {
            Console.WriteLine("How much is komunal?");
            decimal b  = decimal.Parse(Console.ReadLine());
            decimal mnacord = a - b;
            Console.WriteLine($"komunal tsaxs is {b} mnacord is {mnacord}");

        }
        public void mortgage(int a)
        {
            Console.WriteLine("How much is mortgage?");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal mnacord = a - b;
            Console.WriteLine($"mortgage is {b} mnacord is {mnacord}");

        }
        public void biznesVark(int a)
        {
            Console.WriteLine("How much is biznes vark?");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal mnacord = a - b;
            Console.WriteLine($"biznes vark is {b} mnacord is {mnacord}");
        }
        public void vark2(int a)
        {
            Console.WriteLine("How much is second vark?");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal mnacord = a - b;
            Console.WriteLine($"second vark is {b} mnacord is {mnacord}");


        }
        public void chnaxatesvac(int a)
        {
            Console.WriteLine("How much is chnaxatesvac casx?");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal mnacord = a - b;
            Console.WriteLine($"chnaxatesvac caxs is {b} mnacord is {mnacord}");
        }
        public void ITcaxser(int a)
        {
            Console.WriteLine("How much is IT casx?");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal mnacord = a - b;
            Console.WriteLine($"IT caxs is {b} mnacord is {mnacord}");

        }
        public void snund(int a)
        {
            Console.WriteLine("How much is snund?");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal mnacord = a - b;
            Console.WriteLine($"snund is {b} mnacord is {mnacord}");

        }
        public void oil(int a)
        {
            Console.WriteLine("How much is oil?");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal mnacord = a - b;
            Console.WriteLine($"oil is {b} mnacord is {mnacord}");

        }

    }
}
