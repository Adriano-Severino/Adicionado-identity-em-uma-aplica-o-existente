﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.ManagerViewModel
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha Atual")]
        public string OldPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Nova Senha")]
        [StringLength(100,ErrorMessage = "O campo {0} deve ter no minimo {2} e no máximo {1} caracteres", MinimumLength = 6)]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirma nova Senha")]
        [Compare("NewPassword", ErrorMessage = "As senhas devem ser iguais")]
        public string ConfirmPassword { get; set; }

        public string StatusMessage { get; set; }
    }
}
