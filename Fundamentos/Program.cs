using Fundamentos.Models;

Pessoa pessoa = new Pessoa();

pessoa.Nome = "Isaias";
pessoa.Idade = 22;

pessoa.Apresentar();

DateTime dataAtual = DateTime.Now; //pega a data da maquina 
System.Console.WriteLine(dataAtual);
DateTime dataSoma = DateTime.Now.AddDays(5);
System.Console.WriteLine(dataSoma);
DateTime dataFormatada = DateTime.Now;
System.Console.WriteLine(dataFormatada.ToString("dd/MM/yyyy HH:mm"));