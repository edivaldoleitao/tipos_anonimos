using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tipos_anonimos.Models
{
    public static class IntExtension
    {
        // usa com o 'this' o proprio valor para validar fazendo a extensão do tipo
         public static bool EhPar(this int numero) 
         {
            return numero % 2 == 0;
         }
    }
}