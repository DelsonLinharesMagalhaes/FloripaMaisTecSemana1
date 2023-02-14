// FloripaMaisTec
// Curso Desenvolvedor FullStack Jr
// Aluno Délson Linhares Magalhães
// Principios da Programação C# .net
// Módulo 1 Semana 1 Ex8 - Fibonacci


Console.Clear();
Console.WriteLine("Sequência de Fibonacci");
Console.WriteLine();

// Declarando váriaveis

int[] vFibonacci = new int[20];
vFibonacci[0] = 1;
vFibonacci[1] = 1;

// Calculando e exibindo o valor da sequencia de Fibinacci

for (int i = 2; i <20; i++){
    vFibonacci[i] = vFibonacci[i-2] + vFibonacci[i-1];
}

for (int i = 0; i <20; i++){
    Console.WriteLine(vFibonacci[i]);
}
  