using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
using EF.Entity;
using System.Linq.Expressions;
using EF;

namespace DAO
{
    /// <summary>
    /// Student-EO
    /// StudentModel-DTO
    /// </summary>
    public class StudenDAO :DaoBase<Student>,  IStudentDAO
    {
        public int StudentAdd(StudentModel t)
        {
            Student st = new Student() {
                 Id=t.Id,
                  Name=t.Name
            };

            return Add(st);
        }

        public int StudentDelete(StudentModel t)
        {
            Student st = new Student() {
                 Name=t.Name,
                  Id=t.Id
            };
            return Delete(st);
        }

        public List<StudentModel> StudentSelect() {
            List<Student> list = Select();
            List<StudentModel> list2 = new List<StudentModel>();
            foreach (Student item in list)
            {
                StudentModel sm = new StudentModel()
                {
                    Id = item.Id,
                    Name = item.Name
                };
                list2.Add(sm);
            }
            return list2; ;
        }

        public List<StudentModel> SelectStudentBy(int id)
        {
            MyDbContext db = CreateContext();
          List<Student> list=  db.Student.AsNoTracking()
                .Where(e=>e.Id==id)
                .Select(e => e)
                .ToList();
            List<StudentModel> list2 = new List<StudentModel>();
            foreach (Student item in list)
            {
                StudentModel sm = new StudentModel() {
                     Id=item.Id,
                      Name=item.Name
                };
                list2.Add(sm);
            }
            return list2; ;
        }

        public int StudentUpdate(StudentModel t)
        {
            Student st = new Student() {
                 Id=t.Id,
                  Name=t.Name
            };
            return Update(st);
        }

        public List<StudentModel> StudentFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }
    }
}
