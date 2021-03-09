using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primeiros_passos
{
    class Program
    {
        static void Main(string[] args)
        {
            string cor = "Verde";

            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho!");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é Amarelo!");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é Azul!");
                    break;
                default:
                    Console.WriteLine("Sua cor favorita eu não sei!");
                    break;
            }



            Console.ReadLine();
        }

        static void novaMsg() 
        {
            Console.WriteLine("Novidades estão a caminho");
            Console.WriteLine("Aguarde e será surpreendido");
            Console.WriteLine("Aguarde e terá uma grande surpresa");
        }

     

        static void ExibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando funções!");
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("Guia do Programador!");
            Console.WriteLine("Marcos Anacleto!");
        }
        static void GerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * preco);
            Console.WriteLine("Valor final: " + valorFinal);

        }

        static int Somar (int a, int b, int c) 
        {
            int resultadoFinal = a + b + c;
            return resultadoFinal;
        }
    }

}
