using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre com o numero da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o títular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá o valor de deposito inicial (s/n)? ");
            char res = char.Parse(Console.ReadLine());

            if (res == 's' || res == 'S')
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numeroConta, nome, depositoInicial);

            }
            else
            {
                conta = new Conta(numeroConta, nome);
            }

            Console.WriteLine();
            int opc = 0;
            

            int menu(int a)
            {
                int resul;
                Console.WriteLine("[1]Depósito");
                Console.WriteLine("[2]Saque");
                Console.WriteLine("[3]Saldo");
                Console.WriteLine("[5]Sair");
                Console.Write("Escolha uma opcao: ");
                resul = int.Parse(Console.ReadLine());
                a = resul;
                return a;

            }
            Console.Clear();

            while (opc < 5) 
            {
                opc = menu(opc);
                Console.Clear();
                switch (opc)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine();
                        Console.Write("Entre um valor para depósito: ");
                        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conta.Deposito(quantia);
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.Write("Entre um valor para saque: ");
                        quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        conta.Saque(quantia);
                        Console.WriteLine("Dados da conta atualizados:");
                        Console.WriteLine(conta);
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Saldo: ");
                        Console.WriteLine(conta);
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("OPÇÃO INVALIDA");
                        Console.Clear();
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Obrigado por usar nossos serviços!");
        }
    }
}
