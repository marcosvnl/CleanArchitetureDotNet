using System;

namespace TesteDesenvolvimento.Domain.DTO
{
    public class AlunosDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public DateTime DataCadastro { get; set; }
        public string LoginCadastro { get; set; }
    }
}
