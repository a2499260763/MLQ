using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using BLL;
using Model;
using Ioc;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class LiangController : Controller
    {

        IPublicCharBLL isb = IocCreate.CreateBLL<IPublicCharBLL>("PublicCharBLL");

        ISalaryBLL isy = IocCreate.CreateBLL<ISalaryBLL>("SalaryBLL");
        // GET: Liang
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult public_char()
        {
            return View("public_char");
        }

        public ActionResult SelectPublicChar()
        {
            List<PublicCharModel> list = isb.PublicCharSelect();

            return Content(JsonConvert.SerializeObject(list));
        }

        public ActionResult DeletePublic(int id)
        {
            PublicCharModel one = new PublicCharModel()
            {
                PID = id
            };
            int pd = isb.PublicCharDelete(one);
            return Content(JsonConvert.SerializeObject(pd));
        }


        public ActionResult public_char_add()
        {
            return View("public_char_add");
        }

        public ActionResult InsertoneWhere(PublicCharModel one)
        {

            if (isb.PublicCharAdd(one) > 0)
            {
                Response.Write("<script>alert('添加成功')</script>");
                return public_char();
            }
            else
            {
                Response.Write("<script>alert('添加失败')</script>");
                return View();
            }
        }



        public ActionResult salary_item()
        {
            return View("salary_item");
        }

        public ActionResult salary_item_register()
        {
            return View();
        }

        public ActionResult SelectSalary()
        {
            List<SalaryModel> list = isy.SalarySelect();

            return Content(JsonConvert.SerializeObject(list));
        }

        public ActionResult DeleteSalary(int id)
        {
            SalaryModel one = new SalaryModel()
            {
                SID = id
            };
            int pd = isy.SalaryDelete(one);
            return Content(JsonConvert.SerializeObject(pd));
        }

        public ActionResult InsertSalary(SalaryModel one)
        {

            if (isy.SalaryAdd(one) > 0)
            {
                Response.Write("<script>alert('添加成功')</script>");
                return salary_item();
            }
            else
            {
                Response.Write("<script>alert('添加失败')</script>");
                return View();
            }
        }
    }
}