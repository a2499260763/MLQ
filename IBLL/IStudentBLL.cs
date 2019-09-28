using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
   public interface IStudentBLL
    {
        int StudentAdd(StudentModel sm);
        int StudentUpdate(StudentModel sm);
        int StudentDelete(StudentModel sm);
        List<StudentModel> StudentSelect();
        List<StudentModel> SelectStudentBy(int id);
        List<StudentModel> StudentFenYe<K>(int currentPage, int PageSize, out int rows);
    }
}
