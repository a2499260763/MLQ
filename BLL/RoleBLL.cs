using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model;
using IDAO;
using DAO;
using EF;
using Ioc;

namespace BLL
{
   public class RoleBLL : IRoleBLL
    {
        IRoleDAO iub = IocCreate.CreateDao<IRoleDAO, RoleDAO>();

        public int RoleAdd(RoleModel sm)
        {
            return iub.RoleAdd(sm);
        }

        public int RoleDelete(RoleModel sm)
        {
            return iub.RoleDelete(sm);
        }

        public List<RoleModel> RoleFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<RoleModel> RoleSelect()
        {
            return iub.RoleSelect();
        }

        public List<RoleModel> RolesmanFenYe(int currentPage, int PageSize, out int rows)
        {
            return iub.RolesmanFenYe(currentPage,PageSize, out rows);
        }

        public int RoleUpdate(RoleModel sm)
        {
            return iub.RoleUpdate(sm);
        }

        public List<RoleModel> SelectRoleBy(int id)
        {
            return iub.SelectRoleBy(id);
        }
    }
}
