using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagierWebDomain.EntityModels
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserRoleId { get; set; }
        public string Password { get; set; }
    }
}
