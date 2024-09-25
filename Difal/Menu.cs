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

            double aliquotaDestino;

            switch (origemDestino)
            {
                case "RJ": aliquotaDestino = 22; break;
                case "SP": aliquotaDestino = 12; break;
                case "ES": aliquotaDestino = 17; break;
                case "MG": aliquotaDestino = 18; break;
                default: aliquotaDestino = 0; ; break;
            }

            double aliquotaDifal = aliquotaDestino - aliquotaEscolha;
            double valorDifal = (aliquotaDifal * valorProduto) / 100;

            Console.WriteLine($"O DIfal entre {origemEscolha} e {origemDestino} é de R$ {valorDifal}");



            
        }

        
       

        
        
    }
}
