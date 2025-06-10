using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL
    {
        public IEnumerable<Artista> Listar()
        {

            using var context = new ScreenSoundContext();

            return context.Artistas.ToList();            
        }

        //public void Adicionar(Artista artista)
        //{
        //    using var connection = new ScreenSoundContext().ObterConexao();
        //    connection.Open();

        //    string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";
        //    SqlCommand command = new SqlCommand(sql, connection);

        //    command.Parameters.AddWithValue("@nome", artista.Nome);
        //    command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
        //    command.Parameters.AddWithValue("@bio", artista.Bio);

        //    int retorno = command.ExecuteNonQuery();
        //    Console.WriteLine($"Linhas afetadas: {retorno}");

        //}
    }
}
