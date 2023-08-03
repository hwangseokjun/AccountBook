using AccountBook.DataAccess;
using AccountBook.Presenters;
using AccountBook.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBook
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var accountView = new AccountView();
            var accountRepository = new AccountRepository();
            var commonCodeRepository = new CommonCodeRepository();
            var accountPresenter = new AccountPresenter(accountView, accountRepository, commonCodeRepository);
            accountPresenter.Initialize();
            Application.Run(accountView);
        }
    }
}
