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
    public class PublicCharDAO : DaoBase<PublicChar>, IPublicCharDAO
    {
        public int PublicCharAdd(PublicCharModel sm)
        {
            PublicChar pc = new PublicChar()
            {
                PID = sm.PID,
                PName = sm.PName,
                Ptype = sm.Ptype
            };
            return Add(pc);
        }

        public int PublicCharDelete(PublicCharModel sm)
        {
            PublicChar pc = new PublicChar()
            {
                PID = sm.PID,
                PName = sm.PName,
                Ptype = sm.Ptype
            };
            return Delete(pc);
        }

        public List<PublicCharModel> PublicCharFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<PublicCharModel> PublicCharSelect()
        {
            List<PublicChar> list = Select();
            List<PublicCharModel> list2 = new List<PublicCharModel>();
            foreach (PublicChar sm in list)
            {
                PublicCharModel pc = new PublicCharModel()
                {
                    PID = sm.PID,
                    PName = sm.PName,
                    Ptype = sm.Ptype
                };
                list2.Add(pc);
            }
            return list2; ;
        }

        public int PublicCharUpdate(PublicCharModel sm)
        {
            PublicChar pc = new PublicChar()
            {
                PID = sm.PID,
                PName = sm.PName,
                Ptype = sm.Ptype
            };
            return Update(pc);
        }

        public List<PublicCharModel> SelectPublicCharBy(int id)
        {
            MyDbContext db = CreateContext();
            List<PublicChar> list = db.PublicChar.AsNoTracking()
                  .Where(e => e.PID == id)
                  .Select(e => e)
                  .ToList();
            List<PublicCharModel> list2 = new List<PublicCharModel>();
            foreach (PublicChar sm in list)
            {
                PublicCharModel pc = new PublicCharModel()
                {
                    PID = sm.PID,
                    PName = sm.PName,
                    Ptype = sm.Ptype
                };
                list2.Add(pc);
            }
            return list2; ;
        }
    }
}
