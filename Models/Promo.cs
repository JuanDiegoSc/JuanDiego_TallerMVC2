using System.ComponentModel.DataAnnotations;

namespace JuanDiego_TallerMVC2.Models
{
    public class Promo
    {
        [Key]
        public int PromoId { get; set; }

        [Required]
        public string? Descripcion { get; set; }

        [Required]
        public DateTime FechaPromo { get; set; }

        public int BurgerId { get; set; }

        public Burger? Burger { get; set; }
    }
}
