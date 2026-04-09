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

    // evento especial - Avanço  e Recuo
    if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15)
    {
        posicaoJogador += 3;
        Console.WriteLine("BÔNUS! Você caiu em uma casa de impulso e avançou +3 casas!");
        Console.WriteLine($"Nova posição: {posicaoJogador}");
    }
    else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
    {
        posicaoJogador -= 2;
        Console.WriteLine("RECUO! Você caiu em uma armadilha e voltou -2 casas!");
        Console.WriteLine($"Nova posição: {posicaoJogador}");
    }

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
    Thread.Sleep(2000); // Pequena pausa

    int dadoComputador = RandomNumberGenerator.GetInt32(1, 7);
    posicaoComputador += dadoComputador;

    Console.WriteLine($"O Computador tirou {dadoComputador}! Posição dele: {posicaoComputador}");

    // evento especial - Avanço e Recuo
    if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15)
    {
        posicaoComputador += 3;
        Console.WriteLine("IMPULSO! O computador avançou +3 casas extras!");
        Console.WriteLine($"Nova posição dele: {posicaoComputador}");
    }
    else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
    {
        posicaoComputador -= 2;
        Console.WriteLine("O computador caiu em uma armadilha e recuou -2 casas!");
        Console.WriteLine($"Nova posição dele: {posicaoComputador}");
    }

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
