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
namespace WebApplication1.Controllers
{
    public class threeorganizationController:Controller
    {
        IthreeorganizationBLL ithree = IocCreate.CreateBLL<IthreeorganizationBLL>("threeorganizationBLL");
        IoneorganizationBLL ione = IocCreate.CreateBLL<IoneorganizationBLL>("oneorganizationBLL");
        ItwoorganizationBLL itwo = IocCreate.CreateBLL<ItwoorganizationBLL>("twoorganizationBLL");
        public ActionResult Selectthree()
        {
            return View("Selectthree");
        }
        public ActionResult Selectthree2()
        {
            List<threeorganizationModel> list = ithree.threeorganizationSelect();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult insertthree()
        {
            string bian = DateTime.Now.ToString("yyMMddmmss") + new Random().Next(100, 999);
            ViewData["s"] = bian;
            return View("insertthree");
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
        public ActionResult InsertWherethree(threeorganizationModel three)
        {
            if (ithree.threeorganizationAdd(three) > 0)
            {
                Response.Write("<script>alert('添加成功')</script>");
                return Selectthree();
            }else
            {
                Response.Write("<script>alert('添加失败')</script>");
                return View();
            }
        }
        public ActionResult SelectWherethree(int id)
        {
            List<threeorganizationModel> list = ithree.threeorganizationSelectWhere(id);
            threeorganizationModel three = null;
            foreach (threeorganizationModel item in list)
            {
                three = new threeorganizationModel()
                {
                    threeID=id,
                    oneName = item.oneName,
                    twoCodeName = item.twoCodeName,
                    threeCode = item.threeCode,
                    threeCodeName = item.threeCodeName,
                    threeCodemarket = item.threeCodemarket,
                    threeCodepd = item.threeCodepd
                };
            }
            return View("SelectWherethree", three);
        }
        public ActionResult InsertthreeWhere(threeorganizationModel three)
        {
            if (ithree.threeorganizationUpd(three) > 0)
            {
                Response.Write("<script>alert('修改成功')</script>");
                return Selectthree();
            }else
            {
                Response.Write("<script>alert('修改成功')</script>");
                return View();
            }
        }
        public ActionResult Deletethree(int id)
        {
            threeorganizationModel three = new threeorganizationModel()
            {
                threeID = id
            };
            int pd = ithree.threeorganizationDel(three);
            return Content(JsonConvert.SerializeObject(pd));
        }
    }
}