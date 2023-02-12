// FloripaMaisTec
// Curso Desenvolvedor FullStack Jr
// Aluno Délson Linhares Magalhães
// Principios da Programação C# .net
// Módulo 1 Semana 1 Ex4 - Imposto Sobre a Folha


Console.Clear();
Console.WriteLine("Calculando o imposto sobre a folha de pagamento");
Console.WriteLine();

// Declarando váriaveis

double vSalarioBruto = 0;
double vDescontoImposto = 0;

// Entrando com o dados

Console.Write("Digite o salário bruto: ");
vSalarioBruto = int.Parse(Console.ReadLine());

// Calculando o imposto

if (vSalarioBruto > 2500){
    vDescontoImposto = vSalarioBruto * 0.2; // Desconto do 20%
} else if (vSalarioBruto > 1500){
    vDescontoImposto = vSalarioBruto * 0.1; // Desconto do 10%
}else if (vSalarioBruto > 900){
    vDescontoImposto = vSalarioBruto * 0.05; // Desconto do 5%
}

// Exibindo a área do triangulo

Console.WriteLine("");
Console.WriteLine("Sendo o salário bruto de : " + vSalarioBruto + " o imposto será de: " + vDescontoImposto);

