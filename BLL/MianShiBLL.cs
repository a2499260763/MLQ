using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ioc;
using System.Threading.Tasks;
using EF.Entity;
using IDAO;
using IBLL;
using DAO;
using Model;

namespace BLL
{
    public class MianShiBLL : IMianShiBLL
    {
        IMianShiDAO ims = IocCreate.CreateDao<IMianShiDAO, MianShiDAO>();
        public int InsertMianShi(MianShiModel msm)
        {
            return ims.InsertMianShi(msm);
        }

        public List<MianShiModel> MianShiWhere(int Id)
        {
            return ims.MianShiWhere(Id);
        }

        public List<MianShiModel> SelectMianShi()
        {
            return ims.SelectMianShi();
        }

        public int UpdateMianShi(MianShiModel msm)
        {
            return ims.UpdateMianShi(msm);
        }
    }
}
