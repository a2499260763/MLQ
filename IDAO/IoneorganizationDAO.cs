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
    public interface IoneorganizationDAO
    {
        int oneorganizationAdd(oneorganizationModel one); //I级机构添加
        int oneorganizationUpd(oneorganizationModel one); //I级机构修改
        int oneorganizationDel(oneorganizationModel one); //I级机构删除
        List<oneorganizationModel> oneorganizationSelect(); //I级机构查询
        List<oneorganizationModel> oneorganizationSelectWhere(int id); //I级机构条件查询
        List<oneorganizationModel> oneorganizationFenYe<K>(int currentPage, int PageSize, out int rows);
    }
}

