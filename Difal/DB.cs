using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Difal
{
    internal class DB
    {
        //public string[]? nomes = { "RJ", "SP", "MG", "ES" };
        //public double[] aliquotasDb = { 20, 12, 18, 17 };

        List<object> dados = new List<object>() {"RJ",20,"SP",12,"MG",18,"ES",17};

        

        public void Mostrar()
        {
            Console.WriteLine($"A Aliquota do {dados[0]} é de {dados[1]}%");
            Console.ReadKey();
            

            

        }
        
    }

        

}
