using System.ComponentModel.DataAnnotations;

namespace CalculadoraPropinas.Web.Models
{
    public class TipModel
    {
        [Required(ErrorMessage = "Rellena este campo.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El total debe ser mayor a 0.")]
        [Display(Name = "Total de la cuenta ($)")]
        public decimal TotalCheck { get; set; }

        [Required(ErrorMessage = "Rellena este campo.")]
        [Range(0, 100, ErrorMessage = "El porcentaje debe estar entre 0 y 100.")]
        [Display(Name = "Porcentaje de propina (%)")]
        public decimal PercentageTip { get; set; }

        public decimal Tip => TotalCheck * (PercentageTip / 100);

        public decimal TotalWithTip => TotalCheck + Tip;

        public string? Message { get; set; }
    }
}