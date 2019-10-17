using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
using EF.Entity;

namespace DAO
{
    public class EngageTypeDAO : DaoBase<EngageType>, IEngageTypeDAO
    {
        public List<EngageTypeModel> SelectEngageType()
        {
            List<EngageType> list = Select();
            List<EngageTypeModel> list2 = new List<EngageTypeModel>();
            foreach (EngageType item in list)
            {
                EngageTypeModel et = new EngageTypeModel()
                {
                    TName = item.TName
                };
                list2.Add(et);
            }
            return list2;
        }
    }
}
