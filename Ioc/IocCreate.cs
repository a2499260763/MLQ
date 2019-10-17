using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using IDAO;
using DAO;
using IBLL;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
using Model;

namespace Ioc
{
    public class IocCreate
    {
        public static TIDAO CreateDao<TIDAO, TDAO>() where TDAO : TIDAO
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<TIDAO, TDAO>();
            return ioc.Resolve<TIDAO>();
        }

        public static TIBLL CreateBLL<TIBLL>(string name)
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
            ef.ExeConfigFilename = @"D:\kelong\WebApplication2\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            UnityConfigurationSection cs = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(cs, "containerTwo");
            return ioc.Resolve<TIBLL>(name);
        }

    }
}
