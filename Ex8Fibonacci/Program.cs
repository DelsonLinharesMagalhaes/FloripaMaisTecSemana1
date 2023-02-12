// FloripaMaisTec
// Curso Desenvolvedor FullStack Jr
// Aluno Délson Linhares Magalhães
// Principios da Programação C# .net
// Módulo 1 Semana 1 Ex8 - Fibonacci


Console.Clear();
Console.WriteLine("Sequência de Fibonacci");
Console.WriteLine();

// Declarando váriaveis

int vQtdNum = 0;

// Entrando com o dados

Console.Write("Quantida de números? ");
vQtdNum = int.Parse(Console.ReadLine());

int[] vSeqFib = new int[vQtdNum];

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
