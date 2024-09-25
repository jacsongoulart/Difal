using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difal.Menu;


namespace Difal.DB
{
    public class DB
    {
        //public string[]? nomes = { "RJ", "SP", "MG", "ES" };
        //public double[] aliquotasDb = { 20, 12, 18, 17 };

        static public void MostrarEstados()
        {
            
            List<object> Estados = new List<object> { "RJ", "SP", "MG", "ES" };
            
            foreach (var item in Estados)
            {
                
                Console.WriteLine(item);
            }

        }
        
        static public void MostrarAliquotas()
        {

            List<object> Aliquotas = new List<object> { 20, 12, 18, 17 };

            foreach (var item in Aliquotas)
            {
                
                Console.WriteLine(item);
            }



        }
        
    }

    

        

}
