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
    public class framesetController : Controller
    {
        // GET: frameset
        IAccessBLL idao = IocCreate.CreateBLL<IAccessBLL>("AccessBLL");
        IUserBLL iusr = IocCreate.CreateBLL<IUserBLL>("UserBLL");
        public ActionResult Index()
        {
            return View("Index");
        }
        public ActionResult shu()
        {
            string b = Session["Role_id"].ToString();
            string a = Request["id"];
            List<AccessModel> li = idao.select(b, a);
            return Content(JsonConvert.SerializeObject(li));
        }

        public ActionResult top()
        {
            int b = int.Parse(Session["UserID"].ToString());
            List<UserModel> list = iusr.SelectUserBy(b);
            UserModel two = null;
            foreach (UserModel item in list)
            {
                two = new UserModel()
                {
                    user_id = item.user_id,
                    user_name = item.user_name,
                    user_password = item.user_password,
                    user_true_name = item.user_true_name,
                    Role_id = item.Role_id,
                    Role_Name = item.Role_Name

                };
            }
            return View("top", two);
        }
    }
}