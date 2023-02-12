// FloripaMaisTec
// Curso Desenvolvedor FullStack Jr
// Aluno Délson Linhares Magalhães
// Principios da Programação C# .net
// Módulo 1 Semana 1 Ex6 - Tabuada

Console.Clear();
Console.WriteLine("Exibindo a tabuada de 0 a 10!");
Console.WriteLine();

// Declarando váriaveis


int vValor;

// Coletando dados

Console.Write("Qual o valor da tabuada? ");
vValor = int.Parse(Console.ReadLine());


// Calculando e exibindo o valor da tabuada

for (int i = 0; i <=10; i++){
    Console.WriteLine(vValor+ "X" + i + "=" + (vValor*i));
}


            
