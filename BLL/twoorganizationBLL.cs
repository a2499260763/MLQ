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
    class twoorganizationBLL : ItwoorganizationBLL
    {
        ItwoorganizationDAO itwo = IocCreate.CreateDao<ItwoorganizationDAO, twoorganizationDAO>();
        public int twoorganizationAdd(twoorganizationModel two)
        {
            return itwo.twoorganizationAdd(two);
        }

        public int twoorganizationDel(twoorganizationModel two)
        {
            return itwo.twoorganizationDel(two);
        }

        public List<twoorganizationModel> twoorganizationSelect()
        {
            return itwo.twoorganizationSelect();
        }

        public List<twoorganizationModel> twoorganizationSelectWhere(int id)
        {
            return itwo.twoorganizationSelectWhere(id);
        }

        public List<twoorganizationModel> twoorganizationSelectWhereName(string id)
        {
            return itwo.twoorganizationSelectWhereName(id);
        }

        public int twoorganizationUpd(twoorganizationModel two)
        {
            return itwo.twoorganizationUpd(two);
        }
    }
}
