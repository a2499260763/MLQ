using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
using EF;
using System.Linq.Expressions;

namespace DAO
{
    public class UserDAO : DaoBase<EF.User>, IUserDAO
    {
        public List<UserModel> login(string name, string password)
        {
            MyDbContext db = CreateContext();
            List<User> list = db.User.AsNoTracking()
                  .Where(e => e.user_name == name && e.user_password==password)
                  .Select(e => e)
                  .ToList();
            List<UserModel> list2 = new List<UserModel>();
            foreach (User item in list)
            {
                UserModel sm = new UserModel()
                {
                    user_id = item.user_id,
                    user_name = item.user_name,
                    user_password = item.user_password,
                    user_true_name = item.user_true_name
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
            foreach (User item in list)
            {
                UserModel sm = new UserModel()
                {
                    user_id= item.user_id,
                    user_name=item.user_name,
                    user_password=item.user_password,
                    user_true_name=item.user_true_name
                };
                list2.Add(sm);
            }
            return list2; ;
        }

        public int UserAdd(Model.UserModel t)
        {
            EF.User st = new EF.User()
            {
                user_id = t.user_id,
                user_name = t.user_name,
                user_password = t.user_password,
                user_true_name = t.user_true_name
            };

            return Add(st);
        }

        public int UserDelete(Model.UserModel t)
        {
            EF.User st = new EF.User()
            {
                user_id = t.user_id,
                user_name = t.user_name,
                user_password = t.user_password,
                user_true_name = t.user_true_name
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
            foreach (User item in list)
            {
                UserModel sm = new UserModel()
                {
                    user_id = item.user_id,
                    user_name = item.user_name,
                    user_password = item.user_password,
                    user_true_name = item.user_true_name
                };
                list2.Add(sm);
            }
            return list2; ;
        }

        public int UserUpdate(Model.UserModel sm)
        {
            User st = new User()
            {
                user_id = sm.user_id,
                user_name=sm.user_name,
                user_password=sm.user_password,
                user_true_name=sm.user_true_name
            };
            return Update(st);
        }
    }
}
