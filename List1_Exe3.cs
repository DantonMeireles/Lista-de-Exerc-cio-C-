using System;

class Program {
  public static void Main (string[] args) {
  /* Faça o algoritmo (diagrama de blocos e português estruturado) para calcular o valor monetário do desconto (D), sendo que o preço do produto (PR) é fornecido pelo usuário e o desconto é de 5%. Apresentar o valor do desconto.*/

	double dconto, prco;
		Console.WriteLine("Digite o valor do produto: ");
			prco = double.Parse(Console.ReadLine());
				Console.WriteLine ("O valor é: r$ {0}", prco);

	dconto = prco * 0.05;
	Console.WriteLine ("O valor do desconto é: r$ {0} ", dconto);

  }
}
