using eventos.Models;

namespace eventos.API.Services
{
    public interface ICursoService
    {
        List<Curso> GetAll();
        Curso Get(int id);
        void Create(Curso curso);
        void Update(Curso curso);
        void Delete(int id);
    }
}
