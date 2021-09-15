using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagierWebDomain.EntityModels
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserRoleId { get; set; }
        public string Password { get; set; }
    }
}
