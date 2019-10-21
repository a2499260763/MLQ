using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAO
{
   public interface IAccessDAO
    {
        string bianhao();

        int Delete(AccessModel t);

        int Insert(AccessModel t);

        List<AccessModel> select(string JSID, string fuID);

        List<AccessModel> select2(int JSID);

        List<AccessModel> SelectAll();

        AccessModel selecttiao(string name);

        int Update(AccessModel t);
    }
}
