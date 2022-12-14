using Microsoft.EntityFrameworkCore;
using TrabalhoServico.Context;
using TrabalhoServico.Models;
using TrabalhoServico.Repositories.Interfaces;

namespace TrabalhoServico.Repositories
{
    public class JogosRepository : IJogosRepository
    {
        private readonly AppDbContext _context;
        public JogosRepository(AppDbContext ctxt)
        {
            _context = ctxt;
        }
        public IEnumerable<Jogo> Jogos => _context.Jogos.Include(c => c.Categoria);

        public IEnumerable<Jogo> Favoritos => _context.Jogos.Where(c => c.Favorito).Include(c => c.Categoria);

        public Jogo GetJogoById(int jogoId)
        {
            return _context.Jogos.FirstOrDefault(c => c.JogoId == jogoId);
        }
    }
}
