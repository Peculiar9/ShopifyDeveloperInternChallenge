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
        public int UserId { get; set; }
        [Key]
        public int RepositoryId { get; set; }
        public int RepositoryName { get; set; }
    }
}
