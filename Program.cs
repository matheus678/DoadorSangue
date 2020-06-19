using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            [console: DoadorSangue] Solicite a idade do usuário. Avalie se ele pode ser doador de sangue (i.e. possui idade entre 18 e 67 anos). Informe o resultado da avaliação.
            Ex.:
            Qual a sua idade: 35
            Você pode ser doador de sangue.
            ou
            Qual a sua idade: 12
            Você não pode ser doador de sangue.
            ou
            Qual a sua idade: 80
            Você não pode ser doador de sangue.
            */

            Console.WriteLine("Olá, irei ajuda-lo informando se você pode ou não, doar sangue");

            double doador;

            // Utilizarei double para previnir erros de digitação do usuário.

            Console.Write("Por favor, insira sua idade...:");
            doador = Convert.ToDouble(Console.ReadLine());


            
            if (doador >=18 && doador <=67)
            {
                Console.Write("Você está dentro da faixa etária, pode doar sangue.");
            }    
            
            else if (doador <18)
            {
                Console.Write("Você é menor de idade, não pode doar sangue.");
            }

            else if (doador >67)
            {
                Console.Write("Você é acima da idade máxima permitda, não pode doar sangue.");
            }

        }
    }
}
