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
            string filename = "ExsenseV2.exe";

            if (!File.Exists(filename))
            {
                MessageBox.Show(filename + " dosyası bulunamadı.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = filename/*Process.GetCurrentProcess().ProcessName*/,
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
