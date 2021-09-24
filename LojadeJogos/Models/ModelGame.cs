using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LojadeJogos.Models
{
    public class ModelGame
    {
        [Display(Name = "Nome do Jogo")]
        [Required(ErrorMessage = "É obrigatorio inserir o Nome!")]
        public string GameName { get; set; }

        [Display(Name = "Gênero")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Insira o gênero de 4 a 20 caracteres")]
        [Required(ErrorMessage = "É obrigatorio inserir o gênero!")]
        public string GameGender { get; set; }

        [Display(Name = "Desenvolvedor do Jogo")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Insira o desenvolvedor de 2 a 20 caracteres")]
        [Required(ErrorMessage = "É obrigatorio inserir o nome do desenvolvedor!")]
        public string GameDev { get; set; }

        [Display(Name = "Código do Jogo:")]
        [Required(ErrorMessage = "É obrigatorio inserir o código do jogo!")]
        public int GameCod { get; set; }

        [Display(Name = "Ano de Lançamento")]
        [Required(ErrorMessage = "É obrigatorio inserir o ano de lançamento!")]
        public int GameLan { get; set; }

        [Display(Name = "Versão")]
        public string GameVersion { get; set; }

        [Display(Name = "Sinopse do Jogo")]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Insira no mínimo 20 caracteres e no máximo 500")]
        [Required(ErrorMessage = "É obrigatorio inserir a sinopse!")]
        public string GameSinopse { get; set; }

        [Display(Name = "Plataforma do Jogo")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Mínimo de 5 caracteres e máximo de 20")]
        [Required(ErrorMessage = "É obrigatorio inserir as plataformas as quais o jogo está disponivel!")]
        public string GamePlat { get; set; }

        [Display(Name = "Faixa Etária")]
        [Required(ErrorMessage = "É obrigatorio inserir a faixa etária indicativa!")]
        public string GameIdade { get; set; }
    }
}