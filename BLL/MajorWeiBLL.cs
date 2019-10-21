using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using IBLL;
using Model;
using EF.Entity;
using System.Linq.Expressions;
using EF;
using DAO;
using Ioc;
namespace BLL
{
    class MajorWeiBLL : IMajorWeiBLL
    {
        IMajorWeiDAO iwei = IocCreate.CreateDao<IMajorWeiDAO, MajorWeiDAO>();
        public List<MajorWeiModel> MajorWeiSelect()
        {
            return iwei.MajorWeiSelect();
        }

        public List<MajorWeiModel> MajorWeiSelectWhere(int id)
        {
            return iwei.MajorWeiSelectWhere(id);
        }
    }
}
