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
    public class RoleDAO : DaoBase<Role>, IRoleDAO
    {
        public int RoleAdd(RoleModel p)
        {
            Role st = new Role()
            {
                Role_id = p.Role_id,
                Role_Name = p.Role_Name,
                Role_shuo = p.Role_shuo,
                Role_bool = p.Role_bool
            };

            return Add(st);
        }

        public int RoleDelete(RoleModel p)
        {
            Role st = new Role()
            {
                Role_id = p.Role_id,
                Role_Name = p.Role_Name,
                Role_shuo = p.Role_shuo,
                Role_bool = p.Role_bool
            };

            return Delete(st);
        }

        public List<RoleModel> RoleFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<RoleModel> RoleSelect()
        {
            List<Role> list = Select();
            List<RoleModel> list2 = new List<RoleModel>();
            foreach (Role p in list)
            {
                RoleModel sm = new RoleModel()
                {
                    Role_id = p.Role_id,
                    Role_Name = p.Role_Name,
                    Role_shuo = p.Role_shuo,
                    Role_bool = p.Role_bool
                };
                list2.Add(sm);
            }
            return list2; ;
        }

        public List<RoleModel> RolesmanFenYe(int currentPage, int PageSize, out int rows)
        {
            var list = CreateContext().Role.AsNoTracking().OrderBy(e => e.Role_id);
            rows = list.Count();
            var data = list
                 .Skip((currentPage - 1) * PageSize)
                 .Take(PageSize)
                 .ToList();
            List<RoleModel> list2 = new List<RoleModel>();
            foreach (var p in data)
            {
                RoleModel e = new RoleModel()
                {
                    Role_id = p.Role_id,
                    Role_Name = p.Role_Name,
                    Role_shuo = p.Role_shuo,
                    Role_bool = p.Role_bool
                };
                list2.Add(e);
            }
            return list2;
        }

        public int RoleUpdate(RoleModel p)
        {
            Role st = new Role()
            {
                Role_id = p.Role_id,
                Role_Name = p.Role_Name,
                Role_shuo = p.Role_shuo,
                Role_bool = p.Role_bool
            };

            return Update(st);
        }

        public List<RoleModel> SelectRoleBy(int id)
        {
            MyDbContext db = CreateContext();
            List<Role> list = db.Role.AsNoTracking()
                  .Where(e => e.Role_id == id)
                  .Select(e => e)
                  .ToList();
            List<RoleModel> list2 = new List<RoleModel>();
            foreach (Role p in list)
            {
                RoleModel sm = new RoleModel()
                {
                    Role_id = p.Role_id,
                    Role_Name = p.Role_Name,
                    Role_shuo = p.Role_shuo,
                    Role_bool = p.Role_bool

                };
                list2.Add(sm);
            }
            return list2; ;
        }


        public int Adds(int id, int Tid)
        {
            MyDbContext db = CreateContext();
            int a = db.Database.ExecuteSqlCommand(string.Format(@"Insert into [Permissions](id,JSID) values('{0}','{1}')", id, Tid));
            db.SaveChanges();
            return a;
        }
        public int dels(int Tid)
        {
            MyDbContext db = CreateContext();
            int a = db.Database.ExecuteSqlCommand(string.Format(@"delete from  [Permissions] where JSID='{0}'", Tid));
            db.SaveChanges();
            return a;
        }
    }
}
