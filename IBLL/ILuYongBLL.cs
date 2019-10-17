using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
   public interface ILuYongBLL
    {
        List<LuYongModel> SelectLuYong();

        int InsertLuYong(MianShiModel msm);

        List<LuYongModel> LuYongWhere(int Id);

        int UpdateLuYong(LuYongModel lym);

        int UpdateLuYongShengPi(LuYongModel lym);
    }
}
