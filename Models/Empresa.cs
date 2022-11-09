using System.ComponentModel.DataAnnotations;
using System;

namespace Crud.Models
{
    public class Empresa
    {
        [Key]
        public int EmpresaID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public int Codigo { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Pais { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
