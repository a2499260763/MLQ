using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
    public interface IMajorKindBLL
    {
        int AddMajorKind(MajorKindModel mk);
        int UpdateMajorKind(MajorKindModel mk);
        int DeleteMajorKind(MajorKindModel mk);
        List<MajorKindModel> SelectMajorKind();
        List<MajorKindModel> SelectMajorKindBy(int id);
        List<MajorKindModel> MajorKindFenYe<K>(int currentPage, int PageSize, out int rows);
    }
}
