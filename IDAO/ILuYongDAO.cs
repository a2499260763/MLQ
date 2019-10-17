using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAO
{
  public interface ILuYongDAO
    {
        int InsertLuYong(MianShiModel msm);
        List<LuYongModel> SelectLuYong();

        List<LuYongModel> LuYongWhere(int Id);

        int UpdateLuYong(LuYongModel lym);

        int UpdateLuYongShengPi(LuYongModel lym);
    }
}
