using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ioc;
using IBLL;
using DAO;
using Newtonsoft.Json;
using Model;

namespace WebApplication1.Controllers
{
    public class MianShiController : Controller
    {
        IJlBLL ijl = IocCreate.CreateBLL<IJlBLL>("JlBLL");
        IMianShiBLL ims = IocCreate.CreateBLL<IMianShiBLL>("MianShiBLL");
        ILuYongBLL ily = IocCreate.CreateBLL<ILuYongBLL>("LuYongBLL");
        // GET: MianShi
        public ActionResult MianShiRegisterIndex() //面试结果登记
        {

            return View(ims.SelectMianShi());
        }

        public ActionResult MianShiRegisterIndex2(int Id) //面试结果登记
        {
            List<JlMondel> list = ijl.JlWhere(Id);
            MianShiModel msm = null;
            foreach (JlMondel item in list)
            {
                msm = new MianShiModel()
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
                    JlYesNo = item.JlYesNo
                };
            }
            ims.InsertMianShi(msm);

            return RedirectToAction("MianShiRegisterIndex");
        }

        public ActionResult MianShiRegister(int Id) //面试结果登记
        {
            List<MianShiModel> list = ims.MianShiWhere(Id);
            MianShiModel msm = null;
            foreach (MianShiModel item in list)
            {
                msm = new MianShiModel()
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
                    MSZongHeSuZhi = item.MSZongHeSuZhi
                };
                if (msm.JlYesNo == 0)
                {
                    ViewBag.yes = "推荐";
                }
                else if (msm.JlYesNo == 1)
                {
                    ViewBag.yes = "简历无效";
                }
            }
            return View(msm);
        }

        public ActionResult MianShiRegisterUpdate(MianShiModel msm) //面试结果登记
        {
            msm.MSZhaungTai = "已面试";
            if (ims.UpdateMianShi(msm) > 0)
            {
                return RedirectToAction("MianShiRegisterIndex");
            }
            else
                return View(msm);
        }


        public ActionResult MianShiShaiXueUpdate(MianShiModel msm) //面试结果登记
        {
            msm.MSZhaungTai = "已面试";
            msm.MSCiShu = msm.MSCiShu + 1;
            ily.InsertLuYong(msm);
            if (ims.UpdateMianShi(msm) > 0)
            {
                return RedirectToAction("MianShiShaiXueIndex");
            }
            else
                return View(msm);
        }

        public ActionResult MianShiShaiXueIndex()   //面试筛选主页
        {
            return View(ims.SelectMianShi());
        }

        public ActionResult MianShiShaiXue(int Id)
        {
            List<MianShiModel> list = ims.MianShiWhere(Id);
            MianShiModel msm = null;
            foreach (MianShiModel item in list)
            {
                msm = new MianShiModel()
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
                    MSZongHeSuZhi = item.MSZongHeSuZhi
                };
                if (msm.JlYesNo == 0)
                {
                    ViewBag.yes = "推荐";
                }
                else if (msm.JlYesNo == 1)
                {
                    ViewBag.yes = "简历无效";
                }
            }
            return View(msm);
        }
    }
}