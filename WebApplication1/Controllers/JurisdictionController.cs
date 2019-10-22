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
    public class JurisdictionController : Controller
    {

        IUserBLL isb = IocCreate.CreateBLL<IUserBLL>("UserBLL");
        IRoleBLL iro = IocCreate.CreateBLL<IRoleBLL>("RoleBLL");
        IAccessBLL acc = IocCreate.CreateBLL<IAccessBLL>("AccessBLL");

        // GET: Jurisdiction
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Selectlist()
        {
            return View("Selectlist");
        }

        public ActionResult Jueshu()
        {
              
              int num= iro.RoleSelect().Count;
               return Content(num+"");
    }

        public ActionResult Index2(int currentPage, int PageSize)
        {
            int rows = 0;
            return Content(JsonConvert.SerializeObject(isb.UsersmanFenYe(currentPage, PageSize, out rows)));
        }
        public ActionResult GetRow()
        {
            int rows = 0;
            isb.UsersmanFenYe(1, 4, out rows);
            return Content(rows + "");
        }

        public ActionResult Del(int id)
        {
            UserModel um = new UserModel();
            um.user_id = id;
            if (isb.UserDelete(um) > 0)
            {
                return RedirectToAction("Selectlist");
            }
            else
            {
                return View(um);
            }
        }



        public ActionResult user_add()
        {
            List<RoleModel> list = iro.RoleSelect();
            SelectList s1 = new SelectList(list, "Role_id", "Role_Name", 1);
            ViewBag.sl = s1;
            return View("user_add");
        }

        public ActionResult InsertSalary(UserModel one)
        {
            one.Role_Name = iro.SelectRoleBy(one.Role_id).ToList()[0].Role_Name;

            if (isb.UserAdd(one) > 0)
            {
                Response.Write("<script>alert('添加成功')</script>");
                return Selectlist();
            }
            else
            {
                Response.Write("<script>alert('添加失败')</script>");
                return View();
            }
        }




        public ActionResult SelectWheretwo(int id) 
        {
            List<RoleModel> list1 = iro.RoleSelect();
            SelectList s1 = new SelectList(list1, "Role_id", "Role_Name", 1);
            ViewBag.sl = s1;
            List<UserModel> list = isb.SelectUserBy(id);
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
            return View("SelectWheretwo", two);
        }


        public ActionResult Updatetwo(UserModel two)
        {
            two.Role_Name = iro.SelectRoleBy(two.Role_id).ToList()[0].Role_Name;
            if (isb.UserUpdate(two) > 0)
            {
                Response.Write("<script>alert('修改成功')</script>");
                return Selectlist();
            }
            else
            {
                Response.Write("<script>alert('修改失败')</script>");
                return View();
            }
        }




        public ActionResult SelectRole()
        {
            return View("SelectRole");
        }

        public ActionResult Index3(int currentPage, int PageSize)
        {
            int rows = 0;
            return Content(JsonConvert.SerializeObject(iro.RolesmanFenYe(currentPage, PageSize, out rows)));
        }
        public ActionResult GetRow1()
        {
            int rows = 0;
            iro.RolesmanFenYe(1, 4, out rows);
            return Content(rows + "");
        }

        public ActionResult Del1(int id)
        {
            RoleModel um = new RoleModel();
            um.Role_id = id;
            if (iro.RoleDelete(um) > 0)
            {
                return RedirectToAction("SelectRole");
            }
            else
            {
                return View(um);
            }
        }


        public ActionResult RoleAdd()
        {
            return View("RoleAdd");
        }


        public ActionResult InsertRole(RoleModel one)
        {

            if (iro.RoleAdd(one) > 0)
            {
                Response.Write("<script>alert('添加成功')</script>");
                return SelectRole();
            }
            else
            {
                Response.Write("<script>alert('添加失败')</script>");
                return View();
            }
        }

        public ActionResult UpdeteResult(int id)
        {
            return View("UpdeteResult", iro.SelectOne(id));
         
        }

        public ActionResult Index2Up(RoleModel uu, string[] rightCodes)
        {
            List<AccessModel> st = new List<AccessModel>();
            bool pan = true;
            iro.dels(uu.Role_id);
            iro.RoleUpdate(uu);
            if (rightCodes != null)
            {
                foreach (string item in rightCodes)
                {
                    AccessModel li = acc.selecttiao(item);
                    st.Add(li);
                }
                foreach (AccessModel it in st)
                {
                    if (iro.Adds(it.id, uu.Role_id) > 0)
                    {
                        pan = true;
                    }
                    else
                    {
                        pan = false;
                        break;
                    }
                }
                if (pan)
                {
                    return Content("<script>alert('操作成功');location.href='/Jurisdiction/SelectRole'</script>");
                }
                else
                {
                    return Content("<script>alert('操作失败');location.href='/Jurisdiction/SelectRole'</script>");
                }
            }
            return Content("<script>location.href='/Jurisdiction/SelectRole'</script>");
        }


        public ActionResult UpQx(int low)
        {
            List<AccessModel> li = acc.select2(low);
            return Content(JsonConvert.SerializeObject(li));
        }




        public ActionResult Denglus(UserModel uu)
        {
            List<UserModel> li = isb.login(uu.user_name,uu.user_password);
            if (li.Count != 0)
            {
                Session["Role_id"] = li[0].Role_id;
                Session["UserID"] = li[0].user_id;
                Session["UserName"] = li[0].user_name;
                return Content("<script>alert('登录成功');location.href='/frameset/Index';</script>");
            }
            else
            {
                return Content("<script>alert('登录失败');location.href='/Jurisdiction/Denglu';</script>");
            }

        }


        public ActionResult Denglu()
        {
          return View("Denglu");
        }





    }
}