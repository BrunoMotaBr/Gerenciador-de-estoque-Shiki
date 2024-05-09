using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_estoque_Shiki.Classes
{
    public class Uteis // Utilities
    {
        public bool ENumero(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            // Tenta converter a string para um número
            // Se a conversão for bem-sucedida, retorna true
            // Caso contrário, retorna false
            try
            {
                double.Parse(input);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
