using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotograf.Entities
{
    public class FotograflarCesit:BaseEntity
    {
        public string CesidAdi { get; set; }
       
       public string Acıklama { get; set; }

        public string Images { get; set; }
    }
}
