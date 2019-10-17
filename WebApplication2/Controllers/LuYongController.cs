﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ioc;
using Model;
using DAO;
using IBLL;

namespace WebApplication2.Controllers
{
    public class LuYongController : Controller
    {
        ILuYongBLL ilyb = IocCreate.CreateBLL<ILuYongBLL>("LuYongBLL");
        // GET: LuYong
        public ActionResult LuYongShengQingIndex()  //录用申请主页
        {
            return View(ilyb.SelectLuYong());
        }

        public ActionResult LuYongShengQing(int Id)  //录用申请主页
        {
            List<LuYongModel> list = ilyb.LuYongWhere(Id);
            LuYongModel lym = null;
            foreach (var item in list)
            {
                lym = new LuYongModel()
                {
                    Id = item.Id,
                    JlAdds = item.JlAdds,
                    JlAge = item.JlAge,
                    JlAiHoa = item.JlAiHoa,
                    JlBeiZhu = item.JlBeiZhu,
                    JlBiYanShooln = item.JlBiYanShooln,
                    JlBreathAdds = item.JlBreathAdds,
                    JlBreathDay = item.JlBreathDay,
                    JlDianHua = item.JlDianHua,
                    JlEmail = item.JlEmail,
                    JlEntityCond = item.JlEntityCond,
                    JlGeRenLvLi = item.JlGeRenLvLi,
                    JlGuoJi = item.JlGuoJi,
                    JlJiaoYvYean = item.JlJiaoYvYean,
                    JlJiaTingDianHua = item.JlJiaTingDianHua,
                    JlMingZu = item.JlMingZu,
                    JlName = item.JlName,
                    JlSex = item.JlSex,
                    JlShouJi = item.JlShouJi,
                    JlTeChang = item.JlTeChang,
                    JlXingZiYaoQiu = item.JlXingZiYaoQiu,
                    JlXueli = item.JlXueli,
                    JlXueLiZhuanYe = item.JlXueLiZhuanYe,
                    JlYouBian = item.JlYouBian,
                    JlZcTime = item.JlZcTime,
                    JlZcOverTime = item.JlZcTime.AddDays(3),
                    JlZhengZhiMianMao = item.JlZhengZhiMianMao,
                    JlZongJioaXingYang = item.JlZongJioaXingYang,
                    MCName = item.MCName,
                    MKName = item.MKName,
                    ZPName = item.ZPName,
                    JlYesNo = item.JlYesNo,
                    JlTuiJianRen = item.JlTuiJianRen,
                    JlTuiJianTime = item.JlTuiJianTime,
                    MSCiShu = item.MSCiShu,
                    MSEQ = item.MSEQ,
                    MSIQ = item.MSIQ,
                    MSKouCaiPingJia = item.MSKouCaiPingJia,
                    MSMianShiRen = item.MSMianShiRen,
                    MSMianShiTime = item.MSMianShiTime,
                    MSShaiXueRen = item.MSShaiXueRen,
                    MSShaiXueTime = item.MSShaiXueTime,
                    MSShengQingYiJian = item.MSShengQingYiJian,
                    MSWaiYvKouYv = item.MSWaiYvKouYv,
                    MSXingXiangPingJia = item.MSXingXiangPingJia,
                    MSYingBianNengLi = item.MSYingBianNengLi,
                    MSZhaungTai = item.MSZhaungTai,
                    MSZongHeSuZhi = item.MSZongHeSuZhi,
                    LYShengPi = item.LYShengPi,
                    LYShengQing = item.LYShengQing
                };
            }
            if (lym.JlYesNo == 0)
            {
                ViewBag.yes = "推荐";
            }
            else if (lym.JlYesNo == 1)
            {
                ViewBag.yes = "简历无效";
            }
            return View(lym);
        }

        public ActionResult LuYongShengQingUpdate(LuYongModel lym)  //录用申请主页
        {
            if (ilyb.UpdateLuYong(lym)>0)
            {
                Content("<script>alert('申请成功')</script>");
                return RedirectToAction("LuYongShengQingIndex");
            }
            else
            return View(lym);
        }

        public ActionResult LuYongShengPiIndex()  //录用审批主页
        {
            return View(ilyb.SelectLuYong());
        }

        

         public ActionResult LuYongShenPi(int Id)  //录用审批
        {
            List<LuYongModel> list = ilyb.LuYongWhere(Id);
            LuYongModel lym = null;
            foreach (var item in list)
            {
                lym = new LuYongModel()
                {
                    Id = item.Id,
                    JlAdds = item.JlAdds,
                    JlAge = item.JlAge,
                    JlAiHoa = item.JlAiHoa,
                    JlBeiZhu = item.JlBeiZhu,
                    JlBiYanShooln = item.JlBiYanShooln,
                    JlBreathAdds = item.JlBreathAdds,
                    JlBreathDay = item.JlBreathDay,
                    JlDianHua = item.JlDianHua,
                    JlEmail = item.JlEmail,
                    JlEntityCond = item.JlEntityCond,
                    JlGeRenLvLi = item.JlGeRenLvLi,
                    JlGuoJi = item.JlGuoJi,
                    JlJiaoYvYean = item.JlJiaoYvYean,
                    JlJiaTingDianHua = item.JlJiaTingDianHua,
                    JlMingZu = item.JlMingZu,
                    JlName = item.JlName,
                    JlSex = item.JlSex,
                    JlShouJi = item.JlShouJi,
                    JlTeChang = item.JlTeChang,
                    JlXingZiYaoQiu = item.JlXingZiYaoQiu,
                    JlXueli = item.JlXueli,
                    JlXueLiZhuanYe = item.JlXueLiZhuanYe,
                    JlYouBian = item.JlYouBian,
                    JlZcTime = item.JlZcTime,
                    JlZcOverTime = item.JlZcTime.AddDays(3),
                    JlZhengZhiMianMao = item.JlZhengZhiMianMao,
                    JlZongJioaXingYang = item.JlZongJioaXingYang,
                    MCName = item.MCName,
                    MKName = item.MKName,
                    ZPName = item.ZPName,
                    JlYesNo = item.JlYesNo,
                    JlTuiJianRen = item.JlTuiJianRen,
                    JlTuiJianTime = item.JlTuiJianTime,
                    MSCiShu = item.MSCiShu,
                    MSEQ = item.MSEQ,
                    MSIQ = item.MSIQ,
                    MSKouCaiPingJia = item.MSKouCaiPingJia,
                    MSMianShiRen = item.MSMianShiRen,
                    MSMianShiTime = item.MSMianShiTime,
                    MSShaiXueRen = item.MSShaiXueRen,
                    MSShaiXueTime = item.MSShaiXueTime,
                    MSShengQingYiJian = item.MSShengQingYiJian,
                    MSWaiYvKouYv = item.MSWaiYvKouYv,
                    MSXingXiangPingJia = item.MSXingXiangPingJia,
                    MSYingBianNengLi = item.MSYingBianNengLi,
                    MSZhaungTai = item.MSZhaungTai,
                    MSZongHeSuZhi = item.MSZongHeSuZhi,
                    LYShengPi = item.LYShengPi,
                    LYShengQing = item.LYShengQing
                };
            }
            if (lym.JlYesNo == 0)
            {
                ViewBag.yes = "推荐";
            }
            else if (lym.JlYesNo == 1)
            {
                ViewBag.yes = "简历无效";
            }
            return View(lym);
        }

        public ActionResult LuYongShengPiUpdate(LuYongModel lym)  //录用申请主页
        {
            if (ilyb.UpdateLuYong(lym) > 0)
            {
                return RedirectToAction("LuYongShengPiIndex");
            }
            else
                return View(lym);
        }

        public ActionResult LuYongChaXunIndex()  //录用查询主页
        {
            return View(ilyb.SelectLuYong());
        }
        

          public ActionResult LuYongChaXun(int Id)  //录用审批
        {
            List<LuYongModel> list = ilyb.LuYongWhere(Id);
            LuYongModel lym = null;
            foreach (var item in list)
            {
                lym = new LuYongModel()
                {
                    Id = item.Id,
                    JlAdds = item.JlAdds,
                    JlAge = item.JlAge,
                    JlAiHoa = item.JlAiHoa,
                    JlBeiZhu = item.JlBeiZhu,
                    JlBiYanShooln = item.JlBiYanShooln,
                    JlBreathAdds = item.JlBreathAdds,
                    JlBreathDay = item.JlBreathDay,
                    JlDianHua = item.JlDianHua,
                    JlEmail = item.JlEmail,
                    JlEntityCond = item.JlEntityCond,
                    JlGeRenLvLi = item.JlGeRenLvLi,
                    JlGuoJi = item.JlGuoJi,
                    JlJiaoYvYean = item.JlJiaoYvYean,
                    JlJiaTingDianHua = item.JlJiaTingDianHua,
                    JlMingZu = item.JlMingZu,
                    JlName = item.JlName,
                    JlSex = item.JlSex,
                    JlShouJi = item.JlShouJi,
                    JlTeChang = item.JlTeChang,
                    JlXingZiYaoQiu = item.JlXingZiYaoQiu,
                    JlXueli = item.JlXueli,
                    JlXueLiZhuanYe = item.JlXueLiZhuanYe,
                    JlYouBian = item.JlYouBian,
                    JlZcTime = item.JlZcTime,
                    JlZcOverTime = item.JlZcTime.AddDays(3),
                    JlZhengZhiMianMao = item.JlZhengZhiMianMao,
                    JlZongJioaXingYang = item.JlZongJioaXingYang,
                    MCName = item.MCName,
                    MKName = item.MKName,
                    ZPName = item.ZPName,
                    JlYesNo = item.JlYesNo,
                    JlTuiJianRen = item.JlTuiJianRen,
                    JlTuiJianTime = item.JlTuiJianTime,
                    MSCiShu = item.MSCiShu,
                    MSEQ = item.MSEQ,
                    MSIQ = item.MSIQ,
                    MSKouCaiPingJia = item.MSKouCaiPingJia,
                    MSMianShiRen = item.MSMianShiRen,
                    MSMianShiTime = item.MSMianShiTime,
                    MSShaiXueRen = item.MSShaiXueRen,
                    MSShaiXueTime = item.MSShaiXueTime,
                    MSShengQingYiJian = item.MSShengQingYiJian,
                    MSWaiYvKouYv = item.MSWaiYvKouYv,
                    MSXingXiangPingJia = item.MSXingXiangPingJia,
                    MSYingBianNengLi = item.MSYingBianNengLi,
                    MSZhaungTai = item.MSZhaungTai,
                    MSZongHeSuZhi = item.MSZongHeSuZhi,
                    LYShengPi = item.LYShengPi,
                    LYShengQing = item.LYShengQing
                };
            }
            if (lym.JlYesNo == 0)
            {
                ViewBag.yes = "推荐";
            }
            else if (lym.JlYesNo == 1)
            {
                ViewBag.yes = "简历无效";
            }
            return View(lym);
        }
    }
    
}