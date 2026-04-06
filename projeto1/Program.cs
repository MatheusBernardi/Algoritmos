// conversor de medidas
// declaração de variaveis
double medida = 0;
double valor =0;

Console.Write("Digite o valor em milhas: ");
valor = Convert.ToDouble (Console.ReadLine());

medida = valor * 1.6;

Console.Write("Sua medida em KM é de: "+medida);