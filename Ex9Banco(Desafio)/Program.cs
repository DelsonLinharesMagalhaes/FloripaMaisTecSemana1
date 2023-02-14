// FloripaMaisTec
// Curso Desenvolvedor FullStack Jr
// Aluno Délson Linhares Magalhães
// Principios da Programação C# .net
// Módulo 1 Semana 1 Ex9 - Banco(Desafio)

Console.Clear();
Console.WriteLine("Bem vindo ao Banco Nacional Coqueiros!");
Console.WriteLine();

// Declarando váriaveis

int opcaoBanco = 0;
double insVal = 0;

List<double> valTransa = new List<double>();

while(opcaoBanco != 3){
    Console.WriteLine("Por favor selecione uma opção para continuar:");
    Console.WriteLine();
    Console.WriteLine("1 - Adicionar Transação");
    Console.WriteLine("2 - Consultar extrato");
    Console.WriteLine("3 - Sair");
    opcaoBanco = int.Parse(Console.ReadLine());
    if (opcaoBanco == 3){
        Console.WriteLine("Obrigado!");
    }else if(opcaoBanco == 1){
            Console.Write("Digite o valor a ser adicionado!");
            insVal = int.Parse(Console.ReadLine());
            valTransa.Add(insVal);
    }else if(opcaoBanco == 2){
            Console.WriteLine("Extrato!");
            valTransa.ForEach(Console.WriteLine);
    }else{
        Console.WriteLine("Opcao Invalida!");   
    }


}



            

