using System;
using System.Windows.Forms;

using AutoShop.Screens.Auth;
using AutoShop.Screens.MainForm;

namespace AutoShop
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Auth());

            Storage.Storage storage = Storage.Storage.getStorage();

            if (storage.getState().currentUser != null)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
