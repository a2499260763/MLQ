using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using BLL;
using Model;
using Ioc;

namespace WebApplication1.Controllers
{
    public class MainController : Controller
    {
        // GET: Main


        IUserBLL isb = IocCreate.CreateBLL<IUserBLL>("UserBLL");
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult main()
        {
            return View();
        }

        public ActionResult top()
        {
            return View();
        }

        public ActionResult left()
        {
            return View();
        }
        public ActionResult login(string name,string password)
        {
            List<UserModel> list = isb.login(name, password);

            if (list.Count > 0)
            {
                Response.Write("<script>alert('登录成功')</script>");
                return Index();
            }
            else
            {
                Response.Write("<script>alert('登录失败')</script>");
                return View();
            }
        }
        public ActionResult loginYZ(string name, string password)
        {
            List<UserModel> list = isb.login(name, password);

            if (list.Count > 0)
            {
                Response.Write("<script>alert('登录成功')</script>");
                return Index();
            }
            else
            {
                Response.Write("<script>alert('登录失败')</script>");
                return View();
            }
        }
    }
}