﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace p1.Models
{
    public class Product
    {
        [Key]
        public int Id
        {
            get; set;
        }

        [Required]

        public string Name { get; set; }

        public double Price { get; set; }






    }
}
