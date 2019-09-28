using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EF;
using IDAO;

namespace DAO
{
    public class MajorChenDAO : DaoBase<EF.Entity.MajorChen>, IMajorChenDAO
    {
        public int DeleMajorChen(MajorChenModel mcm)
        {
            EF.Entity.MajorChen mc = new EF.Entity.MajorChen()
            {
                Id = mcm.Id
            };
            return Delete(mc);
        }

        public List<MajorChenModel> SelectMajorChen()
        {
            List<EF.Entity.MajorChen> list = Select();
            List<MajorChenModel> list2 = new List<MajorChenModel>();
            foreach (EF.Entity.MajorChen item in list)
            {
                MajorChenModel mk = new MajorChenModel()
                {
                    Id = item.Id,
                     CName=item.CName
                };
                list2.Add(mk);
            }
            return list2;
        }
    }
}
