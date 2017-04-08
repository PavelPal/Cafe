using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cafe.Domain.Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Appartment { get; set; }

        public IEnumerable<OrderedSort> OrderedSorts { get; set; }
    }
}
