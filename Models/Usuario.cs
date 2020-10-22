using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Usuario
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string ApellidoPaterno { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string ApellidoMaterno { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Login { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string NumeroEmpleado { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Status { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Puesto { get; set; }

        public int TotalCnt { get; set; }

    }
}
