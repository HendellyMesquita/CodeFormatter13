using Ninject;
using CodeFormatter13.Infra;

namespace CodeFormatter13.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Criar o Kernel do Ninject e carregar as dependências
            var kernel = new StandardKernel(new DependenciasNinject());

            // Resolver dependências e injetar no Form
            var form = kernel.Get<CodeFormatter13>();

            Application.Run(form);
        }
    }
}