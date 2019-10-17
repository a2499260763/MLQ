using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAO;
using Model;
using EF.Entity;
using Ioc;
using DAO;

namespace BLL
{
    public class MajorReleaseBLL : IMajorReleaseBLL
    {
        IMajorReleaseDAO imr = IocCreate.CreateDao<IMajorReleaseDAO, MajorReleaseDAO>();

        public int AddMajorRelease(MajorReleaseModel mrm)
        {
          return  imr.AddMajorRelease(mrm);
        }

        public List<MajorReleaseModel> SeleMajorRelease()
        {
            return imr.SeleMajorRelease();
        }

        public List<MajorReleaseModel> MajorReleaseWhere(int id)
        {
            return imr.MajorReleaseWhere(id);
        }

        public int UpdateMajorRelease(MajorReleaseModel mrm)
        {
            return imr.UpdateMajorRelease(mrm);
        }

        public int DeleMajorRelease(MajorReleaseModel mrm)
        {
            return imr.DeleMajorRelease(mrm);
        }
    }
}
