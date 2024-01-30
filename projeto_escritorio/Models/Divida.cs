using System.ComponentModel.DataAnnotations;

namespace projeto_escritorio.Models;

public class Divida
{
    [Key]
    [Required]
    public int Id { get; set; }

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
