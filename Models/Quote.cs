using System.ComponentModel.DataAnnotations;

namespace hw_.net_lab2.Models
{
    public class Quote
    {
        [Required(ErrorMessage = "Subtotal is required")]
        // double.Epsilon is the smallest positive number
        [Range(double.Epsilon, double.MaxValue, ErrorMessage = "Subtotal must be greater than 0")]
        public decimal Subtotal { get; set; }

        [Required(ErrorMessage = "Discount percent is required")]
        [Range(0, 100, ErrorMessage = "Discount percent must be between {1} and {2}")]
        public decimal Discount { get; set; }
        
        public decimal DiscountAmount => Subtotal * Discount/100;

        public decimal Total => Subtotal - DiscountAmount;
    }
}
