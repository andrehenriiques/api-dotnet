﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O Genero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do genero não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A Duracao do filme é obrigatório")]
    [Range(70, 600, ErrorMessage = "A duracao deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }

    public virtual ICollection<Sessao> Sessoes { get; set; }

}

