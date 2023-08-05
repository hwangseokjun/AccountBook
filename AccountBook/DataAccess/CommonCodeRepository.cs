using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.DataAccess
{
    public class CommonCodeRepository : ICommonCodeRepository
    {
        public int Delete(CommonCode entity)
        {
            throw new NotImplementedException();
        }

        public int DeleteById(int id)
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            {
                connection.Delete(new CommonCode { Id = id });

                return id;
            }
        }

        public IEnumerable<CommonCode> GetAll()
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            {
                var commonCodes = connection.GetAll<CommonCode>();

                return commonCodes;
            }
        }

        public CommonCode GetById(int id)
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            {
                var commonCode = connection.Get<CommonCode>(id);

                return commonCode;
            }
        }

        public int Insert(CommonCode entity)
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            {
                long id = connection.Insert(entity);

                return (int)id;
            }
        }

        public void Update(CommonCode entity)
        {
            using (var connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            {
                connection.Update<CommonCode>(entity);
            }
        }
    }
}
