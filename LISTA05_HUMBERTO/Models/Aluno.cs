using System.ComponentModel.DataAnnotations;
using LISTA05_HUMBERTO.Validation;

namespace LISTA05_HUMBERTO.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Obrigatório")]
        [MaxLength(10, ErrorMessage = "Maximo 10 letras ")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [ValidacaoRA(ErrorMessage = "RA inválido")]
        public string? RA {get;set;}


        [Required(ErrorMessage = "Obrigatório")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string? CPF { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public bool? Ativo { get; set; }
    }
}
