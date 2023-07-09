using System.ComponentModel.DataAnnotations;

namespace MoviesApi;

public class Movie
{
  [Required(ErrorMessage = "O título do filme é obrigatório.")]
  public string Title { get; set; }

  [Required(ErrorMessage = "O gênero do filme é obrigatório.")]
  [MaxLength(50, ErrorMessage = "O gênero do filme não pode conter mais de 50 caracteres.")]
  public string Genre { get; set; }

  [Required(ErrorMessage = "A duração do filme é obrigatório.")]
  [Range(70, 600, ErrorMessage = "A duração do filme deve ter entre 70 e 600 minutos.")]
  public int Duration { get; set; }
}