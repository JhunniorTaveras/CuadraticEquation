using System;

namespace Problema19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor inserte tres numeros para la ecuacion: ");

            int numberOne = NumeroEnteros();
            int numberTwo = NumeroEnteros();
            int numberThree = NumeroEnteros();

            System.Console.WriteLine("\nSoluciones: ");
            Console.WriteLine(CuadraticEquationOne(numberOne, numberTwo, numberThree));
            Console.WriteLine(CuadraticEquationTwo(numberOne, numberTwo, numberThree));
        }

        static double CuadraticEquationOne(int a, int b, int c)
        {
            double solution;

            solution = (-b + SquareRoot(b ^ 2 - 4 * a * c)) / 2 * a;

            return solution;
        }

        static double CuadraticEquationTwo(int a, int b, int c)
        {
            double solution;

            solution = (-b - SquareRoot(b ^ 2 - 4 * a * c)) / 2 * a;

            return solution;
        }

        static int SquareRoot(int number)
        {
            int root = 1;
            
            for (int i = 0; i < number/2; i++)
            {
                root = (number / root + root) / 2;
                if (i == number + 1)
                {
                    break;
                }
            }

            return root;
        }

        static int NumeroEnteros()
        {
            string letra = null;
            int numeros = 0;

            ConsoleKeyInfo tecla;

            do
            {
                //Obtener la tecla presionada por el usuario
                tecla = Console.ReadKey(true);

                //Verificando si es un numero
                if (char.IsNumber(tecla.KeyChar) || tecla.KeyChar == '-')
                {
                    //Si es un numero, se añade el string letra
                    letra += tecla.KeyChar;
                    //Mostrar por pantalla la tecla presionada
                    Console.Write(tecla.KeyChar);
                }
                else
                {
                    //Verificar si se presiono backspace
                    if (tecla.Key == ConsoleKey.Backspace && letra.Length > 0)
                    {
                        //Eliminar el ultimo elemento del string
                        letra = letra.Substring(0, letra.Length - 1);
                        //Mostrar cambios por consola
                        Console.Write("\b \b");
                    }
                }
                //Si se presiona enter se sale del bucle
            } while (tecla.Key != ConsoleKey.Enter);

            try
            {
                numeros = Convert.ToInt32(letra);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            return numeros;
        }
    }
}
