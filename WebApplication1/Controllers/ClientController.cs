using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ioc;
using Model;
using IBLL;
using EF;
using Newtonsoft.Json;
using BLL;
using DAO;
using System.Data;

namespace hr.Controllers
{
    public class ClientController : Controller
    {
        IMajorChenBLL imc = Ioc.IocCreate.CreateBLL<IMajorChenBLL>("MajorChenBLL");
        IMajorKindBLL ikc = Ioc.IocCreate.CreateBLL<IMajorKindBLL>("MajorKindBLL");
        IMajorBLL im = Ioc.IocCreate.CreateBLL<IMajorBLL>("MajorBLL");
        DBHelper db = new DBHelper();
        // GET: Client
        public ActionResult MajorChenIndex()
        {            
            return View("MajorChenIndex");
        }

          public ActionResult MajorChenIndex2()
        {
            return Content(JsonConvert.SerializeObject(imc.SelectMajorChen()));
        }

        public ActionResult MajorChenDele(int Id)
        {
            MajorChenModel mc = new MajorChenModel()
            {
                Id = Id
            };
            return Content(JsonConvert.SerializeObject(imc.DeleMajorChen(mc)));
        }

        public ActionResult MajorKindIndex()
        {
            return View("MajorKindIndex");
        }
        

        public ActionResult MajorKindIndex2()
        {
            List<MajorKindModel> list = ikc.SelectMajorKind();
            return Content(JsonConvert.SerializeObject(list));
        }
        
        public ActionResult MajorKindDele(int Id)
        {
            MajorKindModel mc = new MajorKindModel()
            {
                Id = Id
            };
            int num = ikc.DeleteMajorKind(mc);
            return Content(JsonConvert.SerializeObject(num));
        }


        string mm;
            public ActionResult MajorKindInsert(string Id)
        {
            int num = int.Parse(Id.Substring(1))+1;
             mm = "0" + num;
            ViewBag.ss = mm;
            return View("MajorKindInsert");
        }

        public ActionResult MajorKindInsert2(string MKID,string MKName)
        {
            if (ModelState.IsValid)
            {
                MajorKindModel mk = new MajorKindModel()
                {
                    MKID = MKID,
                    MKName = MKName
                };
                if (ikc.AddMajorKind(mk)>0)
                {
                   
                    return RedirectToAction("MajorKindIndex");
                }
                else
                {
                    Response.Write("<script>alert('添加失败')<script>");
                    return View(MajorKindInsert(mm));
                }     
            }
            else
            {
                return RedirectToAction("MajorKindInsert");
            }
          
        }

        public ActionResult MajorIndex()
        {
            return View();
        }
        
    
        public ActionResult MajorIndex2()
        {
            string sql = string.Format("select * from View_Major_Kind_Chen");
            DataTable dt = DBHelper.GetTable(sql);
            return Content(JsonConvert.SerializeObject(dt));
            //object list = mb.select();
            
        }

        

         public ActionResult MajorInsert()
        {
            SelectList ls = new SelectList(ikc.SelectMajorKind(), "Id", "MKName");
            SelectList ls2 = new SelectList(imc.SelectMajorChen(), "Id", "CName");
            ViewBag.ss = ls;
            ViewBag.bb = ls2;
            return View();
        }

        public ActionResult MajorInsert2(int MKID, int MCID)
        {
            MajorModel mm = new MajorModel()
            {
                MCID = MCID,
                MKID = MKID
            };
            return Content(JsonConvert.SerializeObject(im.AddMajor(mm)));
        }
       

         public ActionResult MajorDele(int Id)
        {
            MajorModel mm = new MajorModel()
            {
                Id = Id
            };
            return Content(JsonConvert.SerializeObject(im.DeleMajor(mm)));
        }
    }
}