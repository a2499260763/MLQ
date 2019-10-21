using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
    public interface IMajorWeiBLL
    {
        List<MajorWeiModel> MajorWeiSelect(); //
        List<MajorWeiModel> MajorWeiSelectWhere(int id); //
    }
}
