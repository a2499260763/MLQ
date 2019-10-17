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
    public class MianShiDAO : DaoBase<MianShi>, IMianShiDAO
    {
        public int InsertMianShi(MianShiModel msm)
        {
            MianShi ms = new MianShi()
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
                MSCiShu = 1,
                MSZhaungTai = "待面试",
                MSShaiXueTime = DateTime.Now
                
            };
            return Add(ms);
        }

        public List<MianShiModel> MianShiWhere(int Id)
        {
            MyDbContext md = CreateContext();
            List<MianShi> list = md.MianShi.AsNoTracking()
                .Where(e => e.Id == Id)
                .Select(e => e).ToList();
            List<MianShiModel> list2 = new List<MianShiModel>();
            foreach (MianShi item in list)
            {
                MianShiModel msm = new MianShiModel()
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
                list2.Add(msm);
            }
            return list2;
        }

        public List<MianShiModel> SelectMianShi()
        {
            List<MianShi> list = Select();
            List<MianShiModel> list2 = new List<MianShiModel>();
            foreach (MianShi item in list)
            {
                MianShiModel msm = new MianShiModel()
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
                list2.Add(msm);
            }
            return list2;
        }

        public int UpdateMianShi(MianShiModel msm)
        {
            MianShi ms = new MianShi()
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
                JlTuiJianRen = msm.JlTuiJianRen,
                JlTuiJianTime = msm.JlTuiJianTime,
                MSCiShu = msm.MSCiShu,
                MSEQ = msm.MSEQ,
                MSIQ = msm.MSIQ,
                MSKouCaiPingJia = msm.MSKouCaiPingJia,
                MSMianShiRen = msm.MSMianShiRen,
                MSMianShiTime = msm.MSMianShiTime,
                MSShaiXueRen = msm.MSShaiXueRen,
                MSShaiXueTime = msm.MSShaiXueTime,
                MSShengQingYiJian = msm.MSShengQingYiJian,
                MSWaiYvKouYv = msm.MSWaiYvKouYv,
                MSXingXiangPingJia = msm.MSXingXiangPingJia,
                MSYingBianNengLi = msm.MSYingBianNengLi,
                MSZhaungTai = msm.MSZhaungTai,
                MSZongHeSuZhi = msm.MSZongHeSuZhi,

            };
            return Update(ms);
        }
    }
}
