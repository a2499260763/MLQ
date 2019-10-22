using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAO
{
    public interface IRoleDAO
    {
        RoleModel SelectOne(int id);
        int RoleAdd(RoleModel sm);
        int RoleUpdate(RoleModel sm);
        int RoleDelete(RoleModel sm);
        List<RoleModel> RoleSelect();
        List<RoleModel> SelectRoleBy(int id);

        List<RoleModel> RoleFenYe<K>(int currentPage, int PageSize, out int rows);

        List<RoleModel> RolesmanFenYe(int currentPage, int PageSize, out int rows);

        int Adds(int id, int Tid);
        int dels(int Tid);
    }
}
