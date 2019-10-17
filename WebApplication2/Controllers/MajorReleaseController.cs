using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ioc;
using IDAO;
using IBLL;
using DAO;
using Model;
using EF.Entity;
using System.Data;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace WebApplication2.Controllers
{
    public class MajorReleaseController : Controller
    {
 
        IMajorChenBLL imc = IocCreate.CreateBLL<IMajorChenBLL>("MajorChenBLL");
        IMajorKindBLL imk = IocCreate.CreateBLL<IMajorKindBLL>("MajorKindBLL");
        IoneorganizationBLL io = IocCreate.CreateBLL<IoneorganizationBLL>("oneorganizationBLL");
        ItwoorganizationBLL it = IocCreate.CreateBLL<ItwoorganizationBLL>("twoorganizationBLL");
        IthreeorganizationBLL ith = IocCreate.CreateBLL<IthreeorganizationBLL>("threeorganizationBLL");
        IMajorReleaseBLL imr = IocCreate.CreateBLL<IMajorReleaseBLL>("MajorReleaseBLL");
        IEngageTypeDAO ie = IocCreate.CreateDao<IEngageTypeDAO, EngageTypeDAO>();
        // GET: Client
        public ActionResult MajorReleaseAddIndex()
        {
            SelectList listImc = new SelectList(imc.SelectMajorChen(), "Id", "CName");
            SelectList listImk = new SelectList(imk.SelectMajorKind(),"Id", "MKName");
            SelectList listOne = new SelectList(io.oneorganizationSelect(), "oneID", "oneCodeName");
            SelectList listTwo = new SelectList(it.twoorganizationSelect(), "twoID", "twoCodeName");
            SelectList listThree = new SelectList(ith.threeorganizationSelect(), "threeID", "threeCodeName");
            SelectList listType = new SelectList(ie.SelectEngageType(), "TName", "TName");

            ViewBag.cc = listImc;
            ViewBag.kk = listImk;
            ViewBag.one = listOne;
            ViewBag.two = listTwo;
            ViewBag.three = listThree;
            ViewBag.type = listType;

            return View();
        }

        public ActionResult MajorReleaseInsertIndex(int oneID,int twoID,int threeID,string MrType,int MKID,int MCID,int MrAmount,DateTime MrOverTime,string MrRegister,DateTime MrRegistTime,string MrDescribe,string MrRequired)
        {
            MajorReleaseModel mrm = new MajorReleaseModel()
            {
                MCID = MCID,
                MKID = MKID,
                MrAmount = MrAmount,
                MrDescribe = MrDescribe,
                MrOverTime = MrOverTime,
                MrRegister = MrRegister,
                MrRegistTime = MrRegistTime,
                MrRequired = MrRequired,
                MrType = MrType,
                oneID = oneID,
                twoID = twoID,
                threeID = threeID,
                MrChangeTime=DateTime.Now
            };
            return Content(JsonConvert.SerializeObject(imr.AddMajorRelease(mrm)));
        }



        public ActionResult MajorReleaseUpdateIndex()
        {
            return View();
        }

       

         public ActionResult MajorRelesaseFenYe(int currentPage,string where)
        {
            string sql = "proc_FenYe";
            SqlParameter[] ps =
            {
                new SqlParameter() {ParameterName="@pageSize",Value=3 },
                new SqlParameter() {ParameterName="@keyName",Value="Id" },
                new SqlParameter() {ParameterName="@tableName",Value="View_MajorRelease" },
                new SqlParameter() {ParameterName="@currentPage",Value=currentPage },
                new SqlParameter() {ParameterName="@pages",Direction=ParameterDirection.Output,SqlDbType=SqlDbType.Int },
                new SqlParameter() {ParameterName="@where",Value=where },
                new SqlParameter() {ParameterName="@rows",Direction=ParameterDirection.Output,SqlDbType=SqlDbType.Int }
            };
            Dictionary<string, object> dc = new Dictionary<string, object>();
            DataTable dt = DBHelper.GetFenYe(sql, ps);
            dc["dt"] = dt;
            dc["Pages"] = ps[4].Value;
            dc["rows"] = ps[6].Value;
            return Content(JsonConvert.SerializeObject(dc));
        }

           public ActionResult MajorRelesaseUpdate(int Id)
        {
           
            string sql = "select * from View_MajorRelease where Id=" + Id;
            return View(DBHelper.GetTable(sql));
        }

        [HttpPost]
        public ActionResult MajorReleaseUpdate2(int Id,int oneID, int twoID, int threeID, string MrType, int MKID, int MCID, int MrAmount, DateTime MrOverTime, string MrChanger, DateTime MrChangeTime, string MrDescribe, string MrRequired,DateTime MrRegistTime,string MrRegister)
        {
            MajorReleaseModel mrm = new MajorReleaseModel()
            {
                Id=Id,
                MCID = MCID,
                MKID = MKID,
                MrAmount = MrAmount,
                MrDescribe = MrDescribe,
                MrOverTime = MrOverTime,
                MrChanger= MrChanger,
                MrRequired = MrRequired,
                MrType = MrType,
                oneID = oneID,
                twoID = twoID,
                threeID = threeID,
                MrChangeTime = MrChangeTime,
                MrRegister=MrRegister,
                MrRegistTime=MrRegistTime
            };
            return Content(JsonConvert.SerializeObject(imr.UpdateMajorRelease(mrm)));
        }

             public ActionResult MajorReleaseDeleIndex(int Id)
        {
            MajorReleaseModel mrm = new MajorReleaseModel()
            {
                 Id=Id
            };
            return Content(JsonConvert.SerializeObject(imr.DeleMajorRelease(mrm)));
        }

        public ActionResult MajorReleaseFbIndex()
        {
           
            return View();
        }
    }
}