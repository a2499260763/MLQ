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
   public class PublicCharBLL : IPublicCharBLL
    {
        IPublicCharDAO iub = IocCreate.CreateDao<IPublicCharDAO, PublicCharDAO>();

        public int PublicCharAdd(PublicCharModel sm)
        {
            return iub.PublicCharAdd(sm);
        }

        public int PublicCharDelete(PublicCharModel sm)
        {
            return iub.PublicCharDelete(sm);
        }

        public List<PublicCharModel> PublicCharFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<PublicCharModel> PublicCharSelect()
        {
            return iub.PublicCharSelect();
        }

        public int PublicCharUpdate(PublicCharModel sm)
        {
            return iub.PublicCharUpdate(sm);
        }

        public List<PublicCharModel> SelectPublicCharBy(int id)
        {
            return iub.SelectPublicCharBy(id);
        }
    }
}
