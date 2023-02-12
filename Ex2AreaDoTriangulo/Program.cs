// FloripaMaisTec
// Curso Desenvolvedor FullStack Jr
// Aluno Délson Linhares Magalhães
// Principios da Programação C# .net
// Módulo 1 Semana 1 Ex2 - Área do Triangulo


Console.Clear();
Console.WriteLine("Calculando a Área do Triangulo");
Console.WriteLine();

// Declarando váriaveis

double vArea = 0;
double vBase = 0;
double vAltura = 0;

// Entrando com o dados

Console.Write("Digite a base do triangulo: ");
vBase = int.Parse(Console.ReadLine());
Console.Write("Digite a altura do triangulo: ");
vAltura = int.Parse(Console.ReadLine());

// Calculando a área do triangulo

vArea = (vBase * vAltura)/2;

// Exibindo a área do triangulo

Console.WriteLine("");
Console.WriteLine("A área do triangulo é: " + vArea);
