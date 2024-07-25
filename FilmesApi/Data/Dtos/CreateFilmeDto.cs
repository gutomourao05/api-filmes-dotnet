using System;
using System.ComponentModel.DataAnnotations;
namespace FilmesApi.Data.Dtos;
public class CreateFilmeDto
{

    [Required(ErrorMessage = "O título é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O Genero é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do genero não pode exceder 50")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "A Duração é obrigatória")]
    [Range(70, 600, ErrorMessage = "Duracao deve t er entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}

