using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LojadeJogos.Models
{
    public class ModelCi
    {

        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "É obrigatorio inserir o nome do cliente!")]
        public string CliName { get; set; }

        [Display(Name = "Endereço do cliente")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Mínimo de 5 caracteres e máximo de 100")]
        [Required(ErrorMessage = "É obrigatorio inserir o endereço do cliente!")]
        public string CliEnd { get; set; }

        [Display(Name = "CPF do cliente")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Insira um CPF válido")]
        [Required(ErrorMessage = "É obrigatorio inserir o CPF do cliente!")]
        public string CliCpf { get; set; }

        [Display(Name = "Número de telefone do cliente")]
        [Required(ErrorMessage = "É obrigatorio inserir o telefone do cliente!")]
        public string CliNum { get; set; }

        [Display(Name = "E-mail do cliente")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Insira um Email Válido")]
        [Required(ErrorMessage = "É obrigatorio inserir o e-mail do cliente!")]
        public string CliEmail { get; set; }

        [Display(Name = "Data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "É obrigatorio inserir a data de nascimento do cliente!")]
        public DateTime DtCliNasc
        {
            get
            {
                return this.CliNasc.HasValue
                    ? this.CliNasc.Value
                    : DateTime.Now;
            }

            set
            {
                this.CliNasc = value;
            }
        }
        private DateTime? CliNasc = null;

    }
}