using Fotograf.BL.Abstract;
using Fotograf.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotograf.BL.Concerete
{
    public class KargoManager : ManaBase<Kargo>, IKargoManager
    {
        public bool IsmiKontrolEt(string KargoAdi)
        {
            var sonuc = base.repo.GetAll(p => p.KargoAdi == KargoAdi);
            if (sonuc != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public override int Add(Kargo input)
        {
            if (!IsmiKontrolEt(input.KargoAdi))
                return base.Add(input);
            else
                return -1;
        }
    }
}
