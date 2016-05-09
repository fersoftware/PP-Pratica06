using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método CalculaImposto, que recebe o valor da renda líquida anual e o número
 * de dependentes de um contribuinte. Este método deverá calcular e exibir o valor do
 * imposto a ser pago. Considere os seguintes valores:
 * Renda líquida até R$ 1,100.00        - Isento de imposto
 * Acima de R$ 1100,00 até R$ 5000,00   - 10 % de imposto
 * Acima de R$ 5000,00 até R$ 10000,00  - 15% de imposto
 * Acima de R$ 10000,00                 - 20% de imposto
 * Cada dependente que o contribuinte possuir corresponderá a um desconto de R$ 300,00
 * no valor do imposto. Escreva o método Main que solicita que o usuário digite os valores
 * para contribuintes diferentes e chama o método CalculaImposto para exibir o valor do * imposto a ser pago para cada um deles.
 */
namespace PP_Pratica06
{
    class CalculaImposto
    {
        public void exibir()
        {
            Console.Write("Digite a renda liquida anual: ");
            float rendLiquid = float.Parse(Console.ReadLine());
            Console.Write("Digite quantos depedentes possui: ");
            int qtdDepend = int.Parse(Console.ReadLine());
            calculaImposto(rendLiquid, qtdDepend);
        }
        public void calculaImposto(float rd, int qtd)
        {
            float imposto = 0, desconto = 0;

            if(rd <= 1100)
            {
                imposto = 0;
                Console.WriteLine("Isento de imposto");
            }
            else if (rd > 1100 && rd <= 5000)
            {
                imposto = rd * 1.10f;
                Console.WriteLine("10% de imposto -> {0:C}", imposto);
            }
            else if (rd > 5000 && rd <= 10000)
            {
                imposto = rd * 1.15f;
                Console.WriteLine("15% de imposto -> {0:C}", imposto);
            }
            else if (rd > 10000)
            {
                imposto = rd * 1.20f;
                Console.WriteLine("20% de imposto -> {0:C}", imposto);
            }
            for (int i = 0; i < qtd; i++)
            {
                desconto += 300;
            }

            Console.WriteLine("Depedentes: {0} -> Desconto: {1:C}", qtd, desconto);
            Console.WriteLine("Valor a ser pago: {0:C}", imposto - desconto);
        }
    }
}
