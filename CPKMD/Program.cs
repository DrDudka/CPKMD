using CPKMD.Data;
using CPKMD.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace CPKMD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();
            Application.Run(ServiceProvider.GetService<AuthForm>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CPKMEDContext>();
            services.AddTransient<MainForm>();
            services.AddTransient<EditForm>();
            services.AddTransient<AuthForm>();
            services.AddTransient<AuthService>();
        }
    }
}