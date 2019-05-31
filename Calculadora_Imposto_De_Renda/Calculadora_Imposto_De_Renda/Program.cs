using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Imposto_De_Renda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis para a aplicação.
            double valorInvestido = 0;
            int mesesPeriodo = 0;
            double resultadoPoupanca = 0;
            string mesPlural = string.Empty;
            double resultadoRendaFixa = 0;
            double resultadoTotalPoupanca = 0;
            double resultadoTotalRendaFixa = 0;
            double rendaFixaImposto = 0;
            string melhorInvestimento = string.Empty;
            string valorImpostoConvertido = string.Empty;

            //Usuário informa o valor a ser aplicado.
            Console.Write("Quanto deseja investir por Mês: ");
            valorInvestido = double.Parse(Console.ReadLine());

            //Usuário informa a quantidade de meses que vai aplicar.
            Console.Write("Quantos meses pretende investir: ");
            mesesPeriodo = int.Parse(Console.ReadLine());

            //Resultado já dando o valor total do que investil e do que será investido
            resultadoPoupanca = (valorInvestido * mesesPeriodo) * 0.0066;
            resultadoTotalPoupanca = (valorInvestido * mesesPeriodo) + resultadoPoupanca;

            if (mesesPeriodo == 1)
            {
                mesPlural = "mês";
            }

            else
            {
                mesPlural = "meses";
            }

            if (mesesPeriodo <= 12)
            {
                resultadoRendaFixa = (valorInvestido * mesesPeriodo) * 0.0098;
                rendaFixaImposto = resultadoRendaFixa * 0.0025;
                resultadoRendaFixa -= rendaFixaImposto;
                resultadoTotalRendaFixa = (valorInvestido * mesesPeriodo) + resultadoRendaFixa;
            }

            else if (mesesPeriodo > 12 && mesesPeriodo <= 24)
            {
                resultadoRendaFixa = (valorInvestido * mesesPeriodo) * 0.0098;
                rendaFixaImposto = resultadoRendaFixa * 0.0015;
                resultadoRendaFixa -= rendaFixaImposto;
                resultadoTotalRendaFixa = (valorInvestido * mesesPeriodo) + resultadoRendaFixa;
            }

            else if (mesesPeriodo > 24 && mesesPeriodo <= 36)
            {
                resultadoRendaFixa = (valorInvestido * mesesPeriodo) * 0.0098;
                rendaFixaImposto = resultadoRendaFixa * 0.0005;
                resultadoRendaFixa -= rendaFixaImposto;
                resultadoTotalRendaFixa = (valorInvestido * mesesPeriodo) + resultadoRendaFixa;
            }

            else
            {
                resultadoRendaFixa = (valorInvestido * mesesPeriodo) * 0.0098;
                rendaFixaImposto = resultadoRendaFixa * 0.0001;
                resultadoRendaFixa -= rendaFixaImposto;
                resultadoTotalRendaFixa = (valorInvestido * mesesPeriodo) + resultadoRendaFixa;
            }

            if (resultadoTotalPoupanca > resultadoTotalRendaFixa)
            {
                melhorInvestimento = "Poupança";
            }

            else
            {
                melhorInvestimento = "Renda Fixa";
            }

            //Usuário receber a mensagem com o valor total do rendimento no final do período desejado.
            Console.WriteLine("O Valor total do redimento da Poupança será de: {0} no período de: {1} {2}, seu saldo será de: {3}", resultadoPoupanca.ToString("c"), mesesPeriodo, mesPlural, resultadoTotalPoupanca.ToString("c"));
            Console.WriteLine("O Valor total do redimento da Renda Fixa será de: {0}, Imposto de Renda a ser descontado {1} no período de: {2} {3}, seu saldo será de: {4}", resultadoRendaFixa.ToString("c"), rendaFixaImposto.ToString("c"), mesesPeriodo, mesPlural, resultadoTotalRendaFixa.ToString("c"));
            Console.Write("O rendimento mais vantajoso é {0}.", melhorInvestimento);
            Console.ReadKey();
        }
    }
}
