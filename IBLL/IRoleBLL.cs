﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IRoleBLL
    {

        int RoleAdd(RoleModel sm);
        int RoleUpdate(RoleModel sm);
        int RoleDelete(RoleModel sm);
        List<RoleModel> RoleSelect();
        List<RoleModel> SelectRoleBy(int id);

        List<RoleModel> RoleFenYe<K>(int currentPage, int PageSize, out int rows);

        List<RoleModel> RolesmanFenYe(int currentPage, int PageSize, out int rows);

    }
}
