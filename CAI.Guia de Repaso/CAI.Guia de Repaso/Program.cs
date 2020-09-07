using System;

namespace CAI.Guia_de_Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            //R_Nro. 887266

            //EjercicioI();
            //EjercicioII();
            //EjercicioIV();
            //EjercicioV();
            EjercicioVI();
        }
        static void EjercicioI()
        {
            for (int i = 0; i <= 266; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + "FooBar");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + "Bar");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + "Foo");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void EjercicioII()
        {
            int numero = 266;
            for (int i = 2; i <= numero / 2; i++)
            {
                if (numero % i == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i + "Es primo y multiplo de 3");
                }
                else if (numero % i == 0)
                {
                    Console.WriteLine(i + "Es primo");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + "Es multiplo de 3");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void EjercicioIII()
        {
            string palabra, palabraV, palabra2 = "";

            Console.WriteLine("Ingrese la palabra a chequear: ");
            palabra = Convert.ToString(Console.ReadLine());

            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                palabraV = palabra.Substring(i, 1);
                palabra2 = palabra2 + palabraV;
            }
            if (palabra == palabra2)
            {
                Console.WriteLine($"La palabra {palabra} es palíndromo");
            }
            else
            {
                Console.WriteLine($"La palabra {palabra} no es palíndromo");
            }
        }
        static void EjercicioIV()
        {
            string palabra1, palabra2;
            int aux1 = 0, aux2 = 0;

            Console.WriteLine("Ingrese la primera palabra");
            palabra1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda palabra");
            palabra2 = Convert.ToString(Console.ReadLine());

            if (palabra1.Length == palabra2.Length)
            {
                for (int i = 0; i < palabra1.Length; i++)
                {
                    for (int a = 0; a < palabra2.Length; a++)
                    {
                        if (palabra1[i] == palabra2[a])
                        {
                            aux1++;
                        }
                        if (palabra1[i] == palabra2[a])
                        {
                            aux2++;
                        }
                    }
                }
            }
            if (aux1 != aux2)
            {
                Console.WriteLine($"{palabra1} y {palabra2} no son anagramas");
            }
            else
            {
                Console.WriteLine($"{palabra1} y {palabra2} son anagramas");
            }
        }
        static void EjercicioV()
        {
            int num1, num2 = 0;
            Console.WriteLine("Escribe el numero a invertir: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            while (num1 > 0)
            {
                num2 = num2 * 10 + num1 % 10;
                num1 = num1 / 10;
            }
            Console.WriteLine($"El numero invertido es {num2}");
        }
        static void EjercicioVI()
        {
            int numero1, numero2, resultado;

            Console.WriteLine("Ingrese el primer nuemero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ingrese el segundo nuemero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------");

            Console.WriteLine($"El resultado es: {Operacion_Aritmetica(numero1, numero2)}");
        }
        static int Operacion_Aritmetica(int numero1, int numero2)
        {
            return (numero1 + numero2) * (numero1 - numero2);
        }
    }
}
