using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAO
{
   public interface IMajorChenDAO
    {
        List<MajorChenModel> SelectMajorChen();

        int DeleMajorChen(MajorChenModel Id);
    }
}
