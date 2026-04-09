using System.Security.Cryptography;

int posicaoJogador = 0;
int posicaoComputador = 0;
const int linhaChegada = 30;
bool jogoAtivo = true;

Console.WriteLine("--- BEM-VINDO À CORRIDA DE DADOS ---");
Console.WriteLine($"O objetivo é chegar na posição {linhaChegada}!\n");

//jogadas do jogador e do computador
while (jogoAtivo)
{
    // 1. VEZ DO JOGADOR
    Console.WriteLine("\nSua vez! Pressione [ENTER] para rolar o dado...");
    Console.ReadLine();

    int dadoJogador = RandomNumberGenerator.GetInt32(1, 7); // Gera de 1 a 6
    posicaoJogador += dadoJogador;

    Console.WriteLine($"Você tirou {dadoJogador}! Sua posição atual: {posicaoJogador}");

    // Verificação de Vitória do Jogador
    if (posicaoJogador >= linhaChegada)
    {
        Console.WriteLine("\n--- VITÓRIA! ---");
        Console.WriteLine("Você cruzou a linha de chegada primeiro!");
        jogoAtivo = false;
        break;
    }

    // 2. VEZ DO COMPUTADOR
    Console.WriteLine("\nVez do Computador...");
    Thread.Sleep(3000); // Pequena pausa para dar emoção

    int dadoComputador = RandomNumberGenerator.GetInt32(1, 7);
    posicaoComputador += dadoComputador;

    Console.WriteLine($"O Computador tirou {dadoComputador}! Posição dele: {posicaoComputador}");

    // Verificação de Vitória do Computador
    if (posicaoComputador >= linhaChegada)
    {
        Console.WriteLine("\n--- DERROTA! ---");
        Console.WriteLine("O computador venceu a corrida.");
        jogoAtivo = false;
    }
}

Console.WriteLine("\nFim de jogo. Pressione [ENTER] para sair.");
Console.ReadKey();
