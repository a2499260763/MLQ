using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAO
{
    public interface IthreeorganizationDAO
    {
        int threeorganizationAdd(threeorganizationModel three);
        int threeorganizationUpd(threeorganizationModel three);
        int threeorganizationDel(threeorganizationModel three);
        List<threeorganizationModel> threeorganizationSelect();
        List<threeorganizationModel> threeorganizationSelectWhere(int id);
    }
}
