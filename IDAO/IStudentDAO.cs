using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Linq.Expressions;
using EF;

namespace IDAO
{
   public interface IStudentDAO
    {
        int StudentAdd(StudentModel sm);
        int StudentUpdate(StudentModel sm);
        int StudentDelete(StudentModel sm);
        List<StudentModel> StudentSelect();
           List<StudentModel> SelectStudentBy(int id);
          List<StudentModel> StudentFenYe<K>(int currentPage, int PageSize, out int rows);
    }
}
