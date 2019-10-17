using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAO
{
   public interface IMianShiDAO
    {
        int InsertMianShi(MianShiModel msm);

        List<MianShiModel> SelectMianShi();

        List<MianShiModel> MianShiWhere(int Id);

        int UpdateMianShi(MianShiModel msm);
    }
}
