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
    public class Major_changeBLL : IMajor_changeBLL
    {
        IMajor_changeDAO iub = IocCreate.CreateDao<IMajor_changeDAO, Major_changeDAO>();
        public int Major_changeAdd(Major_changeModel sm)
        {
            return iub.Major_changeAdd(sm);
        }

        public int Major_changeDelete(Major_changeModel sm)
        {
            return iub.Major_changeDelete(sm);
        }

        public List<Major_changeModel> Major_changeFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<Major_changeModel> Major_changemanFenYe(int currentPage, int PageSize, out int rows)
        {
            return iub.Major_changemanFenYe(currentPage, PageSize, out rows);
        }

        public List<Major_changeModel> Major_changeSelect()
        {
            return iub.Major_changeSelect();
        }

        public int Major_changeUpdate(Major_changeModel sm)
        {
            return iub.Major_changeUpdate(sm);
        }

        public List<Major_changeModel> SelectMajor_changeBy(int id)
        {
            return iub.SelectMajor_changeBy(id);
        }
    }
}
