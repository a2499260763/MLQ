using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Linq.Expressions;
using EF.Entity;
namespace IDAO
{
    public interface IMajorWeiDAO
    {
        int MajorWeiAdd(MajorWeiModel wei); //
        int MajorWeiUpd(MajorWeiModel wei); //
        int MajorWeiDel(MajorWeiModel wei); //
        List<MajorWeiModel> MajorWeiSelect(); //
        List<MajorWeiModel> MajorWeiSelectWhere(int id); //
    }
}
