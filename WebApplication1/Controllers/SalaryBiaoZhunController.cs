using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using DAO;
using Ioc;
using IBLL;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Controllers
{
    public class SalaryBiaoZhunController : Controller
    {

        ISalaryBLL isb = IocCreate.CreateBLL<ISalaryBLL>("SalaryBLL");
        ISalaryBiaoZhunBLL isbz = IocCreate.CreateBLL<ISalaryBiaoZhunBLL>("SalaryBiaoZhunBLL");

        // GET: SalaryBiaoZhun
        public ActionResult SalaryBiaoZhunDengJiIndex()
        {
            //将XML文件加载进来
            XDocument document = XDocument.Load("C:/Users/MZF/Source/Repos/MLQ/WebApplication1/SBZBianHao.xml");
            //获取到XML的根元素进行操作
            XElement root = document.Root;
            XElement ele = root.Element("BOOK");
            //获取name标签的值
            XElement shuxing = ele.Element("name");
            int id = int.Parse(shuxing.Value);
            //获取根元素下的所有子元素


            XDocument document1 = new XDocument();
            XElement root1 = new XElement("School");
            XElement book = new XElement("BOOK");
            book.SetElementValue("name", id + 1);
            root1.Add(book);
            root1.Save("C:/Users/MZF/Source/Repos/MLQ/WebApplication1/SBZBianHao.xml");

            ViewBag.SalaryID = "SBZ00" + id;
            return View(isb.SalarySelect());
        }

        public ActionResult InsertSalaryBiaoZhun(string SBZBianHao, string SBZName, double SBZZongE, string SBZZhiDingRen, string SBZDengJiRen, string SBZDengJiTime, string SBZBeiZhu, string SalaryChuCai, int SalaryChuCaiID, string SalaryJiaoTong, int SalaryJiaoTongId, double SBZChuCaiJinE, double SBZJiaoTongJinE)
        {
            SalaryBiaoZhunModel sbzm = new SalaryBiaoZhunModel()
            {
                SalaryChuCai = SalaryChuCai,
                SalaryChuCaiID = SalaryChuCaiID,
                SalaryJiaoTong = SalaryJiaoTong,
                SalaryJiaoTongID = SalaryJiaoTongId,
                SBZChuCaiJinE = SBZChuCaiJinE,
                SBZJiaoTongJinE = SBZJiaoTongJinE,
                SBZBeiZhu = SBZBeiZhu,
                SBZBianHao = SBZBianHao,
                SBZDengJiRen = SBZDengJiRen,
                SBZDengJiTime = SBZDengJiTime,
                SBZName = SBZName,
                SBZZhiDingRen = SBZZhiDingRen,
                SBZZongE = SBZZongE
            };
            return Content(JsonConvert.SerializeObject(isbz.InsertSalaryBiaoZhun(sbzm)));
        }


        public ActionResult InsertSalaryBiaoZhunFuHeShow()
        {
            int row;
            List<SalaryBiaoZhunModel> list = isbz.SalaryBiaoZhunFenYe(1, 3, out row);
            ViewBag.row = row;
            return View(list);
        }

        public ActionResult InsertSalaryBiaoZhunFuHe(int Id)
        {

            SalaryBiaoZhunModel list = isbz.SalaryBiaoZhunWhere(Id);

            return View(list);
        }

        public ActionResult InsertSalaryBiaoZhunFuHeUpdate(int Id, string SBZBianHao, string SBZName, double SBZZongE, string SBZZhiDingRen, string SBZFuHeRen, string SBZFuHeTime, string SBZFuHeYiJian, string SalaryChuCai, int SalaryChuCaiID, string SalaryJiaoTong, int SalaryJiaoTongID, double SBZChuCaiJinE, double SBZJiaoTongJinE)
        {
            SalaryBiaoZhunModel list = isbz.SalaryBiaoZhunWhere(Id);
            SalaryBiaoZhunModel sbzm = new SalaryBiaoZhunModel()
            {
                SalaryChuCai = SalaryChuCai,
                SalaryChuCaiID = SalaryChuCaiID,
                SalaryJiaoTong = SalaryJiaoTong,
                SalaryJiaoTongID = SalaryJiaoTongID,
                SBZChuCaiJinE = SBZChuCaiJinE,
                SBZJiaoTongJinE = SBZJiaoTongJinE,
                SBZBeiZhu = list.SBZBeiZhu,
                SBZBianHao = list.SBZBianHao,
                SBZDengJiRen = list.SBZDengJiRen,
                SBZDengJiTime = list.SBZDengJiTime,
                SBZName = SBZName,
                SBZZhiDingRen = SBZZhiDingRen,
                SBZZongE = SBZZongE,
                Id = Id,
                SBZFuHeRen = SBZFuHeRen,
                SBZFuHeTime = SBZFuHeTime,
                SBZFuHeYiJian = SBZFuHeYiJian,
                SBZBianGengRen = " ",
                SBZBianGenTime = " "
            };
            return Content(JsonConvert.SerializeObject(isbz.UpdaeSalaryBiaoZhun(sbzm)));
        }

        public ActionResult SalaryBiaoZhunCxShow()
        {
            return View();
        }

        public ActionResult SalaryBiaoZhunCx(string SBZBianHao, string GuanJianZi, string SBZDengJiTime1, string SBZDengJiTime2)
        {
            string sql = $@"select * from dbo.SalaryBiaoZhun where SBZBianHao like '%{SBZBianHao}%'
and SBZName like '%{GuanJianZi}%' and SBZZhiDingRen like '%{GuanJianZi}%' and  SBZFuHeRen like '%{GuanJianZi}%'
and CONVERT(datetime,SBZDengJiTime) >= '{SBZDengJiTime1}' and CONVERT(datetime,SBZDengJiTime) < '{SBZDengJiTime2}'";
            return View(DBHelper.GetTable(sql));
        }

        public ActionResult SalaryBiaoZhunCxSBZBianHao(string SBZBianHao) //编号查询页面
        {
            string sql = $@"select * from dbo.SalaryBiaoZhun where SBZBianHao like '%{SBZBianHao}%'";
            return View(DBHelper.GetTable(sql));
        }

        public ActionResult SalaryBiaoZhunCxUpdateShow()
        {
            return View();
        }


        public ActionResult SalaryBiaoZhunCxUpdate(string SBZBianHao, string GuanJianZi, string SBZDengJiTime1, string SBZDengJiTime2)
        {
            Session["SBZBianHao"] = SBZBianHao.Replace(" ", "");
            Session["GuanJianZi"] = GuanJianZi.Replace(" ", "");
            Session["SBZDengJiTime1"] = SBZDengJiTime1.Replace(" ", "");
            Session["SBZDengJiTime2"] = SBZDengJiTime2.Replace(" ", "");

            string sql = $@"select * from dbo.SalaryBiaoZhun where SBZBianHao like '%{SBZBianHao}%'
and SBZName like '%{GuanJianZi}%' and SBZZhiDingRen like '%{GuanJianZi}%' and  SBZFuHeRen like '%{GuanJianZi}%'
and CONVERT(datetime,SBZDengJiTime) >= '{SBZDengJiTime1}' and CONVERT(datetime,SBZDengJiTime) < '{SBZDengJiTime2}'";
            return View(DBHelper.GetTable(sql));
        }

        public ActionResult UpdateSalaryBiaoZhun(int Id)
        {

            SalaryBiaoZhunModel list = isbz.SalaryBiaoZhunWhere(Id);

            return View(list);
        }

        public ActionResult SalaryBiaoZhunFuHeUpdate(int Id, string SBZBianHao, string SBZName, double SBZZongE, string SBZZhiDingRen, string SBZBianGengRen, string SBZBianGenTime, string SBZBeiZhu, string SalaryChuCai, int SalaryChuCaiID, string SalaryJiaoTong, int SalaryJiaoTongID, double SBZChuCaiJinE, double SBZJiaoTongJinE)
        {

            SalaryBiaoZhunModel list = isbz.SalaryBiaoZhunWhere(Id);
            SalaryBiaoZhunModel sbzm = new SalaryBiaoZhunModel()
            {
                SalaryChuCai = SalaryChuCai,
                SalaryChuCaiID = SalaryChuCaiID,
                SalaryJiaoTong = SalaryJiaoTong,
                SalaryJiaoTongID = SalaryJiaoTongID,
                SBZChuCaiJinE = SBZChuCaiJinE,
                SBZJiaoTongJinE = SBZJiaoTongJinE,
                SBZBeiZhu = list.SBZBeiZhu,
                SBZBianHao = list.SBZBianHao,
                SBZDengJiRen = list.SBZDengJiRen,
                SBZDengJiTime = list.SBZDengJiTime,
                SBZName = SBZName,
                SBZZhiDingRen = SBZZhiDingRen,
                SBZZongE = SBZZongE,
                Id = Id,
                SBZFuHeRen = list.SBZFuHeRen,
                SBZFuHeTime = list.SBZFuHeTime,
                SBZFuHeYiJian = list.SBZFuHeYiJian,
                SBZBianGengRen = " ",
                SBZBianGenTime = SBZBianGenTime
            };
            return Content(JsonConvert.SerializeObject(isbz.UpdaeSalaryBiaoZhun(sbzm)));
        }
    }
}