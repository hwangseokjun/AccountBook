using Dapper;
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
        public int Delete(AccountEntity entity)
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING)) 
            {
                long id = connection.Insert(entity);

                return (int)id;
            }
        }

        public int DeleteById(int id)
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            {
                connection.Delete(new AccountEntity { Id = id });

                return id;
            }
        }

        public IEnumerable<AccountEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountEntity> GetBetweenDate(string start, string end)
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            {
                string query = "SELECT * FROM account WHERE Date BETWEEN @StartDate AND @EndDate;";
                var accountEntities = connection.Query<AccountEntity>(query, new { StartDate = start, EndDate = end });

                return accountEntities;
            }
        }

        public AccountEntity GetById(int id)
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            {
                var account = connection.Get<AccountEntity>(id);

                return account;
            }
        }

        public int Insert(AccountEntity entity)
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            {
                long id = connection.Insert(entity);

                return (int)id;
            }
        }

        public void Update(AccountEntity entity)
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            {
                connection.Update<AccountEntity>(entity);
            }
        }
    }
}
