using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LojadeJogos.Models
{
    public class ModelFunc
    {
        [Display(Name = "Nome do Funcionário")]
        [Required(ErrorMessage = "É obrigatorio inserir o nome do funcionário!")]
        public string FuncName { get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "É obrigatorio inserir o cargo do funcionário!")]
        public string FuncCargo { get; set; }

        [Display(Name = "Código do Funcionário")]
        [Required(ErrorMessage = "É obrigatorio inserir o código do funcionário!")]
        public int FuncCod { get; set; }

        [Display(Name = "E-mail do funcionário")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Insira um E-mail Válido")]
        [Required(ErrorMessage = "É obrigatorio inserir o e-mail do funcionário!")]
        public string FuncEmail { get; set; }

        [Display(Name = "Número de telefone do funcionário")]
        [Required(ErrorMessage = "É obrigatorio inserir o número de telefone do funcionário!")]
        public string FuncNum { get; set; }

        [Display(Name = "RG do funcionário")]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}-\d{1}$", ErrorMessage = "Insira um Rg válido: xx.xxx.xxx-x")]
        [Required(ErrorMessage = "É obrigatorio inserir o RG do funcionário!")]
        public string FuncRg { get; set; }

        [Display(Name = "CPF do funcionário")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Insira um CPF válido: xxx.xxx.xxx-xx")]
        [Required(ErrorMessage = "É obrigatorio inserir o CPF do funcionário!")]
        public string FuncCpf { get; set; }

        [Display(Name = "Endereço do funcionário")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Mínimo de 5 caracteres e máximo de 100")]
        [Required(ErrorMessage = "É obrigatorio inserir o endereço do funcionário!")]
        public string FuncEnd { get; set; }

        [Display(Name = "Data de nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "É obrigatorio inserir a data de nascimento do funcionário!")]
        public DateTime DtFuncNasc
        {
            get
            {
                return this.FuncNasc.HasValue
                    ? this.FuncNasc.Value
                    : DateTime.Now;
            }

            set
            {
                this.FuncNasc = value;
            }
        }
        private DateTime? FuncNasc = null;

    }
}