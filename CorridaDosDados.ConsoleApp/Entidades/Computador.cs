using System.Security.Cryptography;

namespace JogoDosDados.ConsoleApp.Entidades;

public static class Computador
{
    public static int posicao = 0; // atributo
    const int limiteLinhaChegada = 30;
    const int bonusAvancoExtra = 3;
    const int penalidadeRecuo = 2;

    public static void ExecutarRodada()
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Jogo dos Dados");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Rodada do Computador");

        int resultadoComputador = RandomNumberGenerator.GetInt32(1, 7);

        posicao += resultadoComputador;

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("O número sorteado foi: " + resultadoComputador);
        Console.WriteLine("--------------------------------------");

        Console.WriteLine($"O computador está na posição: {posicao} de {limiteLinhaChegada}.");

        if (posicao == 5 || posicao == 10 || posicao == 15 || posicao == 25)
        {
            Console.WriteLine($"\nEvento: Avanço de {bonusAvancoExtra} casas!");

            posicao += bonusAvancoExtra;

            Console.WriteLine($"\nO computador está na posição: {posicao} de {limiteLinhaChegada}.");
        }

        else if (posicao == 7 || posicao == 13 || posicao == 20)
        {
            Console.WriteLine($"\nEvento: Recuo de {penalidadeRecuo} casas!");

            posicao -= penalidadeRecuo;

            Console.WriteLine($"\nO computador está na posição: {posicao} de {limiteLinhaChegada}.");
        }

        ApresentarMensagemDoComputador();
    }

    public static bool VenceuPartida()
    {
        return posicao >= limiteLinhaChegada;
    }

    private static void ApresentarMensagemDoComputador()
    {
        if (posicao >= limiteLinhaChegada)
        {
            Console.WriteLine($"Que pena! O computador alcançou a linha de chegada.");
            Console.WriteLine("--------------------------------------");
            Console.Write("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("--------------------------------------");
            Console.Write("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}