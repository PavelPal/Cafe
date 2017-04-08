using System.ComponentModel.DataAnnotations;

namespace Cafe.Domain.Model
{
    public class Sort
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool HasFreeCup { get; set; }
        public int FreeCupNumber { get; set; }
    }
}
