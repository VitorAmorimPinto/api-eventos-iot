using eventos.API.Database;
using eventos.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace eventos.API.Services
{
    public class CursoService : ICursoService
    {   
        public readonly eventosContext _db;

        public CursoService(eventosContext db)
        {
            _db = db;
        }
        public void Create(Curso curso)
        {
            _db.Curso.Add(curso);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            Curso curso = _db.Curso.Find(id)!;

            if (curso != null)
            {
                _db.Curso.Remove(curso);

            }
            _db.SaveChanges();
        }

        public Curso Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Curso> GetAll()
        {
            return _db.Curso.OrderBy(a => a.Id).ToList();
        }

        public void Update(Curso curso)
        {
            _db.Curso.Update(curso);
            _db.SaveChanges();
        }
    }
}
