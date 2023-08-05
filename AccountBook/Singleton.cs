using AccountBook.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook
{
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        public static Singleton Instance
        {
            get
            {
                if (_instance is null)
                {
                    lock (_lock)
                    {
                        _instance = _instance ?? new Singleton();
                    }
                }

                return _instance;
            }
        }
        public AccountRepository AccountRepository { get; } = new AccountRepository();
        public CommonCodeRepository CommonCodeRepository { get; } = new CommonCodeRepository();

        private Singleton()
        {

        }
    }
}
