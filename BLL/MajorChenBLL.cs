using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc;
using IDAO;
using IBLL;
using EF;
using Model;
using DAO;

namespace BLL
{
    public class MajorChenBLL : IMajorChenBLL
    {
        IMajorChenDAO im = Ioc.IocCreate.CreateDao<IMajorChenDAO, MajorChenDAO>();

        public int DeleMajorChen(MajorChenModel Id)
        {
            return im.DeleMajorChen(Id);
        }

        public List<MajorChenModel> SelectMajorChen()
        {
            return im.SelectMajorChen();
        }
    }
}
