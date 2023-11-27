using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace start
{
    class Program
    {
        static void Main()
        {
            string mainname = "ExsenseV2.exe";
            string clientdll = "client.dll";
            string antidbg = "antidbg.dll";
            string updater = "UpdateLocker.dll";

            if (!File.Exists(mainname))
            {
                MessageBox.Show(mainname + " dosyası bulunamadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            if (!File.Exists(clientdll))
            {
                MessageBox.Show(clientdll + " dosyası bulunamadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            if (!File.Exists(antidbg))
            {
                MessageBox.Show(antidbg + " dosyası bulunamadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            if (!File.Exists(updater))
            {
                MessageBox.Show(updater + " dosyası bulunamadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = mainname/*Process.GetCurrentProcess().ProcessName*/,
                    Verb = "runas" // Bu, işlemi yönetici izinleriyle başlatmak için gereklidir
                };

                Process.Start(psi);
            }
            catch
            {
                new Thread(() =>
                {
                    Thread.Sleep(2750);
                    Environment.Exit(0);
                }).Start();

                MessageBox.Show("Programı yönetici olarak başlatın.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);
            }

            Environment.Exit(0);
        }
    }
}
