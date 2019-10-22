using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
   public interface ISalaryBiaoZhunBLL
    {
        List<SalaryBiaoZhunModel> SelectSalaryBiaoZhun();
        int InsertSalaryBiaoZhun(SalaryBiaoZhunModel sbzm);

        List<SalaryBiaoZhunModel> SalaryBiaoZhunFenYe(int currentPage, int pageSize, out int rows);

        SalaryBiaoZhunModel SalaryBiaoZhunWhere(int Id);

        int UpdaeSalaryBiaoZhun(SalaryBiaoZhunModel sbzm);
    }
}
