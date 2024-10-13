using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml;
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

            string? origemEscolha = origem switch
            {
                1 => origemEscolha = "RJ",
                2 => origemEscolha = "SP",
                3 => origemEscolha = "ES",
                4 => origemEscolha = "MG",
                _ => origemEscolha = "Padrão"

            };

            double aliquotaEscolha = origemEscolha switch
            {
                "RJ" => aliquotaEscolha = 22,
                "SP" => aliquotaEscolha = 12,
                "ES" => aliquotaEscolha = 17,
                "MG" => aliquotaEscolha = 18,
                 _   => aliquotaEscolha = 0
            };


            Console.WriteLine("Qual estado de destino?");
            Console.WriteLine("");
            Console.WriteLine("1 - RJ Alíquota 22%");
            Console.WriteLine("2 - SP Alíquota 12%");
            Console.WriteLine("3 - ES Alíquota 17%");
            Console.WriteLine("4 - MG Alíquota 18%");
            
            int destino = int.Parse(Console.ReadLine());
            Console.WriteLine();


            string? origemDestino = destino switch
            {
                1 => origemDestino = "RJ",
                2 => origemDestino = "SP",
                3 => origemDestino = "ES",
                4 => origemDestino = "MG",
                _ => origemDestino = "Padrão"
            };


            double aliquotaDestino = origemDestino switch
            {
                "RJ" => aliquotaDestino = 22,
                "SP" => aliquotaDestino = 12,
                "ES" => aliquotaDestino = 17,
                "MG" => aliquotaDestino = 18,
                _ => aliquotaDestino = 0
            };

            
            
            double aliquotaDifal = aliquotaDestino - aliquotaEscolha;
            double valorDifal = (aliquotaDifal * valorProduto) / 100;

            
            Console.WriteLine($"O DIfal entre {origemEscolha} e {origemDestino} é de R$ {valorDifal}");
            

            
            
            



            
        }

        
       

        
        
    }
}
