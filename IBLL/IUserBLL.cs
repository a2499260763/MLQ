using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
   public interface IUserBLL
    {
        int UserAdd(UserModel sm);
        int UserUpdate(UserModel sm);
        int UserDelete(UserModel sm);
        List<UserModel> UserSelect();
        List<UserModel> SelectUserBy(int id);

        List<UserModel> login(string name, string password);
        List<UserModel> UserFenYe<K>(int currentPage, int PageSize, out int rows);
    }
}
