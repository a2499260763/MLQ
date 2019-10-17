using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
  public interface IJlBLL
    {
        int InsertJl(JlMondel jlm);

        List<JlMondel> JlWhere(int Id);

        int UpdateJl(JlMondel jim);
    }
}
