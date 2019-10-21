using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Ioc;
using IDAO;
using IBLL;
using DAO;

namespace BLL
{
    public class SalaryBiaoZhunBLL : ISalaryBiaoZhunBLL
    {
        ISalaryBiaoZhunDAO isbz = IocCreate.CreateDao<ISalaryBiaoZhunDAO, SalaryBiaoZhunDAO>();
        public int InsertSalaryBiaoZhun(SalaryBiaoZhunModel sbzm)
        {
            return isbz.InsertSalaryBiaoZhun(sbzm);
        }

        public List<SalaryBiaoZhunModel> SalaryBiaoZhunFenYe(int currentPage, int pageSize, out int rows)
        {
            return  isbz.SalaryBiaoZhunFenYe(currentPage,pageSize,out rows);
        }

        public SalaryBiaoZhunModel SalaryBiaoZhunWhere(int Id)
        {
            return isbz.SalaryBiaoZhunWhere(Id);
        }

        public int UpdaeSalaryBiaoZhun(SalaryBiaoZhunModel sbzm)
        {
            return isbz.UpdaeSalaryBiaoZhun(sbzm);
        }
    }
}
