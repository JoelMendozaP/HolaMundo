using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su nombre:");
            string name = Console.ReadLine();
            Console.WriteLine("Hola " + name);
            Console
                .WriteLine("Son las " + DateTime.Now.ToString("hh:mm:ss tt"));
        }
    }
}
