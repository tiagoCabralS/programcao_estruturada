using System.Transactions;

namespace CarrinhoDePipoca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] carrinhos = new double[20, 5];
            int doce = 3, salgada = 2, opcao, carrinho, quant_doce, quant_salgada, menor = 0;
            double menor_faturamento = 0;


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
                        quant_doce = int.Parse(Console.ReadLine());
                        Console.Write("Informe a qunatidade de pipocas salgadas vendidas: ");
                        quant_salgada = int.Parse(Console.ReadLine());

                        carrinhos[carrinho - 1, 0] += quant_doce;
                        carrinhos[carrinho - 1, 1] += doce * quant_doce;
                        carrinhos[carrinho - 1, 2] += quant_salgada;
                        carrinhos[carrinho - 1, 3] += salgada * quant_salgada;
                        double somar;
                        somar = carrinhos[carrinho - 1 , 1] + carrinhos[carrinho - 1, 3];
                        carrinhos[carrinho - 1, 4] += somar;

                        if (menor == 0)
                        {
                            menor = carrinho;
                            menor_faturamento = carrinhos[carrinho - 1, 4];
                        }
                        
                        Console.WriteLine("Vendas registradas com sucesso.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("=============================================================");
                        Console.WriteLine("|           |   Pipoca doce   |   Pipoca salg   |           |");
                        Console.WriteLine("| Carrinho  |-----------------+-----------------|   Total   |");
                        Console.WriteLine("|           | Qtde |   Valor  | Qtde |   Valor  |           |");
                        Console.WriteLine("|-----------+------+----------+------+----------+-----------|");
                        for (int a = 0; a < 20; a++)
                        {
                            string n, qtdoce, qtsalg, valdoce, valsalg, total;
                            n = string.Format(@"{0:00}", a+1);
                            qtdoce = string.Format(@"{0:00}", carrinhos[a, 0]);
                            qtsalg = string.Format(@"{0:00}", carrinhos[a, 2]);
                            valdoce = carrinhos[a, 1].ToString("C");
                            valsalg = carrinhos[a, 3].ToString("C");
                            total = carrinhos[a, 4].ToString("C");
                            Console.WriteLine($"|    {n}     |  {qtdoce}  | {valdoce}  |  {qtsalg}  | {valsalg}  | {total}   |");
                        }
                        
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
                        Console.ReadKey();

                        break;
                    case 3:
                        double maior_faturamento, maior;

                        maior = 0;
                        maior_faturamento = 0;


                        for (int i = 0; i < carrinhos.GetLength(0); i++)
                        {
                            if (carrinhos[i, 4] > maior_faturamento)
                            {
                                maior = i+1;
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
                        
                        Console.ReadKey();

                        break;
                    case 4:
                        
                        for (int i = 0; i < carrinhos.GetLength(0); i++)
                        {
                            if (menor == 0) {
                                Console.WriteLine("Ainda não houveram vendas.");
                                Console.ReadKey();
                                break;
                            }
                            else if ((carrinhos[i, 4] < menor_faturamento) && (carrinhos[i, 4] != 0))
                            {
                                menor = i+1;
                                menor_faturamento = carrinhos[i, 4];
                                                               
                            }
                            else
                            {
                                Console.WriteLine($"O carrinho com o menor faturamento foi o N.{menor} com {menor_faturamento.ToString("C")}");
                                Console.ReadKey();
                                break;
                            }
                        }

                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}
