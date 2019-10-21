using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Ioc;
using EF.Entity;
using DAO;
using IDAO;
using IBLL;

namespace BLL
{
    public class JlBLL : IJlBLL
    {
        IJlDAO ijl = IocCreate.CreateDao<IJlDAO, JlDAO>();
        public int InsertJl(JlMondel jlm)
        {
            return ijl.InsertJl(jlm);
        }

        public List<JlMondel> JlWhere(int Id)
        {
            return ijl.JlWhere(Id);
        }

        public int UpdateJl(JlMondel jim)
        {
            return ijl.UpdateJl(jim);
        }
    }
}
