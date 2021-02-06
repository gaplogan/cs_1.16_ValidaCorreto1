using System;

namespace cs_1._16_ValidaCorreto1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            double num, raiz;

            //{entrada de dados}
            num = -1; //valor inicial conveniente para testar a validação
            while (num < 0)
            {
                Console.Write("Digite um número positivo: ");
                num = double.Parse(Console.ReadLine());
                if (num < 0) // Redundância de verificação, isto pode ser melhorado !!!
                {
                    Console.WriteLine("Valor Inválido");
                }                
                Console.WriteLine(); // Pular linha"
            }

            //{Processamento: Tenta extrair a raiz quadrada do número lido}
            raiz = Math.Sqrt(num);

            Console.WriteLine($"Raiz quadrada de {num}: {raiz}");
        }
    }
}
