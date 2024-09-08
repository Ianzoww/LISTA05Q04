using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using LISTA05_HUMBERTO.Models;

namespace LISTA05_HUMBERTO.Controllers
{

    [ApiController]
    [Route("API/ALUNO")]
    public class AlunoController : ControllerBase
    {
        // Static para nao criar nova lista toda vez que chamar a funcao
        private static List<Aluno> listaAlunos = new List<Aluno>();

        [HttpPost]
        [Route("CriarAluno")]
        public IActionResult CriarAluno(Aluno aluno)
        {
            // Nao cai nele
            // Nao esta customisado
            //if (!ModelState.IsValid)
            //{
            //    BadRequest(ModelState);
            //}


            listaAlunos.Add(aluno);
            return Ok();
        }

        [HttpGet]
        [Route("BuscarTodos")]
        public IActionResult BuscarTodos()
        {
            return Ok(listaAlunos);
        }

        [HttpGet]
        [Route("BuscarAlunoPorCPF")]
        public IActionResult BuscarAlunoPorCPF(string cpf)
        {
            Aluno? alunoPesquisado = listaAlunos.Where(a => a.CPF == cpf).FirstOrDefault();

            if (alunoPesquisado is null)
            {
                return NotFound($"{cpf} nao encontrado!");
            }
            return Ok(listaAlunos);
        }



        [HttpDelete]
        [Route("DeletearAluno")]
        public IActionResult RemoverAluno(string cpf)
        {
            Aluno? alunoRemover = listaAlunos.Where(a => a.CPF == cpf).FirstOrDefault();

            if (alunoRemover is null)
            {
                return NotFound($"{cpf} nao encontrado!");
            }
            listaAlunos.Remove(alunoRemover);

            return Ok("Aluno removido");

        }


        [HttpPut]
        [Route("Atualizar/{cpf}")]
        // Chave de busca - Dado novo
        public IActionResult AtualizarTudo(string cpf, Aluno alunoAtualizado)
        {
            Aluno? alunoAtualizar = listaAlunos.Where(a => a.CPF == cpf).FirstOrDefault();

            if (alunoAtualizar is null)
            {
                return NotFound($"{cpf} nao encontrado!");
            }

            alunoAtualizar.Nome = alunoAtualizado.Nome;



            return Ok("Aluno atualizado com sucesso!");
        }
    }
}

