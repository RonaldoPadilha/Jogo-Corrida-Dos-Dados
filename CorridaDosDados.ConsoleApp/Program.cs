using System.Security.Cryptography;

int posicaoJogador = 0;
int posicaoComputador = 0;
const int linhaChegada = 30;
bool jogoAtivo = true;

Console.WriteLine("--- BEM-VINDO À CORRIDA DE DADOS ---");
Console.WriteLine("O objetivo é chegar na posição 30! ");


while (jogoAtivo)
{
    // vez do jogador
    Console.WriteLine("Sua vez! Pressione [ENTER] para rolar o dado...");
    Console.ReadLine();

    int dadoJogador = RandomNumberGenerator.GetInt32(1, 7); // Gera de 1 a 6
    posicaoJogador += dadoJogador;

    Console.WriteLine($"Você tirou {dadoJogador}! Sua posição atual: {posicaoJogador}");

    // Verifica se o jogador ganhou
    if (posicaoJogador >= linhaChegada)
    {
        Console.WriteLine("--- VITÓRIA! ---");
        Console.WriteLine("Você cruzou a linha de chegada primeiro!");
        jogoAtivo = false;
        break;
    }
}
Console.ReadKey();
