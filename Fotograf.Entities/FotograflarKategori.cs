using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotograf.Entities
{
    public class FotograflarKategori:BaseEntity
    {
        public int FotografId { get; set; }
        public int KategoriId { get; set; }

    }
}
