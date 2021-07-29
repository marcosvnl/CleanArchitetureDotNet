using System;

namespace TesteDesenvolvimento.Domain.DTO
{
    public class Situacao
    {
        public int Id { get; set; }
        public string SituacaoAluno { get; set; }
        public DateTime DataCadastro { get; set; }
        public string LoginCadastro { get; set; }
    }
}
