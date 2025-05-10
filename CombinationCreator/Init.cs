using System;
using System.Windows.Forms;

namespace CombinationCreator
{
    static class Init
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CombinationCreator());
        }
    }
}
