using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAO;
using EF;

namespace DAO
{
    public class MajorKindDAO : DaoBase<EF.Entity.MajorKind>, IMajorKindDAO
    {
        public int AddMajorKind(MajorKindModel mkm)
        {
            EF.Entity.MajorKind mk = new EF.Entity.MajorKind()
            {
                MKID = mkm.MKID,
                MKName = mkm.MKName
            };
            return Add(mk);
        }

        public int DeleteMajorKind(MajorKindModel mkm)
        {
            EF.Entity.MajorKind mk = new EF.Entity.MajorKind()
            {
                Id = mkm.Id
            };
            return Delete(mk);
        }

        public List<MajorKindModel> MajorKindFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<MajorKindModel> SelectMajorKind()
        {
            List<EF.Entity.MajorKind> list = Select();
            List<MajorKindModel> list2 = new List<MajorKindModel>();
            foreach (EF.Entity.MajorKind item in list)
            {
                MajorKindModel mk = new MajorKindModel()
                {
                    Id = item.Id,
                    MKID = item.MKID,
                    MKName = item.MKName
                };
                list2.Add(mk);
            }
            return list2;
        }

        public List<MajorKindModel> SelectMajorKindBy(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateMajorKind(MajorKindModel mk)
        {
            throw new NotImplementedException();
        }

       
    }
}
