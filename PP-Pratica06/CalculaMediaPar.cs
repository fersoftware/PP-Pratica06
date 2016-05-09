using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva um método CalculaMediaPares, que recebe um valor inteiro n, maior do que 5.
 * Este método deverá solicitar que o usuário digite n valores inteiros, calcular a média dos
 * números pares digitados e exibir esse média. Escreva o método Main que deverá solicitar
 * que o usuário digite um valor maior do que 5, chama o método CalculaMediaPares,
 * passando o valor digitado pelo usuário.
 */

namespace PP_Pratica06
{
    class CalculaMediaPar
    {
        public void exibir()
        {            
            Console.Write("Digite um Valor inteiro Maior que 5:");
            int n = int.Parse(Console.ReadLine());
            
            if(n > 5)
            {
                CalculaMediaPares(n);
            }
            else
            {
                Console.WriteLine("Valor Incorreto");
            }            
        }

        public void CalculaMediaPares(int n)
        {
            int soma = n % 2 == 0 ? n : 0, qtd = n % 2 == 0 ? 1 : 0;
            string par = n % 2 == 0 ? n + "," : "", digitados = n + ",";
            
            while (n > 5)
            {                
                Console.Write("Digite um Valor inteiro Maior que 5:");
                n = int.Parse(Console.ReadLine());

                if(n > 5)
                {
                    if (n % 2 == 0)
                    {
                        soma += n;
                        par += n + ",";
                        qtd++;
                    }

                    digitados += n + ",";
                }
            }
            Console.WriteLine("Média dos Pares: {0}", soma /qtd);
            Console.WriteLine("Números Pares Digitados: {0}", par);
            Console.WriteLine("Números Digitados em geral: {0}", digitados);
        }
    }
}
