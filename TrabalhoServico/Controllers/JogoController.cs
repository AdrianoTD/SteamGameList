using Microsoft.AspNetCore.Mvc;
using TrabalhoServico.Repositories.Interfaces;

namespace TrabalhoServico.Controllers
{
    public class JogoController : Controller
    {
        private readonly IJogosRepository _jogosRepository;
        public string JogosT { get; set; }
        public JogoController(IJogosRepository jogosRepository)
        {
            _jogosRepository = jogosRepository;
        }

        public IActionResult List()
        {
            //var jogos = _jogosRepository.Jogos;
            var steam = new SteamController();

            _jogosRepository.Jogos.FirstOrDefault().Nome = steam.GetSteamGames().ToString();

            var jogos = _jogosRepository.Jogos;

            return View(jogos);
        }
    }
}
