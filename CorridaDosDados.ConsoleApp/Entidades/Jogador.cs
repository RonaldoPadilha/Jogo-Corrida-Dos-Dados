namespace JogoDosDados.ConsoleApp.Entidades;

using System.Security.Cryptography;

public static class Jogador
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
        Console.WriteLine("Rodada do Jogador");
        Console.WriteLine("--------------------------------------");

        Console.Write("Pressione ENTER para lançar um dado...");
        Console.ReadLine();

        int resultadoJogador = RandomNumberGenerator.GetInt32(1, 7);

        posicao += resultadoJogador;

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("O número sorteado foi: " + resultadoJogador);
        Console.WriteLine("--------------------------------------");

        Console.WriteLine($"Você está na posição: {posicao} de {limiteLinhaChegada}.");

        if (posicao == 5 || posicao == 10 || posicao == 15 || posicao == 25)
        {
            Console.WriteLine($"\nEvento: Avanço de {bonusAvancoExtra} casas!");

            posicao += bonusAvancoExtra;

            Console.WriteLine($"\nVocê está na posição: {posicao} de {limiteLinhaChegada}.");
        }

        else if (posicao == 7 || posicao == 13 || posicao == 20)
        {
            Console.WriteLine($"\nEvento: Recuo de {penalidadeRecuo} casas!");

            posicao -= penalidadeRecuo;

            Console.WriteLine($"\nVocê está na posição: {posicao} de {limiteLinhaChegada}.");
        }

        ApresentarMensagemDoJogador();
    }

    public static bool VenceuPartida()
    {
        return posicao >= limiteLinhaChegada; // true / false
    }

    private static void ApresentarMensagemDoJogador()
    {
        if (posicao >= limiteLinhaChegada)
        {
            Console.WriteLine($"Parabéns! Você alcançou a linha de chegada.");
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