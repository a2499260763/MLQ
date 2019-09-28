using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model;
using IDAO;
using DAO;
using EF;
using Ioc;
namespace BLL
{
    public class StudentBLL : IStudentBLL
    {
       //IStudentDAO ist = IocCreate.CreateStudentDAO();
        IStudentDAO ist = IocCreate.CreateDao<IStudentDAO, StudenDAO>();
        public List<StudentModel> SelectStudentBy(int id)
        {
            return ist.SelectStudentBy(id);
        }

        public int StudentAdd(StudentModel sm)
        {
            return ist.StudentAdd(sm);
        }

        public int StudentDelete(StudentModel sm)
        {
            return ist.StudentDelete(sm);
        }

        public List<StudentModel> StudentFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<StudentModel> StudentSelect()
        {
            return ist.StudentSelect();
        }

        public int StudentUpdate(StudentModel sm)
        {
            return ist.StudentUpdate(sm);
        }
    }
}
