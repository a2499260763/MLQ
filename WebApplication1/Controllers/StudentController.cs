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
    public class StudentController : Controller
    {
        // GET: Student
        //IStudentBLL isb = new StudentBLL();


        IStudentBLL isb = IocCreate.CreateBLL<IStudentBLL>("StudentBLL");
        public ActionResult Index()
        {
            List<StudentModel> list = isb.StudentSelect();
            return View(list);
        }
        [HttpGet]
        public ActionResult Edit(int id) {

            StudentModel sm = isb.SelectStudentBy(id).SingleOrDefault();
            return View(sm);
        }
        [HttpPost]
        public ActionResult Edit(StudentModel sm) {
            if (isb.StudentUpdate(sm) > 0) {
                return RedirectToAction("Index");
            }
            else
            {
                return View(sm);
            }
        }

        public ActionResult Delete(int id)
        {
            StudentModel sm = new StudentModel() {
                 Id=id
            };
            if (isb.StudentDelete(sm)>0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/Student/Index'</script>");
            }

        }
    }
}