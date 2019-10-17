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
    public class JlDAO : DaoBase<Jl>, IJlDAO
    {
        public int InsertJl(JlMondel jlm)
        {
            Jl jl = new Jl()
            {
                Id = jlm.Id,
                JlAdds = jlm.JlAdds,
                JlAge = jlm.JlAge,
                JlAiHoa = jlm.JlAiHoa,
                JlBeiZhu = jlm.JlBeiZhu,
                JlBiYanShooln = jlm.JlBiYanShooln,
                JlBreathAdds = jlm.JlBreathAdds,
                JlBreathDay = jlm.JlBreathDay,
                JlDianHua = jlm.JlDianHua,
                JlEmail = jlm.JlEmail,
                JlEntityCond = jlm.JlEntityCond,
                JlGeRenLvLi = jlm.JlGeRenLvLi,
                JlGuoJi = jlm.JlGuoJi,
                JlJiaoYvYean = jlm.JlJiaoYvYean,
                JlJiaTingDianHua = jlm.JlJiaTingDianHua,
                JlMingZu = jlm.JlMingZu,
                JlName = jlm.JlName,
                JlSex = jlm.JlSex,
                JlShouJi = jlm.JlShouJi,
                JlTeChang = jlm.JlTeChang,
                JlXingZiYaoQiu = jlm.JlXingZiYaoQiu,
                JlXueli = jlm.JlXueli,
                JlXueLiZhuanYe = jlm.JlXueLiZhuanYe,
                JlYouBian = jlm.JlYouBian,
                JlZcTime = jlm.JlZcTime,
                JlZcOverTime = jlm.JlZcTime.AddDays(3),
                JlZhengZhiMianMao = jlm.JlZhengZhiMianMao,
                JlZongJioaXingYang = jlm.JlZongJioaXingYang,
                MCName = jlm.MCName,
                MKName = jlm.MKName,
                ZPName = jlm.ZPName,
                JlYesNo=0
            };
            return Add(jl);
          
        }

        public List<JlMondel> JlWhere(int Id)
        {
            MyDbContext md = CreateContext();
            List<Jl> list = md.Jl.AsNoTracking()
                .Where(e => e.Id == Id)
                .Select(e => e).ToList();
            List<JlMondel> list2 = new List<JlMondel>();
            foreach (Jl item in list)
            {
                JlMondel jlm = new JlMondel()
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
                     JlTuiJianRen=item.JlTuiJianRen,
                      JlTuiJianTime=item.JlTuiJianTime
                };
                list2.Add(jlm);
            }
            return list2;
        }

        public int UpdateJl(JlMondel jim)
        {
            Jl jl = new Jl()
            {
                Id = jim.Id,
                JlYesNo = jim.JlYesNo,
                JlTuiJianRen = jim.JlTuiJianRen,
                JlTuiJianTime = jim.JlTuiJianTime
            };
            return Update(jl);
        }
    }
}
