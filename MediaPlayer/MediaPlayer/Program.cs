using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string a = System.IO.Directory.GetCurrentDirectory();
            Global.settingpath = a + @"\Setting";
            Global.historypath = a + @"\History";
            string text = File.ReadAllText(Global.settingpath);
            if (text.Substring(0, 1) == "0")
                Global.isDark = false;
            else
                Global.isDark = true;
            if (text.Substring(1, 1) == "0")
                Global.haveIntro = false;
            else
                Global.haveIntro = true;
            string pathisIntro = "isIntro";
            string isIntro = File.ReadAllText(pathisIntro);
            if (isIntro == "1")
            {
                if(Global.haveIntro)
                    Application.Run(new fSplashScreen());
            }
            bool runApp = true;
            while (runApp)
            {
                bool loginOk = false;
                using (fLogin frmLogin = new fLogin())
                {
                    if (frmLogin.ShowDialog() == DialogResult.OK)
                    {
                        loginOk = true;
                        frmLogin.DfsDispose(frmLogin);
                    }
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                if (loginOk)
                {
                    using (fMain frmMain = new fMain())
                    {
                        if (frmMain.ShowDialog() == DialogResult.No)
                        {
                            runApp = false;
                            File.WriteAllText(pathisIntro, "1");
                        }
                    }
                }
                if (runApp)
                {
                    Process.Start(Application.ExecutablePath);
                    runApp = false;
                    File.WriteAllText(pathisIntro, "0");
                    //System.Diagnostics.Process.GetCurrentProcess().Kill();
                    Application.Exit();
                }
                
            }
            Application.Exit();
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
