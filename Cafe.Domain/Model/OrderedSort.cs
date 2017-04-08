using System.ComponentModel.DataAnnotations;

namespace Cafe.Domain.Model
{
    public class OrderedSort
    {
        [Key]
        public int Id { get; set; }

        public int Quantity { get; set; }

        public int SortId { get; set; }
        public Sort Sort { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
