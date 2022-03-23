using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo_da_Forca.Entities
{
    static class Acentos
    {
        public static char[] VerificarAcentos(char letra)
        {
            char[] arryEscolhida = new char[5];        
            char[] acentosA = { 'A', 'Á', 'Ã', 'Â', 'À' };
            char[] acentosE = { 'E', 'É', 'Ê', 'È' };
            char[] acentosI = { 'I', 'Í', 'Î', 'Ì', };
            char[] acentosO = { 'O', 'Ó', 'Õ', 'Ô', 'Ò' };
            char[] acentosU = { 'U', 'Ú', 'Û', 'Ù' };
            switch (letra)
            {
                case 'A': arryEscolhida = acentosA; break;
                case 'E': arryEscolhida = acentosE; break;
                case 'I': arryEscolhida = acentosI; break;
                case 'O': arryEscolhida = acentosO; break; 
                case 'U': arryEscolhida = acentosU; break; 

            }
            return arryEscolhida;

        }

    }
}
