using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class CreateSessaoDto
    {
        [Required]
        public int FilmeId { get; set; }
    }
}
