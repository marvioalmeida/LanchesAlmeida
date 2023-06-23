using LanchesAlmeida.Models;

namespace LanchesAlmeida.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
