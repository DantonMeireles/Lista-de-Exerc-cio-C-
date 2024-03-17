using System;

class Program {
  public static void Main (string[] args) {
    /*Faça o algoritmo (diagrama de blocos e português estruturado) que calcule a idade de uma pessoa, sendo que o ano atual (AA) e o ano do nascimento da pessoa (AN) são fornecidos pelo usuário. (considere que a pessoa já fez aniversário nesse ano). Apresentar a idade da pessoa depois de calculada.*/

		double ano_atual, ano_nascimento, resultado;

		Console.WriteLine("Qual o ano que você nasceu? ");
			ano_nascimento = double.Parse(Console.ReadLine());

		Console.WriteLine("Qual o ano atual? ");
			ano_atual = double.Parse(Console.ReadLine());

			resultado = ano_atual - ano_nascimento;

			Console.WriteLine("A sua idade é {0} anos", resultado);
  }
}
