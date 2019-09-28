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
    public class oneorganizationController:Controller
    {
        IoneorganizationBLL ione = IocCreate.CreateBLL<IoneorganizationBLL>("oneorganizationBLL");
        public ActionResult Selectoneorganization()
        {
            return View("Selectoneorganization");
        }
        public ActionResult Selectoneorganization2()
        {
            List<oneorganizationModel> list = ione.oneorganizationSelect();

            return Content(JsonConvert.SerializeObject(list));
        }
        public ActionResult SelectWhereone(int id)
        {
            List<oneorganizationModel> list = ione.oneorganizationSelectWhere(id);
            oneorganizationModel one=null;
            foreach (oneorganizationModel item in list)
            {
                one = new oneorganizationModel()
                {
                    oneID = item.oneID,
                    oneCode = item.oneCode,
                    oneCodeName = item.oneCodeName,
                    oneCoderemuneration = item.oneCoderemuneration,
                    oneCodemarket = item.oneCodemarket
                };
            }

            return View("SelectWhereone", one);

        }
        public ActionResult Updateone(oneorganizationModel one)
        {
            if (ione.oneorganizationUpd(one) > 0)
            {
                Response.Write("<script>alert('修改成功')</script>");
                return Selectoneorganization();
            }else
            {
                Response.Write("<script>alert('修改失败')</script>");
                return View();
            }
        }
        public ActionResult insertone()
        {
            string bian = DateTime.Now.ToString("yyMMddmmss") + new Random().Next(100, 999);
            ViewData["s"] = bian;
            return View("insertone");
        }
        public ActionResult InsertoneWhere(oneorganizationModel one)
        {
            
            if (ione.oneorganizationAdd(one)>0)
            {
                Response.Write("<script>alert('添加成功')</script>");
                return Selectoneorganization();
            }else
            {
                Response.Write("<script>alert('添加失败')</script>");
                return View();
            }
        }
        public ActionResult Deleteone(int id)
        {
            oneorganizationModel one = new oneorganizationModel()
            {
                oneID = id
            };
            int pd = ione.oneorganizationDel(one);
            return Content(JsonConvert.SerializeObject(pd));
        }



    }
}