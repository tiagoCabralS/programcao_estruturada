using System.Numerics;

namespace ex_aviao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] aviao = new int[19, 4];
            string[,] nomes = new string[19, 4];
            string[] letras = ["A", "B", "C", "D"];
            string opcao, nome;
            int fileira, coluna, ocupados, total;
            bool tem_nome;

            bool procurar_passageiro(string nome)
            {
                for (int a = 0; a < nomes.GetLength(0); a++)
                {
                    for (int b = 0; b < nomes.GetLength(1); b++)
                    {
                        if (nomes[a, b] == nome)
                        {
                            fileira = a;
                            coluna = b;
                            tem_nome = true;
                            return true;
                        }
                    }
                }
                return false;
            }

            int escolher_assento(int fileira, int coluna)
            {
                if (aviao[fileira, coluna] != 0)
                {
                    return 3;
                }
                else
                {
                    Console.Write("Digite seu nome: ");
                    nome = Console.ReadLine();
                                        
                    if (procurar_passageiro(nome))
                    {
                        return 2;
                    }
                    else
                    {
                        aviao[fileira, coluna] = 1;
                        nomes[fileira, coluna] = nome;
                        return 1;
                    }
                }
            }

            void listagem_ocupacao()
            {
                for (int a = 0; a < nomes.GetLength(0); a++)
                {
                    Console.WriteLine($"Fileira n. {a + 1}");
                    for (int b = 0; b < nomes.GetLength(1); b++)
                    {
                        if (nomes[a, b] != null)
                        {
                            Console.WriteLine($"Posição {letras[b]}: {nomes[a, b]}");
                        }
                        Console.WriteLine($"Posição {letras[b]}: vazio");
                    }
                }
            }

            bool lotada()
            {
                ocupados = 0;
                Console.WriteLine("Verificar se lotada ");
                for (int a = 0; a < nomes.GetLength(0); a++)
                {
                    for (int b = 0; b < nomes.GetLength(1); b++)
                    {
                        if (nomes[a, b] != null)
                        {
                            ocupados++;
                        }
                    }
                }
                total = nomes.GetLength(0) * nomes.GetLength(1);
                if (ocupados == total)
                {
                    return true;                    
                }
                else
                {
                    return false;
                }
            }
        

            while (true)
            {
                tem_nome = false;
                Console.Clear();
                Console.WriteLine("Opções: ");
                Console.WriteLine("1 - escolher assento");
                Console.WriteLine("2 - Procurar passageiro");
                Console.WriteLine("3 - Listagem de ocupação");
                Console.WriteLine("4 - Verificar se lotada");
                Console.Write("Digite a opção: ");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.WriteLine("Escolha o assento");
                    Console.WriteLine("Fileira: ");
                    fileira = int.Parse(Console.ReadLine());
                    Console.WriteLine("Coluna: ");
                    coluna = int.Parse(Console.ReadLine());

                    if (escolher_assento(fileira, coluna) == 1)
                    {
                        Console.WriteLine("Assento reservado com sucesso.");
                    }
                    else if (escolher_assento(fileira, coluna) == 2)
                    {
                        Console.WriteLine($"Nome já cadastrado.");
                    }
                    else if (escolher_assento(fileira, coluna) == 3)
                    {
                        Console.WriteLine("Posição ocupada.");
                    }
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("Procurar passageiro ");
                    Console.Write("Digite o nome: ");
                    nome = Console.ReadLine();

                    fileira = coluna = 0;

                    for (int a = 0; a < nomes.GetLength(0); a++)
                    {
                        for (int b = 0; b < nomes.GetLength(1); b++)
                        {
                            if (nomes[a, b] == nome)
                            {
                                fileira = a;
                                coluna = b;
                                tem_nome = true;
                                break;
                            }
                        }
                    }

                    if (tem_nome)
                    {
                        Console.WriteLine($"Nome encontrado na posição [{fileira}, {coluna}]");
                    }
                    else
                    {
                        Console.WriteLine("Nome não cadastrado.");
                    }
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Listagem de ocupação: ");
                    listagem_ocupacao();
                }
                else if (opcao == "4")
                {
                    if (lotada())
                    {
                        Console.WriteLine("Todos os assentos estão reservados.");
                        Console.WriteLine("Encerrando o programa. Volte sempre!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Número de assentos vazios: {total - ocupados}");
                    }
                }
                else
                {
                    Console.Write("Opção inválida! Escolha novamente.");
                }
                Console.ReadKey();
            }
        }
    }
}
