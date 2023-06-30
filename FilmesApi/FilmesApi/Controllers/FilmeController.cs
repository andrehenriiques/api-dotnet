using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]

public class FilmeController: ControllerBase
{

    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)
    {
        if (!string.IsNullOrEmpty(filme.Titulo))
        {
            Console.WriteLine(filme.Duracao);
            Console.WriteLine(filme.Titulo);
            Console.WriteLine(filme.Genero);
            filmes.Add(filme);
        }
    }
}

