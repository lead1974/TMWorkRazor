﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMWork.GoogleReCaptcha.Web.Validation;

namespace TMWork.Data.Core.Domain
{ 
    public class FileUpload
    {
        [Key]
        public int FileUploadId { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public byte[] UploadData { get; set; }
        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
