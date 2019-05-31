using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Imposto_De_Renda
{
    public class Calculo
    {
        public double rendimentoPoupanca { get; set; }
        public double rendimentoRendaFixa { get; set; }

        public void RendimentoPoupanca(int meses, double valor)
        {
            double rendimentoTotal = 0;

            for (int i = 1; i < meses; i++)
            {
                if (i == 1)
                {
                    rendimentoPoupanca = (valor * 0.0066) + valor;
                }

                else
                {
                    rendimentoPoupanca = (rendimentoPoupanca * 0.0066) + rendimentoPoupanca;
                }
            }

            rendimentoTotal = rendimentoPoupanca - valor;

            Informacao infor = new Informacao();
            infor.InformarRendimentoPoupanca(meses, rendimentoPoupanca, rendimentoTotal);
        }

        public void RendimentoRendaFixa(int meses, double valor)
        {
            double rendimentoTotal = 0;
            double imposto = 0;

            for (int i = 1; i < meses; i++)
            {
                if (i == 1)
                {
                    rendimentoRendaFixa = (valor * 0.0098) + valor;
                }

                else
                {
                    rendimentoRendaFixa = (rendimentoRendaFixa * 0.0098) + rendimentoRendaFixa;
                }
            }

            rendimentoTotal = rendimentoRendaFixa - valor;

            if (meses <= 12)
            {
                imposto = rendimentoTotal * 0.0025;
                rendimentoTotal -= imposto;
            }

            else if (meses > 12 && meses <= 24)
            {
                imposto = rendimentoTotal * 0.0015;
                rendimentoTotal -= imposto;
            }

            else if (meses > 24 && meses <= 36)
            {
                imposto = rendimentoTotal * 0.0005;
                rendimentoTotal -= imposto;
            }

            else
            {
                imposto = rendimentoTotal * 0.0001;
                rendimentoTotal -= imposto;
            }

            rendimentoRendaFixa -= imposto;

            Informacao infor = new Informacao();
            infor.InformarRendimentoRendaFixa(meses, rendimentoRendaFixa, rendimentoTotal, imposto);
        }

        public void MelhorInvestimento()
        {
            Informacao infor = new Informacao();

            if (rendimentoPoupanca > rendimentoRendaFixa)
            {
                infor.MelhorRendimento("Poupança");
            }

            else
            {
                infor.MelhorRendimento("Renda Fixa");
            }
        }
    }
}
