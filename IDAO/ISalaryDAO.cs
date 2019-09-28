using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
   public interface ISalaryDAO
    {
        int SalaryAdd(SalaryModel sm);
        int SalaryUpdate(SalaryModel sm);
        int SalaryDelete(SalaryModel sm);
        List<SalaryModel> SalarySelect();
        List<SalaryModel> SelectSalaryBy(int id);
        List<SalaryModel> SalaryFenYe<K>(int currentPage, int PageSize, out int rows);
    }
}
