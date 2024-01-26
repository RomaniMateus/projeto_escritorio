using System.ComponentModel.DataAnnotations;

namespace projeto_escritorio.Data.Dtos
{
    public class ReadClienteDto
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;

        //Adicionar o(s) ID(s) da(s) loja(s) 
    }
}
