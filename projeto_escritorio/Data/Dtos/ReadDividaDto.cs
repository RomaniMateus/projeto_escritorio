using projeto_escritorio.Models;
using System.ComponentModel.DataAnnotations;

namespace projeto_escritorio.Data.Dtos;

public class ReadDividaDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo 'valor' é obrigatório")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O valor da dívida deve ser maior que zero")]
    public float valor { get; set; }

    public ReadClienteDto cliente { get; set; }

    public ReadLojaDto loja { get; set; }
}
