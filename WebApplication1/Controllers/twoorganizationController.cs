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
    public class twoorganizationController:Controller
    {
        ItwoorganizationBLL itwo = IocCreate.CreateBLL<ItwoorganizationBLL>("twoorganizationBLL");
        IoneorganizationBLL ione = IocCreate.CreateBLL<IoneorganizationBLL>("oneorganizationBLL");
        public ActionResult Selecttwo()
        {
            return View("Selecttwo");
        }
        public ActionResult Selecttwo2()
        {
            List<twoorganizationModel> list = itwo.twoorganizationSelect();
            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult SelectWheretwo(int id)
        {
            List<twoorganizationModel> list = itwo.twoorganizationSelectWhere(id);
            twoorganizationModel two = null;
            foreach (twoorganizationModel item in list)
            {
                two = new twoorganizationModel()
                {
                    twoID = item.twoID,
                    oneCodeName = item.oneCodeName,
                    twoCode = item.twoCode,
                    twoCodeName = item.twoCodeName,
                    twoCoderemuneration = item.twoCoderemuneration,
                    twoCodemarket = item.twoCodemarket
                };

            }
            return View("SelectWheretwo", two);
        }
        public ActionResult Updatetwo(twoorganizationModel two)
        {
            if (itwo.twoorganizationUpd(two) > 0)
            {
                Response.Write("<script>alert('修改成功')</script>");
                return Selecttwo();
            }else
            {
                Response.Write("<script>alert('修改失败')</script>");
                return View();
            }
        }
        public ActionResult inserttwo()
        {
            string bian = DateTime.Now.ToString("yyMMddmmss") + new Random().Next(100, 999);
            ViewData["s"] = bian;
            List<oneorganizationModel> list = ione.oneorganizationSelect();
            List<SelectListItem> sl = new List<SelectListItem>();
          
            foreach (oneorganizationModel item in list)
            {
               
                SelectListItem s = new SelectListItem()
                {
                    Text = item.oneCodeName,
                    Value = item.oneCodeName
                };
                sl.Add(s);
            }
            ViewBag.sl = sl;
            return View("inserttwo");
        }
        public ActionResult InserttwoWhere(twoorganizationModel two)
        {
            

          
                if (itwo.twoorganizationAdd(two)>0)
                {
                    Response.Write("<script>alert('添加成功')</script>");
                    return Selecttwo();
                }
                else
                {
                    Response.Write("<script>alert('添加失败')</script>");
                    return View();
                }
            
        }
        public ActionResult Deletetwo(int id)
        {
            twoorganizationModel two = new twoorganizationModel()
            {
                twoID = id
            };
            int pd = itwo.twoorganizationDel(two);
            return Content(JsonConvert.SerializeObject(pd));
        }
    }
}