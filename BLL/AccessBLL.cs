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
   public class AccessBLL: IAccessBLL
    {
        IAccessDAO iub = IocCreate.CreateDao<IAccessDAO, AccessDAO>();

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
            return select(JSID, fuID);
        }

        public List<AccessModel> select2(int JSID)
        {
            return select2(JSID);
        }

        public List<AccessModel> SelectAll()
        {
            throw new NotImplementedException();
        }

        public AccessModel selecttiao(string name)
        {
            return selecttiao(name);
        }

        public int Update(AccessModel t)
        {
            throw new NotImplementedException();
        }
    }
}
