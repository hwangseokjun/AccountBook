using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.DataAccess
{
    public class AccountRepository : IAccountRepository
    {
        public int Delete(FinancialAccount entity)
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING)) 
            {
                long id = connection.Insert(entity);

                return (int)id;
            }
        }

        public int DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FinancialAccount> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FinancialAccount> GetBetweenDate(string start, string end)
        {
            throw new NotImplementedException();
        }

        public FinancialAccount GetById(int id)
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            {
                var account = connection.Get<FinancialAccount>(id);

                return account;
            }
        }

        public int Insert(FinancialAccount entity)
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            {
                long id = connection.Insert(entity);

                return (int)id;
            }
        }

        public void Update(FinancialAccount entity)
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            {
                connection.Update<FinancialAccount>(entity);
            }
        }
    }
}
