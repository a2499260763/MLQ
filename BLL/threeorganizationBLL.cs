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
    class threeorganizationBLL : IthreeorganizationBLL
    {
        IthreeorganizationDAO ithree = IocCreate.CreateDao<IthreeorganizationDAO, threeorganizationDAO>();
        public int threeorganizationAdd(threeorganizationModel three)
        {
            return ithree.threeorganizationAdd(three);
        }

        public int threeorganizationDel(threeorganizationModel three)
        {
            return ithree.threeorganizationDel(three);
        }

        public List<threeorganizationModel> threeorganizationSelect()
        {
            return ithree.threeorganizationSelect();
        }

        public List<threeorganizationModel> threeorganizationSelectWhere(int id)
        {
            return ithree.threeorganizationSelectWhere(id);
        }

        public int threeorganizationUpd(threeorganizationModel three)
        {
            return ithree.threeorganizationUpd(three);
        }

        public List<threeorganizationModel> threeorganizationWhere(string id)
        {
            return ithree.threeorganizationWhere(id);
        }
    }
}
