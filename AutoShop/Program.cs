using System;
using System.IO;
using System.Text.Json;
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

            Storage.Storage storage = Storage.Storage.getStorage();

            Application.Run(new Auth());


            if (storage.getState().currentUser != null)
            {
                Application.Run(new MainForm());
            }

        }
    }
}
