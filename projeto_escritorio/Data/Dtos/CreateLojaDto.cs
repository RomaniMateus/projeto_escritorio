using System.ComponentModel.DataAnnotations;

namespace projeto_escritorio.Data.Dtos;

public class CreateLojaDto
{
    [Required(ErrorMessage = "O campo 'nome' é obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo 'CNPJ' é obrigatório")]
    [StringLength(18, ErrorMessage = "O campo 'CNPJ' deve possuir 18 caracteres")]
    public string Cnpj { get; set; }

    [Required(ErrorMessage = "O campo 'Endereço' é obrigatório")]
    [MinLength(20, ErrorMessage = "O campo 'Endereço' deve possui ao menos 20 caracteres")]
    public string Endereco { get; set; }
}
