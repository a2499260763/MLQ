using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EF.Entity;

namespace IBLL
{
  public  interface IMajorReleaseBLL
    {
        List<MajorReleaseModel> SeleMajorRelease();

        int AddMajorRelease(MajorReleaseModel mrm);

        List<MajorReleaseModel> MajorReleaseWhere(int id);

        int UpdateMajorRelease(MajorReleaseModel mrm);

        int DeleMajorRelease(MajorReleaseModel mrm);
    }
}
