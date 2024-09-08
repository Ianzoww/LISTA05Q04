using LISTA05_HUMBERTO.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace LISTA05_HUMBERTO.Uteis
{
    public class ValidarRegistroAluno
    {
        public static bool Validar_RA_Aluno(string ra)
        {
            if(ra.Length != 8 || ra == null)
            {
                return false;
            }
            // @ evita o uso de barra invertida 
            // ^ é o Ancorador de Inicio. A expressao deve comecar com "RA"
            // $ é onde termina a String
            // \d{6} diz que ela tem que ter 6 digitos

            string padraoRA = @"^RA\d{6}$";

            return Regex.IsMatch(ra, padraoRA);
        }
    }
}
