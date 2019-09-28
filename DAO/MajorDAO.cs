using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EF.Entity;
using IDAO;

namespace DAO
{
    public class MajorDAO : DaoBase<EF.Entity.Major>, IMajorDAO
    {
        public int AddMajor(MajorModel mm)
        {
            Major m = new Major()
            {
                MCID = mm.MCID,
                MKID = mm.MKID
            };
            return Add(m);
        }

        public int DeleMajor(MajorModel mm)
        {
            Major m = new Major()
            {
                Id = mm.Id
            };
            return Delete(m);
        }
    }
}
