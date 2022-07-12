using CalculadoraIdadeCSharp;

Console.WriteLine("Programa que calcula a idade de uma pessoa");
Pessoa p = new Pessoa();
Console.Write("Nome da pessoa: ");
p.Nome = Console.ReadLine();
Console.Write("Ano de Nascimento: ");
p.AnoNascimento = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("####################################");
p.ExibirDados();
Console.ReadKey();