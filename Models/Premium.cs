using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AulaCrudBalta.Models
{
    public class Premium
    {
        [Key]
        [System.ComponentModel.DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o título do premium")]
        public DateTime Startdate { get; set; }


        public DateTime Enddate { get; set; }


        public int StudentId { get; set; }
    }
}