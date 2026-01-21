using GerenciadorLivraria.Communication.Enums;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorLivraria.Communication.Requests;

public class RequestRegisterBook
{
    [Required(ErrorMessage = "O título é obrigatório.")]
    [StringLength(120, MinimumLength = 2, ErrorMessage = "O título deve ter entre 2 e 120 caracteres.")]
    public required string Title { get; set; }

    [Required(ErrorMessage = "O autor é obrigatório.")]
    [StringLength(120, MinimumLength = 2, ErrorMessage = "O autor deve ter entre 2 e 120 caracteres.")]
    public required string Author { get; set; }

    [Required(ErrorMessage = "O gênero é obrigatório.")]
    [EnumDataType(typeof(BookGenre), ErrorMessage = "Gênero inválido.")]
    public required string Genre { get; set; }

    [Required(ErrorMessage = "O preço é obrigatório.")]
    [Range(0, double.MaxValue, ErrorMessage = "O preço deve ser maior ou igual a 0.")]
    public required decimal Price { get; set; }

    [Required(ErrorMessage = "O estoque é obrigatório")]
    [Range(0, double.MaxValue, ErrorMessage = "O estoque deve ser maior ou igual a 0.")]
    public required int Stock { get; set; }
}
