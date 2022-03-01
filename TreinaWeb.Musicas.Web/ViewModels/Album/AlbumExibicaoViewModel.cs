using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TreinaWeb.Musicas.Web.ViewModels.Album
{
    public class AlbumExibicaoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome do albúm")]
        public string Nome { get; set; }

        [Display(Name = "Ano do albúm")]
        public int Ano { get; set; }

        [Display(Name = "Observação do albúm")]
        public string Observações { get; set; }

        [Display(Name = "Email de contato")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}