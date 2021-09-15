﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagierWebDomain.EntityModels
{
    public class Repository
    {
        [Key]
        public int Id { get; set; }
        public Guid ImageId { get; set; }
        public int CategoryId { get; set; }

    }
}
    