﻿using ScreenSound.Banco;
using ScreenSound.Menus;
using ScreenSound.Modelos;

internal class MenuMostrarMusicasAnoLancamento : Menu
{
    public override void Executar(DAL<Artista> artistaDAL)
    {
        base.Executar(artistaDAL);
        ExibirTituloDaOpcao("Mostrar musicas por ano de lançamento");
        Console.Write("Digite o ano para consultar músicas:");
        string anoLancamento = Console.ReadLine()!;
        var musicaDal = new DAL<Musica>(new ScreenSoundContext());
        var listaAnoLancamento = musicaDal.ListarPor(a => a.AnoLancamento == Convert.ToInt32(anoLancamento));
        if (listaAnoLancamento.Any())
        {
            Console.WriteLine($"\nMusicas do Ano {anoLancamento}:");
            foreach (var musica in listaAnoLancamento)
            {
                musica.ExibirFichaTecnica();
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO ano {anoLancamento} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}