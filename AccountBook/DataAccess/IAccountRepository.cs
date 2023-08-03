using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.DataAccess
{
    public interface IAccountRepository : IRepository<AccountEntity, int>
    {
        IEnumerable<AccountEntity> GetBetweenDate(string start, string end);
    }
}
