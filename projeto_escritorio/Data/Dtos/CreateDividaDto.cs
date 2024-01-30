using projeto_escritorio.Models;
using System.ComponentModel.DataAnnotations;

namespace projeto_escritorio.Data.Dtos;

public class CreateDividaDto
{

    [Required(ErrorMessage = "O campo 'valor' é obrigatório")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O valor da dívida deve ser maior que zero")]
    public float valor { get; set; }

    [Required]
    public int ClienteId { get; set; }

    [Required]
    public int LojaId { get; set; }
}
