using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Ejercicio 1---");
            Console.WriteLine("Escriba el nombre:");
            string name = Console.ReadLine();
            Console.WriteLine("Escriba el apellido:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Escriba la edad:");
            string age = Console.ReadLine();
            int ageInt = Int32.Parse(age);
            Console.WriteLine(name + " sabe programar? (Y/N)");
            string know = Console.ReadLine();
            Console
                .WriteLine(name +
                " " +
                lastName +
                " de " +
                ageInt +
                " años " +
                (know == "Y" ? "sabe programar" : "no sabe programar"));

            // Console.WriteLine("---Ejercicio 2---");
            // Coche:
            int puertas = 4;
            int ruedas = 4;
            string marca = "Toyota";
            string ITV = "abc1234";

            // Mesa:
            float peso = 84.24f;
            float largo = 74.24f;
            string material = "Metal";
            string color = "rojo";

            // Console.WriteLine("---Ejercicio 3---");
            Console.WriteLine("---Ejercicio 3---");
            Console.WriteLine("Escriba el número a verificar:");
            string num = Console.ReadLine();

            int numInt = Int32.Parse(num);
            Console.WriteLine(numInt + " es mayor o igual a 18?");
            Console.WriteLine(numInt >= 18);
            Console.WriteLine("Un char es ‘a’?");
            Console.WriteLine(Char.IsLetter('a'));
            Console
                .WriteLine("Se cumplen dos condiciones a la vez (ambas verdaderas)");
            Console.WriteLine(20 >= 18 && 70 < 108);
            Console
                .WriteLine("Se cumple una de dos condiciones a la vez (una true y otra false)");
            Console.WriteLine(20 >= 18 && 70 > 108);
        }
    }
}
