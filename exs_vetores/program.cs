// Aluno: Tiago Santos Cabral da Silva - CB:3047709

// ex1

int[] numeros = new int[5];

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i + 1}° número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int c = 0; c < numeros.Length; c++)
{
    Console.WriteLine($"{numeros[c]} x 2 = {numeros[c] * 2}");
}

Console.WriteLine("--------------------------------------");

// ex2

int[] numeros2 = new int[10];
int soma;

soma = 0;

for (int i = 0; i < numeros2.Length; i++)
{
    Console.Write($"Digite o {i + 1}° número: ");
    numeros2[i] = int.Parse(Console.ReadLine());
    soma += numeros2[i];
}

for (int i = 10; i < numeros2.Length; i--)
{
    Console.WriteLine($"{numeros2[i]}");
}

Console.WriteLine($"A soma dos números é {soma}");

Console.WriteLine("--------------------------------------");

// ex3

int[] numeros3 = new int[20];
int constante;

for (int i = 0; i < 20; i++)
{
    Console.Write($"Digite o {i + 1}° número: ");
    numeros3[i] = int.Parse(Console.ReadLine());
}

Console.Write("Digite a constante multiplicativa: ");
constante = int.Parse(Console.ReadLine());

for (int i = 0; i < numeros3.Length; i++)
{
    numeros3[i] *= constante;
}

for (int i = 0; i < numeros3.Length; i++)
{
    Console.WriteLine($"{numeros3[i]}");
}

Console.WriteLine("--------------------------------------");

// ex4

int[] numeros4 = new int[20];
int[] produtos = new int[20];
int constante2;

for (int i = 0; i < numeros4.Length; i++)
{
    Console.Write($"Digite o {i + 1}° número: ");
    numeros4[i] = int.Parse(Console.ReadLine());
}

Console.Write("Digite a constante multiplicativa: ");
constante2 = int.Parse(Console.ReadLine());

for (int i = 0; i < numeros4.Length; i++)
{
    produtos[i] = numeros4[i] * constante2;
}

for (int i = 0; i < produtos.Length; i++)
{
    Console.WriteLine($"{produtos[i]}");
}

Console.WriteLine("--------------------------------------");

// ex5

int[] numeros5 = new int[10];
int maior, menor;

for (int i = 0; i < numeros5.Length; i++)
{
    Console.Write($"Digite o {i + 1}° número: ");
    numeros5[i] = int.Parse(Console.ReadLine());
}

maior = numeros5[0];
menor = numeros5[0];

for (int i = 0; i < numeros5.Length; i++)
{
    if (numeros5[i] > maior) { maior = numeros5[i]; }
    if (numeros5[i] < menor) { menor = numeros5[i]; }
}

Console.WriteLine($"O maior valor digitado foi {maior}");
Console.WriteLine($"O menor valor digitado foi {menor}");

Console.WriteLine("--------------------------------------");

// ex6

int[] numeros6 = new int[10];
int escolha, posicao;
string continuar;
bool achou;

for (int i = 0; i < numeros6.Length; i++)
{
    Console.Write($"Digite o {i + 1}° número: ");
    numeros6[i] = int.Parse(Console.ReadLine());
}

posicao = -1;

while (true)
{
    Console.Write("Número a ser pesquisado: ");
    escolha = int.Parse(Console.ReadLine());

    achou = false;
    for (int i = 0; i < numeros6.Length; i++)
    {
        if (numeros6[i] == escolha)
        {
            achou = true;
            posicao = i;
            break;
        }
    }
    if (achou)
    {
        Console.WriteLine($"O número {escolha} foi encontrado na posição {posicao} do vetor.");
    }
    else
    {
        Console.WriteLine("Número não encontrao no vetor.");
    }

    Console.WriteLine("Deseja continuar? (n para interromper) ");
    continuar = Console.ReadLine();
    if (continuar == "n")
    {
        break;
    }
}

Console.WriteLine("--------------------------------------");

// ex7

string[] nomes = new string[5];
float[] p1s = new float[5];
float[] p2s = new float[5];

for (int i = 0; i < nomes.Length; i++)
{
    Console.Write("Digite o nome do aluno: ");
    nomes[i] = Console.ReadLine();
    Console.Write("Digite a p1 do aluno: ");
    p1s[i] = float.Parse(Console.ReadLine());
    Console.Write("Digite a p2 do aluno: ");
    p2s[i] = float.Parse(Console.ReadLine());
}
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"{i + 1} - Aluno: {nomes[i]} P1: {p1s[i]} P2: {p2s[i]} - Média: {(p1s[i] + p2s[i]) / 2}");
}