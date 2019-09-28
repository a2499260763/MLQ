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
    public class UserBLL : IUserBLL
    {
        IUserDAO iub = IocCreate.CreateDao<IUserDAO, UserDAO>();

        public List<UserModel> login(string name, string password)
        {
            return iub.login(name, password);
        }

        public List<UserModel> SelectUserBy(int id)
        {
            return iub.SelectUserBy(id);
        }

        public int UserAdd(UserModel sm)
        {
            return iub.UserAdd(sm);
        }

        public int UserDelete(UserModel sm)
        {
            return iub.UserDelete(sm);
        }

        public List<UserModel> UserFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> UserSelect()
        {
            return iub.UserSelect();
        }

        public int UserUpdate(UserModel sm)
        {
            return iub.UserUpdate(sm);
        }

        //////111
    }
}
