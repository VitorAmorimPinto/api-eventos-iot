using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventos.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
    }
}
