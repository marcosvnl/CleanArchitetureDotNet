using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TesteDesenvolvimento.Application.Repositories;
using TesteDesenvolvimento.Domain.DTO;

namespace TesteDesenvolvimento.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAddAlunoUseCase _addAlunoUseCase;
        public AlunoController(IAddAlunoUseCase addAlunoUseCase)
        {
            _addAlunoUseCase = addAlunoUseCase;
        }
        [HttpPost("AddAluno")]
        public async Task<IActionResult> AddAluno(AlunosDTO alunos)
        {
            AlunosDTO output = await _addAlunoUseCase.Execute(alunos); 
            return Ok(output);
        }
    }
}
