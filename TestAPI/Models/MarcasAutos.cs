using System.ComponentModel.DataAnnotations;

namespace TestAPI.Models
{
    public class MarcasAutos
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Marca { get; set; }
    }
}
