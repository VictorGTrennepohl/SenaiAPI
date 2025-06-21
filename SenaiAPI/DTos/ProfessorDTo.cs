using SenaiAPI.Entidades;
using System.ComponentModel.DataAnnotations;

namespace SenaiAPI.DTos
{
    public class ProfessorDTo
    {
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }

        public Classe Classe { get; set; }

        public long EscolaId { get; set; }
        public Escola Escola { get; set; }
    }
}
