using System.ComponentModel.DataAnnotations;

namespace BlaCrudWeb.Shared.Models
{
  public class Categoria
  {
    public int CategoriaId { get; set; }

    [Required(ErrorMessage = "O nome da categoria é obrigatório")]
    [MaxLength(100)]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "A descrição da categoria é obrigatório")]
    [MaxLength(200)]
    public string? Descricao { get; set; }

    public ICollection<Produto>? Produtos { get; set; }
  }
}