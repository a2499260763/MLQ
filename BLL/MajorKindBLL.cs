using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Ioc;
using IDAO;
using DAO;
using EF;
using IBLL;

namespace BLL
{
    public class MajorKindBLL : IMajorKindBLL
    {
        IMajorKindDAO im = Ioc.IocCreate.CreateDao<IMajorKindDAO, MajorKindDAO>();
        public int AddMajorKind(MajorKindModel mk)
        {
            return im.AddMajorKind(mk);
        }

        public int DeleteMajorKind(MajorKindModel mk)
        {
            return im.DeleteMajorKind(mk);
        }

        public List<MajorKindModel> MajorKindFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<MajorKindModel> SelectMajorKind()
        {
             return  im.SelectMajorKind();
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
