using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EF.Entity;
using IDAO;
using EF;

namespace DAO
{
    public class LuYongDAO : DaoBase<LuYong>, ILuYongDAO
    {
        public int InsertLuYong(MianShiModel msm)
        {
            LuYong ly = new LuYong()
            {
                Id = msm.Id,
                JlAdds = msm.JlAdds,
                JlAge = msm.JlAge,
                JlAiHoa = msm.JlAiHoa,
                JlBeiZhu = msm.JlBeiZhu,
                JlBiYanShooln = msm.JlBiYanShooln,
                JlBreathAdds = msm.JlBreathAdds,
                JlBreathDay = msm.JlBreathDay,
                JlDianHua = msm.JlDianHua,
                JlEmail = msm.JlEmail,
                JlEntityCond = msm.JlEntityCond,
                JlGeRenLvLi = msm.JlGeRenLvLi,
                JlGuoJi = msm.JlGuoJi,
                JlJiaoYvYean = msm.JlJiaoYvYean,
                JlJiaTingDianHua = msm.JlJiaTingDianHua,
                JlMingZu = msm.JlMingZu,
                JlName = msm.JlName,
                JlSex = msm.JlSex,
                JlShouJi = msm.JlShouJi,
                JlTeChang = msm.JlTeChang,
                JlXingZiYaoQiu = msm.JlXingZiYaoQiu,
                JlXueli = msm.JlXueli,
                JlXueLiZhuanYe = msm.JlXueLiZhuanYe,
                JlYouBian = msm.JlYouBian,
                JlZcTime = msm.JlZcTime,
                JlZcOverTime = msm.JlZcTime.AddDays(3),
                JlZhengZhiMianMao = msm.JlZhengZhiMianMao,
                JlZongJioaXingYang = msm.JlZongJioaXingYang,
                MCName = msm.MCName,
                MKName = msm.MKName,
                ZPName = msm.ZPName,
                JlYesNo = msm.JlYesNo,
                MSCiShu = msm.MSCiShu,
                MSZhaungTai = msm.MSZhaungTai,
                MSShaiXueTime = msm.MSShaiXueTime,
                MSShengQingYiJian = msm.MSShengQingYiJian,
                MSWaiYvKouYv = msm.MSWaiYvKouYv,
                MSXingXiangPingJia = msm.MSXingXiangPingJia,
                MSYingBianNengLi = msm.MSYingBianNengLi,
                MSZongHeSuZhi = msm.MSZongHeSuZhi,
                JlTuiJianRen = msm.JlTuiJianRen,
                JlTuiJianTime = msm.JlTuiJianTime,
                MSEQ = msm.MSEQ,
                MSIQ = msm.MSIQ,
                MSKouCaiPingJia = msm.MSKouCaiPingJia,
                MSMianShiRen = msm.MSMianShiRen,
                MSMianShiTime = msm.MSMianShiTime,
                MSShaiXueRen = msm.MSShaiXueRen
            };
            return Add(ly);
        }

        public List<LuYongModel> LuYongWhere(int Id)
        {
            MyDbContext md = CreateContext();
            List<LuYong> list = md.LuYong.AsNoTracking()
                .Where(e => e.Id == Id).Select(e => e).ToList();
            List<LuYongModel> list2 = new List<LuYongModel>();
            foreach (LuYong item in list)
            {
                LuYongModel lym = new LuYongModel()
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
                list2.Add(lym);
            }
            return list2;     
        }

        public List<LuYongModel> SelectLuYong()
        {
            List<LuYong> list = Select();
            List<LuYongModel> list2 = new List<LuYongModel>();
            foreach (LuYong item in list)
            {
                LuYongModel lym = new LuYongModel()
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
                list2.Add(lym);
            }
            return list2;
        }

        public int UpdateLuYong(LuYongModel lym)
        {
            LuYong ly = new LuYong()
            {
                Id = lym.Id,
                JlAdds = lym.JlAdds,
                JlAge = lym.JlAge,
                JlAiHoa = lym.JlAiHoa,
                JlBeiZhu = lym.JlBeiZhu,
                JlBiYanShooln = lym.JlBiYanShooln,
                JlBreathAdds = lym.JlBreathAdds,
                JlBreathDay = lym.JlBreathDay,
                JlDianHua = lym.JlDianHua,
                JlEmail = lym.JlEmail,
                JlEntityCond = lym.JlEntityCond,
                JlGeRenLvLi = lym.JlGeRenLvLi,
                JlGuoJi = lym.JlGuoJi,
                JlJiaoYvYean = lym.JlJiaoYvYean,
                JlJiaTingDianHua = lym.JlJiaTingDianHua,
                JlMingZu = lym.JlMingZu,
                JlName = lym.JlName,
                JlSex = lym.JlSex,
                JlShouJi = lym.JlShouJi,
                JlTeChang = lym.JlTeChang,
                JlXingZiYaoQiu = lym.JlXingZiYaoQiu,
                JlXueli = lym.JlXueli,
                JlXueLiZhuanYe = lym.JlXueLiZhuanYe,
                JlYouBian = lym.JlYouBian,
                JlZcTime = lym.JlZcTime,
                JlZcOverTime = lym.JlZcTime.AddDays(3),
                JlZhengZhiMianMao = lym.JlZhengZhiMianMao,
                JlZongJioaXingYang = lym.JlZongJioaXingYang,
                MCName = lym.MCName,
                MKName = lym.MKName,
                ZPName = lym.ZPName,
                JlYesNo = lym.JlYesNo,
                MSCiShu = lym.MSCiShu,
                MSZhaungTai = lym.MSZhaungTai,
                MSShaiXueTime = lym.MSShaiXueTime,
                MSShengQingYiJian = lym.MSShengQingYiJian,
                MSWaiYvKouYv = lym.MSWaiYvKouYv,
                MSXingXiangPingJia = lym.MSXingXiangPingJia,
                MSYingBianNengLi = lym.MSYingBianNengLi,
                MSZongHeSuZhi = lym.MSZongHeSuZhi,
                JlTuiJianRen = lym.JlTuiJianRen,
                LYShengQing = lym.LYShengQing,
                JlTuiJianTime = lym.JlTuiJianTime,
                MSEQ = lym.MSEQ,
                MSIQ = lym.MSIQ,
                MSKouCaiPingJia = lym.MSKouCaiPingJia,
                MSMianShiRen = lym.MSMianShiRen,
                MSMianShiTime = lym.MSMianShiTime,
                MSShaiXueRen = lym.MSShaiXueRen,
                 LYShengPi=lym.LYShengPi
            };
            return Update(ly);
        }

        public int UpdateLuYongShengPi(LuYongModel lym)
        {
            LuYong ly = new LuYong()
            {
                Id = lym.Id,
                LYShengPi = lym.LYShengPi
            };

            return Update(ly);
        }
    }
}
