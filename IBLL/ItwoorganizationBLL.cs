﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface ItwoorganizationBLL
    {
        int twoorganizationAdd(twoorganizationModel two);
        int twoorganizationUpd(twoorganizationModel two);
        int twoorganizationDel(twoorganizationModel two);
        List<twoorganizationModel> twoorganizationSelect();
        List<twoorganizationModel> twoorganizationSelectWhere(int id);
        List<twoorganizationModel> twoorganizationSelectWhereName(string id);
    }
}
