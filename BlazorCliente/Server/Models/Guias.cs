using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCliente.Server.Models
{
    public class Guias
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime Fecha { get; set; }
        public string Resumen { get; set; }
        public string Cuerpo { get; set; }
    }
}
