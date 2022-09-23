using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotograf.Entities
{
    public class Fotograflar:BaseEntity
    {
        public string FotografAdi { get; set; }
        public string Aciklama { get; set; }
        public string Fotografcı { get; set; }

        public string? TeknikOzellikler { get; set; }

        public string Images { get; set; }

        public string? Malzemeler { get; set; }

        
        public Tedarikci? Tedarikci { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime CekilenTarihi { get; set; }
        public string KategoriAdi { get; set; }
    }
}
