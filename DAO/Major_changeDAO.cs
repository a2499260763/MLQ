using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
using EF;
using System.Linq.Expressions;
using EF.Entity;

namespace DAO
{
    public class Major_changeDAO : DaoBase<Major_change>, IMajor_changeDAO
    {
        public int Major_changeAdd(Major_changeModel p)
        {
            Major_change st = new Major_change()
            {
                change_reason = p.change_reason,
                checker = p.checker,
                check_reason = p.check_reason,
                check_status = p.check_status,
                check_time = p.check_time,
                first_kind_id = p.first_kind_id,
                first_kind_name = p.first_kind_name,
                major_kind_id = p.major_kind_id,
                major_id = p.major_id,
                human_name = p.human_name,
                human_id = p.human_id,
                major_kind_name = p.major_kind_name,
                major_name = p.major_name,
                mch_id = p.mch_id,
                new_first_kind_id = p.new_first_kind_id,
                new_first_kind_name = p.new_first_kind_name,
                new_major_id = p.new_major_id,
                new_major_kind_id = p.new_major_kind_id,
                new_major_kind_name = p.new_major_kind_name,
                new_salary_standard_id = p.new_salary_standard_id,
                new_major_name = p.new_major_name,
                new_third_kind_id = p.new_third_kind_id,
                new_salary_standard_name = p.new_salary_standard_name,
                new_second_kind_name = p.new_second_kind_name,
                new_second_kind_id = p.new_second_kind_id,
                new_salary_sum = p.new_salary_sum,
                register = p.register,
                new_third_kind_name = p.new_third_kind_name,
                salary_standard_id = p.salary_standard_id,
                salary_standard_name = p.salary_standard_name,
                salary_sum = p.salary_sum,
                regist_time = p.regist_time,
                second_kind_id = p.second_kind_id,
                second_kind_name = p.second_kind_name,
                third_kind_id = p.third_kind_id,
                third_kind_name = p.third_kind_name
            };

            return Add(st);
        }

        public int Major_changeDelete(Major_changeModel p)
        {
            Major_change st = new Major_change()
            {
                change_reason = p.change_reason,
                checker = p.checker,
                check_reason = p.check_reason,
                check_status = p.check_status,
                check_time = p.check_time,
                first_kind_id = p.first_kind_id,
                first_kind_name = p.first_kind_name,
                major_kind_id = p.major_kind_id,
                major_id = p.major_id,
                human_name = p.human_name,
                human_id = p.human_id,
                major_kind_name = p.major_kind_name,
                major_name = p.major_name,
                mch_id = p.mch_id,
                new_first_kind_id = p.new_first_kind_id,
                new_first_kind_name = p.new_first_kind_name,
                new_major_id = p.new_major_id,
                new_major_kind_id = p.new_major_kind_id,
                new_major_kind_name = p.new_major_kind_name,
                new_salary_standard_id = p.new_salary_standard_id,
                new_major_name = p.new_major_name,
                new_third_kind_id = p.new_third_kind_id,
                new_salary_standard_name = p.new_salary_standard_name,
                new_second_kind_name = p.new_second_kind_name,
                new_second_kind_id = p.new_second_kind_id,
                new_salary_sum = p.new_salary_sum,
                register = p.register,
                new_third_kind_name = p.new_third_kind_name,
                salary_standard_id = p.salary_standard_id,
                salary_standard_name = p.salary_standard_name,
                salary_sum = p.salary_sum,
                regist_time = p.regist_time,
                second_kind_id = p.second_kind_id,
                second_kind_name = p.second_kind_name,
                third_kind_id = p.third_kind_id,
                third_kind_name = p.third_kind_name
            };

            return Delete(st);
        }

        public List<Major_changeModel> Major_changeFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<Major_changeModel> Major_changemanFenYe(int currentPage, int PageSize, out int rows)
        {
            var list = CreateContext().Major_change.AsNoTracking().OrderBy(e => e.mch_id);
            rows = list.Count();
            var data = list
                 .Skip((currentPage - 1) * PageSize)
                 .Take(PageSize)
                 .ToList();
            List<Major_changeModel> list2 = new List<Major_changeModel>();
            foreach (var p in data)
            {
                Major_changeModel e = new Major_changeModel()
                {
                    change_reason = p.change_reason,
                    checker = p.checker,
                    check_reason = p.check_reason,
                    check_status = p.check_status,
                    check_time = p.check_time,
                    first_kind_id = p.first_kind_id,
                    first_kind_name = p.first_kind_name,
                    major_kind_id = p.major_kind_id,
                    major_id = p.major_id,
                    human_name = p.human_name,
                    human_id = p.human_id,
                    major_kind_name = p.major_kind_name,
                    major_name = p.major_name,
                    mch_id = p.mch_id,
                    new_first_kind_id = p.new_first_kind_id,
                    new_first_kind_name = p.new_first_kind_name,
                    new_major_id = p.new_major_id,
                    new_major_kind_id = p.new_major_kind_id,
                    new_major_kind_name = p.new_major_kind_name,
                    new_salary_standard_id = p.new_salary_standard_id,
                    new_major_name = p.new_major_name,
                    new_third_kind_id = p.new_third_kind_id,
                    new_salary_standard_name = p.new_salary_standard_name,
                    new_second_kind_name = p.new_second_kind_name,
                    new_second_kind_id = p.new_second_kind_id,
                    new_salary_sum = p.new_salary_sum,
                    register = p.register,
                    new_third_kind_name = p.new_third_kind_name,
                    salary_standard_id = p.salary_standard_id,
                    salary_standard_name = p.salary_standard_name,
                    salary_sum = p.salary_sum,
                    regist_time = p.regist_time,
                    second_kind_id = p.second_kind_id,
                    second_kind_name = p.second_kind_name,
                    third_kind_id = p.third_kind_id,
                    third_kind_name = p.third_kind_name
                };
                list2.Add(e);
            }
            return list2;
        }

        public List<Major_changeModel> Major_changeSelect()
        {
            List<Major_change> list = Select();
            List<Major_changeModel> list2 = new List<Major_changeModel>();
            foreach (Major_change p in list)
            {
                Major_changeModel sm = new Major_changeModel()
                {
                    change_reason = p.change_reason,
                    checker = p.checker,
                    check_reason = p.check_reason,
                    check_status = p.check_status,
                    check_time = p.check_time,
                    first_kind_id = p.first_kind_id,
                    first_kind_name = p.first_kind_name,
                    major_kind_id = p.major_kind_id,
                    major_id = p.major_id,
                    human_name = p.human_name,
                    human_id = p.human_id,
                    major_kind_name = p.major_kind_name,
                    major_name = p.major_name,
                    mch_id = p.mch_id,
                    new_first_kind_id = p.new_first_kind_id,
                    new_first_kind_name = p.new_first_kind_name,
                    new_major_id = p.new_major_id,
                    new_major_kind_id = p.new_major_kind_id,
                    new_major_kind_name = p.new_major_kind_name,
                    new_salary_standard_id = p.new_salary_standard_id,
                    new_major_name = p.new_major_name,
                    new_third_kind_id = p.new_third_kind_id,
                    new_salary_standard_name = p.new_salary_standard_name,
                    new_second_kind_name = p.new_second_kind_name,
                    new_second_kind_id = p.new_second_kind_id,
                    new_salary_sum = p.new_salary_sum,
                    register = p.register,
                    new_third_kind_name = p.new_third_kind_name,
                    salary_standard_id = p.salary_standard_id,
                    salary_standard_name = p.salary_standard_name,
                    salary_sum = p.salary_sum,
                    regist_time = p.regist_time,
                    second_kind_id = p.second_kind_id,
                    second_kind_name = p.second_kind_name,
                    third_kind_id = p.third_kind_id,
                    third_kind_name = p.third_kind_name
                };
                list2.Add(sm);
            }
            return list2; ;
        }

        public int Major_changeUpdate(Major_changeModel p)
        {
            Major_change st = new Major_change()
            {
                change_reason = p.change_reason,
                checker = p.checker,
                check_reason = p.check_reason,
                check_status = p.check_status,
                check_time = p.check_time,
                first_kind_id = p.first_kind_id,
                first_kind_name = p.first_kind_name,
                major_kind_id = p.major_kind_id,
                major_id = p.major_id,
                human_name = p.human_name,
                human_id = p.human_id,
                major_kind_name = p.major_kind_name,
                major_name = p.major_name,
                mch_id = p.mch_id,
                new_first_kind_id = p.new_first_kind_id,
                new_first_kind_name = p.new_first_kind_name,
                new_major_id = p.new_major_id,
                new_major_kind_id = p.new_major_kind_id,
                new_major_kind_name = p.new_major_kind_name,
                new_salary_standard_id = p.new_salary_standard_id,
                new_major_name = p.new_major_name,
                new_third_kind_id = p.new_third_kind_id,
                new_salary_standard_name = p.new_salary_standard_name,
                new_second_kind_name = p.new_second_kind_name,
                new_second_kind_id = p.new_second_kind_id,
                new_salary_sum = p.new_salary_sum,
                register = p.register,
                new_third_kind_name = p.new_third_kind_name,
                salary_standard_id = p.salary_standard_id,
                salary_standard_name = p.salary_standard_name,
                salary_sum = p.salary_sum,
                regist_time = p.regist_time,
                second_kind_id = p.second_kind_id,
                second_kind_name = p.second_kind_name,
                third_kind_id = p.third_kind_id,
                third_kind_name = p.third_kind_name
            };

            return Update(st);
        }

        public List<Major_changeModel> SelectMajor_changeBy(int id)
        {
            MyDbContext db = CreateContext();
            List<Major_change> list = db.Major_change.AsNoTracking()
                  .Where(e => e.mch_id == id)
                  .Select(e => e)
                  .ToList();
            List<Major_changeModel> list2 = new List<Major_changeModel>();
            foreach (Major_change p in list)
            {
                Major_changeModel sm = new Major_changeModel()
                {
                    change_reason = p.change_reason,
                    checker = p.checker,
                    check_reason = p.check_reason,
                    check_status = p.check_status,
                    check_time = p.check_time,
                    first_kind_id = p.first_kind_id,
                    first_kind_name = p.first_kind_name,
                    major_kind_id = p.major_kind_id,
                    major_id = p.major_id,
                    human_name = p.human_name,
                    human_id = p.human_id,
                    major_kind_name = p.major_kind_name,
                    major_name = p.major_name,
                    mch_id = p.mch_id,
                    new_first_kind_id = p.new_first_kind_id,
                    new_first_kind_name = p.new_first_kind_name,
                    new_major_id = p.new_major_id,
                    new_major_kind_id = p.new_major_kind_id,
                    new_major_kind_name = p.new_major_kind_name,
                    new_salary_standard_id = p.new_salary_standard_id,
                    new_major_name = p.new_major_name,
                    new_third_kind_id = p.new_third_kind_id,
                    new_salary_standard_name = p.new_salary_standard_name,
                    new_second_kind_name = p.new_second_kind_name,
                    new_second_kind_id = p.new_second_kind_id,
                    new_salary_sum = p.new_salary_sum,
                    register = p.register,
                    new_third_kind_name = p.new_third_kind_name,
                    salary_standard_id = p.salary_standard_id,
                    salary_standard_name = p.salary_standard_name,
                    salary_sum = p.salary_sum,
                    regist_time = p.regist_time,
                    second_kind_id = p.second_kind_id,
                    second_kind_name = p.second_kind_name,
                    third_kind_id = p.third_kind_id,
                    third_kind_name = p.third_kind_name

                };
                list2.Add(sm);
            }
            return list2; ;
        }
    }
}
