using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagierWebDomain.EntityModels
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [MaxLength(40)]
        public string CategoryName { get; set; }
        [MaxLength(300)]
        public string CategoryDescription { get; set; }
    }
}
