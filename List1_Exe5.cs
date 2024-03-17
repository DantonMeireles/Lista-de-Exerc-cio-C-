using System;

class Program {
  public static void Main (string[] args) {
    /*Faça o algoritmo (diagrama de blocos e português estruturado) para calcular qual foi a porcentagem de desconto dada em um determinado produto (DESC), sabendo-se o preço original do produto (PRECO) e o preço que foi cobrado por ele depois do desconto (PRECOF).*/

		double preco, precof, desc;

		Console.WriteLine("Qual o valor original do produto? ");
			preco = double.Parse(Console.ReadLine());

		Console.WriteLine("Qual o valor do produto com desconto? ");
			precof = double.Parse(Console.ReadLine());

		desc = 100 - ((precof * 100) / preco);
			Console.WriteLine("o desconto é: {0}% ", desc);

  }
}
