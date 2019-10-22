using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IBLL;
using BLL;
using Ioc;
using Model;
using System.IO;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Text;
using System.Security.Cryptography;
using System.Web.Mvc;
using System.Data;
using DAO;

namespace WebApplication1.Controllers
{
    public class resourceController : Controller
    {
        IresourceBLL ires = IocCreate.CreateBLL<IresourceBLL>("resourceBLL");
        IthreeorganizationBLL ithree = IocCreate.CreateBLL<IthreeorganizationBLL>("threeorganizationBLL");
        IoneorganizationBLL ione = IocCreate.CreateBLL<IoneorganizationBLL>("oneorganizationBLL");
        ItwoorganizationBLL itwo = IocCreate.CreateBLL<ItwoorganizationBLL>("twoorganizationBLL");
        IMajorKindBLL ikind = IocCreate.CreateBLL<IMajorKindBLL>("MajorKindBLL");
        IMajorWeiBLL iwei = IocCreate.CreateBLL<IMajorWeiBLL>("MajorWeiBLL");
        IMajorChenBLL ichen = IocCreate.CreateBLL<IMajorChenBLL>("MajorChenBLL");
        ISalaryBiaoZhunBLL ixcbz = IocCreate.CreateBLL<ISalaryBiaoZhunBLL>("SalaryBiaoZhunBLL");
        // GET: resource
        public ActionResult SelectMianshi()
        {
            return View("SelectMianshi");
        }

        public ActionResult Insertresource(string RCode)
        {
            //string bian = DateTime.Now.ToString("yyMMddmmss") + new Random().Next(100, 999);
            //ViewData["s"] = bian;
            resourceModel res = ires.resourceSelectWhere(RCode)[0];
            return View("Insertresource",res);
        }
        public ActionResult Selectxcbz()
        {
            
            List<SalaryBiaoZhunModel>list = ixcbz.SelectSalaryBiaoZhun();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult Selectone()
        {
            List<oneorganizationModel> one = ione.oneorganizationSelect();
            return Content(JsonConvert.SerializeObject(one));
        }
        public ActionResult Selecttwo(string id)
        {

            List<twoorganizationModel> two = itwo.twoorganizationSelectWhereName(id);
            return Content(JsonConvert.SerializeObject(two));
        }
        public ActionResult Selectthree(string id)
        {

            List<threeorganizationModel> three = ithree.threeorganizationWhere(id);
            return Content(JsonConvert.SerializeObject(three));
        }
        public ActionResult InsertWhereresource(resourceModel res)
        {
            if (ires.resourceUpd(res) > 0)
            {
                string code = res.RCode;
                Response.Write("<script>alert('登记成功')</script>");
                TempData["code"] = code;
                return Updateesource();
            }else
            {
                Response.Write("<script>alert('添加失败')</script>");
                return View();
            }
        }
        public ActionResult Updateesource()
        {
            return View("Updateesource");
        }
        public ActionResult AddImage(HttpPostedFileBase file)
        {
            resourceModel res = ires.resourceSelectWhere((string)TempData["code"])[0];
            try
            {
                byte[] bts = MD5.Create().ComputeHash(file.InputStream);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bts)
                {
                    sb.Append(b.ToString("X2"));
                }
                string name = sb.ToString();
                string ext = Path.GetExtension(file.FileName);
                string path = Server.MapPath("~/Image/" + DateTime.Now.ToString("yyyy/MM/dd")) + "/" + name + ext;
                new FileInfo(path).Directory.Create();
                file.SaveAs(path);

                res.RPhoto = path;
            }
            catch (Exception)
            {
                return Content("0");
            }

            
            if (ires.resourceUpd(res) > 0)
            {
                return Content("1");
            }
            else
            {
                return Content("0");
            }

        }
        public ActionResult SelectMajorKind()
        {
            List<MajorKindModel> k = ikind.SelectMajorKind();
            return Content(JsonConvert.SerializeObject(k));
        }
        public ActionResult SelectWhereMajor(string id)
        {
            string sql = string.Format("select CName  from dbo.View_Major_Kind_Chen where MKName='{0}'",id);
            DataTable dt = DBHelper.GetTable(sql);
            return Content(JsonConvert.SerializeObject(dt));
        }
        public ActionResult SelectMajorwei()
        {
            List<MajorWeiModel> wei = iwei.MajorWeiSelect();
            return Content(JsonConvert.SerializeObject(wei));
        }
        public ActionResult Selectresource()
        {
            return View("Selectresource");
        }
        public ActionResult FenYeresource(string dj,int RRState, string RState,int currentPage, int PageSize)
        {
            
                int rows = 0;
            
                List<resourceModel> list = ires.resourceFenYe(RRState, RState, currentPage, PageSize, out rows);
                Dictionary<string, object> dic = new Dictionary<string, object>()
                {
                    {"list",list }, {"rows",rows }
                };
                return Content(JsonConvert.SerializeObject(dic));
            
        }
        public ActionResult GetRow()
        {
            int rows = 0;
            ires.resourceFenYe(0,"未复核", 1, 1, out rows);
            return Content(rows + "");
        }
        public ActionResult UpdateresourceState(string RCode)
        {
            TempData["photo"] = RCode;
            List<resourceModel> list = ires.resourceSelectWhere(RCode);
            resourceModel res = null;
            foreach (resourceModel item in list)
            {
                res = new resourceModel()
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
            }
            return View("UpdateresourceState", res);
        }
        public ActionResult UpdateSelectWhere(resourceModel res)
        {
            if (ires.resourceUpd(res) > 0)
            {
                Response.Write("<script>alert('修改成功')</script>");
                return View("UpdatePhoto");
            }else
            {
                Response.Write("<script>alert('修改失败')</script>");
                return View();
            }
        }
        public ActionResult UpdatePhoto()
        {
            return View("UpdatePhoto");
        }
        public ActionResult UpdateImage(HttpPostedFileBase file)
        {
            resourceModel res = ires.resourceSelectWhere((string)TempData["photo"])[0];
            try
            {
                byte[] bts = MD5.Create().ComputeHash(file.InputStream);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bts)
                {
                    sb.Append(b.ToString("X2"));
                }
                string name = sb.ToString();
                string ext = Path.GetExtension(file.FileName);
                string path = Server.MapPath("~/Image/" + DateTime.Now.ToString("yyyy/MM/dd")) + "/" + name + ext;
                new FileInfo(path).Directory.Create();
                file.SaveAs(path);

                res.RPhoto = path;
            }
            catch (Exception)
            {
                return Content("0");
            }


            if (ires.resourceUpd(res) > 0)
            {
                return Content("1");
            }
            else
            {
                return Content("0");
            }

        }
        public ActionResult SelectWhereresource()
        {
            return View("SelectWhereresource");
        }
        public ActionResult SelectWhereONE()
        {
            List<oneorganizationModel> one = ione.oneorganizationSelect();
            return Content(JsonConvert.SerializeObject(one));
        }
        public ActionResult SelectWhereTWO(string oneCodeName)
        {
            if (oneCodeName == "0")
            {
                List<twoorganizationModel> two = itwo.twoorganizationSelect();
                return Content(JsonConvert.SerializeObject(two));
            }
            else
            {
                List<twoorganizationModel> two = itwo.twoorganizationSelectWhereName(oneCodeName);
                return Content(JsonConvert.SerializeObject(two));
            }
            
        }
        public ActionResult SelectWhereTHREE(string twoCodeName)
        {
            if (twoCodeName == "0")
            {
                List<threeorganizationModel> three = ithree.threeorganizationSelect();
                return Content(JsonConvert.SerializeObject(three));
            }
            else
            {
                List<threeorganizationModel> three = ithree.threeorganizationWhere(twoCodeName);
                return Content(JsonConvert.SerializeObject(three));
            }
        }
        public ActionResult SelectWhereWEIFEN()
        {
            List<MajorKindModel> weifen = ikind.SelectMajorKind();
            return Content(JsonConvert.SerializeObject(weifen));
        }
        public ActionResult SelectWhereWEINAME(string MKName)
        {
            if (MKName == "0")
            {
                List<MajorChenModel> chen = ichen.SelectMajorChen();
                //string sql = string.Format("select CName  from dbo.View_Major_Kind_Chen ");
                //DataTable dt = DBHelper.GetTable(sql);
                return Content(JsonConvert.SerializeObject(chen));
            }
            else
            {
                string sql = string.Format("select CName  from dbo.View_Major_Kind_Chen where MKName='{0}'", MKName);
                DataTable dt = DBHelper.GetTable(sql);
                return Content(JsonConvert.SerializeObject(dt));
            }
            
        }
        [HttpPost]
        public ActionResult SelectWhereDateTwo(resourceModel res)
        {
            Session["res"] = res;
            return SelectWhereDate();
        }
        public ActionResult SelectWhereDate()
        {
           
            return View("SelectWhereDate");
        }
        public ActionResult SelectWhereFenYe(int currentPage, int PageSize)
        {
            int rows = 0;
            resourceModel res = (resourceModel)Session["res"];
            res.RRState = 0;
            res.RState = "已复核";
            List<resourceModel> list = ires.resourceWhereFenYe(res, currentPage, PageSize, out rows);
            Dictionary<string, object> dic = new Dictionary<string, object>()
            {
                {"list",list }, {"rows",rows }
            };
            return Content(JsonConvert.SerializeObject(dic));

        }
        
        public ActionResult Selectres(string code)
        {
            TempData["code"] = code;
            resourceModel res = ires.resourceSelectWhere(code)[0];

            return View(res);
        }


        //人力资源档案变更
        public ActionResult SelectWhereBianGen()
        {
            return View("SelectWhereBianGen");
        }
        public ActionResult SelectWhereBianGenFen(resourceModel res)
        {
            Session["resour"] = res;
            return SelectWhereBianGenFenYe();
        }
        public ActionResult SelectWhereBianGenFenYe()
        {
            return View("SelectWhereBianGenFenYe");
        }
        public ActionResult SelectWhereBianGenFenYetwo(int currentPage, int PageSize)
        {
            int rows = 0;
            resourceModel res = (resourceModel)Session["resour"];
            res.RRState = 0;
            res.RState = "已复核";
            List<resourceModel> list = ires.resourceWhereFenYe(res, currentPage, PageSize, out rows);
            Dictionary<string, object> dic = new Dictionary<string, object>()
            {
                {"list",list }, {"rows",rows }
            };
            return Content(JsonConvert.SerializeObject(dic));

        }
        
        public ActionResult Selectresour(string code)
        {
            TempData["code1"] = code;
            resourceModel res = ires.resourceSelectWhere(code)[0];
            res.RAlterationDate = DateTime.Now.ToString();

            return View(res);
        }
        public ActionResult Updateresourse(resourceModel res)
        {
            if (ires.resourceUpd(res) > 0)
            {
                Response.Write("<script>alert('变更成功')</script>");
                TempData["resCode"] = res.RCode;
                return UpdateSelectPhoto();
            }
            else
            {
                Response.Write("<script>alert('变更失败')</script>");
                return View();
            }
        }
        public ActionResult UpdateSelectPhoto()
        {
            return View("UpdateSelectPhoto");
        }
        public ActionResult AddImages(HttpPostedFileBase file)
        {
            resourceModel res = ires.resourceSelectWhere((string)TempData["resCode"])[0];
            try
            {
                byte[] bts = MD5.Create().ComputeHash(file.InputStream);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bts)
                {
                    sb.Append(b.ToString("X2"));
                }
                string name = sb.ToString();
                string ext = Path.GetExtension(file.FileName);
                string path = Server.MapPath("~/Image/" + DateTime.Now.ToString("yyyy/MM/dd")) + "/" + name + ext;
                new FileInfo(path).Directory.Create();
                file.SaveAs(path);

                res.RPhoto = path;
            }
            catch (Exception)
            {
                return Content("0");
            }


            if (ires.resourceUpd(res) > 0)
            {
                return Content("1");
            }
            else
            {
                return Content("0");
            }

        }
        //人力资源档案删除
        public ActionResult SelectresDel()
        {
            return View("SelectresDel");
        }
        public ActionResult SelectDelFen(resourceModel res)
        {
            Session["restwo"] = res;
            return View("SelectDelFen");
        }
        public ActionResult SelectDelFenYe(int currentPage, int PageSize)
        {
            int rows = 0;
            resourceModel res = (resourceModel)Session["restwo"];
            res.RRState = 0;
            res.RState = "已复核";
            List<resourceModel> list = ires.resourceWhereFenYe(res, currentPage, PageSize, out rows);
            Dictionary<string, object> dic = new Dictionary<string, object>()
            {
                {"list",list }, {"rows",rows }
            };
            return Content(JsonConvert.SerializeObject(dic));
        }
        
        public ActionResult SelectDeltwo(string code)
        {
            resourceModel res = ires.resourceSelectWhere(code)[0];
            return View("SelectDeltwo", res);
        }
        public ActionResult SelectDeltwos(resourceModel res)
        {
            string Rcode = res.RCode;
            resourceModel ress = ires.resourceSelectWhere(Rcode)[0];
            ress.RRState = 1;//1假删除
            if (ires.resourceUpd(ress) > 0)
            {
                Response.Write("<script>alert('删除成功')</script>");
                return SelectresDel();
            }
            else
            {
                Response.Write("<script>alert('删除失败')</script>");
                return View();
            }
        }
        //档案删除恢复
        public ActionResult SelectDelWhereone()
        {
            return View("SelectDelWhereone");
        }
        public ActionResult SelectDelWhereOnes(resourceModel res)
        {
            Session["resDelone"] = res;
            return View("SelectDelWhereOnes");
        }
        public ActionResult SelectDelWhereOnesFenYe(int currentPage, int PageSize)
        {
            int rows = 0;
            resourceModel res = (resourceModel)Session["resDelone"];
            res.RRState = 1;
            res.RState = "已复核";
            List<resourceModel> list = ires.resourceWhereFenYe(res, currentPage, PageSize, out rows);
            Dictionary<string, object> dic = new Dictionary<string, object>()
            {
                {"list",list }, {"rows",rows }
            };
            return Content(JsonConvert.SerializeObject(dic));
        }
        public ActionResult SelectDelWhereOnesRes(string code)
        {
            resourceModel res = ires.resourceSelectWhere(code)[0];
            return View("SelectDelWhereOnesRes", res);
        }
        public ActionResult SelectDelWhereOneUpd(resourceModel res)
        {
            string Rcode = res.RCode;
            resourceModel ress = ires.resourceSelectWhere(Rcode)[0];
            ress.RRState = 0;//0恢复
            if (ires.resourceUpd(ress) > 0)
            {
                Response.Write("<script>alert('恢复成功')</script>");
                return SelectDelWhereone();
            }else
            {
                Response.Write("<script>alert('恢复失败')</script>");
                return View();
            }
        }
        //永久删除
        
        public ActionResult SelectDelWhereTwos()
        {
            
            return View("SelectDelWhereTwos");
        }
        public ActionResult SelectDelWhereTwosFenYe(int currentPage, int PageSize)
        {
            int rows = 0;
            resourceModel res = new resourceModel();
            res.RRState = 1;
            res.RState = "已复核";
            List<resourceModel> list = ires.resourceWhereFenYe(res, currentPage, PageSize, out rows);
            Dictionary<string, object> dic = new Dictionary<string, object>()
            {
                {"list",list }, {"rows",rows }
            };
            return Content(JsonConvert.SerializeObject(dic));
        }
        public ActionResult SelectDelWhereTwosRes(string code)
        {
            resourceModel res = new resourceModel();
            res.RCode = code;
            if (ires.resourceDel(res) > 0)
            {

                Response.Write("<script>alert('永久删除成功')</script>");
                return SelectDelWhereTwos();
            }
            else
            {
                Response.Write("<script>alert('永久删除失败')</script>");
                return View();

            }
        }
    }
}