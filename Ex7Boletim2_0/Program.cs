// FloripaMaisTec
// Curso Desenvolvedor FullStack Jr
// Aluno Délson Linhares Magalhães
// Principios da Programação C# .net
// Módulo 1 Semana 1 Ex3 - Boletim


Console.Clear();
Console.WriteLine("Calculando a média das notas dos alunos e verificando se foi aprovado");
Console.WriteLine();

// Declarando váriaveis

string vNome;
int vQtdNotas = 0;
double vMedia = 0;
double vSomaMedia = 0;

// Entrando com o dados

Console.Write("Qual o nome do aluno? ");
vNome = Console.ReadLine();
Console.Write("Quantida de notas? ");
vQtdNotas = int.Parse(Console.ReadLine());

int[] vNotas = new int[vQtdNotas];

// Calculando a média da nota do aluno

for (int i = 0; i <=  (vQtdNotas-1); i++){
    Console.Write("Digite o valor da nota "+(i+1)+": ");
    vNotas[i] = int.Parse(Console.ReadLine());
    vSomaMedia+=vNotas[i];
}


vMedia = vSomaMedia/vQtdNotas;

// Exibindo a nota média

Console.WriteLine("");
Console.WriteLine("A nota média do aluno é: " + vMedia);

if (vMedia >= 6){
    Console.WriteLine("O aluno foi aprovado!");                 // Maior ou igual a 6 o aluno está aprovado
} else if(vMedia >= 5){
    Console.WriteLine("O aluno está de recuperação!");          // Menor que  6 e maior ou igual a 5 o aluno está aprovado
}else{
    Console.WriteLine("O aluno foi reprovado!");                // Menor do que 5 o aluno está reprovado
}