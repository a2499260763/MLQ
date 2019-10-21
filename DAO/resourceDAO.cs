using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
using EF.Entity;
using EF;
using EF.Entity;
using System.Linq.Expressions;
namespace DAO
{
    public class resourceDAO:DaoBase<resource>,IresourceDAO
    {
        public int resourceAdd(resourceModel r)
        {
            resource e = new resource()
            {
                RCode=r.RCode,
                oneCodeName = r.oneCodeName,
                twoCodeName = r.twoCodeName,
                threeCodeName = r.threeCodeName,
                MKName = r.MKName,
                CName = r.CName,
                MWei = r.MWei,
                RName = r.RName,
                RSex = r.RSex,
                REmail = r.REmail,
                RPhone = r.RPhone,
                RQQ = r.RQQ,
                RCellphone = r.RCellphone,
                RAddress = r.RAddress,
                RPostcode = r.RPostcode,
                RNationality = r.RNationality,
                RBirthplace = r.RBirthplace,
                RBirthday = r.RBirthday,
                RNation = r.RNation,
                RFaith = r.RFaith,
                RPolitics = r.RPolitics,
                RIDKA = r.RIDKA,
                RSecurity = r.RSecurity,
                RAge = r.RAge,
                RBackground = r.RBackground,
                RYears = r.RYears,
                REducation = r.REducation,
                RSalary = r.RSalary,
                RBank = r.RBank,
                RAccounts = r.RAccounts,
                RRegistrant = r.RRegistrant,
                RInputting = r.RInputting,
                Rstrong= r.Rstrong,
                RHobby = r.RHobby,
                Rcurriculum= r.Rcurriculum,
                RFamily= r.RFamily,
                RRemark = r.RRemark,
                RRCode=r.RRCode,
                RRBasicCount = r.RRBasicCount,
                RRShouldCount = r.RRShouldCount,
                RRActualCount = r.RRActualCount,
                RRTransfer = r.RRTransfer,
                RRMotivateCount = r.RRMotivateCount,
                RRTrainCount = r.RRTrainCount,
                RRAlterationCount = r.RRAlterationCount,
                RPhoto = r.RPhoto,
                RAccessory = r.RAccessory,
                RState = r.RState,
                RRecombination = r.RRecombination,
                RRecombinationDate = r.RRecombinationDate,
                RAlteration = r.RAlteration,
                RAlterationDate = r.RAlterationDate,
                RChangeDate = r.RChangeDate,
                RDelDate = r.RDelDate,
                RReplyDate = r.RReplyDate,
                RRState = r.RRState
            };

            return Add(e);
        }
        //I级机构删除
        public int resourceDel(resourceModel r)
        {
            resource e = new resource()
            {
                RCode = r.RCode
            };
            return Delete(e);
        }

        public List<resourceModel> resourceFenYe(int RRState, string RState,int currentPage, int PageSize, out int rows)
        {
            var list = CreateContext().resource.AsNoTracking().Where(e => e.RState == RState).Where(e=>e.RRState== RRState).OrderBy(e => e.RCode);
            rows = list.Count();
            var data = list
                 .Skip((currentPage - 1) * PageSize)
                 .Take(PageSize)
                 .ToList();
            List<resourceModel> list2 = new List<resourceModel>();
            foreach (var item in data)
            {
                resourceModel e = new resourceModel()
                {
                    
                    RCode = item.RCode,
                    oneCodeName = item.oneCodeName,
                    twoCodeName = item.twoCodeName,
                    threeCodeName = item.threeCodeName,
                    MKName = item.MKName,
                    CName = item.CName,
                    MWei = item.MWei,
                    RName = item.RName,
                    RSex = item.RSex,
                    REmail = item.REmail,
                    RPhone = item.RPhone,
                    RQQ = item.RQQ,
                    RCellphone = item.RCellphone,
                    RAddress = item.RAddress,
                    RPostcode = item.RPostcode,
                    RNationality = item.RNationality,
                    RBirthplace = item.RBirthplace,
                    RBirthday = item.RBirthday,
                    RNation = item.RNation,
                    RFaith = item.RFaith,
                    RPolitics = item.RPolitics,
                    RIDKA = item.RIDKA,
                    RSecurity = item.RSecurity,
                    RAge = item.RAge,
                    RBackground = item.RBackground,
                    RYears = item.RYears,
                    REducation = item.REducation,
                    RSalary = item.RSalary,
                    RBank = item.RBank,
                    RAccounts = item.RAccounts,
                    RRegistrant = item.RRegistrant,
                    RInputting = item.RInputting,
                    Rstrong = item.Rstrong,
                    RHobby = item.RHobby,
                    Rcurriculum = item.Rcurriculum,
                    RFamily = item.RFamily,
                    RRemark = item.RRemark,
                    RRCode = item.RRCode,
                    RRBasicCount = item.RRBasicCount,
                    RRShouldCount = item.RRShouldCount,
                    RRActualCount = item.RRActualCount,
                    RRTransfer = item.RRTransfer,
                    RRMotivateCount = item.RRMotivateCount,
                    RRTrainCount = item.RRTrainCount,
                    RRAlterationCount = item.RRAlterationCount,
                    RPhoto = item.RPhoto,
                    RAccessory = item.RAccessory,
                    RState = item.RState,
                    RRecombination = item.RRecombination,
                    RRecombinationDate = item.RRecombinationDate,
                    RAlteration = item.RAlteration,
                    RAlterationDate = item.RAlterationDate,
                    RChangeDate = item.RChangeDate,
                    RDelDate = item.RDelDate,
                    RReplyDate = item.RReplyDate,
                    RRState = item.RRState
                };
                list2.Add(e);
            }
            return list2;
        }
        public List<resourceModel> resourceWhereFenYe(resourceModel res, int pageindex, int pagecount, out int count)
        {
            string sql = "select * from resource where 1=1 ";
            sql += " and RRState="+res.RRState+ " and RState='" + res.RState+"'";
            if (res.oneCodeName != "0"&& res.oneCodeName != ""&& res.oneCodeName != null)
            {
                sql += " and oneCodeName='" + res.oneCodeName+"'";
            }
            if (res.twoCodeName != "0" && res.twoCodeName != "" && res.twoCodeName != null)
            {
                sql += " and twoCodeName='" + res.twoCodeName + "'";
            }
            if (res.threeCodeName != "0" && res.threeCodeName != "" && res.threeCodeName != null)
            {
                sql += " and threeCodeName='" + res.threeCodeName + "'";
            }
            if (res.MKName != "0" && res.MKName != "" && res.MKName != null)
            {
                sql += " and MKName='" + res.MKName + "'";
            }
            if (res.CName != "0" && res.CName != "" && res.CName != null)
            {
                sql += " and CName='" + res.CName + "'";
            }
            if (res.RInputting.ToString() != "0001/1/1 0:00:00" && res.RInputting != null)
            {
                sql += " and RInputting>'" + res.RInputting + "'";
            }
            if (res.RChangeDate.ToString() != "0001/1/1 0:00:00" && res.RChangeDate != null)
            {
                sql += " and RInputting<'" + res.RChangeDate + "'";
            }
            var Result = CreateContext().resource.SqlQuery(sql).Select(e => e).ToList();
            var Result2 = Result.Select(e => e).ToList().Skip((pageindex - 1) * pagecount).Take(pagecount);
            count = Result.Count();
            List<resourceModel> list = new List<resourceModel>();
            foreach (resource item in Result2)
            {
                
                resourceModel hh = new resourceModel()
                {
                    RCode = item.RCode,
                    oneCodeName = item.oneCodeName,
                    twoCodeName = item.twoCodeName,
                    threeCodeName = item.threeCodeName,
                    MKName = item.MKName,
                    CName = item.CName,
                    MWei = item.MWei,
                    RName = item.RName,
                    RSex = item.RSex,
                    REmail = item.REmail,
                    RPhone = item.RPhone,
                    RQQ = item.RQQ,
                    RCellphone = item.RCellphone,
                    RAddress = item.RAddress,
                    RPostcode = item.RPostcode,
                    RNationality = item.RNationality,
                    RBirthplace = item.RBirthplace,
                    RBirthday = item.RBirthday,
                    RNation = item.RNation,
                    RFaith = item.RFaith,
                    RPolitics = item.RPolitics,
                    RIDKA = item.RIDKA,
                    RSecurity = item.RSecurity,
                    RAge = item.RAge,
                    RBackground = item.RBackground,
                    RYears = item.RYears,
                    REducation = item.REducation,
                    RSalary = item.RSalary,
                    RBank = item.RBank,
                    RAccounts = item.RAccounts,
                    RRegistrant = item.RRegistrant,
                    RInputting = item.RInputting,
                    Rstrong = item.Rstrong,
                    RHobby = item.RHobby,
                    Rcurriculum = item.Rcurriculum,
                    RFamily = item.RFamily,
                    RRemark = item.RRemark,
                    RRCode = item.RRCode,
                    RRBasicCount = item.RRBasicCount,
                    RRShouldCount = item.RRShouldCount,
                    RRActualCount = item.RRActualCount,
                    RRTransfer = item.RRTransfer,
                    RRMotivateCount = item.RRMotivateCount,
                    RRTrainCount = item.RRTrainCount,
                    RRAlterationCount = item.RRAlterationCount,
                    RPhoto = item.RPhoto,
                    RAccessory = item.RAccessory,
                    RState = item.RState,
                    RRecombination = item.RRecombination,
                    RRecombinationDate = item.RRecombinationDate,
                    RAlteration = item.RAlteration,
                    RAlterationDate = item.RAlterationDate,
                    RChangeDate = item.RChangeDate,
                    RDelDate = item.RDelDate,
                    RReplyDate = item.RReplyDate,
                    RRState = item.RRState
                };
                list.Add(hh);
            }
            return list;
        }
        //I级机构查询
        public List<resourceModel> resourceSelect()
        {
            List<resource> list = Select();
            List<resourceModel> list2 = new List<resourceModel>();
            foreach (resource item in list)
            {
                resourceModel e = new resourceModel()
                {
                    RCode = item.RCode,
                    oneCodeName = item.oneCodeName,
                    twoCodeName = item.twoCodeName,
                    threeCodeName = item.threeCodeName,
                    MKName = item.MKName,
                    CName = item.CName,
                    RName = item.RName,
                    MWei =item.MWei,
                    RSex = item.RSex,
                    REmail = item.REmail,
                    RPhone = item.RPhone,
                    RQQ = item.RQQ,
                    RCellphone = item.RCellphone,
                    RAddress = item.RAddress,
                    RPostcode = item.RPostcode,
                    RNationality = item.RNationality,
                    RBirthplace = item.RBirthplace,
                    RBirthday = item.RBirthday,
                    RNation = item.RNation,
                    RFaith = item.RFaith,
                    RPolitics = item.RPolitics,
                    RIDKA = item.RIDKA,
                    RSecurity = item.RSecurity,
                    RAge = item.RAge,
                    RBackground = item.RBackground,
                    RYears = item.RYears,
                    REducation = item.REducation,
                    RSalary = item.RSalary,
                    RBank = item.RBank,
                    RAccounts = item.RAccounts,
                    RRegistrant = item.RRegistrant,
                    RInputting = item.RInputting,
                    Rstrong = item.Rstrong,
                    RHobby = item.RHobby,
                    Rcurriculum = item.Rcurriculum,
                    RFamily = item.RFamily,
                    RRemark = item.RRemark,
                    RRCode = item.RRCode,
                    RRBasicCount = item.RRBasicCount,
                    RRShouldCount = item.RRShouldCount,
                    RRActualCount = item.RRActualCount,
                    RRTransfer = item.RRTransfer,
                    RRMotivateCount = item.RRMotivateCount,
                    RRTrainCount = item.RRTrainCount,
                    RRAlterationCount = item.RRAlterationCount,
                    RPhoto = item.RPhoto,
                    RAccessory = item.RAccessory,
                    RState = item.RState,
                    RRecombination = item.RRecombination,
                    RRecombinationDate =item.RRecombinationDate,
                    RAlteration = item.RAlteration,
                    RAlterationDate = item.RAlterationDate,
                    RChangeDate = item.RChangeDate,
                    RDelDate = item.RDelDate,
                    RReplyDate = item.RReplyDate,
                    RRState = item.RRState
                };
                list2.Add(e);
            }
            return list2;
        }
        //I级机构条件查询
        public List<resourceModel> resourceSelectWhere(string code)
        {
            MyDbContext db = CreateContext();
            List<resource> list = db.resource.AsNoTracking()
                .Where(e => e.RCode == code)
                .Select(e => e)
                .ToList();
            List<resourceModel> list2 = new List<resourceModel>();
            foreach (resource item in list)
            {
                resourceModel e = new resourceModel()
                {
                    RCode = item.RCode,
                    oneCodeName = item.oneCodeName,
                    twoCodeName = item.twoCodeName,
                    threeCodeName = item.threeCodeName,
                    MKName = item.MKName,
                    CName = item.CName,
                    MWei = item.MWei,
                    RName = item.RName,
                    RSex = item.RSex,
                    REmail = item.REmail,
                    RPhone = item.RPhone,
                    RQQ = item.RQQ,
                    RCellphone = item.RCellphone,
                    RAddress = item.RAddress,
                    RPostcode = item.RPostcode,
                    RNationality = item.RNationality,
                    RBirthplace = item.RBirthplace,
                    RBirthday = item.RBirthday,
                    RNation = item.RNation,
                    RFaith = item.RFaith,
                    RPolitics = item.RPolitics,
                    RIDKA = item.RIDKA,
                    RSecurity = item.RSecurity,
                    RAge = item.RAge,
                    RBackground = item.RBackground,
                    RYears = item.RYears,
                    REducation = item.REducation,
                    RSalary = item.RSalary,
                    RBank = item.RBank,
                    RAccounts = item.RAccounts,
                    RRegistrant = item.RRegistrant,
                    RInputting = item.RInputting,
                    Rstrong = item.Rstrong,
                    RHobby = item.RHobby,
                    Rcurriculum = item.Rcurriculum,
                    RFamily = item.RFamily,
                    RRemark = item.RRemark,
                    RRCode = item.RRCode,
                    RRBasicCount = item.RRBasicCount,
                    RRShouldCount = item.RRShouldCount,
                    RRActualCount = item.RRActualCount,
                    RRTransfer = item.RRTransfer,
                    RRMotivateCount = item.RRMotivateCount,
                    RRTrainCount = item.RRTrainCount,
                    RRAlterationCount = item.RRAlterationCount,
                    RPhoto = item.RPhoto,
                    RAccessory = item.RAccessory,
                    RState = item.RState,
                    RRecombination = item.RRecombination,
                    RRecombinationDate = item.RRecombinationDate,
                    RAlteration = item.RAlteration,
                    RAlterationDate = item.RAlterationDate,
                    RChangeDate = item.RChangeDate,
                    RDelDate = item.RDelDate,
                    RReplyDate = item.RReplyDate,
                    RRState = item.RRState
                };
                list2.Add(e);
            }
            return list2;

        }
        //I级机构修改
        public int resourceUpd(resourceModel r)
        {
            resource first = new resource()
            {
                
                RCode = r.RCode,
                oneCodeName = r.oneCodeName,
                twoCodeName = r.twoCodeName,
                threeCodeName = r.threeCodeName,
                MKName = r.MKName,
                CName = r.CName,
                MWei = r.MWei,
                RName = r.RName,
                RSex = r.RSex,
                REmail = r.REmail,
                RPhone = r.RPhone,
                RQQ = r.RQQ,
                RCellphone = r.RCellphone,
                RAddress = r.RAddress,
                RPostcode = r.RPostcode,
                RNationality = r.RNationality,
                RBirthplace = r.RBirthplace,
                RBirthday = r.RBirthday,
                RNation = r.RNation,
                RFaith = r.RFaith,
                RPolitics = r.RPolitics,
                RIDKA = r.RIDKA,
                RSecurity = r.RSecurity,
                RAge = r.RAge,
                RBackground = r.RBackground,
                RYears = r.RYears,
                REducation = r.REducation,
                RSalary = r.RSalary,
                RBank = r.RBank,
                RAccounts = r.RAccounts,
                RRegistrant = r.RRegistrant,
                RInputting = r.RInputting,
                Rstrong = r.Rstrong,
                RHobby = r.RHobby,
                Rcurriculum = r.Rcurriculum,
                RFamily = r.RFamily,
                RRemark = r.RRemark,
                RRCode = r.RRCode,
                RRBasicCount = r.RRBasicCount,
                RRShouldCount = r.RRShouldCount,
                RRActualCount = r.RRActualCount,
                RRTransfer = r.RRTransfer,
                RRMotivateCount = r.RRMotivateCount,
                RRTrainCount = r.RRTrainCount,
                RRAlterationCount = r.RRAlterationCount,
                RPhoto = r.RPhoto,
                RAccessory = r.RAccessory,
                RState = r.RState,
                RRecombination = r.RRecombination,
                RRecombinationDate = r.RRecombinationDate,
                RAlteration = r.RAlteration,
                RAlterationDate = r.RAlterationDate,
                RChangeDate = r.RChangeDate,
                RDelDate = r.RDelDate,
                RReplyDate = r.RReplyDate,
                RRState = r.RRState
            };
            return Update(first);
        }
    }
}
