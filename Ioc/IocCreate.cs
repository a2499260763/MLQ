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
        public static IStudentDAO CreateStudentDAO()
        {

            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IStudentDAO, StudenDAO>();
            return ioc.Resolve<IStudentDAO>();
        }

        public static IStudentBLL CreateUserBLL()
        {
            UnityContainer ioc = new UnityContainer();
            //把Unity文件转换为文件对象
            ExeConfigurationFileMap ef = new ExeConfigurationFileMap();
            ef.ExeConfigFilename = @"D:\C#Y2\MVC\项目\Code-T93\Code\HR\WebApplication1\Unity.config";
            //把文件对象转换为配置对象
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            //读取Unity节点(业务逻辑层的块)
            UnityConfigurationSection cs = (UnityConfigurationSection)cf.GetSection("unity");
            //容器里加载业务逻辑层的配置块
            ioc.LoadConfiguration(cs, "containerTwo");
            //根据配置文件的name来定位对象
            return ioc.Resolve<IStudentBLL>("StudentBLL");
        }
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
            ef.ExeConfigFilename = @"D:\C#Y2\MVC\项目\Code-T93\Code\HR\WebApplication1\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ef, ConfigurationUserLevel.None);
            UnityConfigurationSection cs = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(cs, "containerTwo");
            return ioc.Resolve<TIBLL>(name);
        }

    }
}
