// Tiago Santos Cabral da Silva
using System.Runtime.InteropServices;
using System.Transactions;

namespace CarrinhoDePipoca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] carrinhos = new double[20, 5];
            int doce = 3, salgada = 2, opcao, carrinho, qt_doce, qt_salgada, menor_carrinho = -1, vezes_checadas_menor = 0;
            double menor_faturamento = 0;

            void lancarVenda(int num_carrinho, int quant_doce, int quant_salgada)
            {
                num_carrinho = num_carrinho - 1;
                carrinhos[num_carrinho, 0] += quant_doce;
                carrinhos[num_carrinho, 1] += doce * quant_doce;
                carrinhos[num_carrinho, 2] += quant_salgada;
                carrinhos[num_carrinho, 3] += salgada * quant_salgada;
                double somar;
                somar = carrinhos[num_carrinho, 1] + carrinhos[num_carrinho, 3];
                carrinhos[num_carrinho, 4] += somar;

                if (menor_carrinho == -1)
                {
                    menor_carrinho = num_carrinho;
                }
            }

            void cabecalho()
            {
                Console.WriteLine("=============================================================");
                Console.WriteLine("|           |   Pipoca doce   |   Pipoca salg   |           |");
                Console.WriteLine("| Carrinho  |-----------------+-----------------|   Total   |");
                Console.WriteLine("|           | Qtde |   Valor  | Qtde |   Valor  |           |");
                Console.WriteLine("|-----------+------+----------+------+----------+-----------|");
            }

            void corpo()
            {
                for (int a = 0; a < 20; a++)
                {
                    string n, qtdoce, qtsalg, valdoce, valsalg, total;
                    n = string.Format(@"{0:00}", a + 1);
                    qtdoce = string.Format(@"{0:00}", carrinhos[a, 0]);
                    qtsalg = string.Format(@"{0:00}", carrinhos[a, 2]);
                    valdoce = carrinhos[a, 1].ToString("C");
                    valsalg = carrinhos[a, 3].ToString("C");
                    total = carrinhos[a, 4].ToString("C");
                    Console.WriteLine($"|    {n}     |  {qtdoce}  | {valdoce}  |  {qtsalg}  | {valsalg}  | {total}   |");
                }
            }
            #region funcoes
            void rodape()
            {
                Console.WriteLine("|-----------+------+----------+------+----------+-----------|");
                string qt_geral_doceF, qt_geral_salgF, val_geral_doceF, val_geral_salgF, total_geralF;
                double qt_geral_doce = 0, qt_geral_salg = 0, val_geral_doce = 0, val_geral_salg = 0, total_geral = 0;
                for (int a = 0; a < 20; a++)
                {
                    qt_geral_doce += carrinhos[a, 0];
                    val_geral_doce += carrinhos[a, 1];
                    qt_geral_salg += carrinhos[a, 2];
                    val_geral_salg += carrinhos[a, 3];
                    total_geral += carrinhos[a, 4];
                }
                qt_geral_doceF = string.Format(@"{0:00}", qt_geral_doce);
                qt_geral_salgF = string.Format(@"{0:00}", qt_geral_salg);
                val_geral_doceF = val_geral_doce.ToString("C");
                val_geral_salgF = val_geral_salg.ToString("C");
                total_geralF = total_geral.ToString("C");
                Console.WriteLine($"|Total geral|  {qt_geral_doceF}  | {val_geral_doceF}  |  {qt_geral_salgF}  | {val_geral_salgF}  |  {total_geralF}  |");
                Console.WriteLine("=============================================================");
            }

            void maior()
            {
                double maior_faturamento, maior;

                maior = 0;
                maior_faturamento = 0;


                for (int i = 0; i < carrinhos.GetLength(0); i++)
                {
                    if (carrinhos[i, 4] > maior_faturamento)
                    {
                        maior = i + 1;
                        maior_faturamento = carrinhos[i, 4];
                    }
                }

                if (maior == 0)
                {
                    Console.WriteLine("Ainda não houveram vendas.");
                }
                else
                {
                    Console.WriteLine($"O carrinho com maior faturamento foi o N.{maior} com {maior_faturamento.ToString("C")}");
                }
            }

            int menor()
            {
                for (int i = 0; i < carrinhos.GetLength(0); i++)
                {
                    Console.WriteLine($"Checando carrinho {i}");
                    if (menor_carrinho > -1)
                    {
                        if (carrinhos[i, 4] < carrinhos[menor_carrinho, 4] && carrinhos[i, 4] > 0)
                        {
                            Console.WriteLine($"Definindo o carrinho {i} como menor");
                            menor_carrinho = i;
                        }
                    }
                }
                return menor_carrinho;
            }
            #endregion
            while (doce > 2)
            {
                Console.Clear();
                Console.WriteLine("Opções: ");
                Console.WriteLine("0 - Finalizar");
                Console.WriteLine("1 - Lançar venda");
                Console.WriteLine("2 - Mapa de faturamento");
                Console.WriteLine("3 - Carrinho que mais faturou e quanto foi");
                Console.WriteLine("4 - Carrinho que menos faturou e quanto foi");
                Console.Write("Digite a opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Finalizando o sistema. Volte sempre!");
                        doce = 1;
                        break;
                    case 1:
                        Console.WriteLine("Lançar venda");
                        Console.Write("Informe o número do carrinho: ");
                        carrinho = int.Parse(Console.ReadLine());

                        Console.Write("Informe a qunatidade de pipocas doces vendidas: ");
                        qt_doce = int.Parse(Console.ReadLine());
                        Console.Write("Informe a qunatidade de pipocas salgadas vendidas: ");
                        qt_salgada = int.Parse(Console.ReadLine());

                        lancarVenda(carrinho, qt_doce, qt_salgada);

                        Console.WriteLine("Vendas registradas com sucesso.");
                        Console.ReadKey();
                        break;
                    case 2:
                        cabecalho();
                        corpo();
                        rodape();

                        Console.ReadKey();
                        break;
                    case 3:
                        maior();

                        Console.ReadKey();
                        break;
                    case 4:
                        menor_carrinho = menor();

                        if (menor_carrinho == -1)
                        {
                            Console.WriteLine("Ainda não houveram vendas.");
                        }
                        else
                        {
                            Console.WriteLine($"O carrinho com o menor faturamento foi o N.{menor_carrinho + 1} com {carrinhos[menor_carrinho, 4].ToString("C")}");
                        }

                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}
