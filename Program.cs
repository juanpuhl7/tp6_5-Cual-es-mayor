using System;

namespace tp6_5_Cual_es_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Ingrese por favor el numero 1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese por favor el numero 2: ");
            num2=Convert.ToInt32(Console.ReadLine());

            if(num1 > num2){
                Console.WriteLine("El numero: " + num1 + " Es Mayor.");
            }else {
                Console.WriteLine("El numero: " + num2 + " Es Mayor.");
            }
        }
    }
}
