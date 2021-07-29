using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteDesenvolvimento.Domain.DTO;

namespace TesteDesenvolvimento.Application.Repositories
{
    public interface IAddAlunoUseCase
    {
        Task<AlunosDTO> Execute(AlunosDTO alunos);
    }
}
