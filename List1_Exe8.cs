using System;

class Program {
  public static void Main (string[] args) {
   /*Faça o algoritmo (diagrama de blocos e português estruturado) para calcular o valor a ser pago pelo período de estacionamento do automóvel (PAG). O usuário entra com os seguintes dados: hora (HE) e minuto (ME) de entrada, hora (HS) e minuto (MS) de saída. Sabe-se que este estacionamento cobra R$ 4,00, mas calcula as frações de hora também. Por exemplo, se a pessoa ficar 1 hora e quinze minutos, pagará R$ 5,00 (R$ 4,00 pela hora e R$ 1,00 pelos quinze minutos).*/

	double pag, he, me, hs, ms;
		Console.WriteLine("Qual o horario de chegada?");	
			he = double.Parse(Console.ReadLine());

			Console.WriteLine("Qual o minuto da chegada?");
				me = double.Parse(Console.ReadLine());

			Console.WriteLine("Qual o horario de saida?");
				hs = double.Parse(Console.ReadLine());
			
		  Console.WriteLine("Qual o minuto da saida?");
				ms = double.Parse(Console.ReadLine());

			pag = (hs - he) * 4.00 + (ms - me) * (4.00 / 60);

			Console.WriteLine("O resultado é:R${0:F2}", pag);

  }
}
