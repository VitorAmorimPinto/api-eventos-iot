using eventos.Models;

namespace eventos.API.Services
{
    public interface IAlunoService
    {
        List<Aluno> GetAll();
        Aluno Get(string id);
        void Create(Aluno aluno);
        void Update(Aluno aluno);
        void Delete(string id);

    }
}
