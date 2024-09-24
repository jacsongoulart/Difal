
using Difal;

Imposto Rio = new();

Rio.NomeInterno = "RJ";
Rio.NomeDest = "SP";
Rio.BaseCalculoDest = 3510.00;
Rio.AliquotaInterna = 12;
Rio.AliquotaDest = 20;
Rio.CalcularDifal();

DB teste = new();
teste.Mostrar();