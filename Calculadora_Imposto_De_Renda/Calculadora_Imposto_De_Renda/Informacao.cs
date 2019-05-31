using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Imposto_De_Renda
{
    public class Informacao
    {
        public void InformarRendimentoPoupanca(int meses, double valor, double rendimento)
        {
            int mesesTotal = meses;
            double valorTotal = valor;
            string mesPlural = string.Empty;
            double valorRendimento = rendimento;

            if (meses == 1)
            {
                mesPlural = "Mês";
            }

            else
            {
                mesPlural = "Meses";
            }

            Console.WriteLine("O Valor total do redimento da Poupança será de: {0} no período de: {1} {2} seu saldo será de: {3}", valorRendimento.ToString("c"), mesesTotal, mesPlural, valorTotal.ToString("c"));
            Console.ReadKey();
        }

        public void InformarRendimentoRendaFixa(int meses, double valor, double rendimento, double imposto)
        {
            int mesesTotal = meses;
            double valorTotal = valor;
            string mesPlural = string.Empty;
            double valorRendimento = rendimento;
            double valorImposto = imposto;

            if (meses == 1)
            {
                mesPlural = "Mês";
            }

            else
            {
                mesPlural = "Meses";
            }

            Console.WriteLine("O Valor do redimento da Renda Fixa será de: {0}, Imposto de Renda a ser descontado {1} no período de: {2} {3}, seu saldo será de: {4}", valorRendimento.ToString("c"), valorImposto.ToString("c"), mesesTotal, mesPlural, valorTotal.ToString("c"));
            Console.ReadKey();
        }

        public void MelhorRendimento(string melhorInvestimento)
        {
            Console.Write("O rendimento mais vantajoso é {0}.", melhorInvestimento);
            Console.ReadKey();
        }
    }
}
