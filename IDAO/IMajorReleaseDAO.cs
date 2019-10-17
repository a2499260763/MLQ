using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EF.Entity;

namespace IDAO
{
  public interface IMajorReleaseDAO
    {
        List<MajorReleaseModel> SeleMajorRelease();

        int AddMajorRelease(MajorReleaseModel mrm);

        List<MajorReleaseModel> MajorReleaseWhere(int id);

        int UpdateMajorRelease(MajorReleaseModel mrm);

        int DeleMajorRelease(MajorReleaseModel mrm);

      
    }
}
