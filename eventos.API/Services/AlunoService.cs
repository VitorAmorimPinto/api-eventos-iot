using eventos.API.Database;
using eventos.Models;

namespace eventos.API.Services
{
    public class AlunoService : IAlunoService
    {
        public readonly eventosContext _db;
        public AlunoService(eventosContext db) 
        {
            _db = db;
        }
        public void Create(Aluno aluno)
        {
            _db.Aluno.Add(aluno);

            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Aluno Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<Aluno> GetAll()
        {
            return _db.Aluno.OrderBy(a => a.Matricula).ToList();
        }

        public void Update(Aluno aluno)
        {
            _db.Aluno.Update(aluno);
            _db.SaveChanges();
        }
    }
}
