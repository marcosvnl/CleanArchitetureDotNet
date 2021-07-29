using System;

namespace TesteDesenvolvimento.Domain.DTO
{
    public class Turma
    {
        public int Id { get; set; }
        public int IdAluno { get; set; }
        public int IdCurso { get; set; }
        public decimal ValorTurma { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public DateTime DataCadastro { get; set; }
        public string LoginCadastro { get; set; }
    }
}
