using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc;
using Model;
using EF.Entity;
using IDAO;
using DAO;
using IBLL;

namespace BLL
{
    public class YuYongBLL:ILuYongBLL
    {
        ILuYongDAO ily = IocCreate.CreateDao<ILuYongDAO,LuYongDAO>();
        public List<LuYongModel> SelectLuYong()
        {
            return ily.SelectLuYong();
        }

        public int InsertLuYong(MianShiModel msm)
        {
            return ily.InsertLuYong(msm);
        }

        public List<LuYongModel> LuYongWhere(int Id)
        {
            return ily.LuYongWhere(Id);
        }

        public int UpdateLuYong(LuYongModel lym)
        {
            return ily.UpdateLuYong(lym);
        }

        public int UpdateLuYongShengPi(LuYongModel lym)
        {
            return ily.UpdateLuYongShengPi(lym);
        }
    }
}
