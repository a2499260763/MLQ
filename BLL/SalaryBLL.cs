using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model;
using IDAO;
using DAO;
using EF;
using Ioc;

namespace BLL
{
   public class SalaryBLL : ISalaryBLL
    {
        ISalaryDAO iub = IocCreate.CreateDao<ISalaryDAO, SalaryDAO>();

        public int SalaryAdd(SalaryModel sm)
        {
            return iub.SalaryAdd(sm);
        }

        public int SalaryDelete(SalaryModel sm)
        {
            return iub.SalaryDelete(sm);
        }

        public List<SalaryModel> SalaryFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<SalaryModel> SalarySelect()
        {
            return iub.SalarySelect();
        }

        public int SalaryUpdate(SalaryModel sm)
        {
            return iub.SalaryUpdate(sm);
        }

        public List<SalaryModel> SelectSalaryBy(int id)
        {
            return iub.SelectSalaryBy(id);
        }
    }
}
