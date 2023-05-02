using System;

class Program
{
    static void Main(string[] args)
    {
        int tipoSocio;
        double mensalidade, aumento, novaMensalidade;

        do
        {
            Console.Write("Digite o tipo do sócio (1 para fundador, 2 para contribuinte): ");
            tipoSocio = int.Parse(Console.ReadLine());

            if (tipoSocio == 1 || tipoSocio == 2)
            {
                Console.Write("Digite o valor da mensalidade: ");
                mensalidade = double.Parse(Console.ReadLine());

                if (tipoSocio == 1)
                {
                    aumento = mensalidade * 0.35;
                }
                else
                {
                    aumento = mensalidade * 0.46;
                }

                novaMensalidade = mensalidade + aumento;

                Console.WriteLine("Tipo do sócio: " + tipoSocio);
                Console.WriteLine("Valor atual da mensalidade: R$" + mensalidade.ToString("F2"));
                Console.WriteLine("Valor do aumento: R$" + aumento.ToString("F2"));
                Console.WriteLine("Valor da nova mensalidade: R$" + novaMensalidade.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Tipo de sócio inválido! Digite 1 para fundador ou 2 para contribuinte.");
            }
        } while (tipoSocio != 1 && tipoSocio != 2);

        Console.ReadKey();
    }
}