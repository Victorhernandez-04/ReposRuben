using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MetaGames.Models
{
    public class CategoriaUsuario
    {
        [Key]
        public int Id { get; set; }
        public bool Administrador { get; set; }
        public bool Gestor { get; set; }
        public bool Autor { get; set; }
        public bool Anadir { get; set; }
        public bool Eliminar { get; set; }
        public bool Modificar { get; set; }
    }
}
