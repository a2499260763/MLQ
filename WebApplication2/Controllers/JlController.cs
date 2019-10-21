using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using Model;
using EF.Entity;
using DAO;
using Newtonsoft.Json;
using Ioc;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication2.Controllers
{
    public class JlController : Controller
    {
        IMajorReleaseBLL imr = IocCreate.CreateBLL<IMajorReleaseBLL>("MajorReleaseBLL");
        IMajorChenBLL imb = IocCreate.CreateBLL<IMajorChenBLL>("MajorChenBLL");
        IMajorKindBLL imk = IocCreate.CreateBLL<IMajorKindBLL>("MajorKindBLL");
        IJlBLL ijl = IocCreate.CreateBLL<IJlBLL>("JlBLL");
        public ActionResult JlRegisterIndex1()  //简历显示全部
        {
            return View();
        }

        public ActionResult JlFenYe(int currentPage, string where)
        {
            string sql = "proc_FenYe";
            SqlParameter[] ps =
            {
                new SqlParameter() {ParameterName="@pageSize",Value=3 },
                new SqlParameter() {ParameterName="@keyName",Value="Id" },
                new SqlParameter() {ParameterName="@tableName",Value="Jl" },
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

        // GET: Jl
        public ActionResult JlRegisterIndex(int Id = 0)  //简历登记
        {
            ViewBag.Id = 0;
            int cc = 0;
            int kk = 0;
            if (Id != 0)
            {
                foreach (MajorReleaseModel item in imr.MajorReleaseWhere(Id))
                {
                    cc = item.MCID;
                    kk = item.MKID;
                }
                string sqlc = "select CName from dbo.MajorChen where Id = " + cc;
                DataTable dtc = DBHelper.GetTable(sqlc);
                string sqlk = "select MKName from dbo.MajorKind where Id= " + kk;
                DataTable dtk = DBHelper.GetTable(sqlk);
                string KName = null;
                string CName = null;
                foreach (DataRow itemc in dtc.Rows)
                {
                    CName = itemc["CName"].ToString();
                    foreach (DataRow itemk in dtk.Rows)
                    {
                        KName = itemk["MKName"].ToString();
                    }
                }
                ViewBag.cc = CName;
                ViewBag.kk = KName;
                ViewBag.Id = Id;
            }
            return View();
        }

        public ActionResult JlRegisterIndex2()   //
        {
            return Content(JsonConvert.SerializeObject(imk.SelectMajorKind()));
        }

        public ActionResult JlRegisterIndex3(string MKName)
        {
            string sql = $"select * from dbo.Major where MKName='{MKName}'";
            return Content(JsonConvert.SerializeObject(DBHelper.GetTable(sql)));
        }


        public ActionResult JlRegisterInsertIndex(string MKName, string MCName, string ZPName, string JlName, string JlSex, string JlEmail, string JlDianHua, string JlJiaTingDianHua, string JlShouJi, string JlAdds, string JlYouBian, string JlGuoJi, string JlBreathAdds, string JlBreathDay, string JlMingZu, string JlZongJioaXingYang, string JlZhengZhiMianMao, string JlEntityCond, int JlAge, string JlBiYanShooln, string JlXueli, string JlJiaoYvYean, string JlXueLiZhuanYe, double JlXingZiYaoQiu, DateTime JlZcTime, string JlTeChang, string JlAiHoa, string JlGeRenLvLi, string JlBeiZhu)
        {
            JlMondel jlm = new JlMondel()
            {
                JlAdds = JlAdds,
                JlAge = JlAge,
                JlAiHoa = JlAiHoa,
                JlBeiZhu = JlBeiZhu,
                JlBiYanShooln = JlBiYanShooln,
                JlBreathAdds = JlBreathAdds,
                JlBreathDay = JlBreathDay,
                JlDianHua = JlDianHua,
                JlEmail = JlEmail,
                JlEntityCond = JlEntityCond,
                JlGeRenLvLi = JlGeRenLvLi,
                JlGuoJi = JlGuoJi,
                JlJiaoYvYean = JlJiaoYvYean,
                JlJiaTingDianHua = JlJiaTingDianHua,
                JlMingZu = JlMingZu,
                JlName = JlName,
                JlSex = JlSex,
                JlShouJi = JlShouJi,
                JlTeChang = JlTeChang,
                JlXingZiYaoQiu = JlXingZiYaoQiu,
                JlXueli = JlXueli,
                JlXueLiZhuanYe = JlXueLiZhuanYe,
                JlYouBian = JlYouBian,
                JlZcTime = JlZcTime,
                JlZhengZhiMianMao = JlZhengZhiMianMao,
                JlZongJioaXingYang = JlZongJioaXingYang,
                MCName = MCName,
                MKName = MKName,
                ZPName = ZPName
            };
            return Content(JsonConvert.SerializeObject(ijl.InsertJl(jlm)));
        }

        public ActionResult JlShaiXueIndex()
        {
            return View();
        }

        public ActionResult JlShaiXueIndexShow(JlMondel jl,string GuanJianZi)    //显示筛选简历
        {
            
            Session["MCName"] = jl.MCName;
            Session["MKName"] = jl.MKName;
            Session["GuanJianZi"] = GuanJianZi;
            Session["JlZcTime"] = jl.JlZcTime;
            Session["JlZcOverTime"] = jl.JlZcOverTime;

            string sql = $@"SELECT TOP 1000 [Id]
      ,[MCName]
      ,[MKName]
      ,[JlName]
      ,[JlDianHua]
      ,[JlEntityCond]
      ,[JlZcTime]
  FROM[T6].[dbo].[Jl] where MCName = '{jl.MCName.Replace(" ", "")}' and MKName = '{jl.MKName}'
 and JlName like '%{GuanJianZi}%' and JlDianHua like '%{GuanJianZi}%' and JlEntityCond like '%{GuanJianZi}%' and JlGeRenLvLi like '%{GuanJianZi}%'
  and JlZcOverTime > '{jl.JlZcTime}' and JlZcTime < '{jl.JlZcOverTime}'";
            DataTable dd = DBHelper.GetTable(sql);
            return View(dd);
        }

        public ActionResult JlShaiXueIndexUpdate(int Id)    //筛选简历
        {
            JlMondel jl = null;
            foreach (JlMondel item in ijl.JlWhere(Id))
            {
                jl = new JlMondel()
                {
                    Id = item.Id,
                    JlAdds = item.JlAdds,
                    JlAge = item.JlAge,
                    JlAiHoa = item.JlAiHoa,
                    JlBeiZhu = item.JlBeiZhu,
                    JlBiYanShooln = item.JlBiYanShooln,
                    JlBreathAdds = item.JlBreathAdds,
                    JlBreathDay = item.JlBreathDay,
                    JlDianHua = item.JlDianHua,
                    JlEmail = item.JlEmail,
                    JlEntityCond = item.JlEntityCond,
                    JlGeRenLvLi = item.JlGeRenLvLi,
                    JlGuoJi = item.JlGuoJi,
                    JlJiaoYvYean = item.JlJiaoYvYean,
                    JlJiaTingDianHua = item.JlJiaTingDianHua,
                    JlMingZu = item.JlMingZu,
                    JlName = item.JlName,
                    JlSex = item.JlSex,
                    JlShouJi = item.JlShouJi,
                    JlTeChang = item.JlTeChang,
                    JlXingZiYaoQiu = item.JlXingZiYaoQiu,
                    JlXueli = item.JlXueli,
                    JlXueLiZhuanYe = item.JlXueLiZhuanYe,
                    JlYouBian = item.JlYouBian,
                    JlZcTime = item.JlZcTime,
                    JlZcOverTime = item.JlZcTime.AddDays(3),
                    JlZhengZhiMianMao = item.JlZhengZhiMianMao,
                    JlZongJioaXingYang = item.JlZongJioaXingYang,
                    MCName = item.MCName,
                    MKName = item.MKName,
                    ZPName = item.ZPName,
                    JlYesNo = item.JlYesNo
                };
            }
            return View(jl);
        }

        public ActionResult JlShaiXueIndexUpdate1(string sxyj,int Id,string JlTuiJianRen,string JlTuiJianTime)    //筛选简历
        {
            int JlYesNo = 0;
           
            if (sxyj == "无效")
            {
                JlYesNo = 1;
            }
            string sql = $@"UPDATE [T6].[dbo].[Jl]
   SET
      [JlTuiJianRen] = '{JlTuiJianRen}'
      ,[JlTuiJianTime] = '{JlTuiJianTime}'
      ,[JlYesNo] = {JlYesNo}
 WHERE Id = {Id}";
            return Content(JsonConvert.SerializeObject(DBHelper.InsertUpdateDelete(sql)));
        }

        public ActionResult JlYouXiuIndex()
        {
            return View();
        }

        public ActionResult JlYouXiuIndexShow(JlMondel jl, string GuanJianZi)    //显示有效简历
        {
            string sql = $@"SELECT TOP 1000 [Id]
      ,[MCName]
      ,[MKName]
      ,[JlName]
      ,[JlDianHua]
      ,[JlEntityCond]
      ,[JlZcTime]
  FROM[T6].[dbo].[Jl] where MCName = '{jl.MCName}' and MKName = '{jl.MKName}'
 and JlName like '%{GuanJianZi}%' and JlDianHua like '%{GuanJianZi}%' and JlEntityCond like '%{GuanJianZi}%' and JlGeRenLvLi like '%{GuanJianZi}%'
  and JlZcOverTime > '{jl.JlZcTime}' and JlZcTime < '{jl.JlZcOverTime}' and JlYesNo = {0}";
            return View(DBHelper.GetTable(sql));
        }

      
    }
}