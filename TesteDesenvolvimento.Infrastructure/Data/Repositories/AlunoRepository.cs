using Dapper;
using System.Data;
using System.Data.SqlClient;
using TesteDesenvolvimento.Domain.DTO;

namespace TesteDesenvolvimento.Infrastructure.Data.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly string _connectionString;
        public AlunoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public AlunosDTO AddAluno(AlunosDTO aluno)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string insert = @"INSET INTO (Id_Aluno, Nome, Data_nascimento, Sexo, Data_cadastro, Login_cadastro)
                                VALUES(@Id, @Name, @DataNascimento, @DataCadastro, @LoginCadstro)";

                var result = db.Query<AlunosDTO>(insert, new 
                { 
                    Id = aluno.Id, 
                    Name = aluno.Name,
                    DataNascimento = aluno.DataNascimento,
                    DataCadastro = aluno.DataCadastro,
                    LoginCadastro = aluno.LoginCadastro
                });

                return aluno;
            } 
        }
    }
}
