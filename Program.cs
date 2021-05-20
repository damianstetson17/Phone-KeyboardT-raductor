using Calculator.Controllers;
using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            //Controller
            TextController textController = new TextController();
            
            //Input
            Boolean option = true;
            while(option)
            {
                Console.WriteLine("============[Bienvenido!]============");
                Console.WriteLine("[ Por favor, a continuación ingrese la\n palabra que desea convertir! ]");

                string resultCoords = textController.getNumberSecuence(Console.ReadLine());

                Console.WriteLine($"Tus cordenadas numéricas serán: {resultCoords}");
                Console.WriteLine("[ ¿Desee cargar otra palabra? (y/n) ]");
                Console.WriteLine("==================[]=================");
                option =  Console.ReadLine() == "n" ? false : true;
                Console.Clear();
                Console.WriteLine(". . .Adiós!");
            }

        }
    }
}
