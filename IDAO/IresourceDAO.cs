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
    public interface IresourceDAO
    {
        int resourceAdd(resourceModel r); //人力资源档案登记
        int resourceUpd(resourceModel r); //
        int resourceDel(resourceModel r); //
        List<resourceModel> resourceSelect(); //
        List<resourceModel> resourceSelectWhere(string id); //
        List<resourceModel> resourceFenYe(int RRState, string RState,int currentPage, int PageSize, out int rows);
        List<resourceModel> resourceWhereFenYe(resourceModel res, int pageindex, int pagecount, out int count);
    }
}
