using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Jogo_da_Forca.Model
{
    public class PalavraSecretaBanco
    {
        public int Id { get; set; }

        [Required]
        [StringLength(70,MinimumLength =2,ErrorMessage = "Campo palavra secreta deve te no minimo 2 caractere e maximo 70 caracteres" )]
        public string PalavraSecreta { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 2,ErrorMessage = "Campo palavra secreta deve te no minimo 2 caractere e maximo 70 caracteres")]
        public string Dica { get; set; }
    }
}
