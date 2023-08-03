using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.DataAccess
{
    public interface IAccountRepository : IRepository<FinancialAccount, int>
    {
        IEnumerable<FinancialAccount> GetBetweenDate(string start, string end);
    }
}
