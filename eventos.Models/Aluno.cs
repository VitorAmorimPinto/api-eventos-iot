using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventos.Models
{
    public class Aluno
    {
        [Key]
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public Curso?  Curso { get; set; }
        public ICollection<Evento>? Eventos { get; set; }
    }
}
