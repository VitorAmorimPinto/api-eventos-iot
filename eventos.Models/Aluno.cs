using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventos.Models
{
    public class Aluno
    {
        public String Matricula { get; set; }
        public String Nome { get; set; }
        public Curso  Curso { get; set; }
        public ICollection<Evento> Eventos { get; set; }
    }
}
