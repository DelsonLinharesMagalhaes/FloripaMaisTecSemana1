// FloripaMaisTec
// Curso Desenvolvedor FullStack Jr
// Aluno Délson Linhares Magalhães
// Principios da Programação C# .net
// Módulo 1 Semana 1 Ex3 - Boletim


Console.Clear();
Console.WriteLine("Calculando a média das notas dos alunos e verificando se foi aprovado");
Console.WriteLine();

// Declarando váriaveis

double vNota1 = 0;
double vNota2 = 0;
double vNota3 = 0;
double vMedia = 0;

// Entrando com o dados

Console.Write("Digite a primeira nota: ");
vNota1 = int.Parse(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
vNota2 = int.Parse(Console.ReadLine());
Console.Write("Digite a terceira nota: ");
vNota3 = int.Parse(Console.ReadLine());

// Calculando a média da nota do aluno

vMedia = (vNota1+vNota2+vNota3)/3;

// Exibindo a área do triangulo

Console.WriteLine("");
Console.WriteLine("A nota média do aluno é: " + vMedia);

if (vMedia >= 6){
    Console.WriteLine("O aluno foi aprovado!");                 // Maior ou igual a 6 o aluno está aprovado
} else if(vMedia >= 5){
    Console.WriteLine("O aluno está de recuperação!");          // Menor que  6 e maior ou igual a 5 o aluno está aprovado
}else{
    Console.WriteLine("O aluno foi reprovado!");                // Menor do que 5 o aluno está reprovado
}