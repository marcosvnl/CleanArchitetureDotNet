using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDesenvolvimento.Domain.DTO;

namespace TesteDesenvolvimento.Infrastructure.Data.IRepositories
{
    public interface IAlunoRepository
    {
        public AlunosDTO AddAluno(AlunosDTO aluno);
    }
}
