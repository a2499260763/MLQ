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
    public  class threeorganizationDAO : DaoBase<threeorganization>, IthreeorganizationDAO
    {
        public int threeorganizationAdd(threeorganizationModel three)
        {
            threeorganization last = new threeorganization()
            {
                oneName = three.oneName,
                twoCodeName = three.twoCodeName,
                threeCode = three.threeCode,
                threeCodeName = three.threeCodeName,
                threeCodemarket = three.threeCodemarket,
                threeCodepd = three.threeCodepd
            };
            return Add(last);
        }

        public int threeorganizationDel(threeorganizationModel three)
        {
            threeorganization last = new threeorganization()
            {
                threeID=three.threeID
            };
            return Delete(last);
        }

        public List<threeorganizationModel> threeorganizationSelect()
        {
            List<threeorganization> list = Select();
            List<threeorganizationModel> list2 = new List<threeorganizationModel>();
            foreach (threeorganization item in list)
            {
                threeorganizationModel last = new threeorganizationModel()
                {
                    threeID=item.threeID,
                    oneName = item.oneName,
                    twoCodeName = item.twoCodeName,
                    threeCode = item.threeCode,
                    threeCodeName = item.threeCodeName,
                    threeCodemarket = item.threeCodemarket,
                    threeCodepd = item.threeCodepd
                };
                list2.Add(last);
            }
            return list2;
        }

        public List<threeorganizationModel> threeorganizationSelectWhere(int id)
        {
            MyDbContext db = CreateContext();
            List<threeorganization> list = db.threeorganization.AsNoTracking()
                .Where(e => e.threeID == id)
                .Select(e => e)
                .ToList();
            List<threeorganizationModel> list2 = new List<threeorganizationModel>();
            foreach (threeorganization item in list)
            {
                threeorganizationModel last = new threeorganizationModel()
                {
                    threeID = item.threeID,
                    oneName = item.oneName,
                    twoCodeName = item.twoCodeName,
                    threeCode = item.threeCode,
                    threeCodeName = item.threeCodeName,
                    threeCodemarket = item.threeCodemarket,
                    threeCodepd = item.threeCodepd
                };
                list2.Add(last);
            }
            return list2;
        }
        public List<threeorganizationModel> threeorganizationWhere(string id)
        {
            MyDbContext db = CreateContext();
            List<threeorganization> list = db.threeorganization.AsNoTracking()
                .Where(e => e.twoCodeName == id)
                .Select(e => e)
                .ToList();
            List<threeorganizationModel> list2 = new List<threeorganizationModel>();
            foreach (threeorganization item in list)
            {
                threeorganizationModel last = new threeorganizationModel()
                {
                    threeID = item.threeID,
                    oneName = item.oneName,
                    twoCodeName = item.twoCodeName,
                    threeCode = item.threeCode,
                    threeCodeName = item.threeCodeName,
                    threeCodemarket = item.threeCodemarket,
                    threeCodepd = item.threeCodepd
                };
                list2.Add(last);
            }
            return list2;
        }

        public int threeorganizationUpd(threeorganizationModel three)
        {
            threeorganization last = new threeorganization()
            {
                threeID = three.threeID,
                oneName = three.oneName,
                twoCodeName = three.twoCodeName,
                threeCode = three.threeCode,
                threeCodeName = three.threeCodeName,
                threeCodemarket = three.threeCodemarket,
                threeCodepd = three.threeCodepd
            };
            return Update(last);
        }
    }
}
