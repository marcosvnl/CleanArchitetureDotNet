using System;

namespace TesteDesenvolvimento.Domain.DTO
{
    public class RegistroPresencaDTO
    {
        public int Id { get; set; }
        public int IdSituacao { get; set; }
        public DateTime DataPresenca { get; set; }
        public DateTime DataCadastro { get; set; }
        public string LoginCadastro { get; set; }
    }
}
