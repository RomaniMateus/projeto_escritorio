using System.ComponentModel.DataAnnotations;

namespace projeto_escritorio.Models;

public class Cliente
{
    [Required(ErrorMessage ="O nome do cliente é obrigatório")]
    [MinLength(10, ErrorMessage = "O nome deve possuir pelo menos 10 caracteres")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage ="O CPF do cliente é obrigatório")]
    [MinLength(14, ErrorMessage = "O CPF não deve possuir mais de 14 caracteres")]
    public string Cpf { get; set; }
    
    [Required(ErrorMessage = "O endereço do cliente é obrigatório")]
    [MinLength(20, ErrorMessage = "O endereço deve possuir pelo menos 20 caracteres")]
    public string Endereco { get; set; }
    
    [Required(ErrorMessage = "O telefone do cliente é obrigatório")]
    [MinLength(10, ErrorMessage = "O telefone deve possuir pelo menos 10 caracteres")]
    public string Telefone { get; set; }
    
    //Adicionar o(s) ID(s) da(s) loja(s) 
}

