using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class JlMondel
    {
        public int Id { get; set; }


        public string MCName { get; set; }

        public string MKName { get; set; }

        public string ZPName { get; set; }

        public string JlName { get; set; }

        public string JlSex { get; set; }

        public string JlEmail { get; set; }

        public string JlDianHua { get; set; }  //电话

        public string JlJiaTingDianHua { get; set; }  //家庭电话

        public string JlShouJi { get; set; } //手机

        public string JlAdds { get; set; } //住址

        public string JlYouBian { get; set; } //邮编

        public string JlGuoJi { get; set; } //国籍

        public string JlBreathAdds { get; set; } //出生地

        /// <summary>
        /// 生日
        /// </summary>
        public string JlBreathDay { get; set; } //

        public string JlTuiJianRen { get; set; } //推荐人

        public string JlTuiJianTime { get; set; } //推荐时间

        /// <summary>
        /// 名族
        /// </summary>
        public string JlMingZu { get; set; }

        public string JlZongJioaXingYang { get; set; } //宗教信仰

        public string JlZhengZhiMianMao { get; set; } //政治面貌

        public string JlEntityCond { get; set; } //身份证号

        public int JlAge { get; set; } //年龄

        public string JlBiYanShooln { get; set; } //毕业学校

        public string JlXueli { get; set; } //学历

        public string JlJiaoYvYean { get; set; } //教育年限

        public string JlXueLiZhuanYe { get; set; } //学历专业

        public double JlXingZiYaoQiu { get; set; } //薪资要求

        public DateTime JlZcTime { get; set; } //注册时间

        public DateTime JlZcOverTime { get; set; } //注册结束时间

        public string JlTeChang { get; set; } //特长

        public string JlAiHoa { get; set; } //爱好

        public string JlGeRenLvLi { get; set; } //个人履历

        public string JlBeiZhu { get; set; } //备注

        public int JlYesNo { get; set; } //简历是否有效 0-有效 1-无效
    }
}
