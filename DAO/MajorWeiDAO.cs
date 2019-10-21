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
    public class MajorWeiDAO : DaoBase<MajorWei>, IMajorWeiDAO
    {
        public int MajorWeiAdd(MajorWeiModel wei)
        {
            MajorWei w = new MajorWei()
            {
                
                MWei = wei.MWei
            };
            return Add(w);
        }

        public int MajorWeiDel(MajorWeiModel wei)
        {
            MajorWei w = new MajorWei()
            {
                id = wei.id,
            };
            return Delete(w);
        }

        public List<MajorWeiModel> MajorWeiSelect()
        {
            List<MajorWei> list = Select();
            List<MajorWeiModel> list2 = new List<MajorWeiModel>();
            foreach (MajorWei item in list)
            {
                MajorWeiModel one = new MajorWeiModel()
                {
                    id = item.id,
                    MWei = item.MWei
                };
                list2.Add(one);
            }
            return list2;
        }

        public List<MajorWeiModel> MajorWeiSelectWhere(int id)
        {
            MyDbContext db = CreateContext();
            List<MajorWei> list = db.MajorWei.AsNoTracking()
                .Where(e => e.id == id)
                .Select(e => e)
                .ToList();
            List<MajorWeiModel> list2 = new List<MajorWeiModel>();
            foreach (MajorWei item in list)
            {
                MajorWeiModel w = new MajorWeiModel()
                {
                    id = item.id,
                    MWei = item.MWei
                };
                list2.Add(w);
            }
            return list2;
        }

        public int MajorWeiUpd(MajorWeiModel wei)
        {
            MajorWei w = new MajorWei()
            {
                id = wei.id,
                MWei = wei.MWei
            };
            return Update(w);
        }
    }
}
