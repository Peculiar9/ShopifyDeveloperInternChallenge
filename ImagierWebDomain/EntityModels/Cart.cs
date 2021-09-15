using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagierWebDomain.EntityModels
{
    //More Like order
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public IEnumerable<Cart> CartItems { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal TotalPriceMoney { get; set; }
    }
}
