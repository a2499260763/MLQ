using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAO;
using Model;
using EF;
using locContatiner;
using DAO;

namespace BLL
{
    public class MajorBLL : IMajorBLL
    {
        IMajorDAO im = IocContatiner.CreateDao<IMajorDAO, MajorDAO>();
        public int AddMajor(MajorModel mm)
        {
            return im.AddMajor(mm);
        }

        public int DeleMajor(MajorModel mm)
        {
            return im.DeleMajor(mm);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAO;
using Model;
using EF;
using Ioc;
using DAO;

namespace BLL
{
    public class MajorBLL : IMajorBLL
    {
        IMajorDAO im = Ioc.IocCreate.CreateDao<IMajorDAO, MajorDAO>();
        public int AddMajor(MajorModel mm)
        {
            return im.AddMajor(mm);
        }

        public int DeleMajor(MajorModel mm)
        {
            return im.DeleMajor(mm);
        }
    }
}
