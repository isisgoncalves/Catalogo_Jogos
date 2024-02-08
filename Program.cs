using System;

class Program
{
    static void Main()
    {
        int quantidadeJogos = int.Parse(Console.ReadLine());
        
        string[] nomesJogos = new string[quantidadeJogos];

        for(int i = 0; i < quantidadeJogos; i++)
        {
          AdicionarJogo(i, nomesJogos);
        }

        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    static void AdicionarJogo(int indice, string[] nomes)
    {
        // Entrada do nome do jogo
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {string.Join(", ", nomes)} ao catalogo.");
    }
}
