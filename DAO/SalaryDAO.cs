using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
using EF.Entity;
using System.Linq.Expressions;
using EF;

namespace DAO
{
    public class SalaryDAO : DaoBase<Salary>, ISalaryDAO
    {
        public int SalaryAdd(SalaryModel sm)
        {
            Salary st = new Salary()
            {
                SID = sm.SID,
                SName = sm.SName
            };
            return Add(st);
        }

        public int SalaryDelete(SalaryModel sm)
        {
            Salary st = new Salary()
            {
                SID = sm.SID,
                SName = sm.SName
            };
            return Delete(st);
        }

        public List<SalaryModel> SalaryFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<SalaryModel> SalarySelect()
        {
            List<Salary> list = Select();
            List<SalaryModel> list2 = new List<SalaryModel>();
            foreach (Salary item in list)
            {
                SalaryModel sm = new SalaryModel()
                {
                    SID = item.SID,
                    SName = item.SName
                };
                list2.Add(sm);
            }
            return list2; ;
        }

        public int SalaryUpdate(SalaryModel sm)
        {
            Salary st = new Salary()
            {
                SID = sm.SID,
                SName = sm.SName
            };
            return Update(st);
        }

        public List<SalaryModel> SelectSalaryBy(int id)
        {
            MyDbContext db = CreateContext();
            List<Salary> list = db.Salary.AsNoTracking()
                  .Where(e => e.SID == id)
                  .Select(e => e)
                  .ToList();
            List<SalaryModel> list2 = new List<SalaryModel>();
            foreach (Salary item in list)
            {
                SalaryModel sm = new SalaryModel()
                {
                    SID = item.SID,
                    SName = item.SName
                };
                list2.Add(sm);
            }
            return list2;
        }
    }
}
