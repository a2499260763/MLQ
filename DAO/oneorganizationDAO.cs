using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
using EF.Entity;
using EF;
using System.Linq.Expressions;
namespace DAO
{
    public  class oneorganizationDAO : DaoBase<oneorganization>, IoneorganizationDAO
    {
        //I级机构添加
        public int oneorganizationAdd(oneorganizationModel one)
        {
            oneorganization fist = new oneorganization()
            {
                
                oneCode = one.oneCode,
                oneCodeName = one.oneCodeName,
                oneCoderemuneration = one.oneCoderemuneration,
                oneCodemarket = one.oneCodemarket
            };
            return Add(fist);
        }
        //I级机构删除
        public int oneorganizationDel(oneorganizationModel one)
        {
            oneorganization fist = new oneorganization()
            {
                oneID=one.oneID
            };
            return Delete(fist);
        }

        public List<oneorganizationModel> oneorganizationFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }
        //I级机构查询
        public List<oneorganizationModel> oneorganizationSelect()
        {
            List<oneorganization> list = Select();
            List<oneorganizationModel> list2 = new List<oneorganizationModel>();
            foreach (oneorganization item in list)
            {
                oneorganizationModel one = new oneorganizationModel()
                {
                    oneID = item.oneID,
                    oneCode = item.oneCode,
                    oneCodeName = item.oneCodeName,
                    oneCoderemuneration = item.oneCoderemuneration,
                    oneCodemarket = item.oneCodemarket
                };
                list2.Add(one);
            }
            return list2;
        }
        //I级机构条件查询
        public List<oneorganizationModel> oneorganizationSelectWhere(int id)
        {
            MyDbContext db = CreateContext();
            List<oneorganization> list = db.oneorganization.AsNoTracking()
                .Where(e => e.oneID == id)
                .Select(e => e)
                .ToList();
            List<oneorganizationModel> list2 = new List<oneorganizationModel>();
            foreach (oneorganization item in list)
            {
                oneorganizationModel one = new oneorganizationModel()
                {
                    oneID = item.oneID,
                    oneCode = item.oneCode,
                    oneCodeName = item.oneCodeName,
                    oneCoderemuneration = item.oneCoderemuneration,
                    oneCodemarket = item.oneCodemarket
                };
                list2.Add(one);
            }
            return list2;

        }
        //I级机构修改
        public int oneorganizationUpd(oneorganizationModel one)
        {
            oneorganization first = new oneorganization()
            {
                oneID = one.oneID,
                oneCode = one.oneCode,
                oneCodeName = one.oneCodeName,
                oneCoderemuneration = one.oneCoderemuneration,
                oneCodemarket = one.oneCodemarket
            };
            return Update(first);
        }
    }
}
