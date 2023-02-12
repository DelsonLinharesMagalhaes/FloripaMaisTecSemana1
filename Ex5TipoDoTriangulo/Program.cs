// FloripaMaisTec
// Curso Desenvolvedor FullStack Jr
// Aluno Délson Linhares Magalhães
// Principios da Programação C# .net
// Módulo 1 Semana 1 Ex5 - Tipo do Triangulo

Console.Clear();
Console.WriteLine("Determinando o tipo de triangulo!");
Console.WriteLine();

// Declarando váriaveis


int vLado1;
int vLado2;
int vLado3;

// Coletando dados


Console.Write("Qual o valor do primeiro lado: ");
vLado1 = int.Parse(Console.ReadLine());
Console.Write("Qual o valor do segundo lado: ");
vLado2 = int.Parse(Console.ReadLine());
Console.Write("Qual o valor do terceiro lado ");
vLado3 = int.Parse(Console.ReadLine());
Console.WriteLine();

//Verificando se é um triangulo, e qual tipo de troangulo;

 if (vLado1 + vLado2 < vLado3 || vLado3 + vLado2 < vLado1 || vLado3 + vLado1 < vLado2){
    Console.WriteLine("As médidas não formam um triangulo!");
 }else if (vLado1==vLado2 && vLado2==vLado3 && vLado1==vLado3) {
    Console.WriteLine("As médidas não formam um triangulo equilátero!");    
 }else if (vLado1==vLado2 || vLado2==vLado3 || vLado1==vLado3) {
    Console.WriteLine("As médidas não formam um triangulo isósceles!");    
 }else {
    Console.WriteLine("As médidas não formam um triangulo escaleno!");    
 }
            




