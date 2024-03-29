﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMWork.ViewModels
{
    public class CategoryVM
    {
        public CategoryVM()
        {

        }

        [ScaffoldColumn(false)]
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

    }
}
