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

            //Usuário informa o valor a ser aplicado.
            Console.Write("Quanto deseja investir: ");
            valorInvestido = double.Parse(Console.ReadLine());

            //Usuário informa a quantidade de meses que vai aplicar.
            Console.Write("Quantos meses pretende investir: ");
            mesesPeriodo = int.Parse(Console.ReadLine());

            Calculo calculo = new Calculo();
            calculo.RendimentoPoupanca(mesesPeriodo, valorInvestido);
            calculo.RendimentoRendaFixa(mesesPeriodo, valorInvestido);
            calculo.MelhorInvestimento();
        }
    }
}
