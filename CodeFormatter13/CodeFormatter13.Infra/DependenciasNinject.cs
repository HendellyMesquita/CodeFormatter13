using CodeFormatter13.Dominio.CodeFormatter;
using Ninject.Modules;

namespace CodeFormatter13.Infra
{
    public class DependenciasNinject : NinjectModule
    {
        public override void Load()
        {
            Bind<IServicoDeCodeFormatter>().To<ServicoDeCodeFormatter>();
        }
    }
}
