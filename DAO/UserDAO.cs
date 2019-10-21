using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
using EF;
using System.Linq.Expressions;
using EF.Entity;

namespace DAO
{
    public class UserDAO : DaoBase<User>, IUserDAO
    {


        public List<UserModel> login(string name, string password)
        {
            MyDbContext db = CreateContext();
            List<User> list = db.User.AsNoTracking()
                  .Where(e => e.user_name == name && e.user_password==password)
                  .Select(e => e)
                  .ToList();
            List<UserModel> list2 = new List<UserModel>();
            foreach (User p in list)
            {
                UserModel sm = new UserModel()
                {
                    user_id = p.user_id,
                    user_name = p.user_name,
                    user_password = p.user_password,
                    user_true_name = p.user_true_name,
                    Role_id = p.Role_id,
                    Role_Name = p.Role_Name

                };
                list2.Add(sm);
            }
            return list2; ;
        }

        public List<Model.UserModel> SelectUserBy(int id)
        {
            MyDbContext db = CreateContext();
            List<User> list = db.User.AsNoTracking()
                  .Where(e => e.user_id == id)
                  .Select(e => e)
                  .ToList();
            List<UserModel> list2 = new List<UserModel>();
            foreach (User p in list)
            {
                UserModel sm = new UserModel()
                {
                    user_id = p.user_id,
                    user_name = p.user_name,
                    user_password = p.user_password,
                    user_true_name = p.user_true_name,
                    Role_id = p.Role_id,
                    Role_Name = p.Role_Name

                };
                list2.Add(sm);
            }
            return list2; ;
        }

        public int UserAdd(Model.UserModel p)
        {
            User st = new User()
            {
                user_id = p.user_id,
                user_name = p.user_name,
                user_password = p.user_password,
                user_true_name = p.user_true_name,
                Role_id = p.Role_id,
                Role_Name = p.Role_Name
            };

            return Add(st);
        }

        public int UserDelete(Model.UserModel p)
        {
            User st = new User()
            {
                user_id = p.user_id,
                user_name = p.user_name,
                user_password = p.user_password,
                user_true_name = p.user_true_name,
                Role_id = p.Role_id,
                Role_Name = p.Role_Name
            };

            return Delete(st);
        }

        public List<Model.UserModel> UserFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<Model.UserModel> UserSelect()
        {
            List<User> list = Select();
            List<UserModel> list2 = new List<UserModel>();
            foreach (User p in list)
            {
                UserModel sm = new UserModel()
                {
                    user_id = p.user_id,
                    user_name = p.user_name,
                    user_password = p.user_password,
                    user_true_name = p.user_true_name,
                    Role_id = p.Role_id,
                    Role_Name = p.Role_Name
                };
                list2.Add(sm);
            }
            return list2; ;
        }

        public List<UserModel> UsersmanFenYe(int currentPage, int PageSize, out int rows)
        {
            var list = CreateContext().User.AsNoTracking().OrderBy(e => e.user_id);
            rows = list.Count();
            var data = list
                 .Skip((currentPage - 1) * PageSize)
                 .Take(PageSize)
                 .ToList();
            List<UserModel> list2 = new List<UserModel>();
            foreach (var p in data)
            {
                UserModel e = new UserModel()
                {
                    user_id = p.user_id,
                    user_name = p.user_name,
                    user_password = p.user_password,
                    user_true_name = p.user_true_name,
                    Role_id = p.Role_id,
                    Role_Name = p.Role_Name
                };
                list2.Add(e);
            }
            return list2;
        }

        public int UserUpdate(Model.UserModel p)
        {
            User st = new User()
            {
                user_id = p.user_id,
                user_name = p.user_name,
                user_password = p.user_password,
                user_true_name = p.user_true_name,
                Role_id = p.Role_id,
                Role_Name = p.Role_Name
            };
            return Update(st);
        }






    }
}
