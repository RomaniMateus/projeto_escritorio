using projeto_escritorio.Models;
using System.ComponentModel.DataAnnotations;

namespace projeto_escritorio.Data.Dtos;

public class ReadDividaDto
{
    [Required(ErrorMessage = "O campo 'valor' é obrigatório")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O valor da dívida deve ser maior que zero")]
    public float valor { get; set; }

    [Required]
    public int ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; }

    [Required]
    public int LojaId { get; set; }
    public virtual Loja Loja { get; set; }
}
