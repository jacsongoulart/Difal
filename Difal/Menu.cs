using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Difal.DB;




namespace Difal.Menu

{
    public class Menu
    {


        static public void Start()
        {
            Console.Clear();
            
            Console.WriteLine("------------- Calculadora de Difal -----------------");
            Console.WriteLine();
            Console.WriteLine("Qual o valor total do produto?");
            double valorProduto = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Qual estado de origem?");
            Console.WriteLine("");
            Console.WriteLine("1 - RJ Alíquota 22%");
            Console.WriteLine("2 - SP Alíquota 12%");
            Console.WriteLine("3 - ES Alíquota 17%");
            Console.WriteLine("4 - MG Alíquota 18%");
            
            int origem = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double aliquotaOrigem;
            string? origemEscolha;

            switch (origem)
            {
                case 1: origemEscolha = "RJ"; break;
                case 2: origemEscolha = "SP"; break;
                case 3: origemEscolha = "ES"; break;
                case 4: origemEscolha = "MG"; break;
                default:
                    origemEscolha = "Padrão"; break;
            }

            double aliquotaEscolha;

            switch (origemEscolha)
            {
                case "RJ": aliquotaEscolha = 22; break;
                case "SP": aliquotaEscolha = 12; break;
                case "ES": aliquotaEscolha = 17; break;
                case "MG": aliquotaEscolha = 18; break;
                default:
                    aliquotaEscolha = 0; break;
            }


            Console.WriteLine("Qual estado de destino?");
            Console.WriteLine("");
            Console.WriteLine("1 - RJ Alíquota 22%");
            Console.WriteLine("2 - SP Alíquota 12%");
            Console.WriteLine("3 - ES Alíquota 17%");
            Console.WriteLine("4 - MG Alíquota 18%");
            
            int destino = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double aliquotaDestino;
            string? origemDestino;

            switch (destino)
            {
                case 1: origemDestino = "RJ"; break;
                case 2: origemDestino = "SP"; break;
                case 3: origemDestino = "ES"; break;
                case 4: origemDestino= "MG"; break;
                default:
                    origemDestino = "Padrão"; break;
            }

            double aliquotaEscolhaDest;

            switch (origemDestino)
            {
                case "RJ": aliquotaEscolhaDest = 22; break;
                case "SP": aliquotaEscolhaDest = 12; break;
                case "ES": aliquotaEscolhaDest = 17; break;
                case "MG": aliquotaEscolhaDest = 18; break;
                default:
                    aliquotaEscolhaDest = 0; break;
            }






            Console.WriteLine($"{origem}, {origemEscolha},{aliquotaEscolha},{destino},{origemDestino}, {aliquotaEscolhaDest}");



            
        }

        
       

        
        
    }
}
