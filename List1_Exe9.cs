using System;

class Program {
  public static void Main (string[] args) {
    /*Faça o algoritmo (diagrama de blocos e português estruturado) que calcule o valor em Reais
(VAL_REAL), correspondente aos dólares que um turista possui no cofre do hotel. O programa deve
solicitar os seguintes dados: Quantidade de dólares guardados no cofre (VAL_DOLAR) e cotação do
dólar naquele dia (COT).*/

	double val_real, val_dolar, cot;

   Console.WriteLine("Qual a quantidade de dolares que você possui?");
	  val_dolar = double.Parse(Console.ReadLine());

	 Console.WriteLine("Qual a cotação do dolar?");
	 	cot = double.Parse(Console.ReadLine());

	 val_real = (cot * val_dolar);

	 Console.WriteLine("Você possui {0:F2} reais", val_real);

  }
}
