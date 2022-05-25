﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevarCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variabkes
            int number;
            bool continua;
            do
            {
                try
                {
                    continua = false;
                    Console.Write("Enter number: ");
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + Math.Pow(number, 2));
                }
                catch (FormatException e)
                {
                    continua = true;
                    Console.WriteLine("Solo se aceptan numeros enteros y no letras");
                    Console.WriteLine(e.Message);

                }
                catch (OverflowException ) 
                {
                    continua = true;
                    Console.WriteLine("Valor no soportado, el numero es demasiado grande");
                    
                }
            } while (continua==true);    
            Console.WriteLine("Presione enter para continuar");
            Console.ReadKey();
           
        }
    }
}
