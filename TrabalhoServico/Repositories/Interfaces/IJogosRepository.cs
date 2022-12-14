using TrabalhoServico.Models;

namespace TrabalhoServico.Repositories.Interfaces
{
    public interface IJogosRepository
    {
        IEnumerable<Jogo> Jogos { get; }
        IEnumerable<Jogo> Favoritos { get; }
        Jogo GetJogoById(int jogoId);
    }
}
