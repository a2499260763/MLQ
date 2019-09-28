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
    public class twoorganizationDAO : DaoBase<twoorganization>, ItwoorganizationDAO
    {
        public int twoorganizationAdd(twoorganizationModel two)
        {
            twoorganization create = new twoorganization()
            {
                oneCodeName = two.oneCodeName,
                twoCode = two.twoCode,
                twoCodeName = two.twoCodeName,
                twoCoderemuneration = two.twoCoderemuneration,
                twoCodemarket = two.twoCodemarket
            };
            return Add(create);
        }

        public int twoorganizationDel(twoorganizationModel two)
        {
            twoorganization create = new twoorganization()
            {
                twoID = two.twoID
            };
            return Delete(create);
        }

        public List<twoorganizationModel> twoorganizationSelect()
        {
            List<twoorganization> list = Select();
            List<twoorganizationModel> list2 = new List<twoorganizationModel>();
            foreach (twoorganization item in list)
            {
                twoorganizationModel two = new twoorganizationModel ()
                {
                    twoID = item.twoID,
                    oneCodeName = item.oneCodeName,
                    twoCode = item.twoCode,
                    twoCodeName = item.twoCodeName,
                    twoCoderemuneration = item.twoCoderemuneration,
                    twoCodemarket = item.twoCodemarket
                };
                list2.Add(two);
            }
            return list2;
        }

        public List<twoorganizationModel> twoorganizationSelectWhere(int id)
        {
            MyDbContext db = CreateContext();
            List<twoorganization> list = db.twoorganization.AsNoTracking()
                .Where(e => e.twoID == id)
                .Select(e => e)
                .ToList();
            List<twoorganizationModel> list2 = new List<twoorganizationModel>();
            foreach (twoorganization item in list)
            {
                twoorganizationModel two = new twoorganizationModel()
                {
                    twoID = item.twoID,
                    oneCodeName = item.oneCodeName,
                    twoCode = item.twoCode,
                    twoCodeName = item.twoCodeName,
                    twoCoderemuneration = item.twoCoderemuneration,
                    twoCodemarket = item.twoCodemarket
                };
                list2.Add(two);
            }
            return list2;
        }
        public List<twoorganizationModel> twoorganizationSelectWhereName(string id)
        {
            MyDbContext db = CreateContext();
            List<twoorganization> list = db.twoorganization.AsNoTracking()
                .Where(e => e.oneCodeName == id)
                .Select(e => e)
                .ToList();
            List<twoorganizationModel> list2 = new List<twoorganizationModel>();
            foreach (twoorganization item in list)
            {
                twoorganizationModel two = new twoorganizationModel()
                {
                    twoID = item.twoID,
                    oneCodeName = item.oneCodeName,
                    twoCode = item.twoCode,
                    twoCodeName = item.twoCodeName,
                    twoCoderemuneration = item.twoCoderemuneration,
                    twoCodemarket = item.twoCodemarket
                };
                list2.Add(two);
            }
            return list2;
        }

        public int twoorganizationUpd(twoorganizationModel two)
        {
            twoorganization create = new twoorganization()
            {
                twoID = two.twoID,
                oneCodeName = two.oneCodeName,
                twoCode = two.twoCode,
                twoCodeName = two.twoCodeName,
                twoCoderemuneration = two.twoCoderemuneration,
                twoCodemarket = two.twoCodemarket
            };
            return Update(create);
        }
    }
}
