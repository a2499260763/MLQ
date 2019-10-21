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
    class resourceBLL : IresourceBLL
    {
        IresourceDAO ires = IocCreate.CreateDao<IresourceDAO, resourceDAO>();
        public int resourceAdd(resourceModel r)
        {
            return ires.resourceAdd(r);
        }

        public int resourceDel(resourceModel r)
        {
           return ires.resourceDel(r);
        }

        public List<resourceModel> resourceFenYe(int RRState, string RState,int currentPage, int PageSize, out int rows)
        {
            return ires.resourceFenYe(RRState,RState,currentPage, PageSize,out rows);
        }

        public List<resourceModel> resourceSelect()
        {
            return ires.resourceSelect();
        }

        public List<resourceModel> resourceSelectWhere(string id)
        {
            return ires.resourceSelectWhere(id);
        }

        public int resourceUpd(resourceModel r)
        {
            return ires.resourceUpd(r);
        }

        public List<resourceModel> resourceWhereFenYe(resourceModel res, int pageindex, int pagecount, out int count)
        {
            return ires.resourceWhereFenYe(res, pageindex, pagecount,out count);
        }
    }
}
