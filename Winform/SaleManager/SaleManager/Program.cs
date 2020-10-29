using SaleManager.Entities;
using SaleManager.Utils;
using SaleManager.Views;
using System;
using System.Windows.Forms;
using Unity;

namespace SaleManager
{
    static class Config
    {
        public static UnityContainer Container { get; private set; } = new UnityContainer();
        public static void Register()
        {
            Container.RegisterType<IUnitOfWork, UnitOfWork>();
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutoMapperConfig.RegisterAutoMappings();
            Config.Register();

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                MessageBox.Show((e.ExceptionObject as Exception).Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.ThreadException += (s, e) =>
                MessageBox.Show(e.Exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
