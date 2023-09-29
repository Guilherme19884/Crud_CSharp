using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AulaCrudBalta.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        
        [StringLength(80, ErrorMessage = "O nome não pode ter mais que 80 caracteres")]
        [MinLength(2, ErrorMessage = "O nome não pode ter menos que 2 caracteres")]
        [DisplayName("Nome Completo")]
        public string Nome { get; set; } = string.Empty;



        [Required(ErrorMessage = "Obrigatório informar o E-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [DisplayName("E-mail")]
        public string Email { get; set; } = string.Empty;

        public List<Premium> Premiums { get; set; } = new List<Premium>();
    }
}

//parei no minuto 7:28