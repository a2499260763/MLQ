using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using EF.Entity;
using Model;
using EF;


namespace DAO
{
    public class SalaryBiaoZhunDAO : DaoBase<SalaryBiaoZhun>, ISalaryBiaoZhunDAO
    {

    
        public int InsertSalaryBiaoZhun(SalaryBiaoZhunModel sbzm)
        {
            SalaryBiaoZhun sbz = new SalaryBiaoZhun()
            {

                SBZBeiZhu = sbzm.SBZBeiZhu,
                SBZDengJiTime = sbzm.SBZDengJiTime,
                SBZDengJiRen = sbzm.SBZDengJiRen,
                SalaryChuCai = sbzm.SalaryChuCai,
                SalaryChuCaiID = sbzm.SalaryChuCaiID,
                SalaryJiaoTong = sbzm.SalaryJiaoTong,
                SalaryJiaoTongID = sbzm.SalaryJiaoTongID,
                SBZChuCaiJinE = sbzm.SBZChuCaiJinE,
                SBZJiaoTongJinE = sbzm.SBZJiaoTongJinE,
                SBZBianHao = sbzm.SBZBianHao,
                SBZName = sbzm.SBZName,
                SBZZhiDingRen = sbzm.SBZZhiDingRen,
                SBZZongE = sbzm.SBZZongE
            };
            return Add(sbz);
        }

        public List<SalaryBiaoZhunModel> SalaryBiaoZhunFenYe(int currentPage, int pageSize, out int rows)
        {
            var list = CreateContext().SalaryBiaoZhun.AsNoTracking().OrderBy(e => e.Id);
            rows = list.Count();
            var data = list
                 .Skip((currentPage - 1) * pageSize)
                 .Take(pageSize)
                 .ToList();
            List<SalaryBiaoZhunModel> list2 = new List<SalaryBiaoZhunModel>();
            foreach (var p in data)
            {
                SalaryBiaoZhunModel e = new SalaryBiaoZhunModel()
                {
                    Id = p.Id,
                    SBZBeiZhu = p.SBZBeiZhu,
                    SBZDengJiTime = p.SBZDengJiTime,
                    SBZDengJiRen = p.SBZDengJiRen,
                    SalaryChuCai = p.SalaryChuCai,
                    SalaryChuCaiID = p.SalaryChuCaiID,
                    SalaryJiaoTong = p.SalaryJiaoTong,
                    SalaryJiaoTongID = p.SalaryJiaoTongID,
                    SBZChuCaiJinE = p.SBZChuCaiJinE,
                    SBZJiaoTongJinE = p.SBZJiaoTongJinE,
                    SBZBianHao = p.SBZBianHao,
                    SBZName = p.SBZName,
                    SBZZhiDingRen = p.SBZZhiDingRen,
                    SBZZongE = p.SBZZongE
                };
                list2.Add(e);
            }
            return list2;
        }

        public SalaryBiaoZhunModel SalaryBiaoZhunWhere(int Id)
        {
            MyDbContext md = CreateContext();
            List<SalaryBiaoZhun> list = md.SalaryBiaoZhun.AsNoTracking()
                .Where(e => e.Id == Id)
                .Select(e => e).ToList();

            SalaryBiaoZhunModel sbzm = null;
            foreach (var p in list)
            {
                 sbzm = new SalaryBiaoZhunModel()
                {
                    Id = p.Id,
                    SBZBeiZhu = p.SBZBeiZhu,
                    SBZDengJiTime = p.SBZDengJiTime,
                    SBZDengJiRen = p.SBZDengJiRen,
                    SalaryChuCai = p.SalaryChuCai,
                    SalaryChuCaiID = p.SalaryChuCaiID,
                    SalaryJiaoTong = p.SalaryJiaoTong,
                    SalaryJiaoTongID = p.SalaryJiaoTongID,
                    SBZChuCaiJinE = p.SBZChuCaiJinE,
                    SBZJiaoTongJinE = p.SBZJiaoTongJinE,
                    SBZBianHao = p.SBZBianHao,
                    SBZName = p.SBZName,
                    SBZZhiDingRen = p.SBZZhiDingRen,
                    SBZZongE = p.SBZZongE,
                    SBZFuHeRen = p.SBZFuHeRen,
                    SBZFuHeTime = p.SBZFuHeTime,
                    SBZFuHeYiJian = p.SBZFuHeYiJian
                };
            }
            return sbzm;
        }

        public List<SalaryBiaoZhunModel> SelectSalaryBiaoZhun()
        {
            List<SalaryBiaoZhun> list = Select();
            List<SalaryBiaoZhunModel> list2 = new List<SalaryBiaoZhunModel>();
            foreach (var p in list)
            {
                SalaryBiaoZhunModel sbz = new SalaryBiaoZhunModel()
                {
                    Id = p.Id,
                    SBZBeiZhu = p.SBZBeiZhu,
                    SBZDengJiTime = p.SBZDengJiTime,
                    SBZDengJiRen = p.SBZDengJiRen,
                    SalaryChuCai = p.SalaryChuCai,
                    SalaryChuCaiID = p.SalaryChuCaiID,
                    SalaryJiaoTong = p.SalaryJiaoTong,
                    SalaryJiaoTongID = p.SalaryJiaoTongID,
                    SBZChuCaiJinE = p.SBZChuCaiJinE,
                    SBZJiaoTongJinE = p.SBZJiaoTongJinE,
                    SBZBianHao = p.SBZBianHao,
                    SBZName = p.SBZName,
                    SBZZhiDingRen = p.SBZZhiDingRen,
                    SBZZongE = p.SBZZongE,
                    SBZFuHeRen = p.SBZFuHeRen,
                    SBZFuHeTime = p.SBZFuHeTime,
                    SBZFuHeYiJian = p.SBZFuHeYiJian,
                    SBZBianGengRen = p.SBZBianGengRen,
                    SBZBianGenTime = p.SBZBianGenTime
                };
                list2.Add(sbz);
            }
            return list2;
        }

        public int UpdaeSalaryBiaoZhun(SalaryBiaoZhunModel p)
        {
            SalaryBiaoZhun sbz = new SalaryBiaoZhun()
            {
                Id = p.Id,
                SBZBeiZhu = p.SBZBeiZhu,
                SBZDengJiTime = p.SBZDengJiTime,
                SBZDengJiRen = p.SBZDengJiRen,
                SalaryChuCai = p.SalaryChuCai,
                SalaryChuCaiID = p.SalaryChuCaiID,
                SalaryJiaoTong = p.SalaryJiaoTong,
                SalaryJiaoTongID = p.SalaryJiaoTongID,
                SBZChuCaiJinE = p.SBZChuCaiJinE,
                SBZJiaoTongJinE = p.SBZJiaoTongJinE,
                SBZBianHao = p.SBZBianHao,
                SBZName = p.SBZName,
                SBZZhiDingRen = p.SBZZhiDingRen,
                SBZZongE = p.SBZZongE,
                SBZFuHeRen = p.SBZFuHeRen,
                SBZFuHeTime = p.SBZFuHeTime,
                SBZFuHeYiJian = p.SBZFuHeYiJian,
                SBZBianGengRen = p.SBZBianGengRen,
                SBZBianGenTime = p.SBZBianGenTime
            };
            return Update(sbz);
        }
    }
}
