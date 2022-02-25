using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RudraRug.Models
{
    public class Rug
    { //I defined my properties as per my product assigned to me.
        public int Id { get; set; }
        [StringLength(30, MinimumLength = 3)] 
        [Required]
        public string Manufacturer { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]

        public string Material { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Origin { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Property { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Color { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }
        [Range(1, 500), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
