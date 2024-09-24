using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difal
{
    internal class Imposto
    {
            string? nomeInterno;
            string? nomeDest;
            double baseCalculoDest;
            double aliquotaDest;
            double valorFinal;
            double aliquotaInterna;

        public string? NomeInterno { get => nomeInterno; set => nomeInterno = value; }
        public string? NomeDest { get => nomeDest; set => nomeDest = value; }
        public double BaseCalculoDest { get => baseCalculoDest; set => baseCalculoDest = value; }
        public double AliquotaDest { get => aliquotaDest; set => aliquotaDest = value; }
        public double ValorFinal { get => valorFinal; set => valorFinal = value; }
        public double AliquotaInterna { get => aliquotaInterna; set => aliquotaInterna = value; }

        public void CalcularDifal()
        {
            double aliquotaRef;
            aliquotaRef = AliquotaDest - AliquotaInterna;

            ValorFinal = BaseCalculoDest * (aliquotaRef / 100);

            Console.Clear();
            Console.WriteLine($"O valor do Difal entre {NomeInterno} e {NomeDest} é de R$ {ValorFinal}");
        }




    }
}
