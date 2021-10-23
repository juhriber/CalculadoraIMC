using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal alt, massa, imc;

            Console.Write("Digite sua altura em m..: ");
            alt = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Digite seu peso em KG..: ");
            massa = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            imc = massa / (alt * alt);

            if(imc < 17) {

                Console.WriteLine($"Seu IMC é {imc:N2} kg");
                Console.WriteLine("Diagnóstico: Muito abaixo do peso!");
            }

            else if(imc >= 17 && imc <= 18){

                Console.WriteLine($"Seu IMC é {imc:N2} kg");
                Console.WriteLine("Diagnóstico: Abaixo do peso!");

            } else if(imc >= 19 && imc <= 24){

                Console.WriteLine($"Seu IMC é {imc:N2} kg");
                Console.WriteLine("Diagnóstico: Peso normal!");

            } else if(imc >= 25 && imc <= 29) {

                Console.WriteLine($"Seu IMC é {imc:N2} kg");
                Console.WriteLine("Diagnóstico: Acima do peso");

            } else if(imc >= 30 && imc <= 34) {

                Console.WriteLine($"Seu IMC é {imc:N2} kg");
                Console.WriteLine("Diagnóstico: Obesidade I");

            } else if(imc >= 35 && imc <= 39) {

                Console.WriteLine($"Seu IMC é {imc:N2} kg");
                Console.WriteLine("Diagnóstico: Obesidade II (Severa)");

            } else {

                Console.WriteLine($"Seu IMC é {imc:N2} kg");
                Console.WriteLine("Diagnóstico: Obesidade III (Mórbida)");
            }



        }
    }
}