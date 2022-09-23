using Fotograf.BL.Abstract;
using Fotograf.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotograf.BL.Concerete
{
    public class TeslimManager : ManaBase<Teslim>, ITeslimManager
    {
        public bool IsmiKontrolEt(string TeslimEdenAdi)
        {
            var sonuc = base.repo.GetAll(p => p.TeslimEdenAdi == TeslimEdenAdi);
            if (sonuc != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public override int Add(Teslim input)
        {
            if (!IsmiKontrolEt(input.TeslimEdenAdi))
                return base.Add(input);
            else
                return -1;
        }
    }
}
