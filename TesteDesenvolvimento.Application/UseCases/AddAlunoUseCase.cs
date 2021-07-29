using System;
using System.Threading.Tasks;
using TesteDesenvolvimento.Domain.DTO;
using TesteDesenvolvimento.Infrastructure.Data.IRepositories;

namespace TesteDesenvolvimento.Application.Repositories
{
    public sealed class AddAlunoUseCase : IAddAlunoUseCase
    {
        private readonly IAlunoRepository _alunoRepository;
        public AddAlunoUseCase(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public async Task<AlunosDTO> Execute(AlunosDTO alunos)
        {
            alunos = new AlunosDTO();
            try
            {
                if (alunos.Id == 0)
                {
                    AlunosDTO aluno = new AlunosDTO();
                    aluno.Id = 0;
                    return aluno;
                }

                AlunosDTO alunosDTO =  _alunoRepository.AddAluno(alunos);

                return alunosDTO;
            }
            catch (Exception ex)
            {

                AlunosDTO aluno = new AlunosDTO();
                aluno.Id = 0;
                return aluno;
            }
        }
    }
}
