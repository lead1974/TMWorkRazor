using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMWork.Data.Core.Domain
{
    public class IndividualButtonPartial
    {
        public string Folder { get; set; }
        public string Page { get;  set; }
        public string Glyph { get; set; }
        public string ButtonType { get; set; }
        public string pagetype { get; set; }

        public int? Id { get; set; }

        public string Path
        {
            get
            {
                if (Folder!="" && Folder != null) { return Folder + "/" + Page; }
                return Page;
            }
        }

        public string ActionParameters
        {
            get
            {
                if (Id != 0 && Id != null)
                {
                    return Id.ToString();
                }
                return null;
            }
        }
    }
}
