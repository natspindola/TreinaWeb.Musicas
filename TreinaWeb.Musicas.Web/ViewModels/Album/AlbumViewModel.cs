using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TreinaWeb.Musicas.Web.Annotatiions;

namespace TreinaWeb.Musicas.Web.ViewModels.Album
{
    public class AlbumViewModel
    {
        [Required(ErrorMessage = "O ID do albúm é obrigatório")]
        public int Id { get; set; }

        [Display(Name = "Nome do albúm")]
        [Required(ErrorMessage = "O nome do albúm é obrigatório")]
        [MaxLength(100, ErrorMessage = " O nome do álbum deve ter no máximo 100 caractéres.")]
        public string Nome { get; set; }

        [Display(Name = "Ano do albúm")]
        [Required(ErrorMessage = "O ano do albúm é obrigatório")]
        public int Ano { get; set; }

        [Display(Name = "Observação do albúm")]
        [Required(ErrorMessage = "Observações")]
        [MaxLength(1000, ErrorMessage = "Você excedeu a quantidade de caractéres para a observação, que é no máximo 1000.")]
        public string Observações { get; set; }

        [Display(Name = "Email de contato")]
        [Required(ErrorMessage = "O email é obrigatório")]
        [MaxLength(50, ErrorMessage = "O email não pode ter mais que 50 caractéres")]
        [EmailTreinaWeb(ErrorMessage = "O email deve ser da TreinaWeb")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}