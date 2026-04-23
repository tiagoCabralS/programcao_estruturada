// Tiago Santos Cabral da Silva - 3047709

// ex1

double peso_kg, peso_gramas, peso_mais_porcentagem;

Console.Write("Digite o peso em Kg: ");
peso_kg = double.Parse(Console.ReadLine());

peso_gramas = peso_kg * 1000;
Console.WriteLine($"{peso_kg}Kg = {peso_gramas}g");

peso_mais_porcentagem = peso_gramas + (peso_gramas / 100 * 5);
Console.WriteLine($"Ao engordar 5% seu novo peso será: {peso_mais_porcentagem}g");

// ex2

double valor_compra, valor_final, valor_desconto;
int desconto;

Console.Write("Digite o valor da compra: ");
valor_compra = double.Parse(Console.ReadLine());

Console.WriteLine("----------------------------------------");

desconto = 0;

if (valor_compra > 200)
{
    desconto = 10;
}
else if (valor_compra > 100){
    desconto = 5;
}

valor_desconto = valor_compra / 100 * desconto;

valor_final = valor_compra - valor_desconto;

Console.WriteLine($"Valor original: R${valor_compra}");
Console.WriteLine($"Valor do desconto: R${valor_desconto}");
Console.WriteLine($"Valor final: R${valor_final}");

// ex3

string nome, codigo_cargo, nome_cargo;
double salario_atual, salario_novo;
int aumento;
bool continuar;

nome_cargo = "";
aumento = 0;
continuar = true;

Console.Write("Nome: ");
nome = Console.ReadLine();

Console.Write("Salário: ");
salario_atual = double.Parse(Console.ReadLine());

while (true){
    Console.Write("Cargo: ");
    codigo_cargo = Console.ReadLine();

    if (codigo_cargo == "1")
    {
        nome_cargo = "Escriturário";
        aumento = 30;
        break;
    }
    else if (codigo_cargo == "2")
    {
        nome_cargo = "Secretário";
        aumento = 25;
        break;
    }
    else if (codigo_cargo == "3")
    {
        nome_cargo = "Caixa";
        aumento = 20;
        break;
    }
    else if (codigo_cargo == "4")
    {
        nome_cargo = "Gerente";
        aumento = 15;
        break;
    }
    else if (codigo_cargo == "5")
    {
        nome_cargo = "Diretor";
        aumento = 5;
        break;
    }
    else
    {
        Console.WriteLine("Código digitado é invalido");
        continuar = false;
    }
}

salario_novo = salario_atual + (salario_atual / 100 * aumento);

Console.WriteLine("----------------------------------------");
Console.WriteLine($"Nome: {nome} - Salário atual: R${salario_atual}");
Console.WriteLine($"Cargo: {nome_cargo}");
Console.WriteLine($"Percentual de reajuste: {aumento}% - Salário novo: R${salario_novo}");
