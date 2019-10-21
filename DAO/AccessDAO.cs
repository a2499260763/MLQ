using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
using EF.Entity;
using System.Linq.Expressions;
using EF;

namespace DAO
{
    public class AccessDAO : DaoBase<Access>,IAccessDAO
    {
        public string bianhao()
        {
            throw new NotImplementedException();
        }

        public int Delete(AccessModel t)
        {
            throw new NotImplementedException();
        }

        public int Insert(AccessModel t)
        {
            throw new NotImplementedException();
        }

        public List<AccessModel> select(string JSID, string fuID)
        {
            MyDbContext db = new MyDbContext();
            string sql = "";
            if (fuID ==null)
            {
                sql = @"select q.id,[text],Acurl,state,fuID
                        from Access q
                        inner join (
                        select id
                        from [Permissions] 
                        where JSID="+JSID+") qr on q.id=qr.id where [fuID]=0";
            }
            else
            {
                sql = @"select q.id,[text],Acurl,state,fuID
                        from Access q
                        inner join (
                        select id
                        from [Permissions] 
                        where JSID="+JSID+") qr on q.id=qr.id where [fuID]=" + fuID;
            }
            var list = db.Access.SqlQuery(sql);
            List<AccessModel> li2 = new List<AccessModel>();
            foreach(Access item in list)
            {
                AccessModel uu = new AccessModel()
                {
                    id = item.id,
                    text = item.text,
                    Acurl = item.Acurl,
                    state = item.state
                };
                li2.Add(uu);
            }
            return li2;
        }

        public List<AccessModel> select2(int JSID)
        {
            MyDbContext db = CreateContext();
            var li = from p in db.Access
                     join c in db.Permissions on p.id equals c.id
                     where c.JSID == JSID
                     select p;
            List<AccessModel> list = new List<AccessModel>();
            foreach(var item in li)
            {
                AccessModel uu = new AccessModel()
                {
                    text=item.text
                };
                list.Add(uu);
            }
            return list;
        }

        public List<AccessModel> SelectAll()
        {
            throw new NotImplementedException();
        }

        public AccessModel selecttiao(string name)
        {
            MyDbContext db = CreateContext();
            var li = db.Access.Select(e => e).Where(e => e.text == name).ToList();
            AccessModel uu = new AccessModel();
            foreach (var item in li)
            {
               uu = new AccessModel()
                {
                    id = item.id
                };
            }
            return uu;
        }

        public int Update(AccessModel t)
        {
            throw new NotImplementedException();
        }
    }
}
