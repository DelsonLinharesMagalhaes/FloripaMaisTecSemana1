// FloripaMaisTec
// Curso Desenvolvedor FullStack Jr
// Aluno Délson Linhares Magalhães
// Principios da Programação C# .net
// Módulo 1 Semana 1 Ex1 - Entrevista

Console.Clear();
Console.WriteLine("Entrevista!");
Console.WriteLine();

// Declarando váriaveis

string vNome, vSobrenome, vCor;
int vIdade;

// Coletando dados

Console.WriteLine("Olá, Tudo bem? ");
Console.WriteLine("");
Console.Write("Qual o seu nome? ");
vNome = Console.ReadLine();
Console.Write("Qual o seu sobrenome? ");
vSobrenome = Console.ReadLine();
Console.Write("Qual a sua idade? ");
vIdade = int.Parse(Console.ReadLine());
Console.Write("Qual a sua cor favorita ? ");
vCor = Console.ReadLine();

// Exibindo dados

Console.WriteLine($"Nome: {vNome}");
Console.WriteLine($"Sobrenome: {vSobrenome}");
Console.WriteLine($"Idade: {vIdade}");
Console.WriteLine($"Cor Favorita: {vCor}");
