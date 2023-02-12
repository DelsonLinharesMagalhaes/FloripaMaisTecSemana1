// See https://aka.ms/new-console-template for more information


Console.WriteLine("Quantos nomes?");
int tamanhoArray = int.Parse(Console.ReadLine());

string[] nomes = new String[tamanhoArray];

int i = 0;
while (i < tamanhoArray){
    Console.WriteLine($"Digite o nome {i+1}:");
    nomes[i] = Console.ReadLine();
    i++;
}

int b = 0;
while (b < tamanhoArray){
    Console.WriteLine($"O nome {b+1} é {nomes[b]}:");
    b++;
}

