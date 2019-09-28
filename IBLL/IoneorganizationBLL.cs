using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
    public interface IoneorganizationBLL
    {
        int oneorganizationAdd(oneorganizationModel one);
        int oneorganizationUpd(oneorganizationModel one);
        int oneorganizationDel(oneorganizationModel one);
        List<oneorganizationModel> oneorganizationSelect();
        List<oneorganizationModel> oneorganizationSelectWhere(int id);
        List<oneorganizationModel> oneorganizationFenYe<K>(int currentPage, int PageSize, out int rows);
    }
}
