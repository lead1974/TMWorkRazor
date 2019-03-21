using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TMWork.ViewModels
{
    public class UploadVM
    {

        public int Id { get; set; }
        [Display(Name = "File Name")]
        public string FileName { get; set; }
        [Display(Name = "File Path")]
        public string FilePath { get; set; }

    }
}
