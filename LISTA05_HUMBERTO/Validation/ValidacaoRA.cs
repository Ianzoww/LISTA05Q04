using LISTA05_HUMBERTO.Uteis;
using System.ComponentModel.DataAnnotations;

namespace LISTA05_HUMBERTO.Validation
{
    public class ValidacaoRA : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return ValidarRegistroAluno.Validar_RA_Aluno(value.ToString());
        }
    }
}
