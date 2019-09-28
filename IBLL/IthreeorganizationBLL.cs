using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IthreeorganizationBLL
    {
        int threeorganizationAdd(threeorganizationModel three);
        int threeorganizationUpd(threeorganizationModel three);
        int threeorganizationDel(threeorganizationModel three);
        List<threeorganizationModel> threeorganizationSelect();
        List<threeorganizationModel> threeorganizationSelectWhere(int id);
    }
}
