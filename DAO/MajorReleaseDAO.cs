using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EF.Entity;
using IDAO;
using EF;

namespace DAO
{
    public class MajorReleaseDAO : DaoBase<MajorRelease>, IMajorReleaseDAO
    {
        public int AddMajorRelease(MajorReleaseModel mrm)
        {
            MajorRelease mr = new MajorRelease()
            {
                Id = mrm.Id,
                MCID = mrm.MCID,
                MKID = mrm.MKID,
                MrAmount = mrm.MrAmount,
                MrChanger = mrm.MrChanger,
                MrChangeTime = mrm.MrChangeTime,
                MrDescribe = mrm.MrDescribe,
                MrOverTime = mrm.MrOverTime,
                MrRegister = mrm.MrRegister,
                MrRegistTime = mrm.MrRegistTime,
                MrRequired = mrm.MrRequired,
                oneID = mrm.oneID,
                MrType = mrm.MrType,
                twoID = mrm.twoID,
                threeID = mrm.threeID,
                
            };
            return Add(mr);
        }

        public int DeleMajorRelease(MajorReleaseModel mrm)
        {
            MajorRelease mr = new MajorRelease()
            {
                Id = mrm.Id,
                MCID = mrm.MCID,
                MKID = mrm.MKID,
                MrAmount = mrm.MrAmount,
                MrChanger = mrm.MrChanger,
                MrChangeTime = mrm.MrChangeTime,
                MrDescribe = mrm.MrDescribe,
                MrOverTime = mrm.MrOverTime,
                MrRegister = mrm.MrRegister,
                MrRegistTime = mrm.MrRegistTime,
                MrRequired = mrm.MrRequired,
                oneID = mrm.oneID,
                MrType = mrm.MrType,
                twoID = mrm.twoID,
                threeID = mrm.threeID,

            };
            return Delete(mr);
        }

        public List<MajorReleaseModel> MajorReleaseWhere(int id)
        {
            MyDbContext md = CreateContext();
            List<MajorRelease> mr = md.MajorRelease.AsNoTracking()
                .Where(e => e.Id == id)
                .Select(e => e) .ToList();
            List<MajorReleaseModel> list = new List<MajorReleaseModel>();
            foreach (MajorRelease item in mr)
            {
               MajorReleaseModel  mrm = new MajorReleaseModel()
                {
                    MCID = item.MCID,
                    MKID = item.MKID,
                };
                list.Add(mrm);
            }
            
            return list;     
        }

        public List<MajorReleaseModel> SeleMajorRelease()
        {
            List<MajorRelease> list = Select();
            List<MajorReleaseModel> list2 = new List<MajorReleaseModel>();
            foreach (MajorRelease item in list)
            {
                MajorReleaseModel mr = new MajorReleaseModel()
                {
                    Id = item.Id,
                    MCID = item.MCID,
                    MKID = item.MKID,
                    MrAmount = item.MrAmount,
                    MrChanger = item.MrChanger,
                    MrChangeTime = item.MrChangeTime,
                    MrDescribe = item.MrDescribe,
                    MrOverTime = item.MrOverTime,
                    MrRegister = item.MrRegister,
                    MrRegistTime = item.MrRegistTime,
                    MrRequired = item.MrRequired,
                    oneID = item.oneID,
                    MrType = item.MrType,
                    twoID = item.twoID,
                    threeID = item.threeID,

                };
                list2.Add(mr);
            }
            return list2;
        }

        public int UpdateMajorRelease(MajorReleaseModel mrm)
        {
            MajorRelease mr = new MajorRelease()
            {
                Id = mrm.Id,
                MCID = mrm.MCID,
                MKID = mrm.MKID,
                MrAmount = mrm.MrAmount,
                MrChanger = mrm.MrChanger,
                MrChangeTime = mrm.MrChangeTime,
                MrDescribe = mrm.MrDescribe,
                MrOverTime = mrm.MrOverTime,
                MrRegister = mrm.MrRegister,
                MrRegistTime = mrm.MrRegistTime,
                MrRequired = mrm.MrRequired,
                oneID = mrm.oneID,
                MrType = mrm.MrType,
                twoID = mrm.twoID,
                threeID = mrm.threeID,

            };
            return Update(mr);
        }
    }
}
