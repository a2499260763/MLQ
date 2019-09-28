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
    class oneorganizationBLL : IoneorganizationBLL
    {
        IoneorganizationDAO ione = IocCreate.CreateDao<IoneorganizationDAO, oneorganizationDAO>();
        //一表添加
        public int oneorganizationAdd(oneorganizationModel one)
        {
            return ione.oneorganizationAdd(one);
        }
        //一表删除
        public int oneorganizationDel(oneorganizationModel one)
        {
            return ione.oneorganizationDel(one);
        }
        //一表分页
        public List<oneorganizationModel> oneorganizationFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }
        //一表查询
        public List<oneorganizationModel> oneorganizationSelect()
        {
            return ione.oneorganizationSelect();
        }
        //一表条件查询
        public List<oneorganizationModel> oneorganizationSelectWhere(int id)
        {
            return ione.oneorganizationSelectWhere(id);
        }
        //一表修改
        public int oneorganizationUpd(oneorganizationModel one)
        {
            return ione.oneorganizationUpd(one);
        }
    }
}
