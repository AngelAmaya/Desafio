using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Desafio.Models
{
    public class Juguete
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(100)]
        public string Descripcion { get; set; }
        public int RestriccionEdad { get; set; }
        [Required]
        [StringLength(100)]
        public string Compania { get; set; }
        [Required]
        public decimal Precio { get; set; }
    }
}