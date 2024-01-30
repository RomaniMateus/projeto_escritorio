using System.ComponentModel.DataAnnotations;

namespace projeto_escritorio.Models;

public class Loja
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage ="O campo 'nome' é obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage ="O campo 'CNPJ' é obrigatório")]
    [StringLength(18, ErrorMessage ="O campo 'CNPJ' deve possuir 18 caracteres")]
    public string Cnpj { get; set; }

    [Required(ErrorMessage ="O campo 'Endereço' é obrigatório")]
    [MinLength(20, ErrorMessage ="O campo 'Endereço' deve possui ao menos 20 caracteres")]
    public string Endereco { get; set; }

    public virtual ICollection<Divida>? Dividas { get; set; }
}
