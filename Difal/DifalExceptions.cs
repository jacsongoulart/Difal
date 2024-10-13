using System;
using Difal;


public class DifalException : Exception
{
	public DifalException(string msg) : base(msg)
	{
		msg = "Tentando dividir por zero";
	}


}
