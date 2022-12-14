namespace TrabalhoServico.Models
{
    public class Jogo
    {
        public int JogoId { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public string ImagemURL { get; set; }
        public bool Favorito { get; set; }

        public string CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
