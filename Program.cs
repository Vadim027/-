using System;
using System.Windows.Forms;
using Управление_самолетами.Services;  // <-- если папка Services
using Управление_самолетами.Models;    // <-- если папка Models

namespace Управление_самолетами
{
    internal static class Program
    {
        // Главная точка входа для приложения.
        [STAThread]
        static void Main()
        {
            var cfg = AppConfig.Load("Config/AppConfig.xml");
            var db = new DbService(cfg);
            var net = new NetworkService(cfg);
            net.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(cfg, db, net));
        }
    }
}
