using TrabalhoServico.Models;

namespace TrabalhoServico.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
