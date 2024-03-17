using System;

class Program {
  public static void Main (string[] args) {
    /*Faça o algoritmo (diagrama de blocos e português estruturado) para calcular quanto será pago por um produto (PAG), sendo que o preço do produto (PR) e o desconto (D) são fornecidos pelo usuário. Apresentar o valor a ser pago pelo produto.*/

double preco, desconto, valorpago;
	Console.WriteLine("Qual o valor do produto? ");
	preco = double.Parse(Console.ReadLine());

		Console.WriteLine("Qual a porcentagem do desconto? ");
		desconto = double.Parse(Console.ReadLine());

		valorpago = preco - (preco * (desconto * 0.01));

		Console.WriteLine ("O valor  é: r$ {0} ", valorpago);
  }
}
