using System;
using System.Net.Http.Headers;

namespace Class_and_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            person p = new person("Пупкин", "Вася");

            Console.WriteLine(p.Name);
            Console.WriteLine(p.SekondName);

            Console.ReadLine();
        } 
    }
}
